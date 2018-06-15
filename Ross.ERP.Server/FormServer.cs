using AutoMapper;
using Newtonsoft.Json;
using Ross.ERP.Entity;
using Ross.ERP.Entity.RossLive.Model;
using Ross.ERP.Server.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ross.ERP.Server
{
    public partial class FormServer : Form
    {
        private ERPRepository ERP;
        private PLMRespository PLM;
        private RossLiveRespository RLD;
        private BasicDatas BscData;
        private Entity.DTO.DTO_Config SysConfig;
        private string SaveFolderPath = Application.StartupPath + @"\Excel";
        private delegate void ProcessDelegate();
        private Utilities Utility;
        private List<PART> UptParts;
        private DateTime LastUptTime = DateTime.Now;
        private DateTime StartTime;
        private RossConfig RossCfg;
        public FormServer()
        {
            InitializeComponent();
            Utility = new Utilities();
            RLD = new RossLiveRespository();
            RossCfg = RLD.GetRossCfg();
            SysConfig = Utility.GetSysCfg();
            ERP = new ERPRepository(SysConfig.ERPConn);
            PLM = new PLMRespository(SysConfig.PLMConn, RossCfg.Units);

            BscData = new BasicDatas(SysConfig.ERPConn, SysConfig.PLMConn);

            StartTime = DateTime.Now;
            startTime.Text = "启动时间：" + StartTime.ToString();
            notifyMenuItem_start.Enabled = false;
            notifyMenuItem_stop.Enabled = true;

            UpdateLogs UptLog = new UpdateLogs();
            UptLog.CompleteLog = "Start System Background Service";
            UptLog.LogTitle = "Start System Service";
            UptLog.Status = "OK";
            RLD.InsertUptLog(UptLog);

            this.Text = Application.ProductName + " v" + Application.ProductVersion;
        }
        private void FormServer_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                this.notifyIconMain.Visible = true;
            }
        }
        private void notifyIconMain_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.notifyIconMain.Visible = false;
                this.ShowInTaskbar = true;
            }
        }
        private async Task AutoCache()
        {
            tProgBar.Value = 0;
            labelLoadDatas.Text = "正在更新缓存......";
            timerMain.Enabled = true;
            toolBtnRefresh.Enabled = false;
            await Task.Run(() =>
            {
                BscData.LoadERPPart();
                BscData.LoadERPPartMtl();
                BscData.LoadPLM_MPART();
                BscData.LoadPLM_MBOM();
                BscData.LoadPLM_CONS();
                BscData.LoadPLM_CONS_OBJOF();
                BscData.LoadPLM_MATERIAL();
                BscData.LoadPLM_PRODUCT();
                BscData.LoadPLM_MTL();
                this.BeginInvoke(new Action(() =>
                {
                    labelLoadDatas.Text = "缓存成功";
                }));
            });
        }

        private async void toolBtnRefresh_ButtonClick(object sender, EventArgs e)
        {
            await AutoCache();
            timerMain.Enabled = false;
            toolBtnRefresh.Enabled = true;
            tProgBar.Value = 100;
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            if (tProgBar.Value < 100)
                tProgBar.Value += 1;
        }

        private async void BtnAutoUptMtl_Click(object sender, EventArgs e)
        {
            BtnAutoUptMtl.Enabled = false;
            await AutoCache();
            var lists = PLM.GetNewPLMPart(null, LastUptTime);
            if (lists.Count > 0)
            {
                Mapper.Initialize(x => x.CreateMap<Entity.DTO.DTO_MPART, PART>());
                UptParts = Mapper.Map<List<PART>>(lists);

                foreach (var it in UptParts)
                {
                    it.NonStock = Utilities.CheckNonStock(it.PartNum).ToString().ToUpper();
                    it.PartPlant_NonStock = "FALSE";
                    it.TrackLots = "TRUE";
                    it.PartPlant_CostMethod = it.CostMethod;
                    it.PartWhse_WarehouseCode = "YJK";
                }

                DGVMain.DataSource = UptParts;

                var dt = Utility.ListToDataTable(UptParts, "_", "#");
                Utility.ExportExcel(dt, SaveFolderPath + "\\PART_UPDATE.xls");

                if (UptParts.Count > 0)
                    StartSync();
            }

            labelLoadDatas.Text = "就绪";
            timerMain.Enabled = false;
            BtnAutoUptMtl.Enabled = true;
            tProgBar.Value = 0;
        }

        private void StartSync()
        {
            try
            {
                //要导入的物料更新数据文档地址          
                string strPartPath = SaveFolderPath + "\\PART_UPDATE.xls";
                string BATPath = Application.StartupPath + "\\DMT.bat";
                CreateDMTBat(BATPath, strPartPath);
                //执行BAT文件
                //实例化线程
                processSync = new System.Diagnostics.Process();
                // 指定要运行文件的路径
                processSync.StartInfo.FileName = BATPath;
                //激活Exited
                processSync.EnableRaisingEvents = true;
                //添加结束监视事件
                processSync.Exited += new EventHandler(processSync_Exited);
                //运行程序
                processSync.Start();
            }
            catch (Exception err)
            {
                rtboxUpdateDtl.Text = err.Message + err.Source + err.StackTrace;
                processSync = null;
            }
        }

        private void CreateDMTBat(string strBatPath, string strPartPath)
        {
            if (File.Exists(strBatPath))
            {
                File.Delete(strBatPath);
            }

            FileStream fs = new FileStream(strBatPath, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            string strLine;
            strLine = "@ECHO OFF";
            sw.WriteLine(strLine);
            sw.WriteLine("");

            strLine = "ECHO Imports Parts";
            sw.WriteLine(strLine);
            strLine = "start /w " + SysConfig.DMTExePath + " -environment " + SysConfig.DMTDatabase + " -user " + SysConfig.DMTLoginUser + " -pass " + SysConfig.DMTPsw + " -import=\"Part Combined\" -source=\"" + strPartPath + "\" -add -update";
            sw.WriteLine(strLine);
            strLine = "IF %ERRORLEVEL% == 1 ECHO Some Errors While import parts - review log";
            sw.WriteLine(strLine);
            strLine = "ECHO ..OK";
            sw.WriteLine(strLine);
            sw.WriteLine("");

            strLine = "GOTO END";
            sw.WriteLine(strLine);
            sw.WriteLine("");
            strLine = ":ERROR";
            sw.WriteLine(strLine);
            strLine = "ECHO Error Occured Aborted";
            sw.WriteLine(strLine);
            strLine = "GOTO END";
            sw.WriteLine("");
            sw.WriteLine(strLine);
            strLine = ":END";
            sw.WriteLine(strLine);
            sw.WriteLine("");
            strLine = "ECHO Finished";
            sw.WriteLine(strLine);

            strLine = "EXIT";
            sw.WriteLine(strLine);
            sw.Flush();
            sw.Close();
        }

        private void processSync_Exited(object sender, EventArgs e)
        {
            processSync.Close();
            processSync = null;
            ProcessDelegate ProDeleg = delegate ()
            {
                string ErrorTxt = SaveFolderPath + "\\PART_UPDATE.xls.Errors.txt";
                string CompleteTxt = SaveFolderPath + "\\PART_UPDATE.xls.CompleteLog.txt";
                tProgBar.Value = 100;
                toolBtnRefresh.Enabled = true;
                timerMain.Enabled = false;
                var parts = UptParts.Select(o => o.PartNum).ToList();

                UpdateLogs UptLog = new UpdateLogs();
                UptLog.LogTitle = "Part Auto Update Task";
                UptLog.PartNums = JsonConvert.SerializeObject(parts);
                if (File.Exists(ErrorTxt))
                {
                    rtboxUpdateDtl.Text = Utility.TxtRead(ErrorTxt);
                    UptLog.ErrorLog = Utility.TxtRead(ErrorTxt);
                    UptLog.Status = "Error";
                }
                if (File.Exists(CompleteTxt))
                {
                    rtboxUpdateDtl.Text = Utility.TxtRead(CompleteTxt);
                    UptLog.CompleteLog = Utility.TxtRead(CompleteTxt);
                    UptLog.Status = "OK";
                }
                RLD.InsertUptLog(UptLog);
                LastUptTime = DateTime.Now;
            };
            if (this.InvokeRequired)
                this.Invoke(ProDeleg);
        }

        private void DGVUpdateLogs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var CompLog = DGVUpdateLogs.CurrentRow.Cells["CompleteLog"];
            var ErrLog = DGVUpdateLogs.CurrentRow.Cells["ErrorLog"];
            var UserName = DGVUpdateLogs.CurrentRow.Cells["UserName"];
            var MachineName = DGVUpdateLogs.CurrentRow.Cells["MachineName"];
            var PartNums = DGVUpdateLogs.CurrentRow.Cells["PartNums"];
            var SysTime = DGVUpdateLogs.CurrentRow.Cells["SysTime"];
            string contents = SysTime.Value.ToString() + " " + MachineName.Value.ToString() + "-" + UserName.Value.ToString() + "\r\nUpdate PartNums: " + (PartNums.Value == null ? "" : PartNums.Value.ToString()) + "\r\n\r\nError Log: \r\n" + (ErrLog.Value == null ? "" : ErrLog.Value.ToString()) + "\r\nComplete Log: \r\n" + (CompLog.Value == null ? "" : CompLog.Value.ToString());
            rtboxUpdateDtl.Text = contents;
        }

        private void timerAutoUpt_Tick(object sender, EventArgs e)
        {

            TimeSpan ts1 = new TimeSpan(StartTime.Ticks);
            TimeSpan ts2 = new TimeSpan(DateTime.Now.Ticks);
            TimeSpan ts = ts1.Subtract(ts2).Duration();
            runTimes.Text = "已运行：" + ts.Days + "天" + ts.Hours + "小时" + ts.Minutes + "分" + ts.Seconds + "秒";
        }

        private void notifyMenuItem_start_Click(object sender, EventArgs e)
        {
            timerAutoUpt.Enabled = true;
            notifyMenuItem_start.Enabled = false;
            notifyMenuItem_stop.Enabled = true;
        }

        private void notifyMenuItem_stop_Click(object sender, EventArgs e)
        {
            timerAutoUpt.Enabled = false;
            notifyMenuItem_start.Enabled = true;
            notifyMenuItem_stop.Enabled = false;
        }

        private void notifyMenuItem_exist_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出系统服务？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void ToolStripMenuItem_start_Click(object sender, EventArgs e)
        {
            timerAutoUpt.Enabled = true;
            ToolStripMenuItem_start.Enabled = false;
            ToolStripMenuItem_stop.Enabled = true;
        }

        private void ToolStripMenuItem_stop_Click(object sender, EventArgs e)
        {
            timerAutoUpt.Enabled = false;
            ToolStripMenuItem_start.Enabled = true;
            ToolStripMenuItem_stop.Enabled = false;
        }

        private async void tabCtrlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCtrlMain.SelectedIndex == 1)
                DGVUpdateLogs.DataSource = await RLD.GetUptLog(null, 10000);
        }

        private void FormServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定要退出系统服务？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void timerAutoRun_Tick(object sender, EventArgs e)
        {
            BtnAutoUptMtl_Click(null, null);
        }
    }
}
