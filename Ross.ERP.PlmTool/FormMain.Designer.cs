namespace Ross.ERP.PlmTool
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.BtnPartCheck = new System.Windows.Forms.Button();
            this.BtnOprCheck = new System.Windows.Forms.Button();
            this.BtnUnableCheck = new System.Windows.Forms.Button();
            this.BtnBOMCheck = new System.Windows.Forms.Button();
            this.groupBoxTools = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PartNum = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DgvMain = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelLoadDatas = new System.Windows.Forms.ToolStripStatusLabel();
            this.tProgBar = new System.Windows.Forms.ToolStripProgressBar();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.toolBtnRefresh = new System.Windows.Forms.ToolStripSplitButton();
            this.groupBoxTools.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMain)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnPartCheck
            // 
            this.BtnPartCheck.Location = new System.Drawing.Point(6, 20);
            this.BtnPartCheck.Name = "BtnPartCheck";
            this.BtnPartCheck.Size = new System.Drawing.Size(124, 40);
            this.BtnPartCheck.TabIndex = 0;
            this.BtnPartCheck.Text = "档案检查";
            this.BtnPartCheck.UseVisualStyleBackColor = true;
            // 
            // BtnOprCheck
            // 
            this.BtnOprCheck.Location = new System.Drawing.Point(141, 20);
            this.BtnOprCheck.Name = "BtnOprCheck";
            this.BtnOprCheck.Size = new System.Drawing.Size(124, 40);
            this.BtnOprCheck.TabIndex = 1;
            this.BtnOprCheck.Text = "工序检查";
            this.BtnOprCheck.UseVisualStyleBackColor = true;
            // 
            // BtnUnableCheck
            // 
            this.BtnUnableCheck.Location = new System.Drawing.Point(6, 66);
            this.BtnUnableCheck.Name = "BtnUnableCheck";
            this.BtnUnableCheck.Size = new System.Drawing.Size(124, 40);
            this.BtnUnableCheck.TabIndex = 2;
            this.BtnUnableCheck.Text = "禁用码检查";
            this.BtnUnableCheck.UseVisualStyleBackColor = true;
            this.BtnUnableCheck.Click += new System.EventHandler(this.BtnUnableCheck_Click);
            // 
            // BtnBOMCheck
            // 
            this.BtnBOMCheck.Location = new System.Drawing.Point(141, 66);
            this.BtnBOMCheck.Name = "BtnBOMCheck";
            this.BtnBOMCheck.Size = new System.Drawing.Size(124, 40);
            this.BtnBOMCheck.TabIndex = 3;
            this.BtnBOMCheck.Text = "BOM检查";
            this.BtnBOMCheck.UseVisualStyleBackColor = true;
            // 
            // groupBoxTools
            // 
            this.groupBoxTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTools.Controls.Add(this.BtnBOMCheck);
            this.groupBoxTools.Controls.Add(this.BtnUnableCheck);
            this.groupBoxTools.Controls.Add(this.BtnOprCheck);
            this.groupBoxTools.Controls.Add(this.BtnPartCheck);
            this.groupBoxTools.Enabled = false;
            this.groupBoxTools.Location = new System.Drawing.Point(6, 61);
            this.groupBoxTools.Name = "groupBoxTools";
            this.groupBoxTools.Size = new System.Drawing.Size(274, 113);
            this.groupBoxTools.TabIndex = 5;
            this.groupBoxTools.TabStop = false;
            this.groupBoxTools.Text = "数据自检";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.DgvMain);
            this.groupBox2.Location = new System.Drawing.Point(6, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 105);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "处理结果";
            // 
            // PartNum
            // 
            this.PartNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PartNum.Location = new System.Drawing.Point(6, 19);
            this.PartNum.Multiline = true;
            this.PartNum.Name = "PartNum";
            this.PartNum.Size = new System.Drawing.Size(258, 21);
            this.PartNum.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.PartNum);
            this.groupBox3.Location = new System.Drawing.Point(7, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 50);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "物料编码";
            // 
            // DgvMain
            // 
            this.DgvMain.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvMain.Location = new System.Drawing.Point(3, 17);
            this.DgvMain.Name = "DgvMain";
            this.DgvMain.RowTemplate.Height = 23;
            this.DgvMain.Size = new System.Drawing.Size(267, 85);
            this.DgvMain.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelLoadDatas,
            this.tProgBar,
            this.toolBtnRefresh});
            this.statusStrip1.Location = new System.Drawing.Point(0, 287);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(289, 23);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelLoadDatas
            // 
            this.labelLoadDatas.Name = "labelLoadDatas";
            this.labelLoadDatas.Size = new System.Drawing.Size(32, 18);
            this.labelLoadDatas.Text = "就绪";
            // 
            // tProgBar
            // 
            this.tProgBar.Name = "tProgBar";
            this.tProgBar.Size = new System.Drawing.Size(100, 17);
            // 
            // timerMain
            // 
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // toolBtnRefresh
            // 
            this.toolBtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnRefresh.Image")));
            this.toolBtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnRefresh.Name = "toolBtnRefresh";
            this.toolBtnRefresh.Size = new System.Drawing.Size(48, 21);
            this.toolBtnRefresh.Text = "刷新";
            this.toolBtnRefresh.ButtonClick += new System.EventHandler(this.toolBtnRefresh_ButtonClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 310);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxTools);
            this.Name = "FormMain";
            this.Text = "PLM数据自检";
            this.groupBoxTools.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMain)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPartCheck;
        private System.Windows.Forms.Button BtnOprCheck;
        private System.Windows.Forms.Button BtnUnableCheck;
        private System.Windows.Forms.Button BtnBOMCheck;
        private System.Windows.Forms.GroupBox groupBoxTools;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox PartNum;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DgvMain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelLoadDatas;
        private System.Windows.Forms.ToolStripProgressBar tProgBar;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.ToolStripSplitButton toolBtnRefresh;
    }
}

