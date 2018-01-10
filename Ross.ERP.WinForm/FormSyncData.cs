using AutoMapper;
using Ross.ERP.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ross.ERP.PlmSyncTool
{
    public partial class FormSyncData : Form
    {
        /// <summary>
        /// 最后一次更新时间
        /// </summary>
        private DateTime LastUpdateTime { get; set; }
        private Entity.DTO.DTO_Config SysConfig { get; set; }
        /// <summary>
        /// ERP旧BOM
        /// </summary>
        private DataTable DataDelBOM { get; set; }
        /// <summary>
        /// ERP旧BOO
        /// </summary>
        private DataTable DataDelBOO { get; set; }
        /// <summary>
        /// 新物料档案
        /// </summary>
        private DataTable DataNewPart { get; set; }
        /// <summary>
        /// PLM新BOO
        /// </summary>
        private DataTable DataNewBOO { get; set; }
        /// <summary>
        /// PLM新BOM结构
        /// </summary>
        private DataTable DataNewBOM { get; set; }
        /// <summary>
        /// PLM新BOM结构（带分组GroupID）
        /// </summary>
        private DataTable DataNewBOM2 { get; set; }
        private DataTable DataUpdateJobs { get; set; }
        private Utilities Utility;
        private ERPRepository ERP;
        private PLMRespository PLM;
        private delegate void ProcessDelegate();
        private string SaveFolderPath = Application.StartupPath + @"\ExcelImport";
        private int pecentExe = 0;
        private string SyncReportPath = "";
        private string lblStatus = "";
        private string RevisionNum = "A";
        /// <summary>
        /// 程序运行完自动关闭标记
        /// </summary>
        private bool IsAutoClose { get; set; }
        public FormSyncData(string[] PartNumArr, bool AutoClose = true)
        {
            InitializeComponent();
            IsAutoClose = AutoClose;
            Utility = new Utilities();

            if (!IsAutoClose)
            {
                string MM = (DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second).ToString();
                FileHelper.CreateDir("DMT" + PartNumArr[0] + "-" + MM, SaveFolderPath);
                SaveFolderPath += "\\DMT" + PartNumArr[0] + "-" + MM;
            }

            SysConfig = Utility.GetSysCfg();
            if (SysConfig != null)
            {
                string ConfigUnit = Utility.TxtRead(Application.StartupPath + "\\ConfigUnit.txt");
                ERP = new ERPRepository(SysConfig.ERPConn);
                PLM = new PLMRespository(SysConfig.PLMConn, ConfigUnit);

                var Company = ERP.GetCompany();
                LastUpdateTime = Company.LastGetPLMTime;

                timerSync.Enabled = true;
                progressBarSync.Value = pecentExe;
                progressBarSync.Maximum = 100;

                Task taskSync = Task.Factory.StartNew(() =>
                {
                    try
                    {
                        //List<ExportDto.MBOM_UD> delMBOM = new List<ExportDto.MBOM_UD>();
                        List<ExportDto.MBOM_UD> ListMBOM = new List<ExportDto.MBOM_UD>();
                        List<ExportDto.MPART> ListMPART = new List<ExportDto.MPART>();
                        //CallGetDataDelBOM(PartNumArr, out delMBOM);
                        //CallGetDataDelBOO(PartNumArr, delMBOM);

                        CallGetNewPart(PartNumArr, out ListMBOM, out ListMPART);
                        CallGetNewBOO(PartNumArr, ListMBOM);
                        CallGetNewBOM(PartNumArr);

                        //CallGetUpdateJobs(delMBOM, ListMBOM, ListMPART);
                        StartSync();
                    }
                    catch (Exception err)
                    {
                        processSync = null;
                        Utilities.Log(err);
                        MessageBox.Show(err.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }, TaskCreationOptions.None);
            }
        }
        /// <summary>
        /// 获取删除BOM
        /// </summary>
        private void CallGetDataDelBOM(string[] PartNumArr, out List<ExportDto.MBOM_UD> delBOM)
        {
            delBOM = new List<ExportDto.MBOM_UD>();
            if (PartNumArr.Length > 0)
            {
                List<Entity.DTO.DTO_MBOM> lists = new List<Entity.DTO.DTO_MBOM>();
                int GroupId = 1;
                foreach (string PartNum in PartNumArr)
                {
                    List<Entity.DTO.DTO_MBOM> item = new List<Entity.DTO.DTO_MBOM>();
                    ERP.GetERPBOM(PartNum, item);
                    lists = lists.Union(item).ToList();

                    List<ExportDto.MBOM_UD> exMBOM = Utilities.MapTo<List<ExportDto.MBOM_UD>>(item);
                    foreach (var it in exMBOM)
                    {
                        it.GroupID = GroupId;
                    }
                    delBOM = delBOM.Union(exMBOM).ToList();
                    GroupId++;
                }
                List<ExportDto.MBOM> data = Utilities.MapTo<List<ExportDto.MBOM>>(lists);
                data = data.OrderBy(o => o.PartNum).ThenBy(o => o.MtlSeq).ToList();
                DataDelBOM = Utility.ListToDataTable(data, "_", "#");
                Utility.ExportExcel(DataDelBOM, SaveFolderPath + "\\BOM_DEL.xls");
                pecentExe += 10;
                lblStatus = "删除BOM数据已就绪...";
            }
        }
        /// <summary>
        /// 获取删除BOO
        /// </summary>
        private void CallGetDataDelBOO(string[] PartNumArr, List<ExportDto.MBOM_UD> delBOM)
        {
            if (PartNumArr.Length > 0)
            {
                List<Entity.ERP.Model.PartOpr> lists = new List<Entity.ERP.Model.PartOpr>();
                int GroupId = 1;
                foreach (string PartNum in PartNumArr)
                {
                    var BOMS = delBOM.Where(o => o.GroupID == GroupId && o.PullAsAsm == "TRUE").Select(o => new { o.MtlPartNum }).Distinct().ToList();
                    BOMS.Add(new { MtlPartNum = PartNum });
                    foreach (var item in BOMS)
                    {
                        var boo = ERP.GetPartOpr(item.MtlPartNum.Trim());
                        if (boo != null && boo.Count > 0)
                        {
                            lists = lists.Union(boo).ToList();
                        }
                    }
                    GroupId++;
                }
                lists = lists.OrderBy(o => o.PartNum).ThenBy(o => o.OprSeq).ToList();
                List<ExportDto.MBOO> data = Utilities.MapTo<List<ExportDto.MBOO>>(lists);
                foreach (var item in data)
                {
                    item.ECOGroupID = "manager";
                    item.Plant = "MfgSys";
                }
                DataDelBOO = Utility.ListToDataTable(data, "_", "#");
                Utility.ExportExcel(DataDelBOO, SaveFolderPath + "\\BOO_DEL.xls");
                pecentExe += 10;
                lblStatus = "删除BOO数据已就绪...";
            }
        }
        /// <summary>
        /// 获取新物料
        /// </summary>
        private void CallGetNewPart(string[] PartNumArr, out List<ExportDto.MBOM_UD> ListMBOM, out List<ExportDto.MPART> ListMPART)
        {

            List<Entity.DTO.DTO_MPART> lists = new List<Entity.DTO.DTO_MPART>();
            List<Entity.DTO.DTO_MBOM> MBOM = new List<Entity.DTO.DTO_MBOM>();
            ListMBOM = new List<ExportDto.MBOM_UD>();
            int gid = 1;
            foreach (string PartNum in PartNumArr)
            {
                RevisionNum = "R" + ERP.GetRevId(PartNum, BasicDatas.CurrentUser);
                List<Entity.DTO.DTO_MBOM> MB;
                var item = PLM.GetPLMBOMPart(PartNum, out MB);
                MB = MB.OrderBy(o => o.MtlSeq).ToList();

                lists = lists.Union(item).ToList();
                MBOM = MBOM.Union(MB).ToList();

                List<ExportDto.MBOM_UD> exMBOM = Utilities.MapTo<List<ExportDto.MBOM_UD>>(MB);
                foreach (var it in exMBOM)
                {
                    it.GroupID = gid;
                }
                ListMBOM = ListMBOM.Union(exMBOM).ToList();
                gid++;
            }

            foreach (var bom in MBOM)
            {
                bom.RevisionNum = RevisionNum;
            }

            List<ExportDto.MBOM> mbom_data = Utilities.MapTo<List<ExportDto.MBOM>>(MBOM);
            mbom_data = mbom_data.OrderBy(o => o.PartNum).ThenBy(o => o.MtlSeq).ToList();
            DataNewBOM = Utility.ListToDataTable(mbom_data, "_", "#");
            ListMBOM = ListMBOM.OrderBy(o => o.GroupID).ThenBy(o => o.PartNum).ThenBy(o => o.MtlSeq).ToList();
            DataNewBOM2 = Utility.ListToDataTable(ListMBOM, "_", "#");

            List<ExportDto.MPART> data = Utilities.MapTo<List<ExportDto.MPART>>(lists);
            foreach (var part in data)
            {
                part.TrackLots = "TRUE";
                part.NonStock = Utilities.CheckNonStock(part.PartNum).ToString().ToUpper();
                part.PartPlant_NonStock = part.NonStock;
                part.PartPlant_CostMethod = part.CostMethod;
                if (part.TypeCode == "M")
                {
                    part.PartRev_RevisionNum = RevisionNum;
                    part.PartRev_RevShortDesc = RevisionNum;
                }
            }
            DataNewPart = Utility.ListToDataTable(data, "_", "#");
            ListMPART = data;

            Utility.ExportExcel(DataNewPart, SaveFolderPath + "\\PART.xls");
            pecentExe += 20;
            lblStatus = "新物料数据已就绪...";
        }
        /// <summary>
        /// 获取新BOO
        /// </summary>
        private void CallGetNewBOO(string[] PartNumArr, List<ExportDto.MBOM_UD> ListMBOM)
        {
            if (PartNumArr.Length > 0)
            {
                List<Entity.DTO.DTO_MBOO> lists = new List<Entity.DTO.DTO_MBOO>();
                int GroupId = 1;
                foreach (string PartNum in PartNumArr)
                {
                    var boo = PLM.GetPLMBOO(PartNum);
                    lists = lists.Union(boo).ToList();
                    var BOMS = ListMBOM.Where(o => o.GroupID == GroupId && o.PullAsAsm == "TRUE").ToList();
                    List<string> Parts = new List<string>();
                    foreach (var bom in BOMS)
                    {
                        if (!Parts.Contains(bom.MtlPartNum))
                        {
                            Parts.Add(bom.MtlPartNum);
                        }
                    }
                    foreach (var part in Parts)
                    {
                        var boo2 = PLM.GetPLMBOO(part);
                        if (boo2 != null && boo2.Count > 0)
                        {
                            boo2 = boo2.OrderBy(o => o.OprSeq).ToList();
                            lists = lists.Union(boo2).ToList();
                        }
                    }
                    GroupId++;
                }

                foreach (var boo in lists)
                {
                    boo.RevisionNum = RevisionNum;
                }

                lists = lists.OrderBy(o => o.PartNum).ThenBy(o => o.RevisionNum).ThenBy(o => o.OprSeq).ToList();
                Mapper.Initialize(x => x.CreateMap<Entity.DTO.DTO_MBOO, ExportDto.MBOO>().ForMember(dest => dest.CommentText, opt => opt.MapFrom(src => src.OprComment)));
                List<ExportDto.MBOO> data = Mapper.Map<List<ExportDto.MBOO>>(lists);

                DataNewBOO = Utility.ListToDataTable(data, "_", "#");
                Utility.ExportExcel(DataNewBOO, SaveFolderPath + "\\BOO.xls");
                pecentExe += 10;
                lblStatus = "新BOO数据已就绪...";
            }
        }
        /// <summary>
        /// 获取新BOM
        /// </summary>
        private void CallGetNewBOM(string[] PartNumArr)
        {
            if (PartNumArr.Length > 0)
            {
                if (DataNewBOM == null)
                {
                    List<Entity.DTO.DTO_MBOM> lists = new List<Entity.DTO.DTO_MBOM>();
                    foreach (string PartNum in PartNumArr)
                    {
                        //lists = lists.Union(PLM.GetPLMBOM(PartNum)).ToList();
                        PLM.GetPLMBOM(PartNum, lists);
                    }
                    foreach (var bom in lists)
                    {
                        bom.RevisionNum = RevisionNum;
                    }
                    List<ExportDto.MBOM> data = Utilities.MapTo<List<ExportDto.MBOM>>(lists);
                    data = data.OrderBy(o => o.PartNum).ThenBy(o => o.MtlSeq).ToList();
                    DataNewBOM = Utility.ListToDataTable(data, "_", "#");
                }
                Utility.ExportExcel(DataNewBOM, SaveFolderPath + "\\BOM.xls");
                pecentExe += 20;
                lblStatus = "新BOM数据已就绪...";
            }
        }

        private void CallGetUpdateJobs(List<ExportDto.MBOM_UD> DelMBOM, List<ExportDto.MBOM_UD> ListMBOM, List<ExportDto.MPART> ListMPART)
        {
            List<ExportDto.MBOM_JOB> ListBM = new List<ExportDto.MBOM_JOB>();

            foreach (var item in ListMBOM)
            {
                var obj = DelMBOM.Where(o => o.Company == item.Company && o.GroupID == item.GroupID && o.PartNum == item.PartNum && o.MtlSeq == item.MtlSeq).FirstOrDefault();
                if (!Utility.CompareObj(obj, item))
                {
                    var DiffBom = Utilities.MapTo<ExportDto.MBOM_JOB>(item);
                    var Jobs = ERP.GetJobMtl(null, null, item.PartNum);
                    if (Jobs.Count > 0)
                    {
                        foreach (var job in Jobs)
                        {
                            DiffBom.AssemblySeq = job.AssemblySeq;
                            DiffBom.JobNum = job.JobNum;
                            if (ListBM.Where(o => o.GroupID == DiffBom.GroupID && o.JobNum == DiffBom.JobNum && o.AssemblySeq == DiffBom.AssemblySeq && o.MtlSeq == DiffBom.MtlSeq).Count() <= 0)
                            {
                                ListBM.Add(DiffBom);
                            }
                        }
                    }
                    else
                    {
                        DiffBom.AssemblySeq = 0;
                        DiffBom.JobNum = "";
                        if (ListBM.Where(o => o.GroupID == DiffBom.GroupID && o.JobNum == DiffBom.JobNum && o.AssemblySeq == DiffBom.AssemblySeq && o.MtlSeq == DiffBom.MtlSeq).Count() <= 0)
                        {
                            ListBM.Add(DiffBom);
                        }
                    }
                }
            }
            ListBM = ListBM.OrderBy(o => o.GroupID).ThenBy(o => o.JobNum).ThenBy(o => o.AssemblySeq).ThenBy(o => o.MtlSeq).ToList();
            DataUpdateJobs = Utility.ListToDataTable(ListBM, "_", "#");
            pecentExe += 10;
            lblStatus = "开始导入BOM...";
        }
        private void StartSync()
        {
            try
            {
                //string strBOMPathDel = SaveFolderPath + "\\BOM_DEL.xls";
                //string strBOOPathDel = SaveFolderPath + "\\BOO_DEL.xls";
                string strPartPath = SaveFolderPath + "\\PART.xls";
                string strBOOPath = SaveFolderPath + "\\BOO.xls";
                string strBOMPath = SaveFolderPath + "\\BOM.xls";
                string BATPath = Application.StartupPath + "\\DMTExe.bat";
                CreateDMTBat(BATPath, strPartPath, strBOOPath, strBOMPath);
                processSync = new System.Diagnostics.Process();
                processSync.StartInfo.FileName = BATPath;
                processSync.EnableRaisingEvents = true;
                processSync.Exited += new EventHandler(processSync_Exited);
                processSync.Start();
                pecentExe += 10;
            }
            catch (Exception err)
            {
                processSync = null;
                Utilities.Log(err);
                labelSyncStatus.Text = err.Message;
                pecentExe = 100;
            }
        }

        /// <summary>
        /// 编辑生成DMT执行的.bat文件
        /// </summary>
        /// <param name="strBatPath">bat文件地址</param>
        /// <param name="strPartPath">要导入的Part表文件地址</param>
        /// <param name="strBOOPath">要导入的BOO表文件地址</param>
        /// <param name="strBOMPath">要导入的BOM表文件地址</param>
        private void CreateDMTBat(string strBatPath, string strPartPath, string strBOOPath, string strBOMPath)
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
            #region DEL
            //strLine = "ECHO Delete BOM";
            //sw.WriteLine(strLine);
            //strLine = "start /w " + SysConfig.DMTExePath + " -environment " + SysConfig.DMTDatabase + " -user " + SysConfig.DMTLoginUser + " -pass " + SysConfig.DMTPsw + " -import=\"Bill Of Materials\" -source=\"" + strBOMPathDel + "\" -delete";
            //sw.WriteLine(strLine);
            //strLine = "IF %ERRORLEVEL% == 1 ECHO Some Errors While Delete BOM - review log";
            //sw.WriteLine(strLine);
            //strLine = "ECHO ..OK";
            //sw.WriteLine(strLine);

            //strLine = "ECHO Delete BOO";
            //sw.WriteLine(strLine);
            //strLine = "start /w " + SysConfig.DMTExePath + " -environment " + SysConfig.DMTDatabase + " -user " + SysConfig.DMTLoginUser + " -pass " + SysConfig.DMTPsw + " -import=\"Bill Of Operations\" -source=\"" + strBOOPathDel + "\" -delete";
            //sw.WriteLine(strLine);
            //strLine = "IF %ERRORLEVEL% == 1 ECHO Some Errors While Delete BOO - review log";
            //sw.WriteLine(strLine);
            //strLine = "ECHO ..OK";
            //sw.WriteLine(strLine);
            #endregion
            strLine = "ECHO Imports Parts";
            sw.WriteLine(strLine);
            strLine = "start /w " + SysConfig.DMTExePath + " -environment " + SysConfig.DMTDatabase + " -user " + SysConfig.DMTLoginUser + " -pass " + SysConfig.DMTPsw + " -import=\"Part Combined\" -source=\"" + strPartPath + "\" -add -update";
            sw.WriteLine(strLine);
            strLine = "IF %ERRORLEVEL% == 1 ECHO Some Errors While import parts - review log";
            sw.WriteLine(strLine);
            strLine = "ECHO ..OK";
            sw.WriteLine(strLine);
            sw.WriteLine("");
            strLine = "ECHO Imports BOO";
            sw.WriteLine(strLine);
            strLine = "start /w " + SysConfig.DMTExePath + " -environment " + SysConfig.DMTDatabase + " -user " + SysConfig.DMTLoginUser + " -pass " + SysConfig.DMTPsw + " -import=\"Bill Of Operations\" -source=\"" + strBOOPath + "\" -add -update";
            sw.WriteLine(strLine);
            strLine = "IF %ERRORLEVEL% == 1 ECHO Some Errors While import BOO - review log";
            sw.WriteLine(strLine);
            strLine = "ECHO ..OK";
            sw.WriteLine(strLine);
            sw.WriteLine("");
            strLine = "ECHO Imports BOM";
            sw.WriteLine(strLine);
            strLine = "start /w " + SysConfig.DMTExePath + " -environment " + SysConfig.DMTDatabase + " -user " + SysConfig.DMTLoginUser + " -pass " + SysConfig.DMTPsw + " -import=\"Bill Of Materials\" -source=\"" + strBOMPath + "\" -add -update";
            sw.WriteLine(strLine);
            strLine = "IF %ERRORLEVEL% == 1 ECHO Some Errors While import BOM - review log";
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

        private void btnCloseSync_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerSync_Tick(object sender, EventArgs e)
        {
            if (progressBarSync.Value <= 100)
            {
                progressBarSync.Value = pecentExe;
                labelPecent.Text = progressBarSync.Value + "%";
                labelSyncStatus.Text = lblStatus;
            }
        }

        private void processSync_Exited(object sender, EventArgs e)
        {
            processSync.Close();
            processSync = null;

            ProcessDelegate ProDeleg = delegate ()
            {
                timerSync.Enabled = false;
                progressBarSync.Value = 100;
                labelSyncStatus.Text = "PLM数据同步已完成！";
                labelPecent.Text = "100%";
                Utilities.Log("完成PLM数据同步");

                DataTable[] DTS = new DataTable[3];
                DTS[0] = DataNewPart;
                DTS[1] = DataNewBOO;
                DTS[2] = DataNewBOM2;
                //DTS[3] = DataUpdateJobs;

                string[] sheetNames = new string[3];
                sheetNames[0] = "物料档案";
                sheetNames[1] = "新BOO";
                sheetNames[2] = "新BOM";
                //sheetNames[3] = "BOM差异报表";
                SyncReportPath = Utility.ExportExcel(DTS, sheetNames, SaveFolderPath + "\\SyncReport_" + DateTime.Now.ToString("yyMMddhhmmss") + ".xls");

                if (IsAutoClose)
                {
                    this.Close();
                }
                else
                {
                    System.Diagnostics.Process.Start(SyncReportPath);
                }

            };
            if (labelSyncStatus.InvokeRequired)
                labelSyncStatus.Invoke(ProDeleg);
        }

        private void FormSyncData_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (processSync != null)
            {
                MessageBox.Show("正在运行数据同步，不能关闭？", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
            else
            {
                this.Dispose();
            }
        }

        private void linkLabel_ImPartErr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (FileHelper.IsExist(SaveFolderPath + "\\PART.xls.Errors.txt"))
                System.Diagnostics.Process.Start(SaveFolderPath + "\\PART.xls.Errors.txt");
        }

        private void linkLabel_ImBooErr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (FileHelper.IsExist(SaveFolderPath + "\\BOO.xls.Errors.txt"))
                System.Diagnostics.Process.Start(SaveFolderPath + "\\BOO.xls.Errors.txt");
        }

        private void linkLabel_ImBomErr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (FileHelper.IsExist(SaveFolderPath + "\\BOM.xls.Errors.txt"))
                System.Diagnostics.Process.Start(SaveFolderPath + "\\BOM.xls.Errors.txt");
        }

        private void linkLabel_SyncReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(SyncReportPath))
                System.Diagnostics.Process.Start(SyncReportPath);
        }
    }
}
