namespace Ross.ERP.Server
{
    partial class FormServer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServer));
            this.BtnAutoUptMtl = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelLoadDatas = new System.Windows.Forms.ToolStripStatusLabel();
            this.tProgBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolBtnRefresh = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolStripMenuItem_stop = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_start = new System.Windows.Forms.ToolStripMenuItem();
            this.startTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.runTimes = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.DGVMain = new System.Windows.Forms.DataGridView();
            this.tabCtrlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DGVUpdateLogs = new System.Windows.Forms.DataGridView();
            this.rtboxUpdateDtl = new System.Windows.Forms.RichTextBox();
            this.processSync = new System.Diagnostics.Process();
            this.timerAutoUpt = new System.Windows.Forms.Timer(this.components);
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip_notifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyMenuItem_start = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyMenuItem_stop = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyMenuItem_exist = new System.Windows.Forms.ToolStripMenuItem();
            this.timerAutoRun = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMain)).BeginInit();
            this.tabCtrlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUpdateLogs)).BeginInit();
            this.contextMenuStrip_notifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAutoUptMtl
            // 
            this.BtnAutoUptMtl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAutoUptMtl.Location = new System.Drawing.Point(476, 308);
            this.BtnAutoUptMtl.Name = "BtnAutoUptMtl";
            this.BtnAutoUptMtl.Size = new System.Drawing.Size(95, 26);
            this.BtnAutoUptMtl.TabIndex = 0;
            this.BtnAutoUptMtl.Text = "自动更新物料";
            this.BtnAutoUptMtl.UseVisualStyleBackColor = true;
            this.BtnAutoUptMtl.Click += new System.EventHandler(this.BtnAutoUptMtl_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelLoadDatas,
            this.tProgBar,
            this.toolBtnRefresh,
            this.toolStripSplitButton1,
            this.startTime,
            this.toolStripStatusLabel1,
            this.runTimes});
            this.statusStrip1.Location = new System.Drawing.Point(0, 340);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelLoadDatas
            // 
            this.labelLoadDatas.Font = new System.Drawing.Font("宋体", 9F);
            this.labelLoadDatas.Name = "labelLoadDatas";
            this.labelLoadDatas.Size = new System.Drawing.Size(29, 17);
            this.labelLoadDatas.Text = "就绪";
            // 
            // tProgBar
            // 
            this.tProgBar.Name = "tProgBar";
            this.tProgBar.Size = new System.Drawing.Size(100, 16);
            // 
            // toolBtnRefresh
            // 
            this.toolBtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnRefresh.Image = global::Ross.ERP.Server.Properties.Resources.refresh;
            this.toolBtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnRefresh.Name = "toolBtnRefresh";
            this.toolBtnRefresh.Size = new System.Drawing.Size(32, 20);
            this.toolBtnRefresh.Text = "toolStripSplitButton1";
            this.toolBtnRefresh.ButtonClick += new System.EventHandler(this.toolBtnRefresh_ButtonClick);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_stop,
            this.ToolStripMenuItem_start});
            this.toolStripSplitButton1.Image = global::Ross.ERP.Server.Properties.Resources.servers;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // ToolStripMenuItem_stop
            // 
            this.ToolStripMenuItem_stop.Image = global::Ross.ERP.Server.Properties.Resources.stop;
            this.ToolStripMenuItem_stop.Name = "ToolStripMenuItem_stop";
            this.ToolStripMenuItem_stop.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_stop.Text = "暂停";
            this.ToolStripMenuItem_stop.Click += new System.EventHandler(this.ToolStripMenuItem_stop_Click);
            // 
            // ToolStripMenuItem_start
            // 
            this.ToolStripMenuItem_start.Image = global::Ross.ERP.Server.Properties.Resources.start;
            this.ToolStripMenuItem_start.Name = "ToolStripMenuItem_start";
            this.ToolStripMenuItem_start.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_start.Text = "启动";
            this.ToolStripMenuItem_start.Click += new System.EventHandler(this.ToolStripMenuItem_start_Click);
            // 
            // startTime
            // 
            this.startTime.Font = new System.Drawing.Font("宋体", 9F);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(53, 17);
            this.startTime.Text = "启动时间";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("微软雅黑", 7F);
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // runTimes
            // 
            this.runTimes.Font = new System.Drawing.Font("宋体", 9F);
            this.runTimes.Name = "runTimes";
            this.runTimes.Size = new System.Drawing.Size(41, 17);
            this.runTimes.Text = "已运行";
            // 
            // timerMain
            // 
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // DGVMain
            // 
            this.DGVMain.AllowUserToAddRows = false;
            this.DGVMain.AllowUserToDeleteRows = false;
            this.DGVMain.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGVMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVMain.Location = new System.Drawing.Point(3, 3);
            this.DGVMain.Name = "DGVMain";
            this.DGVMain.ReadOnly = true;
            this.DGVMain.RowTemplate.Height = 23;
            this.DGVMain.Size = new System.Drawing.Size(545, 258);
            this.DGVMain.TabIndex = 0;
            // 
            // tabCtrlMain
            // 
            this.tabCtrlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCtrlMain.Controls.Add(this.tabPage1);
            this.tabCtrlMain.Controls.Add(this.tabPage2);
            this.tabCtrlMain.Location = new System.Drawing.Point(12, 12);
            this.tabCtrlMain.Name = "tabCtrlMain";
            this.tabCtrlMain.SelectedIndex = 0;
            this.tabCtrlMain.Size = new System.Drawing.Size(559, 290);
            this.tabCtrlMain.TabIndex = 3;
            this.tabCtrlMain.SelectedIndexChanged += new System.EventHandler(this.tabCtrlMain_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(551, 264);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "更新列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(551, 264);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "服务日志";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DGVUpdateLogs);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtboxUpdateDtl);
            this.splitContainer1.Size = new System.Drawing.Size(545, 258);
            this.splitContainer1.SplitterDistance = 181;
            this.splitContainer1.TabIndex = 0;
            // 
            // DGVUpdateLogs
            // 
            this.DGVUpdateLogs.AllowUserToAddRows = false;
            this.DGVUpdateLogs.AllowUserToDeleteRows = false;
            this.DGVUpdateLogs.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGVUpdateLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVUpdateLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUpdateLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVUpdateLogs.Location = new System.Drawing.Point(0, 0);
            this.DGVUpdateLogs.Name = "DGVUpdateLogs";
            this.DGVUpdateLogs.ReadOnly = true;
            this.DGVUpdateLogs.RowTemplate.Height = 23;
            this.DGVUpdateLogs.Size = new System.Drawing.Size(545, 181);
            this.DGVUpdateLogs.TabIndex = 0;
            this.DGVUpdateLogs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUpdateLogs_CellClick);
            // 
            // rtboxUpdateDtl
            // 
            this.rtboxUpdateDtl.BackColor = System.Drawing.Color.Gainsboro;
            this.rtboxUpdateDtl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtboxUpdateDtl.Location = new System.Drawing.Point(0, 0);
            this.rtboxUpdateDtl.Name = "rtboxUpdateDtl";
            this.rtboxUpdateDtl.ReadOnly = true;
            this.rtboxUpdateDtl.Size = new System.Drawing.Size(545, 73);
            this.rtboxUpdateDtl.TabIndex = 0;
            this.rtboxUpdateDtl.Text = "";
            // 
            // processSync
            // 
            this.processSync.StartInfo.Domain = "";
            this.processSync.StartInfo.LoadUserProfile = false;
            this.processSync.StartInfo.Password = null;
            this.processSync.StartInfo.StandardErrorEncoding = null;
            this.processSync.StartInfo.StandardOutputEncoding = null;
            this.processSync.StartInfo.UserName = "";
            this.processSync.SynchronizingObject = this;
            // 
            // timerAutoUpt
            // 
            this.timerAutoUpt.Enabled = true;
            this.timerAutoUpt.Interval = 1000;
            this.timerAutoUpt.Tick += new System.EventHandler(this.timerAutoUpt_Tick);
            // 
            // notifyIconMain
            // 
            this.notifyIconMain.ContextMenuStrip = this.contextMenuStrip_notifyIcon;
            this.notifyIconMain.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMain.Icon")));
            this.notifyIconMain.Text = "Ross ERP Server";
            this.notifyIconMain.Visible = true;
            this.notifyIconMain.DoubleClick += new System.EventHandler(this.notifyIconMain_DoubleClick);
            // 
            // contextMenuStrip_notifyIcon
            // 
            this.contextMenuStrip_notifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notifyMenuItem_start,
            this.notifyMenuItem_stop,
            this.notifyMenuItem_exist});
            this.contextMenuStrip_notifyIcon.Name = "contextMenuStrip_notifyIcon";
            this.contextMenuStrip_notifyIcon.Size = new System.Drawing.Size(101, 70);
            // 
            // notifyMenuItem_start
            // 
            this.notifyMenuItem_start.Image = global::Ross.ERP.Server.Properties.Resources.start;
            this.notifyMenuItem_start.Name = "notifyMenuItem_start";
            this.notifyMenuItem_start.Size = new System.Drawing.Size(100, 22);
            this.notifyMenuItem_start.Text = "启动";
            this.notifyMenuItem_start.Click += new System.EventHandler(this.notifyMenuItem_start_Click);
            // 
            // notifyMenuItem_stop
            // 
            this.notifyMenuItem_stop.Image = global::Ross.ERP.Server.Properties.Resources.stop;
            this.notifyMenuItem_stop.Name = "notifyMenuItem_stop";
            this.notifyMenuItem_stop.Size = new System.Drawing.Size(100, 22);
            this.notifyMenuItem_stop.Text = "暂停";
            this.notifyMenuItem_stop.Click += new System.EventHandler(this.notifyMenuItem_stop_Click);
            // 
            // notifyMenuItem_exist
            // 
            this.notifyMenuItem_exist.Image = global::Ross.ERP.Server.Properties.Resources.quit;
            this.notifyMenuItem_exist.Name = "notifyMenuItem_exist";
            this.notifyMenuItem_exist.Size = new System.Drawing.Size(100, 22);
            this.notifyMenuItem_exist.Text = "退出";
            this.notifyMenuItem_exist.Click += new System.EventHandler(this.notifyMenuItem_exist_Click);
            // 
            // timerAutoRun
            // 
            this.timerAutoRun.Enabled = true;
            this.timerAutoRun.Interval = 1800000;
            this.timerAutoRun.Tick += new System.EventHandler(this.timerAutoRun_Tick);
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.tabCtrlMain);
            this.Controls.Add(this.BtnAutoUptMtl);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "服务端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormServer_FormClosing);
            this.SizeChanged += new System.EventHandler(this.FormServer_SizeChanged);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMain)).EndInit();
            this.tabCtrlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUpdateLogs)).EndInit();
            this.contextMenuStrip_notifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAutoUptMtl;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelLoadDatas;
        private System.Windows.Forms.ToolStripProgressBar tProgBar;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.ToolStripSplitButton toolBtnRefresh;
        private System.Windows.Forms.DataGridView DGVMain;
        private System.Windows.Forms.TabControl tabCtrlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DGVUpdateLogs;
        private System.Windows.Forms.RichTextBox rtboxUpdateDtl;
        private System.Diagnostics.Process processSync;
        private System.Windows.Forms.Timer timerAutoUpt;
        private System.Windows.Forms.ToolStripStatusLabel startTime;
        private System.Windows.Forms.ToolStripStatusLabel runTimes;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.NotifyIcon notifyIconMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem notifyMenuItem_start;
        private System.Windows.Forms.ToolStripMenuItem notifyMenuItem_stop;
        private System.Windows.Forms.ToolStripMenuItem notifyMenuItem_exist;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_stop;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_start;
        private System.Windows.Forms.Timer timerAutoRun;
    }
}

