namespace PowerRetail.components
{
    partial class DBGridList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelDataFilter = new System.Windows.Forms.Panel();
            this.panelDataFilterList = new System.Windows.Forms.Panel();
            this.panelDataFilterOperator = new System.Windows.Forms.Panel();
            this.btnDataFilterAdd = new System.Windows.Forms.Button();
            this.txtDataFilterValue = new System.Windows.Forms.TextBox();
            this.cbDataFilterOperator = new System.Windows.Forms.ComboBox();
            this.cbDataFilterFields = new System.Windows.Forms.ComboBox();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.panelDataFilter.SuspendLayout();
            this.panelDataFilterOperator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDataFilter
            // 
            this.panelDataFilter.Controls.Add(this.panelDataFilterList);
            this.panelDataFilter.Controls.Add(this.panelDataFilterOperator);
            this.panelDataFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDataFilter.Location = new System.Drawing.Point(0, 0);
            this.panelDataFilter.Name = "panelDataFilter";
            this.panelDataFilter.Size = new System.Drawing.Size(250, 400);
            this.panelDataFilter.TabIndex = 1;
            // 
            // panelDataFilterList
            // 
            this.panelDataFilterList.AutoSize = true;
            this.panelDataFilterList.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDataFilterList.Location = new System.Drawing.Point(0, 87);
            this.panelDataFilterList.Name = "panelDataFilterList";
            this.panelDataFilterList.Size = new System.Drawing.Size(250, 0);
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
            this.panelDataFilterOperator.Size = new System.Drawing.Size(250, 87);
            this.panelDataFilterOperator.TabIndex = 0;
            // 
            // btnDataFilterAdd
            // 
            this.btnDataFilterAdd.Location = new System.Drawing.Point(190, 6);
            this.btnDataFilterAdd.Name = "btnDataFilterAdd";
            this.btnDataFilterAdd.Size = new System.Drawing.Size(56, 49);
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
            this.txtDataFilterValue.Size = new System.Drawing.Size(241, 20);
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
            this.cbDataFilterFields.Size = new System.Drawing.Size(181, 21);
            this.cbDataFilterFields.TabIndex = 4;
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
            this.gridData.Location = new System.Drawing.Point(250, 0);
            this.gridData.Name = "gridData";
            this.gridData.ReadOnly = true;
            this.gridData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridData.RowHeadersVisible = false;
            this.gridData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridData.ShowEditingIcon = false;
            this.gridData.Size = new System.Drawing.Size(350, 400);
            this.gridData.TabIndex = 2;
            this.gridData.DoubleClick += new System.EventHandler(this.gridData_DoubleClick);
            this.gridData.Resize += new System.EventHandler(this.gridData_Resize);
            // 
            // DBGridList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridData);
            this.Controls.Add(this.panelDataFilter);
            this.Name = "DBGridList";
            this.Size = new System.Drawing.Size(600, 400);
            this.panelDataFilter.ResumeLayout(false);
            this.panelDataFilter.PerformLayout();
            this.panelDataFilterOperator.ResumeLayout(false);
            this.panelDataFilterOperator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDataFilter;
        private System.Windows.Forms.Panel panelDataFilterList;
        private System.Windows.Forms.Panel panelDataFilterOperator;
        private System.Windows.Forms.Button btnDataFilterAdd;
        private System.Windows.Forms.TextBox txtDataFilterValue;
        private System.Windows.Forms.ComboBox cbDataFilterOperator;
        private System.Windows.Forms.ComboBox cbDataFilterFields;
        private System.Windows.Forms.DataGridView gridData;
    }
}
