using Ross.ERP.Entity;
using Ross.ERP.PlmTool.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ross.ERP.PlmTool
{
    public partial class FormMain : Form
    {
        private ERPRepository ERP;
        private PLMRespository PLM;
        private BasicDatas BscData;
        private List<Entity.DTO.DTO_MBOM> MBOM;
        private List<Entity.DTO.DTO_MPART> MPART;
        private string partNum = "";
        public FormMain()
        {
            InitializeComponent();
            ERP = new ERPRepository("ERPDbContextLive");
            PLM = new PLMRespository("PLMDbContext");
            BscData = new BasicDatas("ERPDbContextLive", "PLMDbContext");
            AutoCache();
            this.Text = "PLM_BOM自检 v" + Application.ProductVersion;
        }

        private void GetCashData()
        {
            if (partNum != this.PartNum.Text)
            {
                MPART = PLM.GetPLMBOMPart(this.PartNum.Text, out MBOM);
                partNum = this.PartNum.Text;
            }
        }

        private void BtnUnableCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.PartNum.Text))
            {
                MessageBox.Show("请输入物料编码！", "提示"); return;
            }
            DgvMain.DataSource = null;
            string partNum = PartNum.Text.Trim();
            var entity = BasicDatas.ErpPart.Where(o => o.InActive == true && o.PartNum == partNum).FirstOrDefault();
            if (entity != null)
            {
                List<CheckResult> lists = new List<CheckResult>();
                CheckResult obj = new CheckResult();
                obj.PartNum = entity.PartNum;
                obj.PartDesc = entity.PartDescription;
                obj.Message = "此编码已禁用";
                obj.ErrorType = "PART";
                obj.ErrorGrade = 1;
                lists.Add(obj);
                DgvMain.DataSource = lists;
            }
            else
            {
                MessageBox.Show("此编码有效！", "提示");
            }
        }

        private void AutoCache()
        {
            tProgBar.Value = 0;
            labelLoadDatas.Text = "正在更新缓存......";
            timerMain.Enabled = true;
            toolBtnRefresh.Enabled = false;
            Task.Run(() =>
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
                    labelLoadDatas.Text = "更新成功";
                    groupBoxTools.Enabled = true;
                    tProgBar.Value = 100;
                    timerMain.Enabled = false;
                    toolBtnRefresh.Enabled = true;
                }));
            });
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            if (tProgBar.Value < 100)
                tProgBar.Value += 1;
        }

        private void toolBtnRefresh_ButtonClick(object sender, EventArgs e)
        {
            AutoCache();
        }

        private void BtnPartCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.PartNum.Text))
            {
                MessageBox.Show("请输入物料编码！", "提示"); return;
            }
            DgvMain.DataSource = null;
            var obj = BasicDatas.ErpPart.Where(o => o.PartNum == PartNum.Text).FirstOrDefault();
        }

        private void BtnBOMCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.PartNum.Text))
            {
                MessageBox.Show("请输入物料编码！", "提示"); return;
            }
            DgvMain.DataSource = null;
            List<CheckResult> lists = new List<CheckResult>();
            GetCashData();
            foreach (var item in MPART)
            {
                if (item.TypeCode == "M")
                {
                    var boo = PLM.GetPLMBOO(item.PartNum);
                    if (boo.Count <= 0)
                    {
                        lists.Add(new CheckResult()
                        {
                            ErrorGrade = 1,
                            ErrorType = "BOO",
                            Message = "需要有效的工序",
                            PartDesc = item.PartDescription,
                            PartNum = item.PartNum
                        });
                    }
                }
                var entity = BasicDatas.ErpPart.Where(o => o.InActive == true && o.PartNum == item.PartNum).FirstOrDefault();
                if (entity != null)
                {
                    lists.Add(new CheckResult()
                    {
                        ErrorGrade = 1,
                        ErrorType = "PART",
                        Message = "此编码已禁用",
                        PartDesc = item.PartDescription,
                        PartNum = item.PartNum
                    });
                }
            }
            if (lists.Count > 0)
            {
                DgvMain.DataSource = lists;
            }
            else
            {
                MessageBox.Show("BOM没有问题！", "提示");
            }
        }

        private void BtnOprCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.PartNum.Text))
            {
                MessageBox.Show("请输入物料编码！", "提示"); return;
            }
            DgvMain.DataSource = null;
            List<CheckResult> lists = new List<CheckResult>();
            GetCashData();
            foreach (var item in MPART)
            {
                if (item.TypeCode == "M")
                {
                    var boo = PLM.GetPLMBOO(item.PartNum);
                    if (boo.Count <= 0)
                    {
                        CheckResult obj = new CheckResult();
                        obj.ErrorGrade = 1;
                        obj.ErrorType = "BOO";
                        obj.Message = "需要有效的工序";
                        obj.PartDesc = item.PartDescription;
                        obj.PartNum = item.PartNum;
                        lists.Add(obj);
                    }
                }
            }
            if (lists.Count > 0)
            {
                DgvMain.DataSource = lists;
            }
            else
            {
                MessageBox.Show("工序没有问题！", "提示");
            }
        }
    }
}
