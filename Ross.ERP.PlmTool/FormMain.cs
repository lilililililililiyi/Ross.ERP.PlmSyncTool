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
        public FormMain()
        {
            InitializeComponent();
            ERP = new ERPRepository("ERPDbContextLive");
            PLM = new PLMRespository("PLMDbContext");
            BscData = new BasicDatas("ERPDbContextLive", "PLMDbContext");
        }

        private void BtnUnableCheck_Click(object sender, EventArgs e)
        {
            string partNum = PartNum.Text.Trim();
            var entity = BasicDatas.ErpPart.Where(o => o.InActive == true && o.PartNum == partNum).FirstOrDefault();
            if (entity != null)
            {
                List<CheckResult> lists = new List<CheckResult>();
                CheckResult obj = new CheckResult();
                obj.PartNum = entity.PartNum;
                obj.PartDesc = entity.PartDescription;
                obj.Message = "此编码已禁用";
                obj.ErrorType = "Part";
                obj.ErrorGrade = 1;
                lists.Add(obj);
                DgvMain.DataSource = lists;
            }
        }

        private void AutoCache()
        {
            tProgBar.Value = 0;
            labelLoadDatas.Text = "正在更新缓存......";
            timerMain.Enabled = true;
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
    }
}
