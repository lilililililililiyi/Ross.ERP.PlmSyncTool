using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace AutoUpdate
{
    public partial class MainForm : Form
    {
        private string CheckUpdateURL = @"\192.168.0.160\EpicorData\RossPLMSyncTool";
        private string exePath = Application.StartupPath;
        private string UpdateFiles = Application.StartupPath + "\\UpdateFiles";
        private string VersionR = "1.0.0.0";
        private string VersionL = "1.0.0.0";
        private DTO_Config ConfigRemote, ConfigLocal;

        public MainForm()
        {
            InitializeComponent();
        }

        public void GetRemoteFile()
        {
            try
            {
                DirectoryInfo TheFolder = new DirectoryInfo(CheckUpdateURL);
                FileInfo[] FileList = TheFolder.GetFiles();
                this.progressBarUpdate.Minimum = 0;
                this.progressBarUpdate.Maximum = FileList.Length;

                foreach (FileInfo NextFile in FileList)
                {
                    if (NextFile.Name != "Config.txt")
                    {
                        File.Copy(NextFile.FullName, exePath + "\\" + NextFile.Name, true);                        
                    }
                    this.lblMessage.Text = "更新" + NextFile.Name;
                    this.progressBarUpdate.Value += 1;
                    this.lblPercent.Text = "更新进度... " + (this.progressBarUpdate.Value / FileList.Length) * 100 + "%";
                }
                this.lblMessage.Text = "更新完成";
                //更改本地版本号为最新版本号
                ConfigLocal.Version = VersionR;
                string cfgs = JsonConvert.SerializeObject(ConfigLocal);
                TxtWrite(Application.StartupPath + "\\Config.txt", cfgs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckUpdate()
        {
            bool result = false;
            try
            {
                string Cfg = TxtRead(exePath + "\\Config.txt");
                ConfigLocal = JsonConvert.DeserializeObject<DTO_Config>(Cfg);

                CheckUpdateURL = ConfigLocal.AutoUpdateURL;

                Cfg = TxtRead(CheckUpdateURL + "\\Config.txt");
                ConfigRemote = JsonConvert.DeserializeObject<DTO_Config>(Cfg);                

                VersionR = ConfigRemote.Version;
                VersionL = ConfigLocal.Version;
                int VersionRemote = int.Parse(ConfigRemote.Version.Replace(".", ""));
                int VersionLocal = int.Parse(ConfigLocal.Version.Replace(".", ""));

                result = VersionRemote > VersionLocal;
            }
            catch { }
            return result;
        }
        
        public void DownLoadFile()
        {
            if (!Directory.Exists(UpdateFiles))
            {
                Directory.CreateDirectory(UpdateFiles);
            }
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                    webClient.DownloadFileAsync(new Uri(CheckUpdateURL + "\\RossPLMSyncTool.rar"), UpdateFiles + "\\UpdateFile.rar");
                }
                catch (WebException ex)
                {
                    MessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.lblMessage.Text = "下载完成";
                //复制更新文件替换旧文件
                DirectoryInfo TheFolder = new DirectoryInfo(UpdateFiles);
                foreach (FileInfo NextFile in TheFolder.GetFiles())
                {
                    File.Copy(NextFile.FullName, Application.StartupPath + NextFile.Name, true);
                }
                //Directory.Delete(UpdateFiles, true);
                //覆盖完成 重新启动程序  
                //processUpdate = new Process();
                //processUpdate.StartInfo.FileName = "Ross.ERP.PlmSyncTool.exe";
                //processUpdate.StartInfo.WorkingDirectory = exePath;
                //processUpdate.StartInfo.CreateNoWindow = true;
                //processUpdate.Start();
                //Application.Exit();
            }
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.progressBarUpdate.Minimum = 0;
            this.progressBarUpdate.Maximum = (int)e.TotalBytesToReceive;
            this.progressBarUpdate.Value = (int)e.BytesReceived;
            this.lblPercent.Text = e.ProgressPercentage + "%";
        }

        private string TxtRead(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            StringBuilder sb = new StringBuilder();
            while (!sr.EndOfStream)
            {
                sb.AppendLine(sr.ReadLine());
            }
            return sb.ToString();
        }
        public void TxtWrite(string path, string contents)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(contents);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        private void btnCheckUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckUpdate())
            {
                MessageBox.Show("当前版本(v" + VersionL + ")已是最新版！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else
            {
                if (MessageBox.Show("有新版本(v" + VersionR + ")，是否立即更新？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    //关闭主程序
                    //Process process = new Process();
                    //process.StartInfo = new ProcessStartInfo(exePath + "\\Ross.ERP.PlmSyncTool.exe");
                    //process.Close();
                    //更新主程序
                    GetRemoteFile();
                }
            }
        }
    }
}
