using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerRetail
{
    public partial class ItemCard : Form
    {
        private const string PRODUCT_NAME = "Power Retail";
        private const string FORM_CAPTION = "Item Card";
        public ItemCard()
        {
            InitializeComponent();
        }

        private void ItemCard_Load(object sender, EventArgs e)
        {
            ribbon1.ribbonGroupArray = new string[2];
            ribbon1.addRibbonGroup("Report", new string[] { "Top 100 Sales", "Item List" });
            ribbon1.addRibbonGroup("Navigate", new string[] { "Category", "Unit of Measure", "Variant" });
            ribbon1.addRibbonGroup("Manage", new string[] { "Refresh", "-", "Clear Filter", "Filter", "-", "Delete", "View", "Edit", "-", "New" });
            ribbon1.hideAllRibbonMenu();
        }

        private void ItemCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = ParentForm as MainForm;
            mainForm.Text = PRODUCT_NAME;
            mainForm.activeCardForm = null;
        }
    }
}
