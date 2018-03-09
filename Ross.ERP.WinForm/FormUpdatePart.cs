using Ross.ERP.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ross.ERP.PlmSyncTool
{
    public partial class FormUpdatePart : Form
    {
        private Entity.DTO.DTO_Config SysConfig { get; set; }
        private Utilities Utility;
        private string SaveFolderPath = Application.StartupPath + @"\ExcelImport";
        private delegate void ProcessDelegate();
        private PLMRespository PLM;
        private ERPRepository ERP;
        public FormUpdatePart(Entity.DTO.DTO_Config _SysConfig, PLMRespository _PLM, ERPRepository _ERP)
        {
            InitializeComponent();
            SysConfig = _SysConfig;
            PLM = _PLM;
            ERP = _ERP;
            Utility = new Utilities();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            progressBarSync.Value = 0;
            labelPecent.Text = "0%";
            labelSyncStatus.Text = "";
            string contents = rtboxPartNums.Text.Trim();
            if (!string.IsNullOrEmpty(contents))
            {
                string[] PartNums = contents.Split('\n');
                if (PartNums.Length > 0)
                {
                    labelSyncStatus.Text = "物料数据开始更新";
                    progressBarSync.Value += 10;
                    Task.Run(() =>
                    {
                        string MM = (DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second).ToString();
                        FileHelper.CreateDir("DMT" + MM, Application.StartupPath + @"\ExcelImport");
                        SaveFolderPath = Application.StartupPath + @"\ExcelImport\DMT" + MM;
                        DataTable dt = new DataTable();

                        var dataPart = BasicDatas.PLM_MPART.Where(o => PartNums.Contains(o.NO)).ToList();
                        var dataMaterial = BasicDatas.PLM_MATERIAL.Where(o => PartNums.Contains(o.NO)).ToList();
                        var dataProduct = BasicDatas.PLM_PRODUCT.Where(o => PartNums.Contains(o.NO)).ToList();
                        var dataMtl = BasicDatas.PLM_MTL.Where(o => PartNums.Contains(o.NO)).ToList();
                        var dataMach = BasicDatas.PLM_MACH.Where(o => PartNums.Contains(o.NO)).ToList();
                        var lists = PLM.ConvertMPART(dataPart, dataMaterial, dataProduct, dataMtl, dataMach);

                        List<ExportDto.MPART> data = Utilities.MapTo<List<ExportDto.MPART>>(lists);
                        foreach (var it in data)
                        {
                            it.NonStock = Utilities.CheckNonStock(it.PartNum).ToString().ToUpper();
                            it.PartPlant_NonStock = it.NonStock;
                            it.TrackLots = "TRUE";
                            it.PartPlant_CostMethod = it.CostMethod;
                            it.PartWhse_WarehouseCode = "YJK";
                        }
                        dt = Utility.ListToDataTable(data, "_", "#");
                        Utility.ExportExcel(dt, SaveFolderPath + "\\PART_UPDATE.xls");

                        this.BeginInvoke(new Action(() =>
                        {
                            dgvMain.DataSource = data;
                            labelSyncStatus.Text = "物料数据准备就绪";
                            progressBarSync.Value += 40;
                            labelPecent.Text = progressBarSync.Value + "%";
                            if (data.Count > 0)
                            {
                                StartSync();
                            }
                            else
                            {
                                labelPecent.Text = "0%";
                                labelSyncStatus.Text = "无物料数据";
                                progressBarSync.Value = 0;
                            }
                        }));
                    });
                }
            }
            else
            {
                rtboxPartNums.Focus();
                MessageBox.Show("请输入物料编码！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void StartSync()
        {
            try
            {
                //要导入的物料更新数据文档地址          
                string strPartPath = SaveFolderPath + "\\PART_UPDATE.xls";
                string BATPath = Application.StartupPath + "\\DMTExe.bat";
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
                processSync = null;
                Utilities.Log(err);
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
                progressBarSync.Value = 100;
                labelPecent.Text = progressBarSync.Value + "%";
                if (FileHelper.IsExist(SaveFolderPath + "\\PART_UPDATE.xls.Errors.txt"))
                {
                    System.Diagnostics.Process.Start(SaveFolderPath + "\\PART_UPDATE.xls.Errors.txt");
                    labelSyncStatus.Text = "物料更新失败！";
                }
                else
                {
                    labelSyncStatus.Text = "物料更新成功！";
                }

            };
            if (this.InvokeRequired)
                this.Invoke(ProDeleg);
        }

        private void ToolStripMenuItem_AddStock_Click(object sender, EventArgs e)
        {
            
        }

        private void ToolStripMenuItem_UpdateMtl_Click(object sender, EventArgs e)
        {
            buttonUpdate_Click(sender, e);
        }

        private void ToolStripMenuItem_StockList_Click(object sender, EventArgs e)
        {
            dgvMain.DataSource = BasicDatas.StockPart;
        }

        private void toolBtnDel_Click(object sender, EventArgs e)
        {
            var rows = dgvMain.SelectedRows;
            string[] PartNums = new string[dgvMain.SelectedRows.Count];
            int i = 0;
            foreach(DataGridViewRow row in dgvMain.SelectedRows)
            {                
                PartNums[i] = dgvMain.Rows[row.Index].Cells["PartNum"].Value.ToString();
                i++;
            }
            if (ERP.DelStockPart(PartNums) > 0)
            {
                if (MessageBox.Show("确定要删除库存物料？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    MessageBox.Show("库存物料删除成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BasicDatas.StockPart = ERP.GetStockPart();
                    dgvMain.DataSource = BasicDatas.StockPart;
                }                   
            }
        }

        private void toolBtnAdd_Click(object sender, EventArgs e)
        {
            StringBuilder Msg = new StringBuilder();
            string contents = rtboxPartNums.Text.Trim();            
            if (!string.IsNullOrEmpty(contents))
            {
                string[] PartNums = contents.Split('\n');
                int num = 0;
                if (PartNums.Length > 0)
                {
                    foreach (var part in PartNums)
                    {
                        if (ERP.AddStockPart(part.Trim(), BasicDatas.CurrentUser) <= 0 && num<=10)
                        {
                            Msg.Append("，" + part); num++;
                        }
                    }
                }
                if (num <= 0)
                {
                    MessageBox.Show("库存物料添加成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BasicDatas.StockPart = ERP.GetStockPart();
                    dgvMain.DataSource = BasicDatas.StockPart;
                }
                else
                {
                    MessageBox.Show("库存物料添加失败" + Msg.ToString(), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("物料编码不能空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolBtnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(toolTboxPartNum.Text))
            {
                dgvMain.DataSource = BasicDatas.StockPart.Where(o => o.PartNum.Contains(toolTboxPartNum.Text)).ToList();
            }
            else
                dgvMain.DataSource = BasicDatas.StockPart;
        }

        private void rtboxPartNums_KeyDown(object sender, KeyEventArgs e)
        {
            //粘贴去除文本格式
            if (e.Control && e.KeyCode == Keys.V)
            {
                IDataObject dataObj = Clipboard.GetDataObject();
                if (dataObj.GetDataPresent(DataFormats.StringFormat))
                {
                    e.Handled = true;
                    var txt = (string)Clipboard.GetData(DataFormats.StringFormat);
                    txt = txt.Trim().Replace(" ", "");
                    Clipboard.Clear();
                    Clipboard.SetData(DataFormats.StringFormat, txt);
                    rtboxPartNums.Paste();
                }
            }
        }
    }
}
