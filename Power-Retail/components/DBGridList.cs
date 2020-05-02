using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using PowerRetail.classes;
using System.ComponentModel;

namespace PowerRetail.components
{
    public partial class DBGridList : UserControl
    {
        private DataTable dataTable = null;
        private List<string> dataFilter = new List<string>();

        [Browsable(false)]
        [Description("Primary key to distinguish the row")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int[] key { set; get; }
        [Browsable(false)]
        [Description("Column width in percentage")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int[] columnWidth { set; get; }
        [Browsable(false)]
        [Description("list of column")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string columnData { set; get; }
        [Browsable(false)]
        [Description("Source table")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string tableData { set; get;  }
        [Browsable(false)]
        [Description("Source table filter")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string tableFilter { set; get; }

        public event EventHandler grid_DoubleClicked;

        public DBGridList()
        {
            InitializeComponent();
            panelDataFilter.Visible = false;
            columnData = null;
            tableData = null;
            tableFilter = null;
        }

        public void loadData()
        {
            if((columnData != null) && (tableData != null))
            {
                SqlDataReader reader;
                if (tableFilter!=null)
                    reader = SQL.ExecCommand("SELECT " + columnData + " FROM [" + tableData + "] WHERE " + tableFilter);
                else
                    reader = SQL.ExecCommand("SELECT " + columnData + " FROM [" + tableData + "]");
                dataTable = new DataTable();
                DataRow row = dataTable.NewRow();
                cbDataFilterFields.Items.Clear();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    dataTable.Columns.Add(reader.GetName(i));
                    cbDataFilterFields.Items.Add(reader.GetName(i));
                }

                while (reader.Read())
                {
                    row = dataTable.NewRow();
                    for (int i = 0; i < reader.FieldCount; i++)
                        row[reader.GetName(i)] = reader[i].ToString();

                    dataTable.Rows.Add(row);
                }
                updateColumnSize();
            }
        }

        public string[] getKey()
        {
            DataGridViewRow row = gridData.CurrentRow;
            List<string> currKey = new List<string>();
            for(int i=0; i<key.Count(); i++)
            {
                currKey.Add(row.Cells[i].Value.ToString());
            }
            return currKey.ToArray();
        }

        private void clearDataFilterField()
        {
            for (int i = 0; i < cbDataFilterFields.Items.Count; i++)
                cbDataFilterFields.Items.RemoveAt(i);
        }

        private void clearFilterText()
        {
            cbDataFilterFields.ResetText();
            cbDataFilterOperator.ResetText();
            txtDataFilterValue.Clear();
        }

        private void clearData()
        {
            for (int i = 0; i < dataTable.Rows.Count; i++)
                dataTable.Rows[i].Delete();
        }

        public void ClearFilter()
        {
            clearFilterText();
            clearDataFilter();
            clearDataFilterField();
            panelDataFilterList.Controls.Clear();
            loadData();
        }

        public void RefreshData()
        {
            loadData();
            showFilters();
        }

        public void hideShowFilter()
        {
            panelDataFilter.Visible = !panelDataFilter.Visible;
        }

        private void clearDataFilter()
        {
            dataTable.DefaultView.RowFilter = "";
        }

        private string buildDataFilter()
        {
            string returnValue = "";
            for (int i = 0; i < dataFilter.Count(); i++)
            {
                if (i > 0)
                    returnValue = returnValue + " AND " + dataFilter[i];
                else
                    returnValue = dataFilter[i];
            }

            return returnValue;
        }

        private void showFilters()
        {
            Panel panelFilterItem;
            Button btnDeleteFilterItem;
            TextBox txtFilterItem;

            panelDataFilterList.Controls.Clear();
            for (int i = dataFilter.Count() - 1; i >= 0; i--)
            {
                panelFilterItem = new Panel();
                panelFilterItem.Name = "PanelFilterItem" + i;
                panelFilterItem.Height = 30;
                panelFilterItem.Dock = DockStyle.Top;
                panelDataFilterList.Controls.Add(panelFilterItem);

                txtFilterItem = new TextBox();
                txtFilterItem.Name = "txtFilterItem" + i;
                txtFilterItem.Text = dataFilter[i].ToString();
                txtFilterItem.Multiline = true;
                txtFilterItem.ReadOnly = true;
                txtFilterItem.BorderStyle = BorderStyle.None;
                txtFilterItem.Width = panelFilterItem.Width - 50;
                txtFilterItem.Dock = DockStyle.Left;
                panelFilterItem.Controls.Add(txtFilterItem);

                btnDeleteFilterItem = new Button();
                btnDeleteFilterItem.Name = "btnDeleteFilterItem" + i;
                btnDeleteFilterItem.Tag = i;
                btnDeleteFilterItem.Text = "X";
                btnDeleteFilterItem.Width = 30;
                btnDeleteFilterItem.Height = 30;
                btnDeleteFilterItem.FlatAppearance.BorderSize = 0;
                btnDeleteFilterItem.FlatStyle = FlatStyle.Flat;
                btnDeleteFilterItem.Dock = DockStyle.Left;
                btnDeleteFilterItem.Click += new EventHandler(btnDeleteFilterItem_Click);
                panelFilterItem.Controls.Add(btnDeleteFilterItem);
            }
            dataTable.DefaultView.RowFilter = buildDataFilter();
        }

        private void updateDataFilter()
        {
            if (!txtDataFilterValue.Text.Equals(""))
            {
                string filter;
                if (cbDataFilterOperator.Text.Equals("LIKE"))
                    filter = string.Format("[{0}] LIKE {1}", cbDataFilterFields.Text, txtDataFilterValue.Text);
                else if (cbDataFilterOperator.Text.Equals("IN"))
                    filter = string.Format("[{0}] IN ({1})", cbDataFilterFields.Text, txtDataFilterValue.Text);
                else
                    filter = string.Format("[{0}] {1] {2}", cbDataFilterFields.Text, cbDataFilterOperator.Text, txtDataFilterValue.Text);

                int newIndex;
                if (dataFilter == null)
                    newIndex = 0;
                else
                    newIndex = dataFilter.Count() + 1;
                dataFilter.Add(filter);
                showFilters();
            }
        }

        private void updateColumnSize()
        {
            gridData.DataSource = dataTable;
            for (int i = 0; i < gridData.Columns.Count; i++)
                gridData.Columns[i].Width = columnWidth[i] * gridData.Width / 100;
        }

        private void gridData_Resize(object sender, EventArgs e)
        {
            updateColumnSize();
        }

        private void gridData_DoubleClick(object sender, EventArgs e)
        {
            if (grid_DoubleClicked != null)
                grid_DoubleClicked(sender, e);
        }

        private void btnDataFilterAdd_Click(object sender, EventArgs e)
        {
            updateDataFilter();
        }

        private void btnDeleteFilterItem_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            int index = Int32.Parse(b.Tag.ToString());
            dataFilter.RemoveAt(index);
            showFilters();
        }
    }
}
