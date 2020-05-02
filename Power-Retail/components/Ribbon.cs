using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PowerRetail.components
{
    public partial class Ribbon : UserControl
    {
        private string activeRibbon;
        private List<string> ribbonGroupName = new List<string>();
        [Browsable(false), DisplayName("RibbonGroups")]
        [Description("Group of ribbon button menu")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string[] ribbonGroupArray
        {
            get
            {
                return ribbonGroupName.ToArray();
            }
            set
            {
                ribbonGroupName.Clear();
                if (value != null)
                {
                    ribbonGroupName.AddRange(value);
                }
            }
        }

        public event EventHandler ribbonMenu_Clicked;
        public Ribbon()
        {
            InitializeComponent();
            activeRibbon = "";
        }

        public void hideAllRibbonMenu()
        {
            string currentActiveRibbon="";
            foreach (Control c in panelRibbonMenu.Controls)
            {
                if (c is Panel)
                {
                    if (c.Equals(panelRibbonMenu.Controls[panelRibbonMenu.Controls.Count - 1]))
                    {
                        currentActiveRibbon = c.Tag.ToString();
                        c.Visible = true;
                    }
                    else
                        c.Visible = false;
                }
            }
            if(currentActiveRibbon!="")
                showRibbonMenu(currentActiveRibbon);
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

        public void addRibbonGroup(string name, string[] buttons)
        {
            int spIndex = 0;
            Button b = new Button();
            b.Name = "btn" + name;
            b.Text = name;
            b.Tag = name;
            b.Dock = DockStyle.Left;
            b.Width = 100;
            b.FlatAppearance.BorderSize = 0;
            b.FlatStyle = FlatStyle.Flat;
            b.Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Bold);
            b.TextAlign = ContentAlignment.MiddleLeft;
            b.Click += new EventHandler(btnRibbonGroup_Click);
            panelRibbonGroup.Controls.Add(b);

            Panel p = new Panel();
            p.Name = "panel" + name;
            p.Tag = name;
            p.Dock = DockStyle.Left;
            p.AutoSize = true;
            panelRibbonMenu.Controls.Add(p);

            foreach (string s in buttons)
            {
                if (s.Equals("-"))
                {
                    b = new Button();
                    b.Name = "btn" + name + spIndex.ToString();
                    b.Text = "";
                    b.Tag = name;
                    b.Dock = DockStyle.Left;
                    b.Width = 1;
                    b.BackColor = Color.Gainsboro;
                    b.FlatAppearance.BorderSize = 0;
                    b.FlatStyle = FlatStyle.Flat;
                }
                else
                {
                    b = new Button();
                    b.Name = "btn" + s;
                    b.Text = s;
                    b.Tag = name;
                    b.Dock = DockStyle.Left;
                    b.Width = 60;
                    b.FlatAppearance.BorderSize = 0;
                    b.FlatStyle = FlatStyle.Flat;
                    b.TextAlign = ContentAlignment.MiddleCenter;
                    b.Click += new EventHandler(btnRibbonMenu_Click);
                }
                p.Controls.Add(b);
            }
        }

        private void btnRibbonGroup_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            showRibbonMenu(button.Tag.ToString());
        }

        private void btnRibbonMenu_Click(object sender, EventArgs e)
        {
            if (ribbonMenu_Clicked != null)
                ribbonMenu_Clicked(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
