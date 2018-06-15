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
using System.Collections.Generic;

namespace Ross.ERP.PlmSyncTool
{
    public partial class FormMTLCompute : Form
    {
        public string PLMConn { get; set; }
        public string Units { get; set; }
        public FormMTLCompute(string _PLMConn, string _Units)
        {
            PLMConn = _PLMConn;
            Units = _Units;
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tBoxFormula.Text))
                {
                    decimal L = Utilities.ToDec(tBoxLength.Text);
                    decimal W = Utilities.ToDec(tBoxWidth.Text);
                    decimal T = Utilities.ToDec(tBoxThickness.Text);
                    string formula = tBoxFormula.Text.Replace("L", L.ToString()).Replace("d", W.ToString()).Replace("t", T.ToString());
                    var a = new DataTable().Compute(formula, "");
                    richTextBoxResult.Text = Convert.ToDouble(a).ToString("f3");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tBoxPartNum_Leave(object sender, EventArgs e)
        {
            try
            {
                //RossLiveRespository RLD = new RossLiveRespository();
                PLMRespository PLM = new PLMRespository(PLMConn, Units);
                //var item = RLD.GetPartDeg(tBoxPartNum.Text).FirstOrDefault();
                var item = BasicDatas.PLM_MATERIAL.Where(o => o.NO == tBoxPartNum.Text).FirstOrDefault();
                if (item != null)
                {
                    tBoxFormula.Text = item.MTLDEGS.Replace("MTLMZ=", "");
                }
                else
                {
                    MessageBox.Show("材料码不存在！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
