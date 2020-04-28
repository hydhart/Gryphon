namespace PowerRetail
{
    partial class ItemList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelRibbon = new System.Windows.Forms.Panel();
            this.panelRibbonMenu = new System.Windows.Forms.Panel();
            this.panelRibbonMenuReport = new System.Windows.Forms.Panel();
            this.btnRibbonReportTop10Sales = new System.Windows.Forms.Button();
            this.btnRibbonReportItemList = new System.Windows.Forms.Button();
            this.panelRibbonMenuNavigate = new System.Windows.Forms.Panel();
            this.btnRibbonNavigateUoM = new System.Windows.Forms.Button();
            this.btnRibbonNavigateCategory = new System.Windows.Forms.Button();
            this.panelRibbonMenuManage = new System.Windows.Forms.Panel();
            this.btnRibbonManageRefresh = new System.Windows.Forms.Button();
            this.btnRibbonManageSp3 = new System.Windows.Forms.Button();
            this.btnRibbonManageClearFilter = new System.Windows.Forms.Button();
            this.btnRibbonManageFilter = new System.Windows.Forms.Button();
            this.btnRibbonManageSp2 = new System.Windows.Forms.Button();
            this.btnRibbonManageDelete = new System.Windows.Forms.Button();
            this.btnRibbonManageView = new System.Windows.Forms.Button();
            this.btnRibbonManageEdit = new System.Windows.Forms.Button();
            this.btnRibbonManageSp1 = new System.Windows.Forms.Button();
            this.btnRibbonManageNew = new System.Windows.Forms.Button();
            this.panelRibbonGroup = new System.Windows.Forms.Panel();
            this.btnRibbonGroupReport = new System.Windows.Forms.Button();
            this.btnRibbonGroupNavigate = new System.Windows.Forms.Button();
            this.btnRibbonGroupManage = new System.Windows.Forms.Button();
            this.panelData = new System.Windows.Forms.Panel();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.panelDataFilter = new System.Windows.Forms.Panel();
            this.panelDataFilterList = new System.Windows.Forms.Panel();
            this.panelDataFilterOperator = new System.Windows.Forms.Panel();
            this.btnDataFilterAdd = new System.Windows.Forms.Button();
            this.txtDataFilterValue = new System.Windows.Forms.TextBox();
            this.cbDataFilterOperator = new System.Windows.Forms.ComboBox();
            this.cbDataFilterFields = new System.Windows.Forms.ComboBox();
            this.panelRibbon.SuspendLayout();
            this.panelRibbonMenu.SuspendLayout();
            this.panelRibbonMenuReport.SuspendLayout();
            this.panelRibbonMenuNavigate.SuspendLayout();
            this.panelRibbonMenuManage.SuspendLayout();
            this.panelRibbonGroup.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.panelDataFilter.SuspendLayout();
            this.panelDataFilterOperator.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(748, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Tag = "#CLOSE";
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelRibbon
            // 
            this.panelRibbon.Controls.Add(this.panelRibbonMenu);
            this.panelRibbon.Controls.Add(this.panelRibbonGroup);
            this.panelRibbon.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRibbon.Location = new System.Drawing.Point(0, 0);
            this.panelRibbon.Name = "panelRibbon";
            this.panelRibbon.Size = new System.Drawing.Size(778, 90);
            this.panelRibbon.TabIndex = 2;
            // 
            // panelRibbonMenu
            // 
            this.panelRibbonMenu.BackColor = System.Drawing.Color.Silver;
            this.panelRibbonMenu.Controls.Add(this.panelRibbonMenuReport);
            this.panelRibbonMenu.Controls.Add(this.panelRibbonMenuNavigate);
            this.panelRibbonMenu.Controls.Add(this.panelRibbonMenuManage);
            this.panelRibbonMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRibbonMenu.Location = new System.Drawing.Point(0, 30);
            this.panelRibbonMenu.Name = "panelRibbonMenu";
            this.panelRibbonMenu.Size = new System.Drawing.Size(778, 60);
            this.panelRibbonMenu.TabIndex = 1;
            // 
            // panelRibbonMenuReport
            // 
            this.panelRibbonMenuReport.AutoSize = true;
            this.panelRibbonMenuReport.Controls.Add(this.btnRibbonReportTop10Sales);
            this.panelRibbonMenuReport.Controls.Add(this.btnRibbonReportItemList);
            this.panelRibbonMenuReport.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRibbonMenuReport.Location = new System.Drawing.Point(552, 0);
            this.panelRibbonMenuReport.Name = "panelRibbonMenuReport";
            this.panelRibbonMenuReport.Size = new System.Drawing.Size(122, 60);
            this.panelRibbonMenuReport.TabIndex = 2;
            this.panelRibbonMenuReport.Tag = "#REPORT";
            // 
            // btnRibbonReportTop10Sales
            // 
            this.btnRibbonReportTop10Sales.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRibbonReportTop10Sales.FlatAppearance.BorderSize = 0;
            this.btnRibbonReportTop10Sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRibbonReportTop10Sales.Location = new System.Drawing.Point(61, 0);
            this.btnRibbonReportTop10Sales.Name = "btnRibbonReportTop10Sales";
            this.btnRibbonReportTop10Sales.Size = new System.Drawing.Size(61, 60);
            this.btnRibbonReportTop10Sales.TabIndex = 8;
            this.btnRibbonReportTop10Sales.Tag = "#REPORT";
            this.btnRibbonReportTop10Sales.Text = "Top 10\r\nSales";
            this.btnRibbonReportTop10Sales.UseVisualStyleBackColor = true;
            // 
            // btnRibbonReportItemList
            // 
            this.btnRibbonReportItemList.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRibbonReportItemList.FlatAppearance.BorderSize = 0;
            this.btnRibbonReportItemList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRibbonReportItemList.Location = new System.Drawing.Point(0, 0);
            this.btnRibbonReportItemList.Name = "btnRibbonReportItemList";
            this.btnRibbonReportItemList.Size = new System.Drawing.Size(61, 60);
            this.btnRibbonReportItemList.TabIndex = 7;
            this.btnRibbonReportItemList.Tag = "#REPORT";
            this.btnRibbonReportItemList.Text = "Item List\r\n";
            this.btnRibbonReportItemList.UseVisualStyleBackColor = true;
            // 
            // panelRibbonMenuNavigate
            // 
            this.panelRibbonMenuNavigate.AutoSize = true;
            this.panelRibbonMenuNavigate.Controls.Add(this.btnRibbonNavigateUoM);
            this.panelRibbonMenuNavigate.Controls.Add(this.btnRibbonNavigateCategory);
            this.panelRibbonMenuNavigate.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRibbonMenuNavigate.Location = new System.Drawing.Point(430, 0);
            this.panelRibbonMenuNavigate.Name = "panelRibbonMenuNavigate";
            this.panelRibbonMenuNavigate.Size = new System.Drawing.Size(122, 60);
            this.panelRibbonMenuNavigate.TabIndex = 1;
            this.panelRibbonMenuNavigate.Tag = "#NAVIGATE";
            // 
            // btnRibbonNavigateUoM
            // 
            this.btnRibbonNavigateUoM.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRibbonNavigateUoM.FlatAppearance.BorderSize = 0;
            this.btnRibbonNavigateUoM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRibbonNavigateUoM.Location = new System.Drawing.Point(61, 0);
            this.btnRibbonNavigateUoM.Name = "btnRibbonNavigateUoM";
            this.btnRibbonNavigateUoM.Size = new System.Drawing.Size(61, 60);
            this.btnRibbonNavigateUoM.TabIndex = 8;
            this.btnRibbonNavigateUoM.Tag = "#MANAGE";
            this.btnRibbonNavigateUoM.Text = "UoM";
            this.btnRibbonNavigateUoM.UseVisualStyleBackColor = true;
            // 
            // btnRibbonNavigateCategory
            // 
            this.btnRibbonNavigateCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRibbonNavigateCategory.FlatAppearance.BorderSize = 0;
            this.btnRibbonNavigateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRibbonNavigateCategory.Location = new System.Drawing.Point(0, 0);
            this.btnRibbonNavigateCategory.Name = "btnRibbonNavigateCategory";
            this.btnRibbonNavigateCategory.Size = new System.Drawing.Size(61, 60);
            this.btnRibbonNavigateCategory.TabIndex = 7;
            this.btnRibbonNavigateCategory.Tag = "#NAVIGATE";
            this.btnRibbonNavigateCategory.Text = "Category";
            this.btnRibbonNavigateCategory.UseVisualStyleBackColor = true;
            // 
            // panelRibbonMenuManage
            // 
            this.panelRibbonMenuManage.AutoSize = true;
            this.panelRibbonMenuManage.Controls.Add(this.btnRibbonManageRefresh);
            this.panelRibbonMenuManage.Controls.Add(this.btnRibbonManageSp3);
            this.panelRibbonMenuManage.Controls.Add(this.btnRibbonManageClearFilter);
            this.panelRibbonMenuManage.Controls.Add(this.btnRibbonManageFilter);
            this.panelRibbonMenuManage.Controls.Add(this.btnRibbonManageSp2);
            this.panelRibbonMenuManage.Controls.Add(this.btnRibbonManageDelete);
            this.panelRibbonMenuManage.Controls.Add(this.btnRibbonManageView);
            this.panelRibbonMenuManage.Controls.Add(this.btnRibbonManageEdit);
            this.panelRibbonMenuManage.Controls.Add(this.btnRibbonManageSp1);
            this.panelRibbonMenuManage.Controls.Add(this.btnRibbonManageNew);
            this.panelRibbonMenuManage.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRibbonMenuManage.Location = new System.Drawing.Point(0, 0);
            this.panelRibbonMenuManage.Name = "panelRibbonMenuManage";
            this.panelRibbonMenuManage.Size = new System.Drawing.Size(430, 60);
            this.panelRibbonMenuManage.TabIndex = 0;
            this.panelRibbonMenuManage.Tag = "#MANAGE";
            // 
            // btnRibbonManageRefresh
            // 
            this.btnRibbonManageRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRibbonManageRefresh.FlatAppearance.BorderSize = 0;
            this.btnRibbonManageRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRibbonManageRefresh.Location = new System.Drawing.Point(369, 0);
            this.btnRibbonManageRefresh.Name = "btnRibbonManageRefresh";
            this.btnRibbonManageRefresh.Size = new System.Drawing.Size(61, 60);
            this.btnRibbonManageRefresh.TabIndex = 15;
            this.btnRibbonManageRefresh.Tag = "#MANAGE";
            this.btnRibbonManageRefresh.Text = "Refresh";
            this.btnRibbonManageRefresh.UseVisualStyleBackColor = true;
            this.btnRibbonManageRefresh.Click += new System.EventHandler(this.btnRibbonManageRefresh_Click);
            // 
            // btnRibbonManageSp3
            // 
            this.btnRibbonManageSp3.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRibbonManageSp3.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRibbonManageSp3.FlatAppearance.BorderSize = 0;
            this.btnRibbonManageSp3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRibbonManageSp3.Location = new System.Drawing.Point(368, 0);
            this.btnRibbonManageSp3.Name = "btnRibbonManageSp3";
            this.btnRibbonManageSp3.Size = new System.Drawing.Size(1, 60);
            this.btnRibbonManageSp3.TabIndex = 14;
            this.btnRibbonManageSp3.Tag = "#MANAGE";
            this.btnRibbonManageSp3.UseVisualStyleBackColor = false;
            // 
            // btnRibbonManageClearFilter
            // 
            this.btnRibbonManageClearFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRibbonManageClearFilter.FlatAppearance.BorderSize = 0;
            this.btnRibbonManageClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRibbonManageClearFilter.Location = new System.Drawing.Point(307, 0);
            this.btnRibbonManageClearFilter.Name = "btnRibbonManageClearFilter";
            this.btnRibbonManageClearFilter.Size = new System.Drawing.Size(61, 60);
            this.btnRibbonManageClearFilter.TabIndex = 13;
            this.btnRibbonManageClearFilter.Tag = "#MANAGE";
            this.btnRibbonManageClearFilter.Text = "Clear Filter";
            this.btnRibbonManageClearFilter.UseVisualStyleBackColor = true;
            this.btnRibbonManageClearFilter.Click += new System.EventHandler(this.btnRibbonManageClearFilter_Click);
            // 
            // btnRibbonManageFilter
            // 
            this.btnRibbonManageFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRibbonManageFilter.FlatAppearance.BorderSize = 0;
            this.btnRibbonManageFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRibbonManageFilter.Location = new System.Drawing.Point(246, 0);
            this.btnRibbonManageFilter.Name = "btnRibbonManageFilter";
            this.btnRibbonManageFilter.Size = new System.Drawing.Size(61, 60);
            this.btnRibbonManageFilter.TabIndex = 12;
            this.btnRibbonManageFilter.Tag = "#MANAGE";
            this.btnRibbonManageFilter.Text = "Filter";
            this.btnRibbonManageFilter.UseVisualStyleBackColor = true;
            this.btnRibbonManageFilter.Click += new System.EventHandler(this.btnRibbonManageFilter_Click);
            // 
            // btnRibbonManageSp2
            // 
            this.btnRibbonManageSp2.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRibbonManageSp2.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRibbonManageSp2.FlatAppearance.BorderSize = 0;
            this.btnRibbonManageSp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRibbonManageSp2.Location = new System.Drawing.Point(245, 0);
            this.btnRibbonManageSp2.Name = "btnRibbonManageSp2";
            this.btnRibbonManageSp2.Size = new System.Drawing.Size(1, 60);
            this.btnRibbonManageSp2.TabIndex = 9;
            this.btnRibbonManageSp2.Tag = "#MANAGE";
            this.btnRibbonManageSp2.UseVisualStyleBackColor = false;
            // 
            // btnRibbonManageDelete
            // 
            this.btnRibbonManageDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRibbonManageDelete.FlatAppearance.BorderSize = 0;
            this.btnRibbonManageDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRibbonManageDelete.Location = new System.Drawing.Point(184, 0);
            this.btnRibbonManageDelete.Name = "btnRibbonManageDelete";
            this.btnRibbonManageDelete.Size = new System.Drawing.Size(61, 60);
            this.btnRibbonManageDelete.TabIndex = 6;
            this.btnRibbonManageDelete.Tag = "#MANAGE";
            this.btnRibbonManageDelete.Text = "Delete";
            this.btnRibbonManageDelete.UseVisualStyleBackColor = true;
            // 
            // btnRibbonManageView
            // 
            this.btnRibbonManageView.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRibbonManageView.FlatAppearance.BorderSize = 0;
            this.btnRibbonManageView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRibbonManageView.Location = new System.Drawing.Point(123, 0);
            this.btnRibbonManageView.Name = "btnRibbonManageView";
            this.btnRibbonManageView.Size = new System.Drawing.Size(61, 60);
            this.btnRibbonManageView.TabIndex = 5;
            this.btnRibbonManageView.Tag = "#MANAGE";
            this.btnRibbonManageView.Text = "View";
            this.btnRibbonManageView.UseVisualStyleBackColor = true;
            this.btnRibbonManageView.Click += new System.EventHandler(this.btnRibbonManageView_Click);
            // 
            // btnRibbonManageEdit
            // 
            this.btnRibbonManageEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRibbonManageEdit.FlatAppearance.BorderSize = 0;
            this.btnRibbonManageEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRibbonManageEdit.Location = new System.Drawing.Point(62, 0);
            this.btnRibbonManageEdit.Name = "btnRibbonManageEdit";
            this.btnRibbonManageEdit.Size = new System.Drawing.Size(61, 60);
            this.btnRibbonManageEdit.TabIndex = 4;
            this.btnRibbonManageEdit.Tag = "#MANAGE";
            this.btnRibbonManageEdit.Text = "Edit";
            this.btnRibbonManageEdit.UseVisualStyleBackColor = true;
            // 
            // btnRibbonManageSp1
            // 
            this.btnRibbonManageSp1.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRibbonManageSp1.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRibbonManageSp1.FlatAppearance.BorderSize = 0;
            this.btnRibbonManageSp1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRibbonManageSp1.Location = new System.Drawing.Point(61, 0);
            this.btnRibbonManageSp1.Name = "btnRibbonManageSp1";
            this.btnRibbonManageSp1.Size = new System.Drawing.Size(1, 60);
            this.btnRibbonManageSp1.TabIndex = 3;
            this.btnRibbonManageSp1.Tag = "#MANAGE";
            this.btnRibbonManageSp1.UseVisualStyleBackColor = false;
            // 
            // btnRibbonManageNew
            // 
            this.btnRibbonManageNew.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRibbonManageNew.FlatAppearance.BorderSize = 0;
            this.btnRibbonManageNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRibbonManageNew.Location = new System.Drawing.Point(0, 0);
            this.btnRibbonManageNew.Name = "btnRibbonManageNew";
            this.btnRibbonManageNew.Size = new System.Drawing.Size(61, 60);
            this.btnRibbonManageNew.TabIndex = 2;
            this.btnRibbonManageNew.Tag = "#MANAGE";
            this.btnRibbonManageNew.Text = "New";
            this.btnRibbonManageNew.UseVisualStyleBackColor = true;
            // 
            // panelRibbonGroup
            // 
            this.panelRibbonGroup.BackColor = System.Drawing.Color.Gainsboro;
            this.panelRibbonGroup.Controls.Add(this.btnRibbonGroupReport);
            this.panelRibbonGroup.Controls.Add(this.btnRibbonGroupNavigate);
            this.panelRibbonGroup.Controls.Add(this.btnRibbonGroupManage);
            this.panelRibbonGroup.Controls.Add(this.btnClose);
            this.panelRibbonGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRibbonGroup.Location = new System.Drawing.Point(0, 0);
            this.panelRibbonGroup.Name = "panelRibbonGroup";
            this.panelRibbonGroup.Size = new System.Drawing.Size(778, 30);
            this.panelRibbonGroup.TabIndex = 0;
            // 
            // btnRibbonGroupReport
            // 
            this.btnRibbonGroupReport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRibbonGroupReport.FlatAppearance.BorderSize = 0;
            this.btnRibbonGroupReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRibbonGroupReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRibbonGroupReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRibbonGroupReport.Location = new System.Drawing.Point(160, 0);
            this.btnRibbonGroupReport.Name = "btnRibbonGroupReport";
            this.btnRibbonGroupReport.Size = new System.Drawing.Size(80, 30);
            this.btnRibbonGroupReport.TabIndex = 3;
            this.btnRibbonGroupReport.Tag = "#REPORT";
            this.btnRibbonGroupReport.Text = "Report";
            this.btnRibbonGroupReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRibbonGroupReport.UseVisualStyleBackColor = true;
            this.btnRibbonGroupReport.Click += new System.EventHandler(this.btnRibbonGroupReport_Click);
            // 
            // btnRibbonGroupNavigate
            // 
            this.btnRibbonGroupNavigate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRibbonGroupNavigate.FlatAppearance.BorderSize = 0;
            this.btnRibbonGroupNavigate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRibbonGroupNavigate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRibbonGroupNavigate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRibbonGroupNavigate.Location = new System.Drawing.Point(80, 0);
            this.btnRibbonGroupNavigate.Name = "btnRibbonGroupNavigate";
            this.btnRibbonGroupNavigate.Size = new System.Drawing.Size(80, 30);
            this.btnRibbonGroupNavigate.TabIndex = 2;
            this.btnRibbonGroupNavigate.Tag = "#NAVIGATE";
            this.btnRibbonGroupNavigate.Text = "Navigate";
            this.btnRibbonGroupNavigate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRibbonGroupNavigate.UseVisualStyleBackColor = true;
            this.btnRibbonGroupNavigate.Click += new System.EventHandler(this.btnRibbonGroupNavigate_Click);
            // 
            // btnRibbonGroupManage
            // 
            this.btnRibbonGroupManage.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRibbonGroupManage.FlatAppearance.BorderSize = 0;
            this.btnRibbonGroupManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRibbonGroupManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRibbonGroupManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRibbonGroupManage.Location = new System.Drawing.Point(0, 0);
            this.btnRibbonGroupManage.Name = "btnRibbonGroupManage";
            this.btnRibbonGroupManage.Size = new System.Drawing.Size(80, 30);
            this.btnRibbonGroupManage.TabIndex = 1;
            this.btnRibbonGroupManage.Tag = "#MANAGE";
            this.btnRibbonGroupManage.Text = "Manage";
            this.btnRibbonGroupManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRibbonGroupManage.UseVisualStyleBackColor = true;
            this.btnRibbonGroupManage.Click += new System.EventHandler(this.btnRibbonGroupManage_Click);
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.gridData);
            this.panelData.Controls.Add(this.panelDataFilter);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(0, 90);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(778, 609);
            this.panelData.TabIndex = 3;
            // 
            // gridData
            // 
            this.gridData.AllowUserToAddRows = false;
            this.gridData.AllowUserToDeleteRows = false;
            this.gridData.AllowUserToOrderColumns = true;
            this.gridData.AllowUserToResizeRows = false;
            this.gridData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridData.ColumnHeadersHeight = 25;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridData.EnableHeadersVisualStyles = false;
            this.gridData.Location = new System.Drawing.Point(200, 0);
            this.gridData.Name = "gridData";
            this.gridData.ReadOnly = true;
            this.gridData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridData.RowHeadersVisible = false;
            this.gridData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridData.ShowEditingIcon = false;
            this.gridData.Size = new System.Drawing.Size(578, 609);
            this.gridData.TabIndex = 1;
            this.gridData.DoubleClick += new System.EventHandler(this.gridData_DoubleClick);
            this.gridData.Resize += new System.EventHandler(this.gridData_Resize);
            // 
            // panelDataFilter
            // 
            this.panelDataFilter.Controls.Add(this.panelDataFilterList);
            this.panelDataFilter.Controls.Add(this.panelDataFilterOperator);
            this.panelDataFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDataFilter.Location = new System.Drawing.Point(0, 0);
            this.panelDataFilter.Name = "panelDataFilter";
            this.panelDataFilter.Size = new System.Drawing.Size(200, 609);
            this.panelDataFilter.TabIndex = 0;
            // 
            // panelDataFilterList
            // 
            this.panelDataFilterList.AutoSize = true;
            this.panelDataFilterList.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDataFilterList.Location = new System.Drawing.Point(0, 116);
            this.panelDataFilterList.Name = "panelDataFilterList";
            this.panelDataFilterList.Size = new System.Drawing.Size(200, 0);
            this.panelDataFilterList.TabIndex = 1;
            // 
            // panelDataFilterOperator
            // 
            this.panelDataFilterOperator.Controls.Add(this.btnDataFilterAdd);
            this.panelDataFilterOperator.Controls.Add(this.txtDataFilterValue);
            this.panelDataFilterOperator.Controls.Add(this.cbDataFilterOperator);
            this.panelDataFilterOperator.Controls.Add(this.cbDataFilterFields);
            this.panelDataFilterOperator.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDataFilterOperator.Location = new System.Drawing.Point(0, 0);
            this.panelDataFilterOperator.Name = "panelDataFilterOperator";
            this.panelDataFilterOperator.Size = new System.Drawing.Size(200, 116);
            this.panelDataFilterOperator.TabIndex = 0;
            // 
            // btnDataFilterAdd
            // 
            this.btnDataFilterAdd.Location = new System.Drawing.Point(141, 88);
            this.btnDataFilterAdd.Name = "btnDataFilterAdd";
            this.btnDataFilterAdd.Size = new System.Drawing.Size(53, 23);
            this.btnDataFilterAdd.TabIndex = 7;
            this.btnDataFilterAdd.Text = "Add";
            this.btnDataFilterAdd.UseVisualStyleBackColor = true;
            this.btnDataFilterAdd.Click += new System.EventHandler(this.btnDataFilterAdd_Click);
            // 
            // txtDataFilterValue
            // 
            this.txtDataFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataFilterValue.Location = new System.Drawing.Point(4, 62);
            this.txtDataFilterValue.Name = "txtDataFilterValue";
            this.txtDataFilterValue.Size = new System.Drawing.Size(190, 20);
            this.txtDataFilterValue.TabIndex = 6;
            // 
            // cbDataFilterOperator
            // 
            this.cbDataFilterOperator.FormattingEnabled = true;
            this.cbDataFilterOperator.Items.AddRange(new object[] {
            "=",
            "LIKE",
            "IN",
            ">",
            ">=",
            "<",
            "<="});
            this.cbDataFilterOperator.Location = new System.Drawing.Point(4, 34);
            this.cbDataFilterOperator.Name = "cbDataFilterOperator";
            this.cbDataFilterOperator.Size = new System.Drawing.Size(100, 21);
            this.cbDataFilterOperator.TabIndex = 5;
            // 
            // cbDataFilterFields
            // 
            this.cbDataFilterFields.FormattingEnabled = true;
            this.cbDataFilterFields.Location = new System.Drawing.Point(3, 6);
            this.cbDataFilterFields.Name = "cbDataFilterFields";
            this.cbDataFilterFields.Size = new System.Drawing.Size(191, 21);
            this.cbDataFilterFields.TabIndex = 4;
            // 
            // ItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 699);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelRibbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemList";
            this.Text = "Form1";
            this.panelRibbon.ResumeLayout(false);
            this.panelRibbonMenu.ResumeLayout(false);
            this.panelRibbonMenu.PerformLayout();
            this.panelRibbonMenuReport.ResumeLayout(false);
            this.panelRibbonMenuNavigate.ResumeLayout(false);
            this.panelRibbonMenuManage.ResumeLayout(false);
            this.panelRibbonGroup.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.panelDataFilter.ResumeLayout(false);
            this.panelDataFilter.PerformLayout();
            this.panelDataFilterOperator.ResumeLayout(false);
            this.panelDataFilterOperator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelRibbon;
        private System.Windows.Forms.Panel panelRibbonMenu;
        private System.Windows.Forms.Panel panelRibbonMenuNavigate;
        private System.Windows.Forms.Panel panelRibbonMenuManage;
        private System.Windows.Forms.Button btnRibbonManageDelete;
        private System.Windows.Forms.Button btnRibbonManageView;
        private System.Windows.Forms.Button btnRibbonManageEdit;
        private System.Windows.Forms.Button btnRibbonManageSp1;
        private System.Windows.Forms.Button btnRibbonManageNew;
        private System.Windows.Forms.Panel panelRibbonGroup;
        private System.Windows.Forms.Button btnRibbonGroupReport;
        private System.Windows.Forms.Button btnRibbonGroupNavigate;
        private System.Windows.Forms.Button btnRibbonGroupManage;
        private System.Windows.Forms.Panel panelRibbonMenuReport;
        private System.Windows.Forms.Button btnRibbonReportTop10Sales;
        private System.Windows.Forms.Button btnRibbonReportItemList;
        private System.Windows.Forms.Button btnRibbonNavigateUoM;
        private System.Windows.Forms.Button btnRibbonNavigateCategory;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.Panel panelDataFilter;
        private System.Windows.Forms.Panel panelDataFilterList;
        private System.Windows.Forms.Panel panelDataFilterOperator;
        private System.Windows.Forms.Button btnDataFilterAdd;
        private System.Windows.Forms.TextBox txtDataFilterValue;
        private System.Windows.Forms.ComboBox cbDataFilterOperator;
        private System.Windows.Forms.ComboBox cbDataFilterFields;
        private System.Windows.Forms.Button btnRibbonManageFilter;
        private System.Windows.Forms.Button btnRibbonManageSp2;
        private System.Windows.Forms.Button btnRibbonManageClearFilter;
        private System.Windows.Forms.Button btnRibbonManageRefresh;
        private System.Windows.Forms.Button btnRibbonManageSp3;
    }
}