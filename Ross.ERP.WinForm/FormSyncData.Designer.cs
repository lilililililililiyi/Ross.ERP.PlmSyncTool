namespace Ross.ERP.PlmSyncTool
{
    partial class FormSyncData
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
            this.components = new System.ComponentModel.Container();
            this.progressBarSync = new System.Windows.Forms.ProgressBar();
            this.btnCloseSync = new System.Windows.Forms.Button();
            this.labelSyncStatus = new System.Windows.Forms.Label();
            this.timerSync = new System.Windows.Forms.Timer(this.components);
            this.processSync = new System.Diagnostics.Process();
            this.labelPecent = new System.Windows.Forms.Label();
            this.linkLabel_ImPartErr = new System.Windows.Forms.LinkLabel();
            this.linkLabel_ImBooErr = new System.Windows.Forms.LinkLabel();
            this.linkLabel_ImBomErr = new System.Windows.Forms.LinkLabel();
            this.linkLabel_SyncReport = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // progressBarSync
            // 
            this.progressBarSync.Location = new System.Drawing.Point(12, 63);
            this.progressBarSync.Name = "progressBarSync";
            this.progressBarSync.Size = new System.Drawing.Size(460, 26);
            this.progressBarSync.TabIndex = 0;
            // 
            // btnCloseSync
            // 
            this.btnCloseSync.BackColor = System.Drawing.SystemColors.Control;
            this.btnCloseSync.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCloseSync.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCloseSync.Location = new System.Drawing.Point(397, 154);
            this.btnCloseSync.Name = "btnCloseSync";
            this.btnCloseSync.Size = new System.Drawing.Size(75, 30);
            this.btnCloseSync.TabIndex = 1;
            this.btnCloseSync.Text = "关闭";
            this.btnCloseSync.UseVisualStyleBackColor = false;
            this.btnCloseSync.Click += new System.EventHandler(this.btnCloseSync_Click);
            // 
            // labelSyncStatus
            // 
            this.labelSyncStatus.AutoSize = true;
            this.labelSyncStatus.Location = new System.Drawing.Point(13, 30);
            this.labelSyncStatus.Name = "labelSyncStatus";
            this.labelSyncStatus.Size = new System.Drawing.Size(131, 12);
            this.labelSyncStatus.TabIndex = 2;
            this.labelSyncStatus.Text = "数据同步中，请稍后...";
            // 
            // timerSync
            // 
            this.timerSync.Interval = 1000;
            this.timerSync.Tick += new System.EventHandler(this.timerSync_Tick);
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
            this.processSync.Exited += new System.EventHandler(this.processSync_Exited);
            // 
            // labelPecent
            // 
            this.labelPecent.AutoSize = true;
            this.labelPecent.Location = new System.Drawing.Point(425, 30);
            this.labelPecent.Name = "labelPecent";
            this.labelPecent.Size = new System.Drawing.Size(17, 12);
            this.labelPecent.TabIndex = 3;
            this.labelPecent.Text = "0%";
            // 
            // linkLabel_ImPartErr
            // 
            this.linkLabel_ImPartErr.AutoSize = true;
            this.linkLabel_ImPartErr.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel_ImPartErr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel_ImPartErr.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel_ImPartErr.Location = new System.Drawing.Point(12, 107);
            this.linkLabel_ImPartErr.Name = "linkLabel_ImPartErr";
            this.linkLabel_ImPartErr.Size = new System.Drawing.Size(109, 17);
            this.linkLabel_ImPartErr.TabIndex = 4;
            this.linkLabel_ImPartErr.TabStop = true;
            this.linkLabel_ImPartErr.Text = "Import Part Error";
            this.linkLabel_ImPartErr.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ImPartErr_LinkClicked);
            // 
            // linkLabel_ImBooErr
            // 
            this.linkLabel_ImBooErr.AutoSize = true;
            this.linkLabel_ImBooErr.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel_ImBooErr.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel_ImBooErr.Location = new System.Drawing.Point(159, 107);
            this.linkLabel_ImBooErr.Name = "linkLabel_ImBooErr";
            this.linkLabel_ImBooErr.Size = new System.Drawing.Size(114, 17);
            this.linkLabel_ImBooErr.TabIndex = 5;
            this.linkLabel_ImBooErr.TabStop = true;
            this.linkLabel_ImBooErr.Text = "Import BOO Error";
            this.linkLabel_ImBooErr.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ImBooErr_LinkClicked);
            // 
            // linkLabel_ImBomErr
            // 
            this.linkLabel_ImBomErr.AutoSize = true;
            this.linkLabel_ImBomErr.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel_ImBomErr.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel_ImBomErr.Location = new System.Drawing.Point(12, 133);
            this.linkLabel_ImBomErr.Name = "linkLabel_ImBomErr";
            this.linkLabel_ImBomErr.Size = new System.Drawing.Size(116, 17);
            this.linkLabel_ImBomErr.TabIndex = 6;
            this.linkLabel_ImBomErr.TabStop = true;
            this.linkLabel_ImBomErr.Text = "Import BOM Error";
            this.linkLabel_ImBomErr.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ImBomErr_LinkClicked);
            // 
            // linkLabel_SyncReport
            // 
            this.linkLabel_SyncReport.AutoSize = true;
            this.linkLabel_SyncReport.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel_SyncReport.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel_SyncReport.Location = new System.Drawing.Point(159, 133);
            this.linkLabel_SyncReport.Name = "linkLabel_SyncReport";
            this.linkLabel_SyncReport.Size = new System.Drawing.Size(109, 17);
            this.linkLabel_SyncReport.TabIndex = 7;
            this.linkLabel_SyncReport.TabStop = true;
            this.linkLabel_SyncReport.Text = "Sync Data Report";
            this.linkLabel_SyncReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_SyncReport_LinkClicked);
            // 
            // FormSyncData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 196);
            this.Controls.Add(this.linkLabel_SyncReport);
            this.Controls.Add(this.linkLabel_ImBomErr);
            this.Controls.Add(this.linkLabel_ImBooErr);
            this.Controls.Add(this.linkLabel_ImPartErr);
            this.Controls.Add(this.labelPecent);
            this.Controls.Add(this.labelSyncStatus);
            this.Controls.Add(this.btnCloseSync);
            this.Controls.Add(this.progressBarSync);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSyncData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据同步";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSyncData_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarSync;
        private System.Windows.Forms.Button btnCloseSync;
        private System.Windows.Forms.Label labelSyncStatus;
        private System.Windows.Forms.Timer timerSync;
        private System.Diagnostics.Process processSync;
        private System.Windows.Forms.Label labelPecent;
        private System.Windows.Forms.LinkLabel linkLabel_ImPartErr;
        private System.Windows.Forms.LinkLabel linkLabel_ImBooErr;
        private System.Windows.Forms.LinkLabel linkLabel_ImBomErr;
        private System.Windows.Forms.LinkLabel linkLabel_SyncReport;
    }
}