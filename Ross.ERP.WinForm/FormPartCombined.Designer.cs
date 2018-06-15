namespace Ross.ERP.PlmSyncTool
{
    partial class FormPartCombined
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonGetBOM = new System.Windows.Forms.Button();
            this.buttonGetBOO = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtPickerPartEff = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxPartNums = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPartRev = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.contextMenuStripGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_ExportPart = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ExBOO = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ExBOM = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonStartSync = new System.Windows.Forms.Button();
            this.processSync = new System.Diagnostics.Process();
            this.labelSyncStatus = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewBOO = new System.Windows.Forms.DataGridView();
            this.dataGridViewBOM = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.contextMenuStripGrid.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBOO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBOM)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelSyncStatus);
            this.splitContainer1.Panel1.Controls.Add(this.buttonStartSync);
            this.splitContainer1.Panel1.Controls.Add(this.buttonGetBOM);
            this.splitContainer1.Panel1.Controls.Add(this.buttonGetBOO);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonOk);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(984, 562);
            this.splitContainer1.SplitterDistance = 184;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonGetBOM
            // 
            this.buttonGetBOM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetBOM.Location = new System.Drawing.Point(12, 470);
            this.buttonGetBOM.Name = "buttonGetBOM";
            this.buttonGetBOM.Size = new System.Drawing.Size(162, 28);
            this.buttonGetBOM.TabIndex = 8;
            this.buttonGetBOM.Text = "获取BOM";
            this.buttonGetBOM.UseVisualStyleBackColor = true;
            this.buttonGetBOM.Click += new System.EventHandler(this.buttonGetBOM_Click);
            // 
            // buttonGetBOO
            // 
            this.buttonGetBOO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetBOO.Location = new System.Drawing.Point(12, 436);
            this.buttonGetBOO.Name = "buttonGetBOO";
            this.buttonGetBOO.Size = new System.Drawing.Size(162, 28);
            this.buttonGetBOO.TabIndex = 7;
            this.buttonGetBOO.Text = "获取BOO";
            this.buttonGetBOO.UseVisualStyleBackColor = true;
            this.buttonGetBOO.Click += new System.EventHandler(this.buttonGetBOO_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dtPickerPartEff);
            this.groupBox3.Location = new System.Drawing.Point(12, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(162, 52);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "生效日期";
            // 
            // dtPickerPartEff
            // 
            this.dtPickerPartEff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPickerPartEff.Location = new System.Drawing.Point(7, 20);
            this.dtPickerPartEff.Name = "dtPickerPartEff";
            this.dtPickerPartEff.Size = new System.Drawing.Size(149, 21);
            this.dtPickerPartEff.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBoxPartNums);
            this.groupBox2.Location = new System.Drawing.Point(13, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 256);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "物料编码";
            // 
            // textBoxPartNums
            // 
            this.textBoxPartNums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPartNums.Location = new System.Drawing.Point(6, 20);
            this.textBoxPartNums.Multiline = true;
            this.textBoxPartNums.Name = "textBoxPartNums";
            this.textBoxPartNums.Size = new System.Drawing.Size(149, 230);
            this.textBoxPartNums.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBoxPartRev);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 51);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "版本号";
            // 
            // textBoxPartRev
            // 
            this.textBoxPartRev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPartRev.Location = new System.Drawing.Point(6, 20);
            this.textBoxPartRev.Name = "textBoxPartRev";
            this.textBoxPartRev.Size = new System.Drawing.Size(150, 21);
            this.textBoxPartRev.TabIndex = 3;
            this.textBoxPartRev.Text = "A";
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(12, 402);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(162, 28);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "获取物料档案";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMain.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowTemplate.Height = 23;
            this.dataGridViewMain.Size = new System.Drawing.Size(779, 524);
            this.dataGridViewMain.TabIndex = 0;
            this.dataGridViewMain.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMain_CellMouseDown);
            // 
            // contextMenuStripGrid
            // 
            this.contextMenuStripGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_ExportPart,
            this.ToolStripMenuItem_ExBOO,
            this.ToolStripMenuItem_ExBOM});
            this.contextMenuStripGrid.Name = "contextMenuStripGrid";
            this.contextMenuStripGrid.Size = new System.Drawing.Size(149, 70);
            // 
            // ToolStripMenuItem_ExportPart
            // 
            this.ToolStripMenuItem_ExportPart.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.excel;
            this.ToolStripMenuItem_ExportPart.Name = "ToolStripMenuItem_ExportPart";
            this.ToolStripMenuItem_ExportPart.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItem_ExportPart.Text = "导出物料档案";
            this.ToolStripMenuItem_ExportPart.Click += new System.EventHandler(this.ToolStripMenuItem_ExportPart_Click);
            // 
            // ToolStripMenuItem_ExBOO
            // 
            this.ToolStripMenuItem_ExBOO.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.excel;
            this.ToolStripMenuItem_ExBOO.Name = "ToolStripMenuItem_ExBOO";
            this.ToolStripMenuItem_ExBOO.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItem_ExBOO.Text = "导出BOO";
            this.ToolStripMenuItem_ExBOO.Click += new System.EventHandler(this.ToolStripMenuItem_ExBOO_Click);
            // 
            // ToolStripMenuItem_ExBOM
            // 
            this.ToolStripMenuItem_ExBOM.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.excel;
            this.ToolStripMenuItem_ExBOM.Name = "ToolStripMenuItem_ExBOM";
            this.ToolStripMenuItem_ExBOM.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItem_ExBOM.Text = "导出BOM";
            this.ToolStripMenuItem_ExBOM.Click += new System.EventHandler(this.ToolStripMenuItem_ExBOM_Click);
            // 
            // buttonStartSync
            // 
            this.buttonStartSync.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartSync.Location = new System.Drawing.Point(12, 504);
            this.buttonStartSync.Name = "buttonStartSync";
            this.buttonStartSync.Size = new System.Drawing.Size(162, 28);
            this.buttonStartSync.TabIndex = 9;
            this.buttonStartSync.Text = "开始同步";
            this.buttonStartSync.UseVisualStyleBackColor = true;
            this.buttonStartSync.Click += new System.EventHandler(this.buttonStartSync_Click);
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
            // labelSyncStatus
            // 
            this.labelSyncStatus.AutoSize = true;
            this.labelSyncStatus.Location = new System.Drawing.Point(17, 541);
            this.labelSyncStatus.Name = "labelSyncStatus";
            this.labelSyncStatus.Size = new System.Drawing.Size(47, 12);
            this.labelSyncStatus.TabIndex = 10;
            this.labelSyncStatus.Text = "就绪...";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 556);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "物料";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewBOO);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(785, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BOO";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewBOM);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(785, 530);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "BOM";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBOO
            // 
            this.dataGridViewBOO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBOO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBOO.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewBOO.Name = "dataGridViewBOO";
            this.dataGridViewBOO.RowTemplate.Height = 23;
            this.dataGridViewBOO.Size = new System.Drawing.Size(779, 524);
            this.dataGridViewBOO.TabIndex = 0;
            this.dataGridViewBOO.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewBOO_CellMouseDown);
            // 
            // dataGridViewBOM
            // 
            this.dataGridViewBOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBOM.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewBOM.Name = "dataGridViewBOM";
            this.dataGridViewBOM.RowTemplate.Height = 23;
            this.dataGridViewBOM.Size = new System.Drawing.Size(779, 524);
            this.dataGridViewBOM.TabIndex = 0;
            this.dataGridViewBOM.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewBOM_CellMouseDown);
            // 
            // FormPartCombined
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormPartCombined";
            this.Text = "FormPartCombined";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.contextMenuStripGrid.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBOO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBOM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxPartNums;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPartRev;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtPickerPartEff;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGrid;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ExportPart;
        private System.Windows.Forms.Button buttonGetBOO;
        private System.Windows.Forms.Button buttonGetBOM;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ExBOO;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ExBOM;
        private System.Windows.Forms.Button buttonStartSync;
        private System.Diagnostics.Process processSync;
        private System.Windows.Forms.Label labelSyncStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewBOO;
        private System.Windows.Forms.DataGridView dataGridViewBOM;
    }
}