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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ross.ERP.PlmSyncTool
{
    public partial class FormPartCombined : Form
    {
        private ERPRepository ERP;
        private PLMRespository PLM;
        private Utilities Utility;
        private List<ExportDto.MPART> PART;
        private List<ExportDto.MBOO> BOO;
        private List<ExportDto.MBOM> BOM;
        private string SaveFolderPath = Application.StartupPath + @"\ExcelImport";
        private Entity.DTO.DTO_Config SysConfig;
        private delegate void ProcessDelegate();
        public FormPartCombined(ERPRepository _ERP, PLMRespository _PLM)
        {
            InitializeComponent();
            ERP = _ERP;
            PLM = _PLM;
            Utility = new Utilities();
            SysConfig = Utility.GetSysCfg();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxPartNums.Text))
            {
                string contents = textBoxPartNums.Text.Trim();
                string[] PartNums = contents.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                var lists = new List<Entity.DTO.DTO_MPART>();
                lists = PLM.GetNewPLMPart(PartNums, null);
                foreach (var item in lists)
                {
                    if (!string.IsNullOrEmpty(textBoxPartRev.Text))
                    {
                        item.PartRev_RevisionNum = textBoxPartRev.Text;
                        item.PartRev_RevShortDesc = textBoxPartRev.Text;
                    }
                    if (dtPickerPartEff.Value != null)
                    {
                        item.PartRev_EffectiveDate = dtPickerPartEff.Value.ToShortDateString();
                    }
                }
                PART = Utilities.MapTo<List<ExportDto.MPART>>(lists);
                foreach (var part in PART)
                {
                    part.TrackLots = "TRUE";
                    part.NonStock = Utilities.CheckNonStock(part.PartNum).ToString().ToUpper();
                    part.PartPlant_NonStock = part.NonStock;
                    part.PartPlant_CostMethod = part.CostMethod;
                    part.PartWhse_WarehouseCode = "YJK";
                }
                dataGridViewMain.DataSource = PART;
                tabControl1.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("请输入物料编码！");
            }
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

        private void dataGridViewMain_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    contextMenuStripGrid.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void buttonGetBOO_Click(object sender, EventArgs e)
        {
            string contents = textBoxPartNums.Text.Trim();
            string[] PartNums = contents.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            var lists = new List<Entity.DTO.DTO_MBOO>();
            foreach (var item in PartNums)
            {
                var exMBOO = PLM.GetPLMBOO(item, true);
                lists = lists.Union(exMBOO).ToList();
            }
            foreach (var item in lists)
            {
                item.RevisionNum = textBoxPartRev.Text;
            }
            Mapper.Initialize(x => x.CreateMap<Entity.DTO.DTO_MBOO, ExportDto.MBOO>().ForMember(dest => dest.CommentText, opt => opt.MapFrom(src => src.OprComment)));
            BOO = Mapper.Map<List<ExportDto.MBOO>>(lists);
            dataGridViewBOO.DataSource = BOO;
            tabControl1.SelectedIndex = 1;
        }

        private void buttonGetBOM_Click(object sender, EventArgs e)
        {
            string contents = textBoxPartNums.Text.Trim();
            string[] PartNums = contents.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            var lists = new List<Entity.DTO.DTO_MBOM>();
            foreach (var item in PartNums)
            {
                var exMBOM = PLM.GetPLMBOM(item);
                lists = lists.Union(exMBOM).ToList();
            }
            foreach (var item in lists)
            {
                item.RevisionNum = textBoxPartRev.Text;
            }
            BOM = Utilities.MapTo<List<ExportDto.MBOM>>(lists);
            dataGridViewBOM.DataSource = BOM;
            tabControl1.SelectedIndex = 2;
        }

        private void ToolStripMenuItem_ExportPart_Click(object sender, EventArgs e)
        {
            if (PART != null && PART.Count > 0)
            {
                DataTable dt = Utility.ListToDataTable(PART, "_", "#");
                ExportToExcel(dt, "PART");
            }
        }

        private void ToolStripMenuItem_ExBOO_Click(object sender, EventArgs e)
        {
            if (BOO != null && BOO.Count > 0)
            {
                DataTable dt = Utility.ListToDataTable(BOO, "_", "#");
                ExportToExcel(dt, "BOO");
            }
        }

        private void ToolStripMenuItem_ExBOM_Click(object sender, EventArgs e)
        {
            if (BOM != null && BOM.Count > 0)
            {
                DataTable dt = Utility.ListToDataTable(BOM, "_", "#");
                ExportToExcel(dt, "BOM");
            }
        }

        private void buttonStartSync_Click(object sender, EventArgs e)
        {
            buttonStartSync.Enabled = false;
            labelSyncStatus.Text = "开始同步";

            buttonOk_Click(sender, e);
            buttonGetBOO_Click(sender, e);
            buttonGetBOM_Click(sender, e);

            string MM = DateTime.Now.ToString("yyyyMMddhhmmss");
            FileHelper.CreateDir("DMT" + MM, Application.StartupPath + @"\ExcelImport");
            SaveFolderPath = Application.StartupPath + @"\ExcelImport\DMT" + MM;

            var partA = BOM.Select(o => o.MtlPartNum).Distinct().ToList();
            var partB = BOM.Select(o => o.PartNum).Distinct().ToList();
            var part = partA.Union(partB).ToArray();
            var lists = PLM.GetNewPLMPart(part, null);
            var PARTBOM = Utilities.MapTo<List<ExportDto.MPART>>(lists);
            PART = PART.Union(PARTBOM).Distinct().ToList();
            foreach (var item in PART)
            {
                item.TrackLots = "TRUE";
                item.NonStock = Utilities.CheckNonStock(item.PartNum).ToString().ToUpper();
                item.PartPlant_NonStock = item.NonStock;
                item.PartPlant_CostMethod = item.CostMethod;
                item.PartWhse_WarehouseCode = "YJK";
                item.PartRev_RevisionNum = item.TypeCode == "M" ? textBoxPartRev.Text : "";
                item.PartRev_RevShortDesc = item.PartRev_RevisionNum;
            }
            foreach (var item in BOO)
            {
                item.ECOGroupID = "usersync";
            }
            foreach (var item in BOM)
            {
                item.ECOGroupID = "usersync";
            }

            DataTable dt = Utility.ListToDataTable(PART, "_", "#");
            Utility.ExportExcel(dt, SaveFolderPath + "\\PART.xls");
            dt = Utility.ListToDataTable(BOO, "_", "#");
            Utility.ExportExcel(dt, SaveFolderPath + "\\BOO.xls");
            dt = Utility.ListToDataTable(BOM, "_", "#");
            Utility.ExportExcel(dt, SaveFolderPath + "\\BOM.xls");

            List<ExportDto.PARTREV_DEL> part_rev_del = new List<ExportDto.PARTREV_DEL>();
            var items = PART.Where(o => o.TypeCode == "M").ToList();
            foreach (var item in items)
            {
                ExportDto.PARTREV_DEL obj = new ExportDto.PARTREV_DEL();
                obj.Company = "001";
                obj.AltMethod = "";
                obj.PartNum = item.PartNum;
                obj.RevisionNum = item.PartRev_RevisionNum;
                part_rev_del.Add(obj);
            }
            dt = Utility.ListToDataTable(part_rev_del, "_", "#");
            Utility.ExportExcel(dt, SaveFolderPath + "\\PART_REV_DEL.xls");

            StartSync();
        }

        private void StartSync()
        {
            try
            {
                string strPartRevDel = SaveFolderPath + "\\PART_REV_DEL.xls";
                string strPartPath = SaveFolderPath + "\\PART.xls";
                string strBOOPath = SaveFolderPath + "\\BOO.xls";
                string strBOMPath = SaveFolderPath + "\\BOM.xls";
                string BATPath = Application.StartupPath + "\\DMTExe.bat";
                CreateDMTBat(BATPath, strPartPath, strBOOPath, strBOMPath, strPartRevDel);
                processSync = new System.Diagnostics.Process();
                processSync.StartInfo.FileName = BATPath;
                processSync.EnableRaisingEvents = true;
                processSync.Exited += new EventHandler(processSync_Exited);
                processSync.Start();
            }
            catch (Exception err)
            {
                processSync = null;
                labelSyncStatus.Text = err.Message;
                buttonStartSync.Enabled = true;
            }
        }
        private void CreateDMTBat(string strBatPath, string strPartPath, string strBOOPath, string strBOMPath, string strPartRevDelPath)
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

            strLine = "ECHO Delete Part Revision";
            sw.WriteLine(strLine);
            strLine = "start /w " + SysConfig.DMTExePath + " -environment " + SysConfig.DMTDatabase + " -user " + SysConfig.DMTLoginUser + " -pass " + SysConfig.DMTPsw + " -import=\"Part Revision\" -source=\"" + strPartRevDelPath + "\" -delete";
            sw.WriteLine(strLine);
            strLine = "IF %ERRORLEVEL% == 1 ECHO Some Errors While Delete Part Revision  - review log";
            sw.WriteLine(strLine);
            strLine = "ECHO ..OK";
            sw.WriteLine(strLine);

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
        private void processSync_Exited(object sender, EventArgs e)
        {
            processSync.Close();
            processSync = null;
            ProcessDelegate ProDeleg = delegate ()
            {
                labelSyncStatus.Text = "同步完成";
                buttonStartSync.Enabled = true;
                MessageBox.Show("同步完成！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            if (labelSyncStatus.InvokeRequired)
                labelSyncStatus.Invoke(ProDeleg);
        }

        private void dataGridViewBOM_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    contextMenuStripGrid.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void dataGridViewBOO_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    contextMenuStripGrid.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }        
    }
}
