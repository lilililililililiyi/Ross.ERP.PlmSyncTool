using Newtonsoft.Json;
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
    public partial class FormConfig : Form
    {
        private Utilities Utility;
        private Entity.DTO.DTO_Config SysConfig { get; set; }
        public FormConfig()
        {
            InitializeComponent();
            Utility = new Utilities();
            InitData();
        }

        private void InitData()
        {
            List<DbConnStr> collection = new List<DbConnStr>
            {
                new DbConnStr { val = "ERPDbContext", name = "EpicorPilot" },
                new DbConnStr { val = "ERPDbContextLive", name = "Live" }
            };
            cmbBoxERPConn.DataSource = collection;
            this.cmbBoxERPConn.DisplayMember = "name";
            this.cmbBoxERPConn.ValueMember = "val";

            collection = new List<DbConnStr>
            {
                new DbConnStr { val = "PLMDbContext", name = "PLM" },
                new DbConnStr { val = "PLMDbContextTest", name = "PLMTest" }
            };
            cmbBoxPLMConn.DataSource = collection;
            this.cmbBoxPLMConn.DisplayMember = "name";
            this.cmbBoxPLMConn.ValueMember = "val";
            
            string Cfg = Utility.TxtRead(Application.StartupPath + "\\Config.txt");
            SysConfig = JsonConvert.DeserializeObject<Entity.DTO.DTO_Config>(Cfg);
            if (SysConfig != null)
            {
                this.AutoRunHour.Value = SysConfig.AutoRunHour;
                this.tboxDMTExePath.Text = SysConfig.DMTExePath;
                this.tboxDMTDatabase.Text = SysConfig.DMTDatabase;
                this.tboxDMTLoginUser.Text = SysConfig.DMTLoginUser;
                this.tboxDMTPsw.Text = SysConfig.DMTPsw;
                this.cmbBoxERPConn.SelectedValue = string.IsNullOrEmpty(SysConfig.ERPConn) ? "" : SysConfig.ERPConn;
                this.cmbBoxPLMConn.SelectedValue = string.IsNullOrEmpty(SysConfig.PLMConn) ? "" : SysConfig.PLMConn;
                this.tboxCompany.Text = SysConfig.Company;
                this.tboxVersion.Text = Application.ProductVersion;
                this.tboxAutoUpdateURL.Text = SysConfig.AutoUpdateURL;
            }

        }

        private void btnOkConfig_Click(object sender, EventArgs e)
        {
            try
            {
                Entity.DTO.DTO_Config model = new Entity.DTO.DTO_Config();
                model.AutoRunHour = this.AutoRunHour.Value;
                model.DMTExePath = this.tboxDMTExePath.Text;
                model.DMTDatabase = this.tboxDMTDatabase.Text;
                model.DMTLoginUser = this.tboxDMTLoginUser.Text;
                model.DMTPsw = this.tboxDMTPsw.Text;
                model.ERPConn = this.cmbBoxERPConn.SelectedValue.ToString();
                model.PLMConn = this.cmbBoxPLMConn.SelectedValue.ToString();
                model.Company = this.tboxCompany.Text;
                model.Version = this.tboxVersion.Text;
                model.AutoUpdateURL = this.tboxAutoUpdateURL.Text;
                string contents = JsonConvert.SerializeObject(model);
                Utility.TxtWrite(Application.StartupPath + "\\Config.txt", contents);
                MessageBox.Show("设置成功，请重新启动系统！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                Utilities.Log(err);
                MessageBox.Show(err.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            this.Close();
        }

        private void btnCancelConfig_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSetDir_Click(object sender, EventArgs e)
        {
            #region 选择文件夹
            //string defaultPath = "";
            //FolderBrowserDialog dialog = new FolderBrowserDialog();            
            //dialog.Description = "请选择一个文件夹";
            //dialog.ShowNewFolderButton = false;
            //if (defaultPath != "")
            //{
            //    dialog.SelectedPath = defaultPath;
            //}
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{
            //    defaultPath = dialog.SelectedPath;
            //}
            //tboxDMTExePath.Text = defaultPath;
            #endregion
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = "c:\\Epicor";
            if (file.ShowDialog() == DialogResult.OK)
            {
                this.tboxDMTExePath.Text = file.FileName;
            }
        }
    }
    public class DbConnStr
    {
        public string val { get; set; }
        public string name { get; set; }
    }
}
