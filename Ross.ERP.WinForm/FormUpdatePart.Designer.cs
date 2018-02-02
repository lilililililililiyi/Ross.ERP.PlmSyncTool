namespace Ross.ERP.PlmSyncTool
{
    partial class FormUpdatePart
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
            this.rtboxPartNums = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.processSync = new System.Diagnostics.Process();
            this.progressBarSync = new System.Windows.Forms.ProgressBar();
            this.labelSyncStatus = new System.Windows.Forms.Label();
            this.labelPecent = new System.Windows.Forms.Label();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDel = new System.Windows.Forms.ToolStripButton();
            this.toolTboxPartNum = new System.Windows.Forms.ToolStripTextBox();
            this.toolBtnSearch = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtboxPartNums
            // 
            this.rtboxPartNums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtboxPartNums.Font = new System.Drawing.Font("Verdana", 9F);
            this.rtboxPartNums.Location = new System.Drawing.Point(0, 0);
            this.rtboxPartNums.Name = "rtboxPartNums";
            this.rtboxPartNums.Size = new System.Drawing.Size(198, 261);
            this.rtboxPartNums.TabIndex = 0;
            this.rtboxPartNums.Text = "";
            this.rtboxPartNums.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtboxPartNums_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "在下面输入物料编码，多个物料请换行";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUpdate.Location = new System.Drawing.Point(532, 321);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "更新物料";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
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
            // progressBarSync
            // 
            this.progressBarSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBarSync.Location = new System.Drawing.Point(12, 321);
            this.progressBarSync.Name = "progressBarSync";
            this.progressBarSync.Size = new System.Drawing.Size(106, 20);
            this.progressBarSync.TabIndex = 3;
            // 
            // labelSyncStatus
            // 
            this.labelSyncStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSyncStatus.AutoSize = true;
            this.labelSyncStatus.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSyncStatus.Location = new System.Drawing.Point(172, 324);
            this.labelSyncStatus.Name = "labelSyncStatus";
            this.labelSyncStatus.Size = new System.Drawing.Size(31, 14);
            this.labelSyncStatus.TabIndex = 4;
            this.labelSyncStatus.Text = "就绪";
            // 
            // labelPecent
            // 
            this.labelPecent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPecent.AutoSize = true;
            this.labelPecent.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPecent.Location = new System.Drawing.Point(124, 324);
            this.labelPecent.Name = "labelPecent";
            this.labelPecent.Size = new System.Drawing.Size(28, 14);
            this.labelPecent.TabIndex = 5;
            this.labelPecent.Text = "0%";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerMain.Location = new System.Drawing.Point(12, 54);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.rtboxPartNums);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.dgvMain);
            this.splitContainerMain.Size = new System.Drawing.Size(595, 261);
            this.splitContainerMain.SplitterDistance = 198;
            this.splitContainerMain.TabIndex = 6;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(393, 261);
            this.dgvMain.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAdd,
            this.toolBtnDel,
            this.toolTboxPartNum,
            this.toolBtnSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(619, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolBtnAdd
            // 
            this.toolBtnAdd.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.add;
            this.toolBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAdd.Name = "toolBtnAdd";
            this.toolBtnAdd.Size = new System.Drawing.Size(52, 22);
            this.toolBtnAdd.Text = "添加";
            this.toolBtnAdd.Click += new System.EventHandler(this.toolBtnAdd_Click);
            // 
            // toolBtnDel
            // 
            this.toolBtnDel.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.delete;
            this.toolBtnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDel.Name = "toolBtnDel";
            this.toolBtnDel.Size = new System.Drawing.Size(52, 22);
            this.toolBtnDel.Text = "删除";
            this.toolBtnDel.Click += new System.EventHandler(this.toolBtnDel_Click);
            // 
            // toolTboxPartNum
            // 
            this.toolTboxPartNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolTboxPartNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolTboxPartNum.Margin = new System.Windows.Forms.Padding(30, 0, 1, 0);
            this.toolTboxPartNum.Name = "toolTboxPartNum";
            this.toolTboxPartNum.Size = new System.Drawing.Size(100, 25);
            // 
            // toolBtnSearch
            // 
            this.toolBtnSearch.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.search_16_2;
            this.toolBtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSearch.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.toolBtnSearch.Name = "toolBtnSearch";
            this.toolBtnSearch.Size = new System.Drawing.Size(52, 22);
            this.toolBtnSearch.Text = "搜索";
            this.toolBtnSearch.Click += new System.EventHandler(this.toolBtnSearch_Click);
            // 
            // FormUpdatePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 362);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.labelPecent);
            this.Controls.Add(this.labelSyncStatus);
            this.Controls.Add(this.progressBarSync);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdatePart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物料批量更新";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtboxPartNums;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Diagnostics.Process processSync;
        private System.Windows.Forms.ProgressBar progressBarSync;
        private System.Windows.Forms.Label labelSyncStatus;
        private System.Windows.Forms.Label labelPecent;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolBtnDel;
        private System.Windows.Forms.ToolStripButton toolBtnAdd;
        private System.Windows.Forms.ToolStripButton toolBtnSearch;
        private System.Windows.Forms.ToolStripTextBox toolTboxPartNum;
    }
}