using AutoMapper;
using Ross.ERP.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private List<Entity.DTO.DTO_MBOM> PLM_BOM;
        private List<Entity.DTO.DTO_JOBOM> ERP_BOM;
        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tBoxPartNum.Text))
            {
                MessageBox.Show("物料编码必填！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(tBoxJobNum.Text))
            {
                MessageBox.Show("工单号必填！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            BtnOK.Text = "对比中...";
            BtnOK.Enabled = false;
            Task.Run(() =>
            {
                List<Entity.DTO.DTO_MBOM> BOM_DIFF = CompareBOM(tBoxPartNum.Text, tBoxJobNum.Text);
                this.BeginInvoke(new Action(() =>
                {
                    BtnOK.Text = "开始对比";
                    BtnOK.Enabled = true;
                    BtnCmpOper.Enabled = true;
                    if (BOM_DIFF.Count > 0)
                    {
                        #region 导出对比结果
                        var dt = Utility.ListToDataTable(BOM_DIFF, "_", "#");
                        string rnd = Random.Next(0, 9999).ToString();
                        Utility.ExportExcel(dt, SaveFolderPath + "\\" + tBoxPartNum.Text + "BOM_DIFF" + rnd + ".xls");
                        System.Diagnostics.Process.Start(SaveFolderPath + "\\" + tBoxPartNum.Text + "BOM_DIFF" + rnd + ".xls");
                        #endregion
                    }
                    else
                        MessageBox.Show("没有差异！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
            });
        }

        private void BtnCmpOper_Click(object sender, EventArgs e)
        {
            BtnCmpOper.Text = "对比中...";
            BtnCmpOper.Enabled = false;
            Task.Run(() =>
            {
                List<Entity.DTO.DTO_MBOO> BOO_DIFF = CompareBOO(tBoxPartNum.Text, tBoxJobNum.Text);
                this.BeginInvoke(new Action(() =>
                {
                    BtnCmpOper.Text = "工序对比";
                    BtnCmpOper.Enabled = true;
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
        private List<Entity.DTO.DTO_MBOM> CompareBOM(string partNum, string jobNum)
        {
            List<Entity.DTO.DTO_MBOM> BOM_DIFF = new List<Entity.DTO.DTO_MBOM>();
            PLM_BOM = new List<Entity.DTO.DTO_MBOM>();
            ERP_BOM = new List<Entity.DTO.DTO_JOBOM>();

            PLM.GetPLMBOM(partNum, PLM_BOM);

            var JobAsmblDatas = ERP.GetJobAsmbl(jobNum);
            var JobMtlDatas = ERP.GetJobMtl(jobNum);
            ERP.GetJobBom(ERP_BOM, JobAsmblDatas, JobMtlDatas, jobNum);

            foreach (var item in PLM_BOM)
            {
                if (ERP_BOM.Where(o => o.PartNum == item.MtlPartNum).Count() <= 0)
                {
                    BOM_DIFF.Add(item);
                }
            }

            return BOM_DIFF;
        }
        private List<Entity.DTO.DTO_MBOO> CompareBOO(string partNum, string jobNum)
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
            if (!string.IsNullOrEmpty(jobNum) && ERP_BOM.Count > 0)
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
    }
}
