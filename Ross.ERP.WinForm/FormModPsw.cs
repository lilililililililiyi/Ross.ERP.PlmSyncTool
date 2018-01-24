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
    public partial class FormModPsw : Form
    {
        private RossLiveRespository RLD;
        private Entity.RossLive.Model.RossUsers LoginUser;
        public FormModPsw()
        {
            InitializeComponent();
            RLD = new RossLiveRespository();
            GetUser(BasicDatas.CurrentUser);
        }

        public async void GetUser(string UserName)
        {
            var list = await RLD.GetUsers(UserName);
            LoginUser = list.FirstOrDefault();
        }

        private void buttonok_Click(object sender, EventArgs e)
        {
            if (textBoxOldPsw.Text == LoginUser.Password)
            {
                if (textBoxNewPsw.Text == textBoxNewPsw2.Text)
                {
                    LoginUser.Password = textBoxNewPsw.Text;
                    RLD.InsertOrUpdateUser(LoginUser);
                    MessageBox.Show("密码修改成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("两次密码输入不一致！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("旧密码错误！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
