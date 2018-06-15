namespace Ross.ERP.AutoSync
{
    partial class FormAuto
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewPart = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewBOO = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewBOM = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butDir = new System.Windows.Forms.Button();
            this.comboDb = new System.Windows.Forms.ComboBox();
            this.tboxDMTPath = new System.Windows.Forms.TextBox();
            this.tboxPsw = new System.Windows.Forms.TextBox();
            this.tboxUser = new System.Windows.Forms.TextBox();
            this.labelSyncStatus = new System.Windows.Forms.Label();
            this.buttonStartSync = new System.Windows.Forms.Button();
            this.buttonGetNewPart = new System.Windows.Forms.Button();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.processSync = new System.Diagnostics.Process();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPart)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBOO)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBOM)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelSyncStatus);
            this.splitContainer1.Panel2.Controls.Add(this.buttonStartSync);
            this.splitContainer1.Panel2.Controls.Add(this.buttonGetNewPart);
            this.splitContainer1.Size = new System.Drawing.Size(654, 382);
            this.splitContainer1.SplitterDistance = 327;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(654, 324);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewPart);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(646, 298);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PART";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPart
            // 
            this.dataGridViewPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPart.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewPart.Name = "dataGridViewPart";
            this.dataGridViewPart.RowTemplate.Height = 23;
            this.dataGridViewPart.Size = new System.Drawing.Size(640, 292);
            this.dataGridViewPart.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewBOO);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(646, 298);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BOO";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBOO
            // 
            this.dataGridViewBOO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBOO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBOO.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewBOO.Name = "dataGridViewBOO";
            this.dataGridViewBOO.RowTemplate.Height = 23;
            this.dataGridViewBOO.Size = new System.Drawing.Size(640, 292);
            this.dataGridViewBOO.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewBOM);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(646, 298);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "BOM";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBOM
            // 
            this.dataGridViewBOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBOM.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewBOM.Name = "dataGridViewBOM";
            this.dataGridViewBOM.RowTemplate.Height = 23;
            this.dataGridViewBOM.Size = new System.Drawing.Size(640, 292);
            this.dataGridViewBOM.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.butDir);
            this.tabPage4.Controls.Add(this.comboDb);
            this.tabPage4.Controls.Add(this.tboxDMTPath);
            this.tabPage4.Controls.Add(this.tboxPsw);
            this.tabPage4.Controls.Add(this.tboxUser);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(646, 298);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "设置";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "数据库";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "用户名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "DMT";
            // 
            // butDir
            // 
            this.butDir.Location = new System.Drawing.Point(259, 29);
            this.butDir.Name = "butDir";
            this.butDir.Size = new System.Drawing.Size(60, 23);
            this.butDir.TabIndex = 5;
            this.butDir.Text = "浏览...";
            this.butDir.UseVisualStyleBackColor = true;
            this.butDir.Click += new System.EventHandler(this.butDir_Click);
            // 
            // comboDb
            // 
            this.comboDb.FormattingEnabled = true;
            this.comboDb.Items.AddRange(new object[] {
            "Live",
            "EpicorPilot"});
            this.comboDb.Location = new System.Drawing.Point(70, 112);
            this.comboDb.Name = "comboDb";
            this.comboDb.Size = new System.Drawing.Size(80, 20);
            this.comboDb.TabIndex = 4;
            this.comboDb.Text = "Live";
            // 
            // tboxDMTPath
            // 
            this.tboxDMTPath.Location = new System.Drawing.Point(70, 31);
            this.tboxDMTPath.Name = "tboxDMTPath";
            this.tboxDMTPath.Size = new System.Drawing.Size(183, 21);
            this.tboxDMTPath.TabIndex = 1;
            this.tboxDMTPath.Text = "C:\\Epicor\\ERP10.1Client.Live\\Client\\DMT.exe";
            // 
            // tboxPsw
            // 
            this.tboxPsw.Location = new System.Drawing.Point(70, 85);
            this.tboxPsw.Name = "tboxPsw";
            this.tboxPsw.PasswordChar = '*';
            this.tboxPsw.Size = new System.Drawing.Size(80, 21);
            this.tboxPsw.TabIndex = 3;
            this.tboxPsw.Text = "123123";
            // 
            // tboxUser
            // 
            this.tboxUser.Location = new System.Drawing.Point(70, 58);
            this.tboxUser.Name = "tboxUser";
            this.tboxUser.Size = new System.Drawing.Size(80, 21);
            this.tboxUser.TabIndex = 2;
            this.tboxUser.Text = "it002";
            // 
            // labelSyncStatus
            // 
            this.labelSyncStatus.AutoSize = true;
            this.labelSyncStatus.Location = new System.Drawing.Point(12, 21);
            this.labelSyncStatus.Name = "labelSyncStatus";
            this.labelSyncStatus.Size = new System.Drawing.Size(47, 12);
            this.labelSyncStatus.TabIndex = 2;
            this.labelSyncStatus.Text = "就绪...";
            // 
            // buttonStartSync
            // 
            this.buttonStartSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartSync.Location = new System.Drawing.Point(486, 16);
            this.buttonStartSync.Name = "buttonStartSync";
            this.buttonStartSync.Size = new System.Drawing.Size(75, 23);
            this.buttonStartSync.TabIndex = 1;
            this.buttonStartSync.Text = "开始同步";
            this.buttonStartSync.UseVisualStyleBackColor = true;
            this.buttonStartSync.Click += new System.EventHandler(this.buttonStartSync_Click);
            // 
            // buttonGetNewPart
            // 
            this.buttonGetNewPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetNewPart.Location = new System.Drawing.Point(567, 16);
            this.buttonGetNewPart.Name = "buttonGetNewPart";
            this.buttonGetNewPart.Size = new System.Drawing.Size(75, 23);
            this.buttonGetNewPart.TabIndex = 0;
            this.buttonGetNewPart.Text = "获取数据";
            this.buttonGetNewPart.UseVisualStyleBackColor = true;
            this.buttonGetNewPart.Click += new System.EventHandler(this.buttonGetNewPart_Click);
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
            // FormAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 382);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormAuto";
            this.Text = "自动同步";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBOO)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBOM)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewPart;
        private System.Windows.Forms.Button buttonGetNewPart;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewBOO;
        private System.Windows.Forms.DataGridView dataGridViewBOM;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.TextBox tboxDMTPath;
        private System.Windows.Forms.TextBox tboxPsw;
        private System.Windows.Forms.TextBox tboxUser;
        private System.Windows.Forms.ComboBox comboDb;
        private System.Diagnostics.Process processSync;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonStartSync;
        private System.Windows.Forms.Label labelSyncStatus;
        private System.Windows.Forms.Button butDir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

