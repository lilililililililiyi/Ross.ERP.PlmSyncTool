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
    public partial class FormPartRev : Form
    {
        ERPRepository ERP;
        public FormPartRev(ERPRepository _ERP)
        {
            InitializeComponent();
            ERP = _ERP;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tboxPartNum.Text))
            {
                var datas = BasicDatas.ErpPartRev.Where(o => o.PartNum == tboxPartNum.Text).ToList();
                DgvMain.DataSource = datas.Select(o => new { o.PartNum,o.RevisionNum,o.RevShortDesc,o.ApprovedDate,o.EffectiveDate }).OrderByDescending(o=>o.EffectiveDate).ToList();
                var DropLists = datas.OrderByDescending(o => o.EffectiveDate).Select(o => o.RevisionNum).ToList();
                cboxPartRev.DataSource = DropLists;
            }
            else
            {
                MessageBox.Show("请填写物料编码！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonUpt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tboxPartNum.Text) && !string.IsNullOrEmpty(cboxPartRev.SelectedValue.ToString()))
            {
                ERP.ChgPartRevEffectDate(tboxPartNum.Text, cboxPartRev.SelectedValue.ToString());
                buttonOK_Click(sender, e);
            }
            else
            {
                MessageBox.Show("请填写物料编码和版本！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
