using PowerRetail.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerRetail
{
    public partial class ItemList : Form
    {
        private const string RIBBON_MANAGE = "#MANAGE";
        //private const string RIBBON_NAVIGATE = "#NAVIGATE";
        //private const string RIBBON_REPORT = "#REPORT";
        private string activeRibbon;
        private int[] columnWidth = { 15, 30, 39, 15 };
        private string columnData = "[MenuID] as [Menu ID], [Name], [Caption], [ParentID] as [Parent ID]";
        private string tableData = "ApplicationMenu";
        //private string columnData = "[No],[Description],[SearchDescription] as [Search Description], [ItemCategoryID] as [Category ID], [UnitPrice] as [Unit Price], [Blocked]";
        //private string tableData = "Item";
        private DataTable dataTable;
        private string[] dataFilter;


        public ItemList()
        {
            InitializeComponent();
            hideAllRibbonMenu();
            activeRibbon = "";
            showRibbonMenu(RIBBON_MANAGE);
            panelDataFilter.Visible = false;
            loadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hideAllRibbonMenu()
        {
            foreach (Control c in panelRibbonMenu.Controls)
            {
                if (c is Panel)
                    c.Visible = false;
            }
        }
        private void showRibbonMenu(string newActiveRibbon)
        {
            if (newActiveRibbon != activeRibbon)
            {
                string oldRibbon = activeRibbon;
                activeRibbon = newActiveRibbon;
                foreach (Control c in panelRibbonMenu.Controls)
                {
                    if (c is Panel)
                    {
                        if (c.Tag.ToString().Equals(oldRibbon))
                            c.Visible = false;
                        else if (c.Tag.ToString().Equals(activeRibbon))
                            c.Visible = true;
                    }
                }
                foreach (Control c in panelRibbonGroup.Controls)
                {
                    if (c is Button)
                    {
                        if (c.Tag.ToString().Equals(oldRibbon))
                            c.BackColor = Color.Gainsboro;
                        else if (c.Tag.ToString().Equals(activeRibbon))
                            c.BackColor = Color.Silver;
                    }
                }
            }
        }

        private void loadData()
        {
            SqlDataReader reader = SQL.ExecCommand("SELECT " + columnData + " FROM [" + tableData + "]");
            dataTable = new DataTable();
            DataRow row = dataTable.NewRow();

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
        }

        private void clearDataFilterField()
        {
            for (int i=0; i<cbDataFilterFields.Items.Count; i++)
                cbDataFilterFields.Items.RemoveAt(i);
        }

        private void clearData()
        {
            for(int i=0; i<dataTable.Rows.Count; i++)
                dataTable.Rows[i].Delete();
        }

        private void hideShowFilter()
        {
            panelDataFilter.Visible = !panelDataFilter.Visible;
        }

        private void clearDataFilter()
        {
            dataTable.DefaultView.RowFilter = "";
        }

        private void updateDataFilter()
        {
            if (!txtDataFilterValue.Text.Equals(""))
            {
                string filter;
                if (cbDataFilterOperator.Text.Equals("LIKE"))
                    filter = string.Format("[{0}] LIKE '{1}'", cbDataFilterFields.Text, txtDataFilterValue.Text);
                else if (cbDataFilterOperator.Text.Equals("IN"))
                    filter = string.Format("[{0}] IN ({1})", cbDataFilterFields.Text, txtDataFilterValue.Text);
                else
                    filter = string.Format("[{0}] {1] '{2}'", cbDataFilterFields.Text, cbDataFilterOperator.Text, txtDataFilterValue.Text);
                dataTable.DefaultView.RowFilter = filter;
                //MessageBox.Show(dataTable.DefaultView.RowFilter);
            }
        }

        private void btnRibbonGroupManage_Click(object sender, EventArgs e)
        {
            showRibbonMenu(btnRibbonGroupManage.Tag.ToString());
        }

        private void btnRibbonGroupNavigate_Click(object sender, EventArgs e)
        {
            showRibbonMenu(btnRibbonGroupNavigate.Tag.ToString());
        }

        private void btnRibbonGroupReport_Click(object sender, EventArgs e)
        {
            showRibbonMenu(btnRibbonGroupReport.Tag.ToString());
        }

        private void btnRibbonManageFilter_Click(object sender, EventArgs e)
        {
            hideShowFilter();
        }

        private void btnRibbonManageView_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = gridData.CurrentRow;
            MessageBox.Show(row.Cells[0].Value.ToString());
        }

        private void btnDataFilterAdd_Click(object sender, EventArgs e)
        {
            updateDataFilter();
        }

        private void btnRibbonManageClearFilter_Click(object sender, EventArgs e)
        {
            clearDataFilter();
        }

        private void gridData_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow row = gridData.CurrentRow;
            MessageBox.Show(row.Cells[0].Value.ToString());
        }

        private void btnRibbonManageRefresh_Click(object sender, EventArgs e)
        {
            clearDataFilterField();
            clearData();
            loadData();
            updateDataFilter();
        }

        private void gridData_Resize(object sender, EventArgs e)
        {
            gridData.DataSource = dataTable;
            for (int i = 0; i < gridData.Columns.Count; i++)
                gridData.Columns[i].Width = columnWidth[i] * gridData.Width / 100;

        }
    }
}
