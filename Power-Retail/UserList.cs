using System;
using System.Windows.Forms;

namespace PowerRetail
{
    public partial class UserList : Form
    {
        private const string PRODUCT_NAME = "Power Retail";
        private const string FORM_CAPTION = "Item Card";

        public UserList()
        {
            InitializeComponent();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            ribbonMenu.ribbonGroupArray = new string[2];
            ribbonMenu.addRibbonGroup("Navigate", new string[] { "Permission" });
            ribbonMenu.addRibbonGroup("Manage", new string[] { "Refresh", "-", "Clear Filter", "Filter", "-", "Delete", "View", "Edit", "-", "New" });
            ribbonMenu.hideAllRibbonMenu();
            
            dbGridListUser.columnWidth = new int[]{ 20, 79 };
            dbGridListUser.key = new int[] { 0 };
            dbGridListUser.columnData = "[UserID] as [User ID], [Name]";
            dbGridListUser.tableData = "User";
            dbGridListUser.loadData();

        }

        private void UserList_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = ParentForm as MainForm;
            mainForm.Text = PRODUCT_NAME;
            mainForm.activeListForm = null;
        }

        private void ribbonMenu_ribbonMenu_Clicked(object sender, EventArgs e)
        {
            Button b = sender as Button;
            switch(b.Text.ToLower())
            {
                case "new": break;
                case "edit": MessageBox.Show(dbGridListUser.getKey()[0].ToString()); break;
                case "view": MessageBox.Show(dbGridListUser.getKey()[0].ToString()); break;
                case "delete": MessageBox.Show(dbGridListUser.getKey()[0].ToString()); break;
                case "filter": dbGridListUser.hideShowFilter(); break;
                case "clear filter": dbGridListUser.ClearFilter(); break;
                case "refresh": dbGridListUser.RefreshData(); break;
                case "permission": break;
            }
        }

        private void dbGridListUser_grid_DoubleClicked(object sender, EventArgs e)
        {
            MessageBox.Show(dbGridListUser.getKey()[0].ToString());
        }
    }
}
