namespace Ross.ERP.PlmSyncTool
{
    partial class FormConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnOkConfig = new System.Windows.Forms.Button();
            this.btnCancelConfig = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxDMTLoginUser = new System.Windows.Forms.TextBox();
            this.tboxDMTPsw = new System.Windows.Forms.TextBox();
            this.tboxDMTDatabase = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AutoRunHour = new System.Windows.Forms.NumericUpDown();
            this.cmbBoxERPConn = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxDMTExePath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSetDir = new System.Windows.Forms.Button();
            this.cmbBoxPLMConn = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tboxCompany = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tboxVersion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tboxAutoUpdateURL = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.AutoRunHour)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "设置每天：";
            // 
            // btnOkConfig
            // 
            this.btnOkConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOkConfig.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOkConfig.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOkConfig.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOkConfig.Location = new System.Drawing.Point(597, 399);
            this.btnOkConfig.Name = "btnOkConfig";
            this.btnOkConfig.Size = new System.Drawing.Size(75, 23);
            this.btnOkConfig.TabIndex = 2;
            this.btnOkConfig.Text = "确定";
            this.btnOkConfig.UseVisualStyleBackColor = false;
            this.btnOkConfig.Click += new System.EventHandler(this.btnOkConfig_Click);
            // 
            // btnCancelConfig
            // 
            this.btnCancelConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelConfig.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancelConfig.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelConfig.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelConfig.Location = new System.Drawing.Point(516, 399);
            this.btnCancelConfig.Name = "btnCancelConfig";
            this.btnCancelConfig.Size = new System.Drawing.Size(75, 23);
            this.btnCancelConfig.TabIndex = 3;
            this.btnCancelConfig.Text = "取消";
            this.btnCancelConfig.UseVisualStyleBackColor = false;
            this.btnCancelConfig.Click += new System.EventHandler(this.btnCancelConfig_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "DMT授权用户：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "DMT授权密码：";
            // 
            // tboxDMTLoginUser
            // 
            this.tboxDMTLoginUser.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxDMTLoginUser.Location = new System.Drawing.Point(113, 53);
            this.tboxDMTLoginUser.Name = "tboxDMTLoginUser";
            this.tboxDMTLoginUser.Size = new System.Drawing.Size(160, 22);
            this.tboxDMTLoginUser.TabIndex = 6;
            // 
            // tboxDMTPsw
            // 
            this.tboxDMTPsw.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxDMTPsw.Location = new System.Drawing.Point(113, 81);
            this.tboxDMTPsw.Name = "tboxDMTPsw";
            this.tboxDMTPsw.PasswordChar = '*';
            this.tboxDMTPsw.Size = new System.Drawing.Size(160, 22);
            this.tboxDMTPsw.TabIndex = 7;
            this.tboxDMTPsw.UseSystemPasswordChar = true;
            // 
            // tboxDMTDatabase
            // 
            this.tboxDMTDatabase.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxDMTDatabase.Location = new System.Drawing.Point(113, 110);
            this.tboxDMTDatabase.Name = "tboxDMTDatabase";
            this.tboxDMTDatabase.Size = new System.Drawing.Size(160, 22);
            this.tboxDMTDatabase.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "DMT连接库：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(270, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "ERP连接库：";
            // 
            // AutoRunHour
            // 
            this.AutoRunHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AutoRunHour.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoRunHour.Location = new System.Drawing.Point(100, 102);
            this.AutoRunHour.Name = "AutoRunHour";
            this.AutoRunHour.Size = new System.Drawing.Size(50, 22);
            this.AutoRunHour.TabIndex = 11;
            // 
            // cmbBoxERPConn
            // 
            this.cmbBoxERPConn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBoxERPConn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxERPConn.FormattingEnabled = true;
            this.cmbBoxERPConn.Location = new System.Drawing.Point(355, 19);
            this.cmbBoxERPConn.Name = "cmbBoxERPConn";
            this.cmbBoxERPConn.Size = new System.Drawing.Size(161, 22);
            this.cmbBoxERPConn.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(156, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "点自动运行";
            // 
            // tboxDMTExePath
            // 
            this.tboxDMTExePath.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxDMTExePath.Location = new System.Drawing.Point(113, 25);
            this.tboxDMTExePath.Name = "tboxDMTExePath";
            this.tboxDMTExePath.Size = new System.Drawing.Size(386, 22);
            this.tboxDMTExePath.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 14);
            this.label7.TabIndex = 16;
            this.label7.Text = "DMT文件路径：";
            // 
            // btnSetDir
            // 
            this.btnSetDir.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSetDir.FlatAppearance.BorderSize = 0;
            this.btnSetDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetDir.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetDir.Location = new System.Drawing.Point(505, 21);
            this.btnSetDir.Name = "btnSetDir";
            this.btnSetDir.Size = new System.Drawing.Size(60, 22);
            this.btnSetDir.TabIndex = 17;
            this.btnSetDir.Text = "浏览...";
            this.btnSetDir.UseVisualStyleBackColor = false;
            this.btnSetDir.Click += new System.EventHandler(this.btnSetDir_Click);
            // 
            // cmbBoxPLMConn
            // 
            this.cmbBoxPLMConn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBoxPLMConn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxPLMConn.FormattingEnabled = true;
            this.cmbBoxPLMConn.Location = new System.Drawing.Point(100, 18);
            this.cmbBoxPLMConn.Name = "cmbBoxPLMConn";
            this.cmbBoxPLMConn.Size = new System.Drawing.Size(160, 22);
            this.cmbBoxPLMConn.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 14);
            this.label8.TabIndex = 18;
            this.label8.Text = "PLM连接库：";
            // 
            // tboxCompany
            // 
            this.tboxCompany.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCompany.Location = new System.Drawing.Point(100, 134);
            this.tboxCompany.Name = "tboxCompany";
            this.tboxCompany.Size = new System.Drawing.Size(160, 22);
            this.tboxCompany.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 14);
            this.label9.TabIndex = 21;
            this.label9.Text = "公司名称：";
            // 
            // tboxVersion
            // 
            this.tboxVersion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxVersion.Location = new System.Drawing.Point(100, 46);
            this.tboxVersion.Name = "tboxVersion";
            this.tboxVersion.ReadOnly = true;
            this.tboxVersion.Size = new System.Drawing.Size(156, 22);
            this.tboxVersion.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 14);
            this.label10.TabIndex = 23;
            this.label10.Text = "当前版本：";
            // 
            // tboxAutoUpdateURL
            // 
            this.tboxAutoUpdateURL.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxAutoUpdateURL.Location = new System.Drawing.Point(100, 74);
            this.tboxAutoUpdateURL.Name = "tboxAutoUpdateURL";
            this.tboxAutoUpdateURL.Size = new System.Drawing.Size(418, 22);
            this.tboxAutoUpdateURL.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 14);
            this.label11.TabIndex = 25;
            this.label11.Text = "更新地址：";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tboxDMTExePath);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnSetDir);
            this.groupBox1.Controls.Add(this.tboxDMTLoginUser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tboxDMTPsw);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tboxDMTDatabase);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 169);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DMT设置";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tboxAutoUpdateURL);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tboxVersion);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tboxCompany);
            this.groupBox2.Controls.Add(this.cmbBoxPLMConn);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbBoxERPConn);
            this.groupBox2.Controls.Add(this.AutoRunHour);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 186);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "系统设置";
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 432);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelConfig);
            this.Controls.Add(this.btnOkConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            ((System.ComponentModel.ISupportInitialize)(this.AutoRunHour)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOkConfig;
        private System.Windows.Forms.Button btnCancelConfig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxDMTLoginUser;
        private System.Windows.Forms.TextBox tboxDMTPsw;
        private System.Windows.Forms.TextBox tboxDMTDatabase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown AutoRunHour;
        private System.Windows.Forms.ComboBox cmbBoxERPConn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxDMTExePath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSetDir;
        private System.Windows.Forms.ComboBox cmbBoxPLMConn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tboxCompany;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tboxVersion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tboxAutoUpdateURL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}