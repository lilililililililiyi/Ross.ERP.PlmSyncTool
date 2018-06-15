namespace Ross.ERP.PlmSyncTool
{
    partial class FormBOMComp
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
            this.BtnOK = new System.Windows.Forms.Button();
            this.tBoxPartNum = new System.Windows.Forms.TextBox();
            this.tBoxJobNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRev = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioJob = new System.Windows.Forms.RadioButton();
            this.radioPLM = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnOK.Location = new System.Drawing.Point(5, 7);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(76, 125);
            this.BtnOK.TabIndex = 0;
            this.BtnOK.Text = "开始对比";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // tBoxPartNum
            // 
            this.tBoxPartNum.Location = new System.Drawing.Point(78, 86);
            this.tBoxPartNum.Name = "tBoxPartNum";
            this.tBoxPartNum.Size = new System.Drawing.Size(100, 21);
            this.tBoxPartNum.TabIndex = 1;
            // 
            // tBoxJobNum
            // 
            this.tBoxJobNum.Location = new System.Drawing.Point(78, 111);
            this.tBoxJobNum.Name = "tBoxJobNum";
            this.tBoxJobNum.Size = new System.Drawing.Size(100, 21);
            this.tBoxJobNum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "物料编码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(25, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "工单号";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxRev);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.tBoxJobNum);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.tBoxPartNum);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BtnOK);
            this.splitContainer1.Size = new System.Drawing.Size(284, 141);
            this.splitContainer1.SplitterDistance = 192;
            this.splitContainer1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(25, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "版本号";
            // 
            // textBoxRev
            // 
            this.textBoxRev.Location = new System.Drawing.Point(78, 60);
            this.textBoxRev.Name = "textBoxRev";
            this.textBoxRev.Size = new System.Drawing.Size(100, 21);
            this.textBoxRev.TabIndex = 8;
            this.textBoxRev.Text = "A";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioJob);
            this.groupBox1.Controls.Add(this.radioPLM);
            this.groupBox1.Location = new System.Drawing.Point(8, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 47);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "对比选项";
            // 
            // radioJob
            // 
            this.radioJob.AutoSize = true;
            this.radioJob.Checked = true;
            this.radioJob.Location = new System.Drawing.Point(9, 21);
            this.radioJob.Name = "radioJob";
            this.radioJob.Size = new System.Drawing.Size(71, 16);
            this.radioJob.TabIndex = 5;
            this.radioJob.TabStop = true;
            this.radioJob.Text = "对比工单";
            this.radioJob.UseVisualStyleBackColor = true;
            this.radioJob.CheckedChanged += new System.EventHandler(this.radioJob_CheckedChanged);
            // 
            // radioPLM
            // 
            this.radioPLM.AutoSize = true;
            this.radioPLM.Location = new System.Drawing.Point(86, 21);
            this.radioPLM.Name = "radioPLM";
            this.radioPLM.Size = new System.Drawing.Size(65, 16);
            this.radioPLM.TabIndex = 6;
            this.radioPLM.Text = "对比PLM";
            this.radioPLM.UseVisualStyleBackColor = true;
            this.radioPLM.CheckedChanged += new System.EventHandler(this.radioPLM_CheckedChanged);
            // 
            // FormBOMComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBOMComp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BOM对比";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.TextBox tBoxPartNum;
        private System.Windows.Forms.TextBox tBoxJobNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton radioPLM;
        private System.Windows.Forms.RadioButton radioJob;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRev;
    }
}