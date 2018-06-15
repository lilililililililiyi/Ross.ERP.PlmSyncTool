namespace Ross.ERP.PlmSyncTool
{
    partial class FormMTLCompute
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
            this.tBoxPartNum = new System.Windows.Forms.TextBox();
            this.tBoxLength = new System.Windows.Forms.TextBox();
            this.tBoxWidth = new System.Windows.Forms.TextBox();
            this.tBoxThickness = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.tBoxFormula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBoxPartNum
            // 
            this.tBoxPartNum.Location = new System.Drawing.Point(87, 10);
            this.tBoxPartNum.Name = "tBoxPartNum";
            this.tBoxPartNum.Size = new System.Drawing.Size(154, 21);
            this.tBoxPartNum.TabIndex = 0;
            this.tBoxPartNum.Leave += new System.EventHandler(this.tBoxPartNum_Leave);
            // 
            // tBoxLength
            // 
            this.tBoxLength.Location = new System.Drawing.Point(87, 70);
            this.tBoxLength.Name = "tBoxLength";
            this.tBoxLength.Size = new System.Drawing.Size(100, 21);
            this.tBoxLength.TabIndex = 2;
            // 
            // tBoxWidth
            // 
            this.tBoxWidth.Location = new System.Drawing.Point(87, 97);
            this.tBoxWidth.Name = "tBoxWidth";
            this.tBoxWidth.Size = new System.Drawing.Size(100, 21);
            this.tBoxWidth.TabIndex = 3;
            // 
            // tBoxThickness
            // 
            this.tBoxThickness.Location = new System.Drawing.Point(87, 124);
            this.tBoxThickness.Name = "tBoxThickness";
            this.tBoxThickness.Size = new System.Drawing.Size(100, 21);
            this.tBoxThickness.TabIndex = 4;
            // 
            // BtnOK
            // 
            this.BtnOK.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnOK.Location = new System.Drawing.Point(6, 196);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(266, 54);
            this.BtnOK.TabIndex = 6;
            this.BtnOK.Text = "计     算";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "材料编码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "长度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "宽度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "厚度";
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(87, 151);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(100, 39);
            this.richTextBoxResult.TabIndex = 11;
            this.richTextBoxResult.Text = "";
            // 
            // tBoxFormula
            // 
            this.tBoxFormula.Location = new System.Drawing.Point(87, 38);
            this.tBoxFormula.Name = "tBoxFormula";
            this.tBoxFormula.ReadOnly = true;
            this.tBoxFormula.Size = new System.Drawing.Size(154, 21);
            this.tBoxFormula.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "计算公式";
            // 
            // FormMTLCompute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBoxFormula);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.tBoxThickness);
            this.Controls.Add(this.tBoxWidth);
            this.Controls.Add(this.tBoxLength);
            this.Controls.Add(this.tBoxPartNum);
            this.Name = "FormMTLCompute";
            this.Text = "材料定额计算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxPartNum;
        private System.Windows.Forms.TextBox tBoxLength;
        private System.Windows.Forms.TextBox tBoxWidth;
        private System.Windows.Forms.TextBox tBoxThickness;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.TextBox tBoxFormula;
        private System.Windows.Forms.Label label5;
    }
}