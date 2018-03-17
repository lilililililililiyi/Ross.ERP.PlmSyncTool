using Ross.ERP.Entity;
using Ross.ERP.Entity.RossLive.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ross.ERP.PlmSyncTool
{
    public partial class FormLogin : Form
    {
        private ERPRepository ERP;
        private RossLiveRespository RLD;
        private Utilities Utility;
        private delegate void ProcessDelegate();
        private Entity.DTO.DTO_Config SysConfig;
        private FormConfig formConfig;
        private bool isMouseDown = false;
        private Point FormLocation;
        private Point mouseOffset;
        private string EpicorSysConfig = Application.StartupPath + @"\Live.sysconfig";
        public FormLogin()
        {
            InitializeComponent();
            this.Text = "罗斯（无锡）PLM数据同步工具" + Application.ProductName + " v" + Application.ProductVersion;

            Utility = new Utilities();
            SysConfig = Utility.GetSysCfg();
            if (SysConfig != null)
            {
                ERP = new ERPRepository(SysConfig.ERPConn);
                RLD = new RossLiveRespository();

                if (Utility.CheckUpdate(SysConfig.AutoUpdateURL))
                {
                    if (MessageBox.Show("系统有新版本！确定立即更新吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        System.Diagnostics.Process AutoUpdate = new System.Diagnostics.Process();
                        AutoUpdate.StartInfo.FileName = Application.StartupPath + @"\AutoUpdate.bat";
                        AutoUpdate.EnableRaisingEvents = true;
                        AutoUpdate.Start();
                    }
                }
            }
            else
            {
                MessageBox.Show("数据库连接出错，请点击设置进行系统配置...", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLogin.Enabled = false;
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (tboxUserName.Text == "" || tboxPassword.Text == "")
            {
                MessageBox.Show("请输入用户名和密码", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                btnLogin.Enabled = false;
                string errmsg = "Invalid username or password.";
                var User = ERP.GetUser(tboxUserName.Text);
                //Ice.Core.Session EpicorSession = Login(tboxUserName.Text, tboxPassword.Text, out errmsg);
                if (User == null)
                {
                    MessageBox.Show(errmsg, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnLogin.Enabled = true;
                }
                else
                {

                    List<RossUsers> list = await RLD.GetUsers(User.DcdUserID);
                    if (list.Count <= 0)
                    {
                        RossUsers user = new RossUsers();
                        user.Password = User.DcdUserID;
                        user.UserID = User.DcdUserID;
                        user.UserName = User.DcdUserID;
                        user.Powers = "#";
                        RLD.InsertOrUpdateUser(user);
                    }
                    var rossUser = RLD.GetUser(User.DcdUserID, tboxPassword.Text);

                    if (rossUser != null)
                    {
                        //BasicDatas.CurrentUser = EpicorSession.UserID;                           
                        BasicDatas.CurrentUser = User.DcdUserID;
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(errmsg, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    btnLogin.Enabled = true;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                FormLocation = this.Location;
                mouseOffset = Control.MousePosition;
            }
        }

        private void FormLogin_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void FormLogin_MouseMove(object sender, MouseEventArgs e)
        {
            int _x = 0;
            int _y = 0;
            if (isMouseDown)
            {
                Point pt = Control.MousePosition;
                _x = mouseOffset.X - pt.X;
                _y = mouseOffset.Y - pt.Y;

                this.Location = new Point(FormLocation.X - _x, FormLocation.Y - _y);
            }
        }

        private void picbtnSetting_Click(object sender, EventArgs e)
        {
            if (formConfig == null || formConfig.IsDisposed)
            {
                formConfig = new FormConfig();
                formConfig.Show();
                formConfig.Owner = this;
            }
            else
            {
                formConfig.WindowState = FormWindowState.Normal;
                formConfig.Activate();
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (formConfig == null || formConfig.IsDisposed)
            {
                formConfig = new FormConfig();
                formConfig.Show();
                formConfig.Owner = this;
            }
            else
            {
                formConfig.WindowState = FormWindowState.Normal;
                formConfig.Activate();
            }
        }

        public Ice.Core.Session Login(string user, string password, out string errmsg, string company = "")
        {
            try
            {
                Ice.Core.Session _session = new Ice.Core.Session(user, password, Ice.Core.Session.LicenseType.Default, EpicorSysConfig);
                errmsg = "";
                return _session;
            }
            catch (Exception err)
            {
                errmsg = err.Message;
                return null;
            }
        }
    }
}
