namespace Ross.ERP.PlmSyncTool
{
    partial class FormPartRev
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
            this.tboxPartNum = new System.Windows.Forms.TextBox();
            this.cboxPartRev = new System.Windows.Forms.ComboBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonUpt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvMain = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tboxPartNum
            // 
            this.tboxPartNum.Location = new System.Drawing.Point(16, 20);
            this.tboxPartNum.Name = "tboxPartNum";
            this.tboxPartNum.Size = new System.Drawing.Size(100, 21);
            this.tboxPartNum.TabIndex = 0;
            // 
            // cboxPartRev
            // 
            this.cboxPartRev.FormattingEnabled = true;
            this.cboxPartRev.Location = new System.Drawing.Point(123, 20);
            this.cboxPartRev.Name = "cboxPartRev";
            this.cboxPartRev.Size = new System.Drawing.Size(121, 20);
            this.cboxPartRev.TabIndex = 1;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(251, 20);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "查询版本";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonUpt
            // 
            this.buttonUpt.Location = new System.Drawing.Point(333, 20);
            this.buttonUpt.Name = "buttonUpt";
            this.buttonUpt.Size = new System.Drawing.Size(75, 23);
            this.buttonUpt.TabIndex = 3;
            this.buttonUpt.Text = "修复版本";
            this.buttonUpt.UseVisualStyleBackColor = true;
            this.buttonUpt.Click += new System.EventHandler(this.buttonUpt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonUpt);
            this.groupBox1.Controls.Add(this.tboxPartNum);
            this.groupBox1.Controls.Add(this.buttonOK);
            this.groupBox1.Controls.Add(this.cboxPartRev);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 57);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.DgvMain);
            this.groupBox2.Location = new System.Drawing.Point(13, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 274);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "列表";
            // 
            // DgvMain
            // 
            this.DgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvMain.Location = new System.Drawing.Point(3, 17);
            this.DgvMain.Name = "DgvMain";
            this.DgvMain.RowTemplate.Height = 23;
            this.DgvMain.Size = new System.Drawing.Size(553, 254);
            this.DgvMain.TabIndex = 0;
            // 
            // FormPartRev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPartRev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "工程设计";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tboxPartNum;
        private System.Windows.Forms.ComboBox cboxPartRev;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonUpt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvMain;
    }
}