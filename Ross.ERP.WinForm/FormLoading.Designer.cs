namespace Ross.ERP.PlmSyncTool
{
    partial class FormLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoading));
            this.progressBarLoad = new System.Windows.Forms.ProgressBar();
            this.processLoad = new System.Diagnostics.Process();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBarLoad
            // 
            this.progressBarLoad.Location = new System.Drawing.Point(8, 35);
            this.progressBarLoad.Name = "progressBarLoad";
            this.progressBarLoad.Size = new System.Drawing.Size(284, 23);
            this.progressBarLoad.TabIndex = 0;
            // 
            // processLoad
            // 
            this.processLoad.StartInfo.Domain = "";
            this.processLoad.StartInfo.LoadUserProfile = false;
            this.processLoad.StartInfo.Password = null;
            this.processLoad.StartInfo.StandardErrorEncoding = null;
            this.processLoad.StartInfo.StandardOutputEncoding = null;
            this.processLoad.StartInfo.UserName = "";
            this.processLoad.SynchronizingObject = this;
            // 
            // timerLoad
            // 
            this.timerLoad.Enabled = true;
            this.timerLoad.Interval = 1000;
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelStatus.Location = new System.Drawing.Point(12, 9);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(101, 17);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "基础数据加载中...";
            // 
            // FormLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(304, 70);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.progressBarLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "基础数据加载中......";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLoading_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLoading_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormLoading_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormLoading_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarLoad;
        private System.Diagnostics.Process processLoad;
        private System.Windows.Forms.Timer timerLoad;
        private System.Windows.Forms.Label labelStatus;
    }
}