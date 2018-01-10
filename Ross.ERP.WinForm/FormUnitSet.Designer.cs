namespace Ross.ERP.PlmSyncTool
{
    partial class FormUnitSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUnitSet));
            this.dataGridViewUnit = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_AddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Del = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnit)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUnit
            // 
            this.dataGridViewUnit.AllowUserToOrderColumns = true;
            this.dataGridViewUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUnit.Location = new System.Drawing.Point(0, 25);
            this.dataGridViewUnit.Name = "dataGridViewUnit";
            this.dataGridViewUnit.RowTemplate.Height = 23;
            this.dataGridViewUnit.Size = new System.Drawing.Size(384, 237);
            this.dataGridViewUnit.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Save,
            this.ToolStripMenuItem_AddNew,
            this.ToolStripMenuItem_Del});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_Save
            // 
            this.ToolStripMenuItem_Save.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.save;
            this.ToolStripMenuItem_Save.Name = "ToolStripMenuItem_Save";
            this.ToolStripMenuItem_Save.Size = new System.Drawing.Size(60, 21);
            this.ToolStripMenuItem_Save.Text = "保存";
            this.ToolStripMenuItem_Save.Click += new System.EventHandler(this.ToolStripMenuItem_Save_Click);
            // 
            // ToolStripMenuItem_AddNew
            // 
            this.ToolStripMenuItem_AddNew.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.add;
            this.ToolStripMenuItem_AddNew.Name = "ToolStripMenuItem_AddNew";
            this.ToolStripMenuItem_AddNew.Size = new System.Drawing.Size(60, 21);
            this.ToolStripMenuItem_AddNew.Text = "新增";
            this.ToolStripMenuItem_AddNew.Click += new System.EventHandler(this.ToolStripMenuItem_AddNew_Click);
            // 
            // ToolStripMenuItem_Del
            // 
            this.ToolStripMenuItem_Del.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.delete;
            this.ToolStripMenuItem_Del.Name = "ToolStripMenuItem_Del";
            this.ToolStripMenuItem_Del.Size = new System.Drawing.Size(60, 21);
            this.ToolStripMenuItem_Del.Text = "删除";
            this.ToolStripMenuItem_Del.Click += new System.EventHandler(this.ToolStripMenuItem_Del_Click);
            // 
            // FormUnitSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.dataGridViewUnit);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormUnitSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "单位设置";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnit)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUnit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Save;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_AddNew;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Del;
    }
}