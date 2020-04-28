using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerRetail.classes
{
    public static class AppMenu
    {
        public static void ConstructMenu(MainForm formParent)
        {
            Panel panelSubmenu;
            Button btnMenu;
            Button btnSubmenu;

            SqlDataReader parentMenuReader = SQL.ExecCommand("SELECT MenuID,[Name],Caption FROM ApplicationMenu WHERE Indentation = 1 ORDER BY MenuID DESC");
            if(parentMenuReader != null)
            //if (parentMenuReader.HasRows)
            {
                while (parentMenuReader.Read())
                {
                    panelSubmenu = new Panel();
                    panelSubmenu.Parent = formParent.panelLeft;
                    panelSubmenu.Name = "Panel" + parentMenuReader["MenuID"].ToString();
                    panelSubmenu.Dock = DockStyle.Top;
                    panelSubmenu.Tag = parentMenuReader["MenuID"].ToString();
                    panelSubmenu.AutoSize = true;
                    panelSubmenu.Visible = false;
                    formParent.panelLeft.Controls.Add(panelSubmenu);

                    btnMenu = new Button();
                    btnMenu.Parent = formParent.panelLeft;
                    btnMenu.Name =  "Btn" + parentMenuReader["MenuID"].ToString();
                    btnMenu.Text = parentMenuReader["Caption"].ToString();
                    btnMenu.Tag = parentMenuReader["MenuID"].ToString();
                    btnMenu.Dock = DockStyle.Top;
                    btnMenu.FlatStyle = FlatStyle.Flat;
                    btnMenu.FlatAppearance.BorderSize = 0;
                    btnMenu.BackColor = Color.Gray;
                    btnMenu.ForeColor = Color.White;
                    btnMenu.Font = new Font(new FontFamily("Microsoft Sans Serif"), 10, FontStyle.Bold);
                    btnMenu.TextAlign = ContentAlignment.MiddleLeft;
                    btnMenu.Size = new Size(220, 40);
                    btnMenu.Click += new EventHandler(formParent.btnMenuClicked);
                    formParent.panelLeft.Controls.Add(btnMenu);

                    SqlDataReader childMenuReader = SQL.ExecCommand("SELECT MenuID,[Name],Caption,ObjectName FROM ApplicationMenu WHERE ParentID = '" + parentMenuReader["MenuID"].ToString() + "' ORDER BY MenuID DESC");
                    if (childMenuReader != null)
                    {
                        while (childMenuReader.Read())
                        {
                            btnSubmenu = new Button();
                            btnSubmenu.Parent = panelSubmenu;
                            btnSubmenu.Name = "Btn" + childMenuReader["MenuID"].ToString();
                            btnSubmenu.Text = childMenuReader["Caption"].ToString();
                            btnSubmenu.Tag = childMenuReader["MenuID"].ToString();
                            btnSubmenu.Dock = DockStyle.Top;
                            btnSubmenu.FlatStyle = FlatStyle.Flat;
                            btnSubmenu.FlatAppearance.BorderSize = 0;
                            btnSubmenu.BackColor = Color.Silver;
                            btnSubmenu.ForeColor = Color.White;
                            btnSubmenu.Font = new Font(new FontFamily("Microsoft Sans Serif"), 9, FontStyle.Bold);
                            btnSubmenu.TextAlign = ContentAlignment.MiddleLeft;
                            btnSubmenu.Padding = new Padding(15, 0, 0, 0);
                            btnSubmenu.Size = new Size(220, 30);
                            btnSubmenu.Click += new EventHandler(formParent.btnSubmenuClicked);
                            btnSubmenu.AccessibleName = childMenuReader["ObjectName"].ToString().ToLower(); ;
                            panelSubmenu.Controls.Add(btnSubmenu);
                        }
                    }
                }
            }
        }
    }
}
