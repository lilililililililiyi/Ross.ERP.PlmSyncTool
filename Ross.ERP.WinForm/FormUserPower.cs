using AutoMapper;
using Ross.ERP.Entity;
using Ross.ERP.Entity.RossLive.Model;
using Ross.ERP.PlmSyncTool.ExportDto;
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
    public partial class FormUserPower : Form
    {
        private RossLiveRespository RLD;
        private int CurrPowerID = 0;
        private string CurrUserID = null;
        public FormUserPower()
        {
            InitializeComponent();
            RLD = new RossLiveRespository();
            InitData();
        }

        public async void InitData()
        {
            var UserList = await RLD.GetUsers();
            DgvUsers.DataSource = UserList.Select(o => new { o.UserID, o.UserName }).ToList();
            var PowerList = await RLD.GetPowers();
            Mapper.Initialize(x => x.CreateMap<RossPowers, POWERS>());
            DgvPowers.DataSource = Mapper.Map<List<POWERS>>(PowerList);
        }

        private void btnEditPower_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgvPowers.SelectedRows)
            {
                string PowerIndex = row.Cells["PowerIndex"].Value.ToString();
                string PowerName = row.Cells["PowerName"].Value.ToString();
                bool InActive = bool.Parse(row.Cells["InActive"].Value.ToString());
                int PowerID = row.Cells["ID"].Value != null ? int.Parse(row.Cells["ID"].Value.ToString()) : 0;
                int ParentID = row.Cells["ParentID"].Value != null ? int.Parse(row.Cells["ParentID"].Value.ToString()) : 0;
                RossPowers model = null;
                if (PowerID == 0)
                    model = new RossPowers();
                else
                    model = RLD.GetPower(PowerID);
                model.InActive = InActive;
                model.ParentID = ParentID;
                model.PowerIndex = PowerIndex;
                model.PowerName = PowerName;
                RLD.InsertOrUpdatePower(model);
            }
            buttonSet.Enabled = true;
            InitData();
        }

        private async void btnAddRow_Click(object sender, EventArgs e)
        {
            var PowerList = await RLD.GetPowers();
            RossPowers obj = new RossPowers();
            obj.ParentID = CurrPowerID;
            PowerList.Add(obj);
            DgvPowers.DataSource = Mapper.Map<List<POWERS>>(PowerList);
            DgvPowers.CurrentCell = DgvPowers.Rows[DgvPowers.Rows.Count - 1].Cells[2];
            buttonSet.Enabled = false;
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            CurrUserID = DgvUsers.CurrentRow.Cells["UserID"].Value.ToString();
            if (!string.IsNullOrEmpty(CurrUserID))
            {
                string Powers = "#";
                foreach (DataGridViewRow row in DgvPowers.Rows)
                {
                    bool IsCheck = bool.Parse(row.Cells["IsCheck"].Value.ToString());
                    if (IsCheck)
                        Powers += "," + row.Cells["PowerIndex"].Value.ToString();
                }
                Powers = Powers.Replace("#,", "");
                var user = RLD.GetUser(CurrUserID);
                user.Powers = Powers;
                RLD.InsertOrUpdateUser(user);
                MessageBox.Show("权限设置成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("请选择一个用户！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DgvPowers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrUserID = DgvUsers.CurrentRow.Cells["UserID"].Value.ToString();
            var User = RLD.GetUser(CurrUserID);
            foreach (DataGridViewRow row in DgvPowers.Rows)
            {
                string power = row.Cells["PowerIndex"].Value == null ? "###" : row.Cells["PowerIndex"].Value.ToString();
                if (!string.IsNullOrEmpty(User.Powers))
                {
                    row.Cells["IsCheck"].Value = User.Powers.Contains(power);
                }
                else
                    row.Cells["IsCheck"].Value = false;
            }
        }

        private void ChkAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgvPowers.Rows)
            {
                row.Cells["IsCheck"].Value = ChkAll.Checked;
            }
        }
    }
}
