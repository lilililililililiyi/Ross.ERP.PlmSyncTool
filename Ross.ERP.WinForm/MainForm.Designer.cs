namespace Ross.ERP.PlmSyncTool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.splitCont = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControlLeft = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.treeViewLeft = new System.Windows.Forms.TreeView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.treeViewLeftBot = new System.Windows.Forms.TreeView();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGVBOM = new System.Windows.Forms.DataGridView();
            this.toolStripTop = new System.Windows.Forms.ToolStrip();
            this.DropDownButtonFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuExist = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuModPsw = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDropBtnPlm = new System.Windows.Forms.ToolStripDropDownButton();
            this.BtnGetNewBOM = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnGetNewBOO = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnGetNewMTL = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ChkBOM = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_UpdateParts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDropbtnErp = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem_GetERPBOM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDropBtnPartOpr = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Jobs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDropBtnPartMtl = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDropBtnPart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDropExport = new System.Windows.Forms.ToolStripDropDownButton();
            this.BtnExport_NewPart = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnExport_NewBom = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ResetCache = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBtnReport = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem_MtlAna = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBtnStart = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem_Start = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Stop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDropSetting = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem_Unit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Sys = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_OpenLog = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ClearLog = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_SyncLog = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPowers = new System.Windows.Forms.ToolStripMenuItem();
            this.tboxPartNum = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStripBot = new System.Windows.Forms.StatusStrip();
            this.StatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBarBot = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusLabelCompany = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.SLabelErpDbName = new System.Windows.Forms.ToolStripStatusLabel();
            this.SLabelPlmDbName = new System.Windows.Forms.ToolStripStatusLabel();
            this.SLabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAutoUpdate = new System.Windows.Forms.Label();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.BtnImportNewBOM = new System.Windows.Forms.Button();
            this.BtnGetNewPartMtl = new System.Windows.Forms.Button();
            this.timerOpr = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_CopyToExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Bom = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ERPBOM = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ClearResult = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_ExBom = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ExWGJ = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ExZZJ = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ToFactBOM = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ClearTree = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerProg = new System.Windows.Forms.Timer(this.components);
            this.timerAutoSync = new System.Windows.Forms.Timer(this.components);
            this.timerAutoCache = new System.Windows.Forms.Timer(this.components);
            this.ToolStripMenuItem_PartPlan = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitCont)).BeginInit();
            this.splitCont.Panel1.SuspendLayout();
            this.splitCont.Panel2.SuspendLayout();
            this.splitCont.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControlLeft.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBOM)).BeginInit();
            this.toolStripTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStripBot.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contextMenuStripMain.SuspendLayout();
            this.contextMenuStripTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.AllowUserToOrderColumns = true;
            this.dataGridViewMain.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMain.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.RowTemplate.Height = 23;
            this.dataGridViewMain.Size = new System.Drawing.Size(556, 345);
            this.dataGridViewMain.TabIndex = 0;
            this.dataGridViewMain.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMain_CellMouseDoubleClick);
            this.dataGridViewMain.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMain_CellMouseDown);
            // 
            // splitCont
            // 
            this.splitCont.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitCont.BackColor = System.Drawing.SystemColors.Control;
            this.splitCont.Location = new System.Drawing.Point(3, 61);
            this.splitCont.Name = "splitCont";
            // 
            // splitCont.Panel1
            // 
            this.splitCont.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitCont.Panel1.Controls.Add(this.panel2);
            // 
            // splitCont.Panel2
            // 
            this.splitCont.Panel2.Controls.Add(this.tabControlMain);
            this.splitCont.Size = new System.Drawing.Size(778, 377);
            this.splitCont.SplitterDistance = 205;
            this.splitCont.SplitterWidth = 3;
            this.splitCont.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.tabControlLeft);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 377);
            this.panel2.TabIndex = 0;
            // 
            // tabControlLeft
            // 
            this.tabControlLeft.Controls.Add(this.tabPage3);
            this.tabControlLeft.Controls.Add(this.tabPage4);
            this.tabControlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlLeft.Font = new System.Drawing.Font("Verdana", 8F);
            this.tabControlLeft.Location = new System.Drawing.Point(0, 0);
            this.tabControlLeft.Multiline = true;
            this.tabControlLeft.Name = "tabControlLeft";
            this.tabControlLeft.SelectedIndex = 0;
            this.tabControlLeft.Size = new System.Drawing.Size(205, 377);
            this.tabControlLeft.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.treeViewLeft);
            this.tabPage3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(197, 351);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "设计BOM";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // treeViewLeft
            // 
            this.treeViewLeft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewLeft.Font = new System.Drawing.Font("宋体", 9F);
            this.treeViewLeft.Location = new System.Drawing.Point(3, 3);
            this.treeViewLeft.Name = "treeViewLeft";
            this.treeViewLeft.Size = new System.Drawing.Size(191, 345);
            this.treeViewLeft.TabIndex = 0;
            this.treeViewLeft.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewLeft_NodeMouseClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.treeViewLeftBot);
            this.tabPage4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(197, 351);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "制造BOM";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // treeViewLeftBot
            // 
            this.treeViewLeftBot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewLeftBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewLeftBot.Font = new System.Drawing.Font("宋体", 9F);
            this.treeViewLeftBot.Location = new System.Drawing.Point(3, 3);
            this.treeViewLeftBot.Name = "treeViewLeftBot";
            this.treeViewLeftBot.Size = new System.Drawing.Size(191, 345);
            this.treeViewLeftBot.TabIndex = 0;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Verdana", 8F);
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(570, 377);
            this.tabControlMain.TabIndex = 1;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(562, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "数据列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGVBOM);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(562, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "新BOM";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGVBOM
            // 
            this.DGVBOM.AllowUserToAddRows = false;
            this.DGVBOM.AllowUserToDeleteRows = false;
            this.DGVBOM.AllowUserToOrderColumns = true;
            this.DGVBOM.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVBOM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVBOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVBOM.Location = new System.Drawing.Point(3, 3);
            this.DGVBOM.Name = "DGVBOM";
            this.DGVBOM.ReadOnly = true;
            this.DGVBOM.RowTemplate.Height = 23;
            this.DGVBOM.Size = new System.Drawing.Size(556, 345);
            this.DGVBOM.TabIndex = 0;
            this.DGVBOM.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVBOM_CellMouseDoubleClick);
            this.DGVBOM.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVBOM_CellMouseDown);
            // 
            // toolStripTop
            // 
            this.toolStripTop.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DropDownButtonFile,
            this.toolDropBtnPlm,
            this.toolDropbtnErp,
            this.toolDropExport,
            this.toolBtnReport,
            this.toolBtnStart,
            this.toolDropSetting});
            this.toolStripTop.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop.Name = "toolStripTop";
            this.toolStripTop.Size = new System.Drawing.Size(784, 25);
            this.toolStripTop.TabIndex = 4;
            this.toolStripTop.Text = "toolStrip1";
            // 
            // DropDownButtonFile
            // 
            this.DropDownButtonFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DropDownButtonFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuExist,
            this.ToolStripMenuModPsw});
            this.DropDownButtonFile.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.Folder;
            this.DropDownButtonFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DropDownButtonFile.Name = "DropDownButtonFile";
            this.DropDownButtonFile.Size = new System.Drawing.Size(45, 22);
            this.DropDownButtonFile.Text = "用户";
            // 
            // ToolStripMenuExist
            // 
            this.ToolStripMenuExist.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.quit;
            this.ToolStripMenuExist.Name = "ToolStripMenuExist";
            this.ToolStripMenuExist.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuExist.Text = "退出";
            this.ToolStripMenuExist.Click += new System.EventHandler(this.ToolStripMenuExist_Click);
            // 
            // ToolStripMenuModPsw
            // 
            this.ToolStripMenuModPsw.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.password;
            this.ToolStripMenuModPsw.Name = "ToolStripMenuModPsw";
            this.ToolStripMenuModPsw.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuModPsw.Text = "修改密码";
            this.ToolStripMenuModPsw.Click += new System.EventHandler(this.ToolStripMenuModPsw_Click);
            // 
            // toolDropBtnPlm
            // 
            this.toolDropBtnPlm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolDropBtnPlm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnGetNewBOM,
            this.BtnGetNewBOO,
            this.BtnGetNewMTL,
            this.ToolStripMenuItem_ChkBOM,
            this.ToolStripMenuItem_UpdateParts});
            this.toolDropBtnPlm.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.PLM;
            this.toolDropBtnPlm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDropBtnPlm.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.toolDropBtnPlm.Name = "toolDropBtnPlm";
            this.toolDropBtnPlm.Size = new System.Drawing.Size(46, 22);
            this.toolDropBtnPlm.Text = "PLM";
            // 
            // BtnGetNewBOM
            // 
            this.BtnGetNewBOM.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.tree;
            this.BtnGetNewBOM.Name = "BtnGetNewBOM";
            this.BtnGetNewBOM.Size = new System.Drawing.Size(154, 22);
            this.BtnGetNewBOM.Text = "获取BOM";
            this.BtnGetNewBOM.Click += new System.EventHandler(this.toolDropGetNewBOM_Click);
            // 
            // BtnGetNewBOO
            // 
            this.BtnGetNewBOO.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.flow;
            this.BtnGetNewBOO.Name = "BtnGetNewBOO";
            this.BtnGetNewBOO.Size = new System.Drawing.Size(154, 22);
            this.BtnGetNewBOO.Text = "获取BOO";
            this.BtnGetNewBOO.Click += new System.EventHandler(this.BtnGetNewBOO_Click);
            // 
            // BtnGetNewMTL
            // 
            this.BtnGetNewMTL.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.File;
            this.BtnGetNewMTL.Name = "BtnGetNewMTL";
            this.BtnGetNewMTL.Size = new System.Drawing.Size(154, 22);
            this.BtnGetNewMTL.Text = "获取新物料";
            this.BtnGetNewMTL.Click += new System.EventHandler(this.BtnGetNewMTL_Click);
            // 
            // ToolStripMenuItem_ChkBOM
            // 
            this.ToolStripMenuItem_ChkBOM.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.File;
            this.ToolStripMenuItem_ChkBOM.Name = "ToolStripMenuItem_ChkBOM";
            this.ToolStripMenuItem_ChkBOM.Size = new System.Drawing.Size(154, 22);
            this.ToolStripMenuItem_ChkBOM.Text = "检测BOM更新";
            this.ToolStripMenuItem_ChkBOM.Click += new System.EventHandler(this.ToolStripMenuItem_ChkBOM_Click);
            // 
            // ToolStripMenuItem_UpdateParts
            // 
            this.ToolStripMenuItem_UpdateParts.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.refresh;
            this.ToolStripMenuItem_UpdateParts.Name = "ToolStripMenuItem_UpdateParts";
            this.ToolStripMenuItem_UpdateParts.Size = new System.Drawing.Size(154, 22);
            this.ToolStripMenuItem_UpdateParts.Text = "批量更新物料";
            this.ToolStripMenuItem_UpdateParts.Click += new System.EventHandler(this.ToolStripMenuItem_UpdateParts_Click);
            // 
            // toolDropbtnErp
            // 
            this.toolDropbtnErp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolDropbtnErp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_GetERPBOM,
            this.toolDropBtnPartOpr,
            this.ToolStripMenuItem_Jobs,
            this.toolDropBtnPartMtl,
            this.toolDropBtnPart});
            this.toolDropbtnErp.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.model;
            this.toolDropbtnErp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDropbtnErp.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.toolDropbtnErp.Name = "toolDropbtnErp";
            this.toolDropbtnErp.Size = new System.Drawing.Size(43, 22);
            this.toolDropbtnErp.Text = "ERP";
            // 
            // ToolStripMenuItem_GetERPBOM
            // 
            this.ToolStripMenuItem_GetERPBOM.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.tree;
            this.ToolStripMenuItem_GetERPBOM.Name = "ToolStripMenuItem_GetERPBOM";
            this.ToolStripMenuItem_GetERPBOM.Size = new System.Drawing.Size(130, 22);
            this.ToolStripMenuItem_GetERPBOM.Text = "获取BOM";
            this.ToolStripMenuItem_GetERPBOM.Click += new System.EventHandler(this.ToolStripMenuItem_GetERPBOM_Click);
            // 
            // toolDropBtnPartOpr
            // 
            this.toolDropBtnPartOpr.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.flow;
            this.toolDropBtnPartOpr.Name = "toolDropBtnPartOpr";
            this.toolDropBtnPartOpr.Size = new System.Drawing.Size(130, 22);
            this.toolDropBtnPartOpr.Text = "获取BOO";
            this.toolDropBtnPartOpr.Click += new System.EventHandler(this.toolDropBtnPartOpr_Click);
            // 
            // ToolStripMenuItem_Jobs
            // 
            this.ToolStripMenuItem_Jobs.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.File;
            this.ToolStripMenuItem_Jobs.Name = "ToolStripMenuItem_Jobs";
            this.ToolStripMenuItem_Jobs.Size = new System.Drawing.Size(130, 22);
            this.ToolStripMenuItem_Jobs.Text = "所有工单";
            this.ToolStripMenuItem_Jobs.Click += new System.EventHandler(this.ToolStripMenuItem_Jobs_Click);
            // 
            // toolDropBtnPartMtl
            // 
            this.toolDropBtnPartMtl.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.File;
            this.toolDropBtnPartMtl.Name = "toolDropBtnPartMtl";
            this.toolDropBtnPartMtl.Size = new System.Drawing.Size(130, 22);
            this.toolDropBtnPartMtl.Text = "BOM物料";
            this.toolDropBtnPartMtl.Click += new System.EventHandler(this.toolDropBtnPartMtl_Click);
            // 
            // toolDropBtnPart
            // 
            this.toolDropBtnPart.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.File;
            this.toolDropBtnPart.Name = "toolDropBtnPart";
            this.toolDropBtnPart.Size = new System.Drawing.Size(130, 22);
            this.toolDropBtnPart.Text = "物料档案";
            this.toolDropBtnPart.Click += new System.EventHandler(this.toolDropBtnPart_Click);
            // 
            // toolDropExport
            // 
            this.toolDropExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolDropExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnExport_NewPart,
            this.BtnExport_NewBom,
            this.ToolStripMenuItem_ResetCache});
            this.toolDropExport.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.operate;
            this.toolDropExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDropExport.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.toolDropExport.Name = "toolDropExport";
            this.toolDropExport.Size = new System.Drawing.Size(45, 22);
            this.toolDropExport.Text = "操作";
            // 
            // BtnExport_NewPart
            // 
            this.BtnExport_NewPart.Enabled = false;
            this.BtnExport_NewPart.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.excel;
            this.BtnExport_NewPart.Name = "BtnExport_NewPart";
            this.BtnExport_NewPart.Size = new System.Drawing.Size(148, 22);
            this.BtnExport_NewPart.Text = "导出新物料";
            this.BtnExport_NewPart.Click += new System.EventHandler(this.BtnExport_NewPart_Click);
            // 
            // BtnExport_NewBom
            // 
            this.BtnExport_NewBom.Enabled = false;
            this.BtnExport_NewBom.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.excel;
            this.BtnExport_NewBom.Name = "BtnExport_NewBom";
            this.BtnExport_NewBom.Size = new System.Drawing.Size(148, 22);
            this.BtnExport_NewBom.Text = "导出新BOM";
            this.BtnExport_NewBom.Click += new System.EventHandler(this.BtnExport_NewBom_Click);
            // 
            // ToolStripMenuItem_ResetCache
            // 
            this.ToolStripMenuItem_ResetCache.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.refresh;
            this.ToolStripMenuItem_ResetCache.Name = "ToolStripMenuItem_ResetCache";
            this.ToolStripMenuItem_ResetCache.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItem_ResetCache.Text = "重置本地缓存";
            this.ToolStripMenuItem_ResetCache.Click += new System.EventHandler(this.ToolStripMenuItem_ResetCache_Click);
            // 
            // toolBtnReport
            // 
            this.toolBtnReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_MtlAna,
            this.ToolStripMenuItem_PartPlan});
            this.toolBtnReport.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnReport.Image")));
            this.toolBtnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnReport.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.toolBtnReport.Name = "toolBtnReport";
            this.toolBtnReport.Size = new System.Drawing.Size(45, 22);
            this.toolBtnReport.Text = "报表";
            // 
            // ToolStripMenuItem_MtlAna
            // 
            this.ToolStripMenuItem_MtlAna.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.chart;
            this.ToolStripMenuItem_MtlAna.Name = "ToolStripMenuItem_MtlAna";
            this.ToolStripMenuItem_MtlAna.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_MtlAna.Text = "物料分析";
            this.ToolStripMenuItem_MtlAna.Click += new System.EventHandler(this.ToolStripMenuItem_MtlAna_Click);
            // 
            // toolBtnStart
            // 
            this.toolBtnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnStart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Start,
            this.ToolStripMenuItem_Stop});
            this.toolBtnStart.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.start;
            this.toolBtnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnStart.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.toolBtnStart.Name = "toolBtnStart";
            this.toolBtnStart.Size = new System.Drawing.Size(45, 22);
            this.toolBtnStart.Text = "启动";
            // 
            // ToolStripMenuItem_Start
            // 
            this.ToolStripMenuItem_Start.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.start;
            this.ToolStripMenuItem_Start.Name = "ToolStripMenuItem_Start";
            this.ToolStripMenuItem_Start.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_Start.Text = "启动";
            this.ToolStripMenuItem_Start.Click += new System.EventHandler(this.ToolStripMenuItem_Start_Click);
            // 
            // ToolStripMenuItem_Stop
            // 
            this.ToolStripMenuItem_Stop.Enabled = false;
            this.ToolStripMenuItem_Stop.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.stop;
            this.ToolStripMenuItem_Stop.Name = "ToolStripMenuItem_Stop";
            this.ToolStripMenuItem_Stop.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_Stop.Text = "停止";
            this.ToolStripMenuItem_Stop.Click += new System.EventHandler(this.ToolStripMenuItem_Stop_Click);
            // 
            // toolDropSetting
            // 
            this.toolDropSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolDropSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Unit,
            this.ToolStripMenuItem_Sys,
            this.ToolStripMenuItem_OpenLog,
            this.ToolStripMenuItem_SyncLog,
            this.ToolStripMenuItemPowers});
            this.toolDropSetting.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.setting;
            this.toolDropSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDropSetting.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.toolDropSetting.Name = "toolDropSetting";
            this.toolDropSetting.Size = new System.Drawing.Size(45, 22);
            this.toolDropSetting.Text = "设置";
            // 
            // ToolStripMenuItem_Unit
            // 
            this.ToolStripMenuItem_Unit.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.File;
            this.ToolStripMenuItem_Unit.Name = "ToolStripMenuItem_Unit";
            this.ToolStripMenuItem_Unit.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItem_Unit.Text = "单位设置";
            this.ToolStripMenuItem_Unit.Click += new System.EventHandler(this.ToolStripMenuItem_Unit_Click);
            // 
            // ToolStripMenuItem_Sys
            // 
            this.ToolStripMenuItem_Sys.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.setting;
            this.ToolStripMenuItem_Sys.Name = "ToolStripMenuItem_Sys";
            this.ToolStripMenuItem_Sys.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItem_Sys.Text = "系统设置";
            this.ToolStripMenuItem_Sys.Click += new System.EventHandler(this.ToolStripMenuItem_Sys_Click);
            // 
            // ToolStripMenuItem_OpenLog
            // 
            this.ToolStripMenuItem_OpenLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_ClearLog});
            this.ToolStripMenuItem_OpenLog.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.log;
            this.ToolStripMenuItem_OpenLog.Name = "ToolStripMenuItem_OpenLog";
            this.ToolStripMenuItem_OpenLog.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItem_OpenLog.Text = "系统日志";
            this.ToolStripMenuItem_OpenLog.Click += new System.EventHandler(this.ToolStripMenuItem_OpenLog_Click);
            // 
            // ToolStripMenuItem_ClearLog
            // 
            this.ToolStripMenuItem_ClearLog.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.clear;
            this.ToolStripMenuItem_ClearLog.Name = "ToolStripMenuItem_ClearLog";
            this.ToolStripMenuItem_ClearLog.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_ClearLog.Text = "清除日志";
            this.ToolStripMenuItem_ClearLog.Click += new System.EventHandler(this.ToolStripMenuItem_ClearLog_Click);
            // 
            // ToolStripMenuItem_SyncLog
            // 
            this.ToolStripMenuItem_SyncLog.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.logs;
            this.ToolStripMenuItem_SyncLog.Name = "ToolStripMenuItem_SyncLog";
            this.ToolStripMenuItem_SyncLog.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItem_SyncLog.Text = "数据同步日志";
            this.ToolStripMenuItem_SyncLog.Click += new System.EventHandler(this.ToolStripMenuItem_SyncLog_Click);
            // 
            // ToolStripMenuItemPowers
            // 
            this.ToolStripMenuItemPowers.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.power;
            this.ToolStripMenuItemPowers.Name = "ToolStripMenuItemPowers";
            this.ToolStripMenuItemPowers.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItemPowers.Text = "权限设置";
            this.ToolStripMenuItemPowers.Click += new System.EventHandler(this.ToolStripMenuItemPowers_Click);
            // 
            // tboxPartNum
            // 
            this.tboxPartNum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboxPartNum.Location = new System.Drawing.Point(7, 5);
            this.tboxPartNum.Name = "tboxPartNum";
            this.tboxPartNum.Size = new System.Drawing.Size(120, 23);
            this.tboxPartNum.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.statusStripBot);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.splitCont);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 462);
            this.panel1.TabIndex = 7;
            // 
            // statusStripBot
            // 
            this.statusStripBot.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabelInfo,
            this.ProgressBarBot,
            this.StatusLabelCompany,
            this.StatusLabelTime,
            this.SLabelErpDbName,
            this.SLabelPlmDbName,
            this.SLabelUser});
            this.statusStripBot.Location = new System.Drawing.Point(0, 440);
            this.statusStripBot.Name = "statusStripBot";
            this.statusStripBot.Size = new System.Drawing.Size(784, 22);
            this.statusStripBot.TabIndex = 8;
            this.statusStripBot.Text = "statusStrip1";
            // 
            // StatusLabelInfo
            // 
            this.StatusLabelInfo.BackColor = System.Drawing.SystemColors.Control;
            this.StatusLabelInfo.Name = "StatusLabelInfo";
            this.StatusLabelInfo.Size = new System.Drawing.Size(56, 17);
            this.StatusLabelInfo.Text = "状态信息";
            // 
            // ProgressBarBot
            // 
            this.ProgressBarBot.Name = "ProgressBarBot";
            this.ProgressBarBot.Size = new System.Drawing.Size(100, 16);
            // 
            // StatusLabelCompany
            // 
            this.StatusLabelCompany.BackColor = System.Drawing.SystemColors.Control;
            this.StatusLabelCompany.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.StatusLabelCompany.Name = "StatusLabelCompany";
            this.StatusLabelCompany.Size = new System.Drawing.Size(129, 17);
            this.StatusLabelCompany.Text = "StatusLabelCompany";
            // 
            // StatusLabelTime
            // 
            this.StatusLabelTime.BackColor = System.Drawing.SystemColors.Control;
            this.StatusLabelTime.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.StatusLabelTime.Name = "StatusLabelTime";
            this.StatusLabelTime.Size = new System.Drawing.Size(102, 17);
            this.StatusLabelTime.Text = "StatusLabelTime";
            // 
            // SLabelErpDbName
            // 
            this.SLabelErpDbName.BackColor = System.Drawing.SystemColors.Window;
            this.SLabelErpDbName.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.SLabelErpDbName.Name = "SLabelErpDbName";
            this.SLabelErpDbName.Size = new System.Drawing.Size(54, 17);
            this.SLabelErpDbName.Text = "ERP连接";
            // 
            // SLabelPlmDbName
            // 
            this.SLabelPlmDbName.BackColor = System.Drawing.SystemColors.Control;
            this.SLabelPlmDbName.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.SLabelPlmDbName.Name = "SLabelPlmDbName";
            this.SLabelPlmDbName.Size = new System.Drawing.Size(57, 17);
            this.SLabelPlmDbName.Text = "PLM连接";
            // 
            // SLabelUser
            // 
            this.SLabelUser.BackColor = System.Drawing.SystemColors.Control;
            this.SLabelUser.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.SLabelUser.Name = "SLabelUser";
            this.SLabelUser.Size = new System.Drawing.Size(56, 17);
            this.SLabelUser.Text = "当前用户";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.lblAutoUpdate);
            this.panel3.Controls.Add(this.dtPicker);
            this.panel3.Controls.Add(this.BtnImportNewBOM);
            this.panel3.Controls.Add(this.BtnGetNewPartMtl);
            this.panel3.Controls.Add(this.tboxPartNum);
            this.panel3.Location = new System.Drawing.Point(0, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 32);
            this.panel3.TabIndex = 7;
            // 
            // lblAutoUpdate
            // 
            this.lblAutoUpdate.AutoSize = true;
            this.lblAutoUpdate.Font = new System.Drawing.Font("Verdana", 8F);
            this.lblAutoUpdate.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblAutoUpdate.Location = new System.Drawing.Point(349, 11);
            this.lblAutoUpdate.Name = "lblAutoUpdate";
            this.lblAutoUpdate.Size = new System.Drawing.Size(90, 13);
            this.lblAutoUpdate.TabIndex = 8;
            this.lblAutoUpdate.Text = "Cache update!";
            // 
            // dtPicker
            // 
            this.dtPicker.CustomFormat = "yyyy-MM-dd";
            this.dtPicker.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker.Location = new System.Drawing.Point(219, 4);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(124, 22);
            this.dtPicker.TabIndex = 7;
            this.dtPicker.Value = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            // 
            // BtnImportNewBOM
            // 
            this.BtnImportNewBOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnImportNewBOM.BackColor = System.Drawing.SystemColors.Control;
            this.BtnImportNewBOM.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.BtnImportNewBOM.FlatAppearance.BorderSize = 0;
            this.BtnImportNewBOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImportNewBOM.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImportNewBOM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnImportNewBOM.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.sync_16;
            this.BtnImportNewBOM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImportNewBOM.Location = new System.Drawing.Point(687, 5);
            this.BtnImportNewBOM.Name = "BtnImportNewBOM";
            this.BtnImportNewBOM.Size = new System.Drawing.Size(85, 25);
            this.BtnImportNewBOM.TabIndex = 3;
            this.BtnImportNewBOM.Text = "开始同步";
            this.BtnImportNewBOM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnImportNewBOM.UseVisualStyleBackColor = false;
            this.BtnImportNewBOM.Click += new System.EventHandler(this.BtnImportNewBOM_Click);
            // 
            // BtnGetNewPartMtl
            // 
            this.BtnGetNewPartMtl.BackColor = System.Drawing.SystemColors.Control;
            this.BtnGetNewPartMtl.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.BtnGetNewPartMtl.FlatAppearance.BorderSize = 0;
            this.BtnGetNewPartMtl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGetNewPartMtl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGetNewPartMtl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnGetNewPartMtl.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.search_16_2;
            this.BtnGetNewPartMtl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGetNewPartMtl.Location = new System.Drawing.Point(133, 4);
            this.BtnGetNewPartMtl.Name = "BtnGetNewPartMtl";
            this.BtnGetNewPartMtl.Size = new System.Drawing.Size(80, 24);
            this.BtnGetNewPartMtl.TabIndex = 2;
            this.BtnGetNewPartMtl.Text = "查找物料";
            this.BtnGetNewPartMtl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGetNewPartMtl.UseVisualStyleBackColor = false;
            this.BtnGetNewPartMtl.Click += new System.EventHandler(this.BtnGetNewPartMtl_Click);
            // 
            // timerOpr
            // 
            this.timerOpr.Enabled = true;
            this.timerOpr.Tick += new System.EventHandler(this.timerOpr_Tick);
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_CopyToExcel,
            this.ToolStripMenuItem_Bom,
            this.ToolStripMenuItem_ERPBOM,
            this.ToolStripMenuItem_ClearResult});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(161, 92);
            // 
            // ToolStripMenuItem_CopyToExcel
            // 
            this.ToolStripMenuItem_CopyToExcel.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.copy;
            this.ToolStripMenuItem_CopyToExcel.Name = "ToolStripMenuItem_CopyToExcel";
            this.ToolStripMenuItem_CopyToExcel.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItem_CopyToExcel.Text = "复制到表格";
            this.ToolStripMenuItem_CopyToExcel.Click += new System.EventHandler(this.ToolStripMenuItem_CopyToExcel_Click);
            // 
            // ToolStripMenuItem_Bom
            // 
            this.ToolStripMenuItem_Bom.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.view;
            this.ToolStripMenuItem_Bom.Name = "ToolStripMenuItem_Bom";
            this.ToolStripMenuItem_Bom.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItem_Bom.Text = "查看PLM_BOM";
            this.ToolStripMenuItem_Bom.Click += new System.EventHandler(this.ToolStripMenuItem_Bom_Click);
            // 
            // ToolStripMenuItem_ERPBOM
            // 
            this.ToolStripMenuItem_ERPBOM.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.view;
            this.ToolStripMenuItem_ERPBOM.Name = "ToolStripMenuItem_ERPBOM";
            this.ToolStripMenuItem_ERPBOM.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItem_ERPBOM.Text = "查看ERP_BOM";
            this.ToolStripMenuItem_ERPBOM.Click += new System.EventHandler(this.ToolStripMenuItem_ERPBOM_Click);
            // 
            // ToolStripMenuItem_ClearResult
            // 
            this.ToolStripMenuItem_ClearResult.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.trash;
            this.ToolStripMenuItem_ClearResult.Name = "ToolStripMenuItem_ClearResult";
            this.ToolStripMenuItem_ClearResult.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItem_ClearResult.Text = "清空表格";
            this.ToolStripMenuItem_ClearResult.Click += new System.EventHandler(this.ToolStripMenuItem_ClearResult_Click);
            // 
            // contextMenuStripTree
            // 
            this.contextMenuStripTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_ExBom,
            this.ToolStripMenuItem_ExWGJ,
            this.ToolStripMenuItem_ExZZJ,
            this.ToolStripMenuItem_ToFactBOM,
            this.ToolStripMenuItem_ClearTree});
            this.contextMenuStripTree.Name = "contextMenuStripTree";
            this.contextMenuStripTree.Size = new System.Drawing.Size(161, 114);
            // 
            // ToolStripMenuItem_ExBom
            // 
            this.ToolStripMenuItem_ExBom.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.excel;
            this.ToolStripMenuItem_ExBom.Name = "ToolStripMenuItem_ExBom";
            this.ToolStripMenuItem_ExBom.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItem_ExBom.Text = "导出BOM";
            this.ToolStripMenuItem_ExBom.Click += new System.EventHandler(this.ToolStripMenuItem_ExBom_Click);
            // 
            // ToolStripMenuItem_ExWGJ
            // 
            this.ToolStripMenuItem_ExWGJ.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.excel;
            this.ToolStripMenuItem_ExWGJ.Name = "ToolStripMenuItem_ExWGJ";
            this.ToolStripMenuItem_ExWGJ.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItem_ExWGJ.Text = "导出外购件明细";
            this.ToolStripMenuItem_ExWGJ.Click += new System.EventHandler(this.ToolStripMenuItem_ExWGJ_Click);
            // 
            // ToolStripMenuItem_ExZZJ
            // 
            this.ToolStripMenuItem_ExZZJ.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.excel;
            this.ToolStripMenuItem_ExZZJ.Name = "ToolStripMenuItem_ExZZJ";
            this.ToolStripMenuItem_ExZZJ.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItem_ExZZJ.Text = "导出自制件明细";
            this.ToolStripMenuItem_ExZZJ.Click += new System.EventHandler(this.ToolStripMenuItem_ExZZJ_Click);
            // 
            // ToolStripMenuItem_ToFactBOM
            // 
            this.ToolStripMenuItem_ToFactBOM.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.fun;
            this.ToolStripMenuItem_ToFactBOM.Name = "ToolStripMenuItem_ToFactBOM";
            this.ToolStripMenuItem_ToFactBOM.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItem_ToFactBOM.Text = "生成制造BOM";
            this.ToolStripMenuItem_ToFactBOM.Click += new System.EventHandler(this.ToolStripMenuItem_ToFactBOM_Click);
            // 
            // ToolStripMenuItem_ClearTree
            // 
            this.ToolStripMenuItem_ClearTree.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.clear;
            this.ToolStripMenuItem_ClearTree.Name = "ToolStripMenuItem_ClearTree";
            this.ToolStripMenuItem_ClearTree.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItem_ClearTree.Text = "清空数据";
            this.ToolStripMenuItem_ClearTree.Click += new System.EventHandler(this.ToolStripMenuItem_ClearTree_Click);
            // 
            // notifyIconMain
            // 
            this.notifyIconMain.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMain.Icon")));
            this.notifyIconMain.Text = "PLM数据同步";
            this.notifyIconMain.DoubleClick += new System.EventHandler(this.notifyIconMain_DoubleClick);
            // 
            // timerProg
            // 
            this.timerProg.Enabled = true;
            this.timerProg.Interval = 500;
            this.timerProg.Tick += new System.EventHandler(this.timerProg_Tick);
            // 
            // timerAutoSync
            // 
            this.timerAutoSync.Tick += new System.EventHandler(this.timerAutoSync_Tick);
            // 
            // timerAutoCache
            // 
            this.timerAutoCache.Enabled = true;
            this.timerAutoCache.Interval = 1800000;
            this.timerAutoCache.Tick += new System.EventHandler(this.timerAutoCache_Tick);
            // 
            // ToolStripMenuItem_PartPlan
            // 
            this.ToolStripMenuItem_PartPlan.Image = global::Ross.ERP.PlmSyncTool.Properties.Resources.model;
            this.ToolStripMenuItem_PartPlan.Name = "ToolStripMenuItem_PartPlan";
            this.ToolStripMenuItem_PartPlan.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_PartPlan.Text = "物料计划";
            this.ToolStripMenuItem_PartPlan.Click += new System.EventHandler(this.ToolStripMenuItem_PartPlan_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.toolStripTop);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PLM数据同步";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.splitCont.Panel1.ResumeLayout(false);
            this.splitCont.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCont)).EndInit();
            this.splitCont.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControlLeft.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBOM)).EndInit();
            this.toolStripTop.ResumeLayout(false);
            this.toolStripTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStripBot.ResumeLayout(false);
            this.statusStripBot.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.contextMenuStripMain.ResumeLayout(false);
            this.contextMenuStripTree.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.SplitContainer splitCont;
        private System.Windows.Forms.ToolStripDropDownButton toolDropBtnPlm;
        private System.Windows.Forms.ToolStripMenuItem BtnGetNewMTL;
        private System.Windows.Forms.ToolStrip toolStripTop;
        private System.Windows.Forms.TextBox tboxPartNum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnGetNewPartMtl;
        private System.Windows.Forms.Button BtnImportNewBOM;
        private System.Windows.Forms.ToolStripDropDownButton toolDropbtnErp;
        private System.Windows.Forms.ToolStripMenuItem toolDropBtnPartMtl;
        private System.Windows.Forms.ToolStripMenuItem toolDropBtnPartOpr;
        private System.Windows.Forms.ToolStripMenuItem BtnGetNewBOM;
        private System.Windows.Forms.StatusStrip statusStripBot;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelInfo;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelTime;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelCompany;
        private System.Windows.Forms.ToolStripProgressBar ProgressBarBot;
        private System.Windows.Forms.ToolStripDropDownButton DropDownButtonFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuExist;
        private System.Windows.Forms.TreeView treeViewLeft;
        private System.Windows.Forms.ToolStripDropDownButton toolDropExport;
        private System.Windows.Forms.ToolStripMenuItem BtnExport_NewPart;
        private System.Windows.Forms.ToolStripMenuItem BtnExport_NewBom;
        private System.Windows.Forms.Timer timerOpr;
        private System.Windows.Forms.ToolStripDropDownButton toolDropSetting;
        private System.Windows.Forms.ToolStripDropDownButton toolBtnStart;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Start;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Stop;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_CopyToExcel;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Bom;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTree;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ExBom;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ExWGJ;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ExZZJ;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Jobs;
        private System.Windows.Forms.NotifyIcon notifyIconMain;
        private System.Windows.Forms.ToolStripStatusLabel SLabelErpDbName;
        private System.Windows.Forms.Timer timerProg;
        private System.Windows.Forms.ToolStripStatusLabel SLabelPlmDbName;
        private System.Windows.Forms.ToolStripMenuItem BtnGetNewBOO;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ChkBOM;
        private System.Windows.Forms.ToolStripStatusLabel SLabelUser;
        private System.Windows.Forms.Timer timerAutoSync;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Unit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Sys;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_OpenLog;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DGVBOM;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ClearLog;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ClearResult;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_GetERPBOM;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ERPBOM;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ClearTree;
        private System.Windows.Forms.TreeView treeViewLeftBot;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ToFactBOM;
        private System.Windows.Forms.TabControl tabControlLeft;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SyncLog;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ResetCache;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_UpdateParts;
        private System.Windows.Forms.ToolStripDropDownButton toolBtnReport;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_MtlAna;
        private System.Windows.Forms.Timer timerAutoCache;
        private System.Windows.Forms.Label lblAutoUpdate;
        private System.Windows.Forms.ToolStripMenuItem toolDropBtnPart;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuModPsw;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPowers;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_PartPlan;
    }
}

