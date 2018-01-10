using Newtonsoft.Json;
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
    public partial class FormLogin : Form
    {
        private ERPRepository ERP;
        private Utilities Utility;
        private delegate void ProcessDelegate();
        private Entity.DTO.DTO_Config SysConfig;
        private FormConfig formConfig;
        private bool isMouseDown = false;
        private Point FormLocation;
        private Point mouseOffset;
        private string EpicorSysConfig = Application.StartupPath + @"\LiveSub.sysconfig";
        public FormLogin()
        {
            InitializeComponent();
            this.lblSoftV.Text = Application.ProductName + " v" + Application.ProductVersion;

            Utility = new Utilities();
            SysConfig = Utility.GetSysCfg();
            if (SysConfig != null)
            {
                ERP = new ERPRepository(SysConfig.ERPConn);
                labelSysInfo.Text = "";

                if(Utility.CheckUpdate(SysConfig.AutoUpdateURL))
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
                labelSysInfo.Text = "数据库连接出错，请点击设置进行系统配置...";
                btnLogin.Enabled = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tboxUserName.Text == "" || tboxPassword.Text == "")
            {
                MessageBox.Show("请输入用户名和密码", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                labelSysInfo.Text = "登录中...";
                btnLogin.Enabled = false;                
                
                Task taskSync = Task.Factory.StartNew(() =>
                {
                    //var User = ERP.GetUser(tboxUserName.Text, tboxPassword.Text);
                    string errmsg = "";
                    Ice.Core.Session EpicorSession = Login(tboxUserName.Text, tboxPassword.Text, out errmsg);
                    if (EpicorSession == null)
                    {
                        ProcessDelegate ProDeleg = delegate ()
                        {
                            MessageBox.Show(errmsg, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btnLogin.Enabled = true;
                        };
                        if (this.InvokeRequired)
                            this.Invoke(ProDeleg);
                    }
                    else
                    {
                        ProcessDelegate ProDeleg = delegate ()
                        {
                            //BasicDatas.CurrentUser = User.DcdUserID;
                            BasicDatas.CurrentUser = EpicorSession.UserID;
                            labelSysInfo.Text = "登录成功...";
                            btnLogin.Enabled = true;
                            //Utilities.Log(User.Name + " Login successful");
                            Utilities.Log(EpicorSession.UserID + " Login successful");
                            //MainForm mainForm = new MainForm(User.DcdUserID);
                            MainForm mainForm = new MainForm(EpicorSession.UserID);
                            mainForm.Show();
                            this.Hide();
                        };
                        if (this.InvokeRequired)
                            this.Invoke(ProDeleg);
                    }
                }, TaskCreationOptions.None);
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

        public Ice.Core.Session Login(string user, string password,out string errmsg, string company = "")
        {
            try
            {
                Ice.Core.Session _session = new Ice.Core.Session(user, password, Ice.Core.Session.LicenseType.Default, EpicorSysConfig);
                errmsg = "";
                return _session;
            }
            catch(Exception err)
            {
                errmsg = err.Message;
                return null;
            }
        }
    }
}
