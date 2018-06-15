using Oracle.ManagedDataAccess.Client;
using Ross.ERP.Entity;
using Ross.ERP.Entity.DTO;
using Ross.ERP.Entity.PLM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ross.ERP.AutoSync
{
    public partial class FormAuto : Form
    {
        private string SaveFolderPath = Application.StartupPath + @"\ExcelImport";
        private Utilities Utility;
        private List<Entity.ERP.Model.OpMaster> ErpOpMaster;
        private delegate void ProcessDelegate();
        public FormAuto()
        {
            InitializeComponent();
            Utility = new Utilities();
            using (Entity.ERP.ERPDbContext ERP = new Entity.ERP.ERPDbContext())
            {
                ErpOpMaster = ERP.OpMaster.ToList();
            }
        }

        private void buttonGetNewPart_Click(object sender, EventArgs e)
        {
            buttonGetNewPart.Enabled = false;
            using (Entity.PLM.PLMDbContext PLM = new Entity.PLM.PLMDbContext())
            {
                #region 执行存储过程
                //OracleParameter param_day = new OracleParameter(":day", OracleDbType.Int32);
                //param_day.Value = 2;
                //param_day.Direction = ParameterDirection.Input;
                //var query = PLM.Database.SqlQuery<ERPNEWBOM>("begin sp_auto_bom (:day); end;", param_day);
                //var resp = PLM.Database.ExecuteSqlCommand("BEGIN SP_AUTO_BOM(0); END;");                
                #endregion

                var partsA = PLM.V_PART.SqlQuery("select * from V_PARTALL").ToList();
                var partsN = PLM.V_PART.SqlQuery("select * from V_PART").ToList();

                var boo = PLM.V_BOO.Where(o => o.REVISIONNUM == "A").ToList();
                foreach (var item in boo)
                {
                    item.ECOGROUPID = "usersync";
                    item.REVISIONNUM = "C";
                }

                var bom = PLM.V_BOM.Where(o => o.REVISIONNUM == "A").ToList();
                foreach (var item in bom)
                {
                    item.ECOGROUPID = "usersync";
                    item.REVISIONNUM = "C";
                }

                var pt1 = bom.Select(o => o.PARTNUM).Distinct().ToList();
                var pt2 = bom.Select(o => o.MTLPARTNUM).Distinct().ToList();
                pt1 = pt1.Union(pt2).ToList().Distinct().ToList();
                var partsC = partsA.Where(o => pt1.Contains(o.PARTNUM)).ToList();
                foreach (var item in partsC)
                {
                    item.PARTREV_REVISIONNUM = item.TYPECODE == "M" ? "C" : "";
                    item.PARTREV_REVSHORTDESC = item.PARTREV_REVISIONNUM;
                }


                List<DTO.PARTREV_DEL> part_rev_del = new List<DTO.PARTREV_DEL>();
                var items = partsC.Where(o => o.TYPECODE == "M").ToList();
                foreach (var item in items)
                {
                    DTO.PARTREV_DEL obj = new DTO.PARTREV_DEL();
                    obj.Company = "001";
                    obj.AltMethod = "";
                    obj.PartNum = item.PARTNUM;
                    obj.RevisionNum = "C";
                    part_rev_del.Add(obj);
                }
                var DT_PART_DEL = Utility.ListToDataTable(part_rev_del, "_", "#");
                Utility.ExportExcel(DT_PART_DEL, SaveFolderPath + "\\PART_REV_DEL.xls");

                List<DTO.MPART> data_part_c = Utilities.MapTo<List<DTO.MPART>>(partsC);
                List<DTO.MPART> data_part_new = Utilities.MapTo<List<DTO.MPART>>(partsN);
                var parts = data_part_c.Union(data_part_new).ToList();
                foreach (var item in parts)
                {
                    item.NonStock = item.TypeCode == "M" ? "TRUE" : "FALSE";
                    item.PartPlant_NonStock = item.NonStock;
                }
                var DT_PART = Utility.ListToDataTable(parts, "_", "#");
                Utility.ExportExcel(DT_PART, SaveFolderPath + "\\PART.xls");

                List<DTO.MBOO> data_boo = Utilities.MapTo<List<DTO.MBOO>>(boo);
                foreach (var item in data_boo)
                {
                    item.OpCode = CvtOper(item.OpCode);
                }
                var DT_BOO = Utility.ListToDataTable(data_boo, "_", "#");
                Utility.ExportExcel(DT_BOO, SaveFolderPath + "\\BOO.xls");

                List<DTO.MBOM> data_bom = Utilities.MapTo<List<DTO.MBOM>>(bom);
                var DT_BOM = Utility.ListToDataTable(data_bom, "_", "#");
                Utility.ExportExcel(DT_BOM, SaveFolderPath + "\\BOM.xls");

                dataGridViewPart.DataSource = parts;
                dataGridViewBOO.DataSource = data_boo;
                dataGridViewBOM.DataSource = data_bom;
            }
            buttonGetNewPart.Enabled = true;
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
            strLine = "start /w " + tboxDMTPath.Text + " -environment " + comboDb.Text + " -user " + tboxUser.Text + " -pass " + tboxPsw.Text + " -import=\"Part Revision\" -source=\"" + strPartRevDelPath + "\" -delete";
            sw.WriteLine(strLine);
            strLine = "IF %ERRORLEVEL% == 1 ECHO Some Errors While Delete Part Revision  - review log";
            sw.WriteLine(strLine);
            strLine = "ECHO ..OK";
            sw.WriteLine(strLine);

            strLine = "ECHO Imports Parts";
            sw.WriteLine(strLine);
            strLine = "start /w " + tboxDMTPath.Text + " -environment " + comboDb.Text + " -user " + tboxUser.Text + " -pass " + tboxPsw.Text + " -import=\"Part Combined\" -source=\"" + strPartPath + "\" -add -update";
            sw.WriteLine(strLine);
            strLine = "IF %ERRORLEVEL% == 1 ECHO Some Errors While import parts - review log";
            sw.WriteLine(strLine);
            strLine = "ECHO ..OK";
            sw.WriteLine(strLine);
            sw.WriteLine("");

            strLine = "ECHO Imports BOO";
            sw.WriteLine(strLine);
            strLine = "start /w " + tboxDMTPath.Text + " -environment " + comboDb.Text + " -user " + tboxUser.Text + " -pass " + tboxPsw.Text + " -import=\"Bill Of Operations\" -source=\"" + strBOOPath + "\" -add -update";
            sw.WriteLine(strLine);
            strLine = "IF %ERRORLEVEL% == 1 ECHO Some Errors While import BOO - review log";
            sw.WriteLine(strLine);
            strLine = "ECHO ..OK";
            sw.WriteLine(strLine);
            sw.WriteLine("");

            strLine = "ECHO Imports BOM";
            sw.WriteLine(strLine);
            strLine = "start /w " + tboxDMTPath.Text + " -environment " + comboDb.Text + " -user " + tboxUser.Text + " -pass " + tboxPsw.Text + " -import=\"Bill Of Materials\" -source=\"" + strBOMPath + "\" -add -update";
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

        private void buttonStartSync_Click(object sender, EventArgs e)
        {
            labelSyncStatus.Text = "数据同步中...";
            string MM = DateTime.Now.ToString("yyyyMMddhhmmss");
            CreateDir("DMT" + MM, Application.StartupPath + @"\ExcelImport");
            SaveFolderPath = Application.StartupPath + @"\ExcelImport\DMT" + MM;

            StartSync();
        }

        private void processSync_Exited(object sender, EventArgs e)
        {
            processSync.Close();
            processSync = null;
            ProcessDelegate ProDeleg = delegate ()
            {
                labelSyncStatus.Text = DateTime.Now.ToString() + "同步完成";
                buttonStartSync.Enabled = true;
            };
            if (labelSyncStatus.InvokeRequired)
                labelSyncStatus.Invoke(ProDeleg);
        }

        private void butDir_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = "c:\\Epicor";
            if (file.ShowDialog() == DialogResult.OK)
            {
                this.tboxDMTPath.Text = file.FileName;
            }
        }

        private string CvtOper(string opcode)
        {
            try
            {
                return ErpOpMaster.Where(o => o.CommentText.Contains(opcode)).FirstOrDefault().OpCode;
            }
            catch
            {
                return opcode;
            }
        }
        public void CreateDir(string dirPath, string activeDir = "")
        {
            if (!Directory.Exists(activeDir + dirPath))
            {
                if (activeDir == "")
                {
                    Directory.CreateDirectory(dirPath);
                }
                else
                {
                    DirectoryInfo di = new DirectoryInfo(activeDir);
                    di.CreateSubdirectory(dirPath);
                }
            }
        }
    }
}
