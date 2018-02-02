namespace Ross.ERP.PlmSyncTool
{
    partial class FormModPsw
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
            this.buttonok = new System.Windows.Forms.Button();
            this.textBoxOldPsw = new System.Windows.Forms.TextBox();
            this.textBoxNewPsw = new System.Windows.Forms.TextBox();
            this.textBoxNewPsw2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonok
            // 
            this.buttonok.Location = new System.Drawing.Point(197, 127);
            this.buttonok.Name = "buttonok";
            this.buttonok.Size = new System.Drawing.Size(75, 23);
            this.buttonok.TabIndex = 0;
            this.buttonok.Text = "确定";
            this.buttonok.UseVisualStyleBackColor = true;
            this.buttonok.Click += new System.EventHandler(this.buttonok_Click);
            // 
            // textBoxOldPsw
            // 
            this.textBoxOldPsw.Location = new System.Drawing.Point(80, 29);
            this.textBoxOldPsw.Name = "textBoxOldPsw";
            this.textBoxOldPsw.Size = new System.Drawing.Size(120, 21);
            this.textBoxOldPsw.TabIndex = 1;
            this.textBoxOldPsw.UseSystemPasswordChar = true;
            // 
            // textBoxNewPsw
            // 
            this.textBoxNewPsw.Location = new System.Drawing.Point(80, 56);
            this.textBoxNewPsw.Name = "textBoxNewPsw";
            this.textBoxNewPsw.Size = new System.Drawing.Size(120, 21);
            this.textBoxNewPsw.TabIndex = 2;
            this.textBoxNewPsw.UseSystemPasswordChar = true;
            // 
            // textBoxNewPsw2
            // 
            this.textBoxNewPsw2.Location = new System.Drawing.Point(80, 83);
            this.textBoxNewPsw2.Name = "textBoxNewPsw2";
            this.textBoxNewPsw2.Size = new System.Drawing.Size(120, 21);
            this.textBoxNewPsw2.TabIndex = 3;
            this.textBoxNewPsw2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "旧密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "新密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "确认密码";
            // 
            // FormModPsw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNewPsw2);
            this.Controls.Add(this.textBoxNewPsw);
            this.Controls.Add(this.textBoxOldPsw);
            this.Controls.Add(this.buttonok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormModPsw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "密码修改";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonok;
        private System.Windows.Forms.TextBox textBoxOldPsw;
        private System.Windows.Forms.TextBox textBoxNewPsw;
        private System.Windows.Forms.TextBox textBoxNewPsw2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}