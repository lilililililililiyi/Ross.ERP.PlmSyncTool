using Ross.ERP.Entity;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Data;
using System.Threading.Tasks;
using AutoMapper;

namespace Ross.ERP.PlmSyncTool
{
    public partial class MainForm : Form
    {
        private ERPRepository ERP;
        private PLMRespository PLM;
        private RossLiveRespository RLD;
        private FormConfig formConfig;
        private FormUnitSet formUnitSet;
        private FormSyncData formSyncData;
        private Thread TasksThread;
        private delegate void ProcessDelegate();
        private Utilities Utility;
        private List<Entity.DTO.DTO_MBOM> BOMDS { get; set; }
        private List<Entity.DTO.DTO_MBOM> BOMDS_Fact { get; set; }
        private int DataCount { get; set; }
        private DataTable DataTemp { get; set; }
        private Entity.DTO.DTO_Config SysConfig { get; set; }
        private List<Entity.DTO.DTO_MBOM> NeedUpdateBom { get; set; }
        private bool ProgressRuning = false;
        private DataGridView CurrentDgv;
        private BasicDatas BscData;
        private Entity.RossLive.Model.RossConfig RossCfg;

        public MainForm()
        {
            InitializeComponent();
            this.Text = Application.ProductName + " v" + Application.ProductVersion;
            Utility = new Utilities();
            SysConfig = Utility.GetSysCfg();
            SLabelUser.Text = BasicDatas.CurrentUser;
            CurrentDgv = this.dataGridViewMain;
            if (SysConfig != null)
            {
                FormLoading formLoad = new FormLoading(SysConfig.ERPConn, SysConfig.PLMConn);
                formLoad.ShowDialog();
                formLoad.Owner = this;
                RLD = new RossLiveRespository();
                RossCfg = RLD.GetRossCfg();
                ERP = new ERPRepository(SysConfig.ERPConn);
                PLM = new PLMRespository(SysConfig.PLMConn, RossCfg.Units);
                BscData = new BasicDatas(SysConfig.ERPConn, SysConfig.PLMConn);
                InitData();
            }
            else
            {
                MessageBox.Show("配置文件错误，请联系软件供应商！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitData()
        {
            try
            {
                statusStripBot.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
                StatusLabelTime.Alignment = ToolStripItemAlignment.Right;
                StatusLabelCompany.Alignment = ToolStripItemAlignment.Right;

                SLabelErpDbName.Text = SysConfig.ERPConn.IndexOf("Live") > 0 ? "Live" : "EpicorPilot";
                SLabelPlmDbName.Text = SysConfig.PLMConn.IndexOf("Test") > 0 ? "PLMTest" : "PLM";

                ProgressBarBot.Maximum = 100;
                timerOpr.Enabled = true;
                timerOpr.Interval = 1000;

                var Company = ERP.GetCompany();
                StatusLabelCompany.Text = Company.Name;
                dtPicker.Value = DateTime.Now;

                SetMenus();
            }
            catch
            {
                SLabelErpDbName.Text = "ERP数据库未连接";
                SLabelPlmDbName.Text = "PLM数据库未连接";
            }
        }
        private async void SetMenus()
        {
            RossLiveRespository RLD = new RossLiveRespository();
            var user = RLD.GetUser(BasicDatas.CurrentUser);
            var powers = await RLD.GetPowers();
            int pid = 0;
            BtnImportNewBOM.Enabled = user.Powers.Contains("ToolAsync");
            foreach (ToolStripDropDownButton c in toolStripTop.Items)
            {
                if (powers.Where(o => o.PowerIndex == c.Name).Count() <= 0)
                {
                    pid = RLD.InsertOrUpdatePower(new Entity.RossLive.Model.RossPowers
                    {
                        PowerIndex = c.Name,
                        PowerName = c.Text,
                        InActive = false,
                        ParentID = 0
                    });
                }
                c.Enabled = user.Powers.Contains(c.Name);
                foreach (ToolStripMenuItem dc in c.DropDownItems)
                {
                    if (powers.Where(o => o.PowerIndex == dc.Name).Count() <= 0)
                    {
                        RLD.InsertOrUpdatePower(new Entity.RossLive.Model.RossPowers
                        {
                            PowerIndex = dc.Name,
                            PowerName = dc.Text,
                            InActive = false,
                            ParentID = pid
                        });
                    }
                    dc.Enabled = user.Powers.Contains(dc.Name);
                }
            }
        }
        private void BtnGetNewMTL_Click(object sender, System.EventArgs e)
        {
            BtnGetNewPartMtl.Enabled = false;
            BtnGetNewMTL.Enabled = false;
            ProgressBarBot.Value = 0;
            TasksThread = new Thread(new ThreadStart(CallGetNewPart));
            TasksThread.IsBackground = true;
            TasksThread.Start();
        }

        private void BtnGetNewPartMtl_Click(object sender, System.EventArgs e)
        {
            BtnGetNewPartMtl.Enabled = false;
            BtnGetNewMTL.Enabled = false;
            ProgressBarBot.Value = 0;
            TasksThread = new Thread(new ThreadStart(CallGetNewPart));
            TasksThread.IsBackground = true;
            TasksThread.Start();
        }
        private void BtnGetNewBOO_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tboxPartNum.Text))
            {
                MessageBox.Show("请输入产品码！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                BtnGetNewBOO.Enabled = false;
                ProgressBarBot.Value = 0;
                this.treeViewLeft.Nodes.Clear();
                TasksThread = new Thread(new ThreadStart(CallGetNewBOO));
                TasksThread.IsBackground = true;
                TasksThread.Start();
            }
        }

        private void BtnImportNewBOM_Click(object sender, System.EventArgs e)
        {
            string PartNum = tboxPartNum.Text.Trim();
            if (!string.IsNullOrEmpty(PartNum))
            {
                if (MessageBox.Show("需要更新本地缓存吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    FormLoading formLoad = new FormLoading(SysConfig.ERPConn, SysConfig.PLMConn);
                    formLoad.ShowDialog();
                    formLoad.Owner = this;
                }
                ImportNewBOM(new string[] { PartNum }, false);
            }
            else
            {
                MessageBox.Show("请输入产品码！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ImportNewBOM(string[] PartNumArr, bool AutoClose = true)
        {
            if (PartNumArr.Length > 0)
            {
                if (formSyncData == null || formSyncData.IsDisposed)
                {
                    formSyncData = new FormSyncData(PartNumArr, AutoClose, RossCfg.Units);
                    formSyncData.Show();
                    formSyncData.Owner = this;
                }
                else
                {
                    formSyncData.WindowState = FormWindowState.Normal;
                    formSyncData.Show();
                    formSyncData.Activate();
                }
            }
        }

        private void toolDropBtnPartMtl_Click(object sender, EventArgs e)
        {
            ProgressRuning = true;
            ProgressBarBot.Value = 0;
            this.treeViewLeft.Nodes.Clear();
            Task taskSync = Task.Factory.StartNew(() =>
            {
                var ds = ERP.GetJobMtl(false, false, tboxPartNum.Text);
                this.BeginInvoke(new Action(() =>
                {
                    dataGridViewMain.DataSource = ds;
                    DataCount = ds.Count;
                    ProgressRuning = false;
                    StatusLabelInfo.Text = "共获取" + DataCount + "条数据";
                    ProgressBarBot.Value = 100;
                    tabControlMain.SelectedIndex = 0;
                    tabControlMain.SelectedTab.Text = "ERP部件物料";
                    CurrentDgv = dataGridViewMain;
                }));
            }, TaskCreationOptions.None);
        }

        private void toolDropBtnPartOpr_Click(object sender, EventArgs e)
        {
            ProgressRuning = true;
            ProgressBarBot.Value = 0;
            this.treeViewLeft.Nodes.Clear();
            Task taskSync = Task.Factory.StartNew(() =>
            {
                var ds = ERP.GetPartOpr(tboxPartNum.Text.Trim());
                ds = ds.OrderBy(o => o.RevisionNum).ThenBy(o => o.OprSeq).ToList();
                foreach (var it in ds)
                {
                    it.SysRevID = null;
                }
                this.BeginInvoke(new Action(() =>
                {
                    dataGridViewMain.DataSource = ds;
                    DataCount = ds.Count;
                    ProgressRuning = false;
                    StatusLabelInfo.Text = "共获取" + DataCount + "条ERP工艺流程数据";
                    ProgressBarBot.Value = 100;
                    tabControlMain.SelectedIndex = 0;
                    tabControlMain.SelectedTab.Text = "ERP部件BOO";
                    CurrentDgv = dataGridViewMain;
                }));
            }, TaskCreationOptions.None);

        }

        private void toolDropGetNewBOM_Click(object sender, EventArgs e)
        {
            FunGetNewBOM();
        }

        private void CallGetNewBOMFun()
        {
            try
            {
                List<Entity.DTO.DTO_MBOM> ds = new List<Entity.DTO.DTO_MBOM>();
                PLM.GetPLMBOM(tboxPartNum.Text, ds);
                ds = ds.OrderBy(o => o.PartNum).ThenBy(o => o.MtlSeq).ToList();
                BOMDS = ds;
                this.BeginInvoke(new Action(() =>
                {
                    dataGridViewMain.DataSource = ds;
                    tabControlMain.SelectedIndex = 0;
                    tabControlMain.SelectedTab.Text = "PLM_BOM数据";
                    CurrentDgv = this.dataGridViewMain;

                    if (ds.Count > 0)
                    {
                        BindTreeView(ds, tboxPartNum.Text, treeViewLeft);
                    }
                    DataCount = ds.Count;

                    BtnGetNewBOM.Enabled = true;
                }));
            }
            catch (Exception err)
            {
                Utilities.Log(err);
                MessageBox.Show(err.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CallGetNewPart()
        {
            DateTime dt = DateTime.Parse(dtPicker.Text);
            var ds = PLM.GetNewPLMPart(dt, tboxPartNum.Text);
            foreach (var it in ds)
            {
                it.PartPlant_NonStock = Utilities.CheckNonStock(it.PartNum).ToString().ToUpper();
            }
            this.BeginInvoke(new Action(() =>
            {
                dataGridViewMain.DataSource = ds;
                DataCount = ds.Count;
                tabControlMain.SelectedIndex = 0;
                tabControlMain.SelectedTab.Text = "PLM新物料数据";
                CurrentDgv = dataGridViewMain;

                BtnGetNewPartMtl.Enabled = true;
                BtnGetNewMTL.Enabled = true;
            }));
        }

        private void CallGetNewBOO()
        {
            string PartNum = this.tboxPartNum.Text;
            var ds = PLM.GetPLMBOO(PartNum);
            ds = ds.OrderBy(o => o.OprSeq).ToList();
            foreach (var item in ds)
            {
                item.SubContract = item.SubContract == "TRUE" ? "1" : "0";
            }
            this.BeginInvoke(new Action(() =>
            {
                dataGridViewMain.DataSource = ds;
                DataCount = ds.Count;
                BtnGetNewBOO.Enabled = true;
                tabControlMain.SelectedIndex = 0;
                tabControlMain.SelectedTab.Text = "PLM部件BOO";
                CurrentDgv = dataGridViewMain;
            }));
        }

        private async Task<List<Entity.DTO.DTO_MBOM>> GetBOMDIF(int Top = 0)
        {
            ProgressBarBot.Value = 0;
            ProgressRuning = true;
            this.treeViewLeft.Nodes.Clear();

            List<Entity.DTO.DTO_MBOM> result = new List<Entity.DTO.DTO_MBOM>();
            List<Entity.ERP.Model.Part> ListPart = new List<Entity.ERP.Model.Part>();

            return await Task.Run(() =>
            {
                ListPart = ERP.GetUnClosedPart(Top);
                if (ListPart != null)
                {
                    foreach (var item in ListPart)
                    {
                        List<Entity.DTO.DTO_MBOM> ERPBOM = new List<Entity.DTO.DTO_MBOM>();
                        ERP.GetERPBOM(item.PartNum, ERPBOM, false);
                        List<Entity.DTO.DTO_MBOM> PLMBOM = new List<Entity.DTO.DTO_MBOM>();
                        PLM.GetPLMBOM(item.PartNum, PLMBOM, false);
                        foreach (var it in ERPBOM)
                        {
                            it.PartDescription = "";
                            it.MtlPartDescription = "";
                        }
                        ERPBOM = ERPBOM.OrderBy(o => o.MtlSeq).ToList();
                        foreach (var it in PLMBOM)
                        {
                            it.PartDescription = "";
                            it.MtlPartDescription = "";
                        }
                        PLMBOM = PLMBOM.OrderBy(o => o.MtlSeq).ToList();

                        bool isEqual = true;
                        if (ERPBOM.Count == PLMBOM.Count)
                        {
                            for (int i = 0; i < ERPBOM.Count; i++)
                            {
                                isEqual = Utility.CompareType(ERPBOM[i], PLMBOM[i]);
                                if (!isEqual)
                                    break;
                            }
                        }
                        else
                        {
                            isEqual = false;
                        }
                        if (!isEqual)
                        {
                            result = result.Union(PLMBOM).ToList();
                        }
                    }
                }
                this.BeginInvoke(new Action(() =>
                {
                    var datas = result.Select(o => new { o.Company, o.PartNum, o.ECOGroupID }).Distinct().ToList();
                    DataCount = datas.Count;
                    DGVBOM.DataSource = datas;
                    tabControlMain.SelectedIndex = 1;
                    tabControlMain.SelectedTab.Text = "BOM更新数据";
                    CurrentDgv = DGVBOM;
                    ProgressBarBot.Value = 100;
                    StatusLabelInfo.Text = "共获取" + DataCount + "条信息";
                    ProgressRuning = false;

                }));
                return result;
            });
        }

        private void FunGetNewBOM()
        {
            if (string.IsNullOrEmpty(tboxPartNum.Text))
            {
                MessageBox.Show("请输入产品码！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                treeViewLeft.Nodes.Clear();
                BtnGetNewBOM.Enabled = false;
                ProgressBarBot.Value = 0;
                TasksThread = new Thread(new ThreadStart(CallGetNewBOMFun));
                TasksThread.IsBackground = true;
                TasksThread.Start();
            }
        }

        private void BindTreeView(List<Entity.DTO.DTO_MBOM> Rows, string PartNum, TreeView tree)
        {
            try
            {
                var root = Rows.Where(o => o.PartNum == PartNum).FirstOrDefault();
                TreeNode rootNode = new TreeNode();
                rootNode.Tag = root.PartNum;
                rootNode.Text = root.PartNum + "(" + root.PartDescription + ")";
                tree.Nodes.Add(rootNode);

                var childs = Rows.Where(o => o.PartNum == PartNum).ToList();
                foreach (var item in childs)
                {
                    TreeNode node = new TreeNode();
                    node.Tag = item.MtlPartNum;
                    node.Text = item.MtlPartNum + "(" + item.MtlPartDescription + ")";
                    rootNode.Nodes.Add(node);
                    BindTreeViewChild(Rows, node);
                }
            }
            catch (Exception err)
            {
                Utilities.Log(err);
            }
        }
        private void BindTreeViewChild(List<Entity.DTO.DTO_MBOM> Rows, TreeNode fNode)
        {
            var childs = Rows.Where(o => o.PartNum == fNode.Tag.ToString()).ToList();
            if (childs.Count == 0)
            {
                return;
            }

            foreach (var item in childs)
            {
                TreeNode node = new TreeNode();
                node.Tag = item.MtlPartNum;
                node.Text = item.MtlPartNum + "(" + item.MtlPartDescription + ")";
                fNode.Nodes.Add(node);
                //递归
                BindTreeViewChild(Rows, node);
            }
        }
        private void ToolStripMenuExist_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出程序？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void dataGridViewMain_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var PartNum = dataGridViewMain.CurrentRow.Cells["PartNum"];
            tboxPartNum.Text = PartNum.Value.ToString();
        }

        private void BtnExport_NewPart_Click(object sender, EventArgs e)
        {
            ExportToExcel(Utility.DgvToTable(CurrentDgv), "PART" + DateTime.Now.ToString("yyMMddhhmmss"));
        }

        private void BtnExport_NewBom_Click(object sender, EventArgs e)
        {
            ExportToExcel(Utility.DgvToTable(CurrentDgv), "BOM" + tboxPartNum.Text);
        }

        private void timerOpr_Tick(object sender, EventArgs e)
        {
            StatusLabelTime.Text = DateTime.Now.ToString();
        }

        private void ToolStripMenuItem_Start_Click(object sender, EventArgs e)
        {
            timerAutoSync.Enabled = true;
            toolBtnStart.Image = Properties.Resources.stop;
            toolBtnStart.Text = "停止";
            ToolStripMenuItem_Start.Enabled = false;
            ToolStripMenuItem_Stop.Enabled = true;
        }

        private void ToolStripMenuItem_Stop_Click(object sender, EventArgs e)
        {
            timerAutoSync.Enabled = false;
            toolBtnStart.Image = Properties.Resources.start;
            toolBtnStart.Text = "启动";
            ToolStripMenuItem_Start.Enabled = true;
            ToolStripMenuItem_Stop.Enabled = false;
        }

        private void dataGridViewMain_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    contextMenuStripMain.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void ToolStripMenuItem_CopyToExcel_Click(object sender, EventArgs e)
        {
            DataTable dt = Utility.DgvToTable(CurrentDgv);
            ExportToExcel(dt, "Temp" + DateTime.Now.ToString("yyMMddhhmmss"));
        }

        private void ExportToExcel(DataTable dt, string fileName = "", string filePath = "")
        {
            if (dt == null)
            {
                return;
            }
            else
            {
                try
                {
                    var result = Utility.ExportExcel(dt, filePath, fileName);
                    if (result != null)
                    {
                        System.Diagnostics.Process.Start(result);
                    }
                }
                catch (Exception err)
                {
                    Utilities.Log(err);
                }
            }
        }

        private void treeViewLeft_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripTree.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void ToolStripMenuItem_ExBom_Click(object sender, EventArgs e)
        {
            ExportToExcel(Utility.DgvToTable(CurrentDgv), "BOM" + tboxPartNum.Text);
        }

        private void ToolStripMenuItem_ExWGJ_Click(object sender, EventArgs e)
        {
            if (BOMDS != null)
            {
                var lists = BOMDS.Where(o => o.PullAsAsm == "FALSE").ToList();
                DataTemp = Utility.ListToDataTable(lists);
                ExportToExcel(DataTemp, tboxPartNum.Text + "外购件报表");
            }
        }

        private void ToolStripMenuItem_ExZZJ_Click(object sender, EventArgs e)
        {
            if (BOMDS != null)
            {
                var lists = BOMDS.Where(o => o.PullAsAsm == "TRUE").ToList();
                DataTemp = Utility.ListToDataTable(lists);
                ExportToExcel(DataTemp, tboxPartNum.Text + "自制件报表");
            }
        }

        private void ToolStripMenuItem_Bom_Click(object sender, EventArgs e)
        {
            var val = CurrentDgv.CurrentCell.Value;
            tboxPartNum.Text = val.ToString();
            FunGetNewBOM();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = true;
                this.notifyIconMain.Visible = true;
            }
        }

        private void notifyIconMain_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Maximized;
                this.notifyIconMain.Visible = false;
                this.ShowInTaskbar = true;
            }
        }

        private void timerProg_Tick(object sender, EventArgs e)
        {
            if (TasksThread != null)
            {
                if (TasksThread.ThreadState == ThreadState.Stopped)
                {
                    ProgressBarBot.Value = 100;
                    StatusLabelInfo.Text = "共获取" + DataCount + "条数据";
                }
                else
                {
                    StatusLabelInfo.Text = "数据获取中...";
                    if (ProgressBarBot.Value <= 90)
                        ProgressBarBot.Value += 1;
                    else
                        ProgressBarBot.Value = 90;
                }
            }

            if (ProgressRuning)
            {
                StatusLabelInfo.Text = "数据获取中...";
                if (ProgressBarBot.Value <= 90)
                    ProgressBarBot.Value += 1;
                else
                    ProgressBarBot.Value = 90;
            }
        }

        private async void ToolStripMenuItem_ChkBOM_Click(object sender, EventArgs e)
        {
            ProgressRuning = true;
            ProgressBarBot.Value = 0;
            await ChkUpdateBOM();
        }

        private async Task ChkUpdateBOM()
        {
            DateTime dt = DateTime.Parse(dtPicker.Text);
            Task taskSync = new Task(() =>
            {
                List<Entity.DTO.DTO_MBOM> lists = PLM.GetModBOM(dt);
                this.BeginInvoke(new Action(() =>
                {
                    DGVBOM.DataSource = lists;
                    tabControlMain.SelectedIndex = 1;
                    tabControlMain.SelectedTab.Text = "PLM更新BOM";
                    CurrentDgv = this.DGVBOM;

                    DataCount = lists.Count;
                    ProgressRuning = false;
                    StatusLabelInfo.Text = "共获取" + DataCount + "条数据";
                    ProgressBarBot.Value = 100;
                }));
            }, TaskCreationOptions.None);
            await Task.Run(() => taskSync.Start());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private async void timerAutoSync_Tick(object sender, EventArgs e)
        {
            decimal autoRunHour = 3;
            if (SysConfig != null)
            {
                autoRunHour = SysConfig.AutoRunHour;
            }
            if (DateTime.Now.Hour == autoRunHour)
            {
                try
                {
                    NeedUpdateBom = await GetBOMDIF(20);
                    if (NeedUpdateBom != null)
                    {
                        var TmpBom = NeedUpdateBom.Select(o => new { o.PartNum }).Distinct().ToList();
                        string[] PartNumArr = new string[TmpBom.Count];
                        for (int i = 0; i < TmpBom.Count; i++)
                        {
                            PartNumArr[i] = TmpBom[i].PartNum;
                        }
                        ImportNewBOM(PartNumArr);
                    }
                }
                catch (Exception err)
                {
                    Utilities.Log(err);
                }
            }
        }

        private void btnUptGetTime_Click(object sender, EventArgs e)
        {
            try
            {
                ERP.UpdateLastGetPLMTime(DateTime.Parse(dtPicker.Text));
                MessageBox.Show("更改成功!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToolStripMenuItem_Unit_Click(object sender, EventArgs e)
        {
            if (formUnitSet == null || formUnitSet.IsDisposed)
            {
                formUnitSet = new FormUnitSet();
                formUnitSet.Show();
                formUnitSet.Owner = this;
            }
            else
            {
                formUnitSet.WindowState = FormWindowState.Normal;
                formUnitSet.Activate();
            }
        }

        private void ToolStripMenuItem_Sys_Click(object sender, EventArgs e)
        {
            if (formConfig == null || formConfig.IsDisposed)
            {
                formConfig = new FormConfig();
                formConfig.Show();
                formConfig.Owner = this;
            }
            else
            {
                formConfig.WindowState = FormWindowState.Normal;
                formConfig.Activate();
            }
        }

        private void ToolStripMenuItem_OpenLog_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\SysLog.txt");
        }

        private void DGVBOM_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var val = DGVBOM.CurrentRow.Cells["PartNum"];
            tboxPartNum.Text = val.Value.ToString();
        }

        private void DGVBOM_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    contextMenuStripMain.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentDgv = tabControlMain.SelectedIndex == 0 ? dataGridViewMain : DGVBOM;
        }

        private void ToolStripMenuItem_ClearLog_Click(object sender, EventArgs e)
        {
            Utility.TxtWrite(Application.StartupPath + "\\SysLog.txt", "");
            MessageBox.Show("清除日志成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripMenuItem_ClearResult_Click(object sender, EventArgs e)
        {
            CurrentDgv.DataSource = null;
        }

        private async void ToolStripMenuItem_GetERPBOM_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tboxPartNum.Text))
            {
                MessageBox.Show("请输入产品码！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                treeViewLeft.Nodes.Clear();
                dataGridViewMain.DataSource = null;
                ToolStripMenuItem_GetERPBOM.Enabled = false;
                ProgressBarBot.Value = 0;
                ProgressRuning = true;
                await GetERPBOM();
            }
        }

        private async Task GetERPBOM()
        {
            Task taskSync = new Task(() =>
            {
                List<Entity.DTO.DTO_MBOM> lists = new List<Entity.DTO.DTO_MBOM>();
                ERP.GetERPBOM(tboxPartNum.Text, lists);
                lists = lists.OrderBy(o => o.PartNum).ThenBy(o => o.MtlSeq).ToList();
                this.BeginInvoke(new Action(() =>
                {
                    ToolStripMenuItem_GetERPBOM.Enabled = true;
                    dataGridViewMain.DataSource = lists;
                    tabControlMain.SelectedIndex = 0;
                    tabControlMain.SelectedTab.Text = "ERP_BOM数据";
                    CurrentDgv = this.dataGridViewMain;
                    DataCount = lists.Count;
                    BOMDS = lists;
                    if (lists.Count > 0)
                    {
                        BindTreeView(lists, tboxPartNum.Text, treeViewLeft);
                    }

                    ProgressRuning = false;
                    StatusLabelInfo.Text = "共获取" + lists.Count + "条数据";
                    ProgressBarBot.Value = 100;
                }));
            }, TaskCreationOptions.None);
            try {
                await Task.Run(() => taskSync.Start());
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ToolStripMenuItem_ERPBOM_Click(object sender, EventArgs e)
        {
            treeViewLeft.Nodes.Clear();
            dataGridViewMain.DataSource = null;
            ToolStripMenuItem_GetERPBOM.Enabled = false;
            ProgressBarBot.Value = 0;
            ProgressRuning = true;

            var val = CurrentDgv.CurrentCell.Value;
            tboxPartNum.Text = val.ToString();
            await GetERPBOM();
        }

        private void ToolStripMenuItem_ClearTree_Click(object sender, EventArgs e)
        {
            treeViewLeft.Nodes.Clear();
        }

        private void ToolStripMenuItem_ToFactBOM_Click(object sender, EventArgs e)
        {
            if (BOMDS_Fact == null)
                BOMDS_Fact = new List<Entity.DTO.DTO_MBOM>();
            foreach (var item in BOMDS)
            {
                //判断虚拟件
                if (item.PartDescription.Contains("VPART"))
                {
                    //寻找上级非虚拟件
                    var vPart = LookUVPart(item.PartNum, BOMDS);
                    if (vPart != null)
                    {
                        var MtlParts = BOMDS.Where(o => o.PartNum == item.PartNum).ToList();
                        foreach (var mtl in MtlParts)
                        {
                            mtl.PartNum = vPart.PartNum;
                            BOMDS_Fact.Add(mtl);
                        }
                    }
                }
                else
                {
                    if (BOMDS_Fact.Where(o => o.PartNum == item.PartNum && o.MtlSeq == item.MtlSeq).Count() <= 0)
                    {
                        BOMDS_Fact.Add(item);
                    }
                }
            }
            treeViewLeftBot.Nodes.Clear();
            BOMDS_Fact = BOMDS_Fact.Where(o => !o.PartDescription.Contains("VPART") && !o.MtlPartDescription.Contains("VPART")).ToList();
            BindTreeView(BOMDS_Fact, tboxPartNum.Text, treeViewLeftBot);
            tabControlLeft.SelectedIndex = 1;
        }

        /// <summary>
        /// 寻找上级非虚拟件
        /// </summary>
        /// <param name="PartNum"></param>
        /// <param name="BOM"></param>
        /// <returns></returns>
        private Entity.DTO.DTO_MBOM LookUVPart(string PartNum, List<Entity.DTO.DTO_MBOM> BOM)
        {
            var vPart = BOM.Where(o => o.MtlPartNum == PartNum).FirstOrDefault();
            if (vPart != null)
            {
                if (!vPart.PartDescription.Contains("VPART"))
                {
                    return vPart;
                }
                else
                {
                    return LookUVPart(vPart.PartNum, BOM);
                }
            }
            else
            {
                return null;
            }
        }

        private void ToolStripMenuItem_SyncLog_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.InitialDirectory = Application.StartupPath + "\\ExcelImport";
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                System.Diagnostics.Process.Start(fileDialog.FileName);
            }
        }

        private void ToolStripMenuItem_ResetCache_Click(object sender, EventArgs e)
        {
            FormLoading formLoad = new FormLoading(SysConfig.ERPConn, SysConfig.PLMConn);
            formLoad.ShowDialog();
            formLoad.Owner = this;
        }

        private void ToolStripMenuItem_UpdateParts_Click(object sender, EventArgs e)
        {
            FormUpdatePart formUpdatePart = new FormUpdatePart(SysConfig, PLM, ERP);
            formUpdatePart.ShowDialog();
            formUpdatePart.Owner = this;
        }

        private void ToolStripMenuItem_MtlAna_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\MtlAnalysis.xltx");
        }

        private void AutoCache()
        {
            lblAutoUpdate.Text = "Start Update Cache.";
            Task.Run(() =>
            {
                BscData.LoadPLM_MPART();
                BscData.LoadPLM_MBOM();
                BscData.LoadPLM_CONS();
                BscData.LoadPLM_CONS_OBJOF();
                BscData.LoadPLM_MATERIAL();
                BscData.LoadPLM_PRODUCT();
                BscData.LoadPLM_MTL();
                this.BeginInvoke(new Action(() =>
                {
                    lblAutoUpdate.Text = DateTime.Now.ToString() + ". Update OK!";
                }));
            });
        }

        private void timerAutoCache_Tick(object sender, EventArgs e)
        {
            AutoCache();
        }

        private void toolDropBtnPart_Click(object sender, EventArgs e)
        {
            ProgressRuning = true;
            ProgressBarBot.Value = 0;
            Task.Run(() =>
            {
                var lists = ERP.GetPart("", tboxPartNum.Text);
                foreach (var it in lists)
                {
                    it.SysRevID = null;
                }
                this.BeginInvoke(new Action(() =>
                {
                    dataGridViewMain.DataSource = lists;
                    StatusLabelInfo.Text = "共获取" + lists.Count + "条数据";
                    tabControlMain.SelectedIndex = 0;
                    tabControlMain.SelectedTab.Text = "ERP物料档案";
                    CurrentDgv = dataGridViewMain;
                    ProgressRuning = false;
                    ProgressBarBot.Value = 100;
                }));
            });
        }

        private void ToolStripMenuModPsw_Click(object sender, EventArgs e)
        {
            FormModPsw form = new FormModPsw();
            form.Owner = this;
            form.ShowDialog();
        }

        private void ToolStripMenuItemPowers_Click(object sender, EventArgs e)
        {
            FormUserPower form = new FormUserPower();
            form.Owner = this;
            form.ShowDialog();
        }

        private void ToolStripMenuItem_PartPlan_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\PartPlan.xltx");
        }

        private void ToolStripMenuItem_UnitBug_Click(object sender, EventArgs e)
        {
            //var datas = (from a in PLM_Part
            //             join b in BasicDatas.ErpPart.Where(o => o.InActive == false) on a.PartNum equals b.PartNum
            //             where a.IUM.ToUpper() != b.IUM.ToUpper()
            //             select new { plm = a }).ToList();                     

            ProgressRuning = true;
            ProgressBarBot.Value = 0;
            Task.Run(() =>
            {
                var PLM_Part = PLM.GetNewPLMPart(dtPicker.Value);
                List<Entity.DTO.DTO_MPART> datas = new List<Entity.DTO.DTO_MPART>();
                foreach (var plmpart in PLM_Part)
                {
                    if (BasicDatas.ErpPart.Where(o => o.InActive == false && o.PartNum == plmpart.PartNum && o.IUM.ToUpper() != plmpart.IUM.ToUpper()).Count() > 0)
                    {
                        datas.Add(plmpart);
                    }
                }
                this.BeginInvoke(new Action(() =>
                {
                    dataGridViewMain.DataSource = datas;
                    StatusLabelInfo.Text = "共获取" + datas.Count + "条数据";
                    tabControlMain.SelectedTab.Text = "单位异常数据";
                    tabControlMain.SelectedIndex = 0;
                    CurrentDgv = dataGridViewMain;
                    ProgressRuning = false;
                    ProgressBarBot.Value = 100;
                }));
            });
        }

        private void ToolStripMenuItem_Rev_Click(object sender, EventArgs e)
        {
            FormPartRev form = new FormPartRev(ERP);
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
