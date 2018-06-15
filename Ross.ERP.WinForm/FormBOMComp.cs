using AutoMapper;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using Ross.ERP.Entity;
using Ross.ERP.Entity.DTO;
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
    public partial class FormBOMComp : Form
    {
        private ERPRepository ERP;
        private PLMRespository PLM;
        private Utilities Utility;
        private string SaveFolderPath = Application.StartupPath + @"\ExcelImport";
        private Random Random = new Random();
        public FormBOMComp(ERPRepository _ERP, PLMRespository _PLM)
        {
            InitializeComponent();
            ERP = _ERP;
            PLM = _PLM;
            Utility = new Utilities();
        }

        private List<DTO_MBOM> PLM_BOM;
        private List<DTO_MBOM> ERP_JOB_BOM;
        private List<DTO_MBOM> ERP_DES_BOM;
        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tBoxPartNum.Text))
            {
                MessageBox.Show("物料编码必填！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(tBoxJobNum.Text) && radioJob.Checked)
            {
                MessageBox.Show("工单号必填！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            BtnOK.Text = "对比中...";
            BtnOK.Enabled = false;
            Task.Run(() =>
            {

                //获取ERP设计BOM
                ERP_DES_BOM = new List<DTO_MBOM>();
                ERP.GetERPBOM(tBoxPartNum.Text, ERP_DES_BOM, true, textBoxRev.Text);

                if (radioJob.Checked)
                {
                    //获取工单BOM
                    var JobAsmblDatas = ERP.GetJobAsmbl(tBoxJobNum.Text);
                    var JobMtlDatas = ERP.GetJobMtl(tBoxJobNum.Text);
                    ERP_JOB_BOM = new List<DTO_MBOM>();
                    string mainPart = "";
                    try
                    {
                        mainPart = JobAsmblDatas.Where(o => o.JobNum == tBoxJobNum.Text && o.BomLevel == 0).FirstOrDefault().PartNum;
                    }
                    catch { }
                    ERP.GetJobBom(ERP_JOB_BOM, JobAsmblDatas, JobMtlDatas, mainPart);
                }
                else
                {
                    //获取PLMBOM
                    PLM_BOM = new List<DTO_MBOM>();
                    PLM.GetPLMBOM(tBoxPartNum.Text, PLM_BOM);
                }
                //List<DTO_MBOM> BOM_DIFF = CompareBOM(tBoxPartNum.Text, tBoxJobNum.Text);
                this.BeginInvoke(new Action(() =>
                {
                    BtnOK.Text = "开始对比";
                    BtnOK.Enabled = true;
                    #region 导出对比结果
                    //var dt = Utility.ListToDataTable(BOM_DIFF, "_", "#");
                    //string rnd = Random.Next(0, 9999).ToString();
                    string filepath = SaveFolderPath + "\\" + tBoxPartNum.Text + "BOM_DIFF.xls";
                    long ticks = DateTime.Now.Ticks;
                    if (radioJob.Checked)
                    {
                        filepath = SaveFolderPath + "\\DES_JOB_" + tBoxPartNum.Text + "_" + tBoxJobNum.Text + "_Compare" + ticks.ToString() + ".xls";
                        CreateDIFFBook(filepath, ERP_DES_BOM, ERP_JOB_BOM, "设计BOM", "工单BOM");
                    }
                    else
                    {
                        filepath = SaveFolderPath + "\\DES_PLM_" + tBoxPartNum.Text + "_Compare" + ticks.ToString() + ".xls";
                        CreateDIFFBook2(filepath, ERP_DES_BOM, PLM_BOM, "PLMBOM", "设计BOM");
                    }
                    //Utility.ExportExcel(dt, SaveFolderPath + "\\" + tBoxPartNum.Text + "BOM_DIFF" + rnd + ".xls");
                    System.Diagnostics.Process.Start(filepath);
                    #endregion
                }));
            });
        }

        private void BtnCmpOper_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                List<Entity.DTO.DTO_MBOO> BOO_DIFF = CompareBOO(tBoxPartNum.Text, tBoxJobNum.Text);
                this.BeginInvoke(new Action(() =>
                {
                    if (BOO_DIFF.Count > 0)
                    {
                        BOO_DIFF = BOO_DIFF.OrderBy(o => o.PartNum).ThenBy(o => o.OprSeq).ToList();
                        #region 导出对比结果
                        var dt = Utility.ListToDataTable(BOO_DIFF, "_", "#");
                        string rnd = Random.Next(0, 9999).ToString();
                        Utility.ExportExcel(dt, SaveFolderPath + "\\" + tBoxPartNum.Text + "BOO_DIFF" + rnd + ".xls");
                        System.Diagnostics.Process.Start(SaveFolderPath + "\\" + tBoxPartNum.Text + "BOO_DIFF" + rnd + ".xls");
                        #endregion
                    }
                    else
                        MessageBox.Show("没有差异！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
            });

        }
        /// <summary>
        /// PLM的BOM对比工单BOM
        /// </summary>
        /// <param name="partNum"></param>
        /// <param name="jobNum"></param>
        /// <returns></returns>
        private List<DTO_MBOM> CompareBOM(string partNum, string jobNum)
        {
            List<DTO_MBOM> BOM_DIFF = new List<DTO_MBOM>();
            PLM_BOM = new List<DTO_MBOM>();
            ERP_JOB_BOM = new List<DTO_MBOM>();

            PLM.GetPLMBOM(partNum, PLM_BOM);

            var JobAsmblDatas = ERP.GetJobAsmbl(jobNum);
            var JobMtlDatas = ERP.GetJobMtl(jobNum);
            ERP.GetJobBom(ERP_JOB_BOM, JobAsmblDatas, JobMtlDatas, partNum);

            foreach (var item in PLM_BOM)
            {
                if (ERP_JOB_BOM.Where(o => o.PartNum == item.MtlPartNum).Count() <= 0)
                {
                    BOM_DIFF.Add(item);
                }
            }

            return BOM_DIFF;
        }
        /// <summary>
        /// 工单BOO对比PLMBOO
        /// </summary>
        /// <param name="partNum"></param>
        /// <param name="jobNum"></param>
        /// <returns></returns>
        private List<DTO_MBOO> CompareBOO(string partNum, string jobNum)
        {
            List<Entity.DTO.DTO_MBOO> BOO_DIFF = new List<Entity.DTO.DTO_MBOO>();
            #region PLM所有BOO
            List<Entity.DTO.DTO_MBOO> PLM_BOO = new List<Entity.DTO.DTO_MBOO>();
            if (!string.IsNullOrEmpty(partNum) && PLM_BOM.Count > 0)
            {
                var boo = PLM.GetPLMBOO(partNum);
                PLM_BOO = PLM_BOO.Union(boo).ToList();

                var PBOM = PLM_BOM.Where(o => o.PullAsAsm == "TRUE").ToList();
                foreach (var item in PBOM)
                {
                    var boos = PLM.GetPLMBOO(item.MtlPartNum);
                    PLM_BOO = PLM_BOO.Union(boos).ToList();
                }
                PLM_BOO = PLM_BOO.OrderBy(o => o.PartNum).ThenBy(o => o.OprSeq).ToList();
            }
            #endregion
            #region ERP所有BOO
            List<Entity.DTO.DTO_MBOO> ERP_BOO = new List<Entity.DTO.DTO_MBOO>();
            if (!string.IsNullOrEmpty(jobNum) && ERP_JOB_BOM.Count > 0)
            {

                var operList = ERP.GetJobOper(jobNum);
                var asmbList = ERP.GetJobAsmbl(jobNum);
                var boolists = from asmbl in asmbList
                               join joboper in operList on new { asmbl.Company, asmbl.AssemblySeq, asmbl.JobNum } equals new { joboper.Company, joboper.AssemblySeq, joboper.JobNum }
                               orderby asmbl.AssemblySeq ascending
                               select new { asmbl, joboper };
                foreach (var boo in boolists)
                {
                    Entity.DTO.DTO_MBOO obj = new Entity.DTO.DTO_MBOO();
                    obj.Company = boo.asmbl.Company;
                    obj.DaysOut = boo.joboper.DaysOut.ToString();
                    obj.ECOGroupID = "manager";
                    obj.LaborEntryMethod = boo.joboper.LaborEntryMethod;
                    obj.OpCode = boo.joboper.OpCode;
                    obj.OprComment = boo.joboper.CommentText;
                    obj.OprSeq = boo.joboper.OprSeq;
                    obj.PartDescription = boo.asmbl.Description;
                    obj.PartNum = boo.asmbl.PartNum;
                    obj.Plant = "MfgSys";
                    obj.ProdStandard = boo.joboper.ProdStandard;
                    obj.RevisionNum = boo.joboper.RevisionNum;
                    obj.StdFormat = boo.joboper.StdFormat;
                    obj.SubContract = boo.joboper.SubContract.ToString().ToUpper();
                    obj.VendorNumVendorID = boo.joboper.VendorNum.ToString();
                    ERP_BOO.Add(obj);
                }
                ERP_BOO = ERP_BOO.OrderBy(o => o.PartNum).ThenBy(o => o.OprSeq).ToList();
            }
            #endregion
            #region 开始对比
            if (PLM_BOO != null && ERP_BOO != null)
            {
                foreach (var item in PLM_BOO)
                {
                    if (ERP_BOO.Where(o => o.PartNum == item.PartNum).Count() <= 0)
                    {
                        if (BOO_DIFF.Where(o => o.PartNum == item.PartNum).Count() <= 0)
                        {
                            item.VendorNumVendorID = "无此物料";
                            BOO_DIFF.Add(item);
                            continue;
                        }
                    }
                    else
                    {
                        var ERPBOO = ERP_BOO.Where(o => o.PartNum == item.PartNum && o.OpCode == item.OpCode);
                        if (ERPBOO.Count() <= 0)
                        {
                            if (BOO_DIFF.Where(o => o.PartNum == item.PartNum && o.OpCode == item.OpCode).Count() <= 0)
                            {
                                item.VendorNumVendorID = "工序不存在";
                                BOO_DIFF.Add(item);
                                continue;
                            }
                        }
                    }
                }
            }
            #endregion
            return BOO_DIFF;
        }

        public void CreateDIFFBook(string filePath, List<DTO_MBOM> BOMDES, List<DTO_MBOM> BOMJOB, string NameA = "", string NameB = "")
        {
            HSSFWorkbook book = new HSSFWorkbook();
            ISheet sheet1 = book.CreateSheet("CompareResult");

            IRow rowhead = sheet1.CreateRow(0);
            rowhead.CreateCell(0).SetCellValue("半成品编码");
            rowhead.CreateCell(1).SetCellValue(NameA + "物料编码");
            rowhead.CreateCell(2).SetCellValue(NameA + "物料数量");
            rowhead.CreateCell(3).SetCellValue(NameB + "物料编码");
            rowhead.CreateCell(4).SetCellValue(NameB + "物料数量");
            sheet1.SetColumnWidth(0, 20 * 256);
            sheet1.SetColumnWidth(1, 20 * 256);
            sheet1.SetColumnWidth(2, 20 * 256);
            sheet1.SetColumnWidth(3, 20 * 256);
            sheet1.SetColumnWidth(4, 20 * 256);

            //HSSFPalette palette = book.GetCustomPalette();
            //palette.SetColorAtIndex((short)8, 250, 0, 0);
            //HSSFColor hssFColor = palette.FindColor(250, 0, 0);
            //ICellStyle cellStyle = book.CreateCellStyle();
            //cellStyle.FillPattern = FillPattern.SolidForeground;
            //cellStyle.FillForegroundColor = hssFColor.Indexed;

            IFont font = book.CreateFont();//创建字体样式  
            font.Color = HSSFColor.White.Index;//设置字体颜色  
            ICellStyle style = book.CreateCellStyle();//创建单元格样式 
            style.FillForegroundColor = HSSFColor.Red.Index; //设置背景色
            style.FillPattern = FillPattern.SolidForeground;
            style.SetFont(font);//设置单元格样式中的字体样式 

            ICellStyle style2 = book.CreateCellStyle();//创建单元格样式 
            style2.FillForegroundColor = HSSFColor.Green.Index; //设置背景色
            style2.FillPattern = FillPattern.SolidForeground;
            style2.SetFont(font);//设置单元格样式中的字体样式  


            int RowNum = 0;
            var asmbList = BOMDES.Select(o => o.PartNum).Distinct().ToList();
            foreach (var asmb in asmbList)
            {
                foreach (var item in BOMDES.Where(o => o.PartNum == asmb).ToList())
                {
                    IRow row = sheet1.CreateRow(RowNum + 1);
                    row.CreateCell(0).SetCellValue(asmb);
                    row.CreateCell(1).SetCellValue(item.MtlPartNum);
                    row.CreateCell(2).SetCellValue(item.QtyPer.ToString("0.00"));

                    var CompItem = BOMJOB.Where(o => o.MtlPartNum == item.MtlPartNum && o.PartNum == asmb).FirstOrDefault();
                    if (CompItem == null)
                    {
                        row.CreateCell(3).SetCellValue("缺少");
                        row.GetCell(3).CellStyle = style;
                    }
                    else
                    {
                        row.CreateCell(3).SetCellValue(CompItem.MtlPartNum);
                        row.CreateCell(4).SetCellValue(CompItem.QtyPer.ToString("0.00"));
                        if (CompItem.QtyPer != item.QtyPer)
                        {
                            row.GetCell(4).CellStyle = style;
                        }
                    }
                    RowNum++;
                }
            }
            //反向对比
            foreach (var item in BOMJOB)
            {
                var CompItem = BOMDES.Where(o => o.MtlPartNum == item.MtlPartNum && o.PartNum == item.PartNum).FirstOrDefault();
                if (CompItem == null)
                {
                    IRow row = sheet1.CreateRow(RowNum);
                    row.CreateCell(0).SetCellValue(item.PartNum);
                    row.CreateCell(1).SetCellValue("");
                    row.CreateCell(2).SetCellValue("");
                    row.CreateCell(3).SetCellValue(item.MtlPartNum);
                    row.CreateCell(4).SetCellValue(item.QtyPer.ToString("0.00"));
                    row.GetCell(3).CellStyle = style2;
                    RowNum++;
                }
            }

            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            book.Write(fs);
            fs.Dispose();
        }

        public void CreateDIFFBook2(string filePath, List<DTO_MBOM> BOMDES, List<DTO_MBOM> BOMPLM, string NameA = "", string NameB = "")
        {
            HSSFWorkbook book = new HSSFWorkbook();
            ISheet sheet1 = book.CreateSheet("ComparePLMResult");

            IRow rowhead = sheet1.CreateRow(0);
            rowhead.CreateCell(0).SetCellValue(NameA + "父级物料");
            rowhead.CreateCell(1).SetCellValue(NameA + "父级物料名称");
            rowhead.CreateCell(2).SetCellValue(NameA + "物料编码");
            rowhead.CreateCell(3).SetCellValue(NameA + "数量");
            rowhead.CreateCell(4).SetCellValue(NameB + "父级物料");
            rowhead.CreateCell(5).SetCellValue(NameB + "父级物料名称");
            rowhead.CreateCell(6).SetCellValue(NameB + "物料编码");
            rowhead.CreateCell(7).SetCellValue(NameB + "数量");
            sheet1.SetColumnWidth(0, 20 * 256);
            sheet1.SetColumnWidth(1, 20 * 256);
            sheet1.SetColumnWidth(2, 20 * 256);
            sheet1.SetColumnWidth(3, 20 * 256);
            sheet1.SetColumnWidth(4, 20 * 256);
            sheet1.SetColumnWidth(5, 20 * 256);
            sheet1.SetColumnWidth(6, 20 * 256);
            sheet1.SetColumnWidth(7, 20 * 256);

            IFont font = book.CreateFont();
            font.Color = HSSFColor.White.Index;
            ICellStyle style = book.CreateCellStyle();
            style.FillForegroundColor = HSSFColor.Red.Index;
            style.FillPattern = FillPattern.SolidForeground;
            style.SetFont(font);

            var ListDes = BOMDES.GroupBy(t => t.MtlPartNum)
                    .Select(g => new
                    {
                        SumQty = g.Sum(t => t.QtyPer),
                        PartNum = g.Max(t => t.MtlPartNum),
                        ParentPart = g.Max(t=>t.PartNum),
                        ParentPartDesc = g.Max(t => t.PartDescription)
                    });

            var ListPlm = BOMPLM.GroupBy(t => t.MtlPartNum)
                    .Select(g => new
                    {
                        SumQty = g.Sum(t => t.QtyPer),
                        PartNum = g.Max(t => t.MtlPartNum),
                        ParentPart = g.Max(t => t.PartNum),
                        ParentPartDesc = g.Max(t => t.PartDescription)
                    });

            int RowNum = 0;
            foreach (var item in ListPlm)
            {
                IRow row = sheet1.CreateRow(RowNum + 1);
                row.CreateCell(0).SetCellValue(item.ParentPart);
                row.CreateCell(1).SetCellValue(item.ParentPartDesc);
                row.CreateCell(2).SetCellValue(item.PartNum);
                row.CreateCell(3).SetCellValue(item.SumQty.ToString("0.00"));
                var obj = ListDes.Where(o => o.PartNum == item.PartNum).FirstOrDefault();
                if (obj == null)
                {
                    row.CreateCell(6).SetCellValue("缺少");
                    row.GetCell(6).CellStyle = style;
                }
                else
                {
                    row.CreateCell(4).SetCellValue(obj.ParentPart);
                    row.CreateCell(5).SetCellValue(obj.ParentPartDesc);
                    row.CreateCell(6).SetCellValue(obj.PartNum);
                    if (item.SumQty != obj.SumQty)
                    {
                        row.CreateCell(7).SetCellValue(obj.SumQty.ToString("0.00"));
                        row.GetCell(7).CellStyle = style;
                    }
                }
                RowNum++;
            }

            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            book.Write(fs);
            fs.Dispose();
        }
        private void radioPLM_CheckedChanged(object sender, EventArgs e)
        {
            tBoxJobNum.Enabled = false;
        }

        private void radioJob_CheckedChanged(object sender, EventArgs e)
        {
            tBoxJobNum.Enabled = true;
        }
    }

    public class CompBom
    {
        public string PartNum { get; set; }
        public decimal SumQty { get; set; }
    }
}
