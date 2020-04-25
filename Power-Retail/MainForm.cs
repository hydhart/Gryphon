using PowerRetail.classes;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PowerRetail
{
    public partial class MainForm : Form
    {
        SqlConnection myDBConnection = null;

        public MainForm()
        {
            Application.Run(new Splash());
            Application.Run(new Login());

            InitializeComponent();

            //ConstructMenu();
            AppMenu.ConstructMenu(this);
            ConstructLogo();
        }

        private void ConstructLogo()
        {
            Panel PanelLogo = new Panel();
            PanelLogo.Parent = panelLeft;
            PanelLogo.Tag = "000";
            PanelLogo.Size = new Size(200, 100);
            PanelLogo.Dock = DockStyle.Top;
            panelLeft.Controls.Add(PanelLogo);

            PictureBox PicLogo = new PictureBox();
            //Image ImgLogo1 = Image.FromHbitmap()
            Image ImgLogo = Image.FromFile(".\\resources\\CompanyLogo.jpg");
            PicLogo.Image = ImgLogo;
            PicLogo.Size = new Size(200, 100);
            PanelLogo.Controls.Add(PicLogo);            
        }

        private void ConstructMenu()
        {
            Panel panelSubmenu;
            Button btnMenu;
            Button btnSubmenu;

            // POS Menu
            panelSubmenu = new Panel();
            panelSubmenu.Parent = panelLeft;
            panelSubmenu.Name = "Panel002";
            panelSubmenu.Dock = DockStyle.Top;
            panelSubmenu.Tag = "002000";
            panelSubmenu.AutoSize = true;
            panelSubmenu.Visible = false;
            panelLeft.Controls.Add(panelSubmenu);

            btnMenu = new Button();
            btnMenu.Parent = panelLeft;
            btnMenu.Name = "Btn002";
            btnMenu.Text = "POS";
            btnMenu.Tag = "002000";
            btnMenu.Dock = DockStyle.Top;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.BackColor = Color.Gray;
            btnMenu.ForeColor = Color.White;
            btnMenu.Font = new Font(new FontFamily("Microsoft Sans Serif"), 10, FontStyle.Bold);
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.Size = new Size(200, 40);
            btnMenu.Click += new EventHandler(btnMenuClicked);
            panelLeft.Controls.Add(btnMenu);

            btnSubmenu = new Button();
            btnSubmenu.Parent = panelSubmenu;
            btnSubmenu.Name = "Btn002002";
            btnSubmenu.Text = "POS 002002";
            btnSubmenu.Tag = "002002";
            btnSubmenu.Dock = DockStyle.Top;
            btnSubmenu.FlatStyle = FlatStyle.Flat;
            btnSubmenu.FlatAppearance.BorderSize = 0;
            btnSubmenu.BackColor = Color.Silver;
            btnSubmenu.ForeColor = Color.White;
            btnSubmenu.Font = new Font(new FontFamily("Microsoft Sans Serif"), 9, FontStyle.Bold);
            btnSubmenu.TextAlign = ContentAlignment.MiddleLeft;
            btnSubmenu.Padding = new Padding(15, 0, 0, 0);
            btnSubmenu.Size = new Size(200, 30);
            btnSubmenu.Click += new EventHandler(btnSubmenuClicked);
            panelSubmenu.Controls.Add(btnSubmenu);

            btnSubmenu = new Button();
            btnSubmenu.Parent = panelSubmenu;
            btnSubmenu.Name = "Btn002001";
            btnSubmenu.Text = "POS 002001";
            btnSubmenu.Tag = "002001";
            btnSubmenu.Dock = DockStyle.Top;
            btnSubmenu.FlatStyle = FlatStyle.Flat;
            btnSubmenu.FlatAppearance.BorderSize = 0;
            btnSubmenu.BackColor = Color.Silver;
            btnSubmenu.ForeColor = Color.White;
            btnSubmenu.Font = new Font(new FontFamily("Microsoft Sans Serif"), 9, FontStyle.Bold);
            btnSubmenu.TextAlign = ContentAlignment.MiddleLeft;
            btnSubmenu.Padding = new Padding(15, 0, 0, 0);
            btnSubmenu.Size = new Size(200, 30);
            btnSubmenu.Click += new EventHandler(btnSubmenuClicked);
            panelSubmenu.Controls.Add(btnSubmenu);

            // Back Office
            panelSubmenu = new Panel();
            panelSubmenu.Parent = panelLeft;
            panelSubmenu.Name = "Panel001";
            panelSubmenu.Dock = DockStyle.Top;
            panelSubmenu.Tag = "001000";
            panelSubmenu.AutoSize = true;
            panelSubmenu.Visible = false;
            panelLeft.Controls.Add(panelSubmenu);

            btnMenu = new Button();
            btnMenu.Parent = panelLeft;
            btnMenu.Name = "Btn001";
            btnMenu.Text = "Back Office";
            btnMenu.Tag = "001000";
            btnMenu.Dock = DockStyle.Top;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.BackColor = Color.Gray;
            btnMenu.ForeColor = Color.White;
            btnMenu.Font = new Font(new FontFamily("Microsoft Sans Serif"), 10, FontStyle.Bold);
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.Size = new Size(200, 40);
            btnMenu.Click += new EventHandler(btnMenuClicked);
            panelLeft.Controls.Add(btnMenu);

            btnSubmenu = new Button();
            btnSubmenu.Parent = panelSubmenu;
            btnSubmenu.Name = "Btn001002";
            btnSubmenu.Text = "Back Office 001002";
            btnSubmenu.Tag = "001002";
            btnSubmenu.Dock = DockStyle.Top;
            btnSubmenu.FlatStyle = FlatStyle.Flat;
            btnSubmenu.FlatAppearance.BorderSize = 0;
            btnSubmenu.BackColor = Color.Silver;
            btnSubmenu.ForeColor = Color.White;
            btnSubmenu.Font = new Font(new FontFamily("Microsoft Sans Serif"), 9, FontStyle.Bold);
            btnSubmenu.TextAlign = ContentAlignment.MiddleLeft;
            btnSubmenu.Padding = new Padding(15,0,0,0);
            btnSubmenu.Size = new Size(200, 30);
            btnSubmenu.Click += new EventHandler(btnSubmenuClicked);
            panelSubmenu.Controls.Add(btnSubmenu);

            btnSubmenu = new Button();
            btnSubmenu.Parent = panelSubmenu;
            btnSubmenu.Name = "Btn001001";
            btnSubmenu.Text = "Back Office 001001";
            btnSubmenu.Tag = "001001";
            btnSubmenu.Dock = DockStyle.Top;
            btnSubmenu.FlatStyle = FlatStyle.Flat;
            btnSubmenu.FlatAppearance.BorderSize = 0;
            btnSubmenu.BackColor = Color.Silver;
            btnSubmenu.ForeColor = Color.White;
            btnSubmenu.Font = new Font(new FontFamily("Microsoft Sans Serif"), 9, FontStyle.Bold);
            btnSubmenu.TextAlign = ContentAlignment.MiddleLeft;
            btnSubmenu.Padding = new Padding(15, 0, 0, 0);
            btnSubmenu.Size = new Size(200, 30);
            btnSubmenu.Click += new EventHandler(btnSubmenuClicked);
            panelSubmenu.Controls.Add(btnSubmenu);
        }

        public void btnMenuClicked(object sender, EventArgs eD)
        {
            Button button = sender as Button;
            foreach(Control c in panelLeft.Controls)
            {
                if(c is Panel)
                {
                    if (c.Tag == button.Tag)
                        c.Visible = true;
                    else if (c.Tag.ToString() != "000")
                        c.Visible = false;
                }
            }
        }

        public void btnSubmenuClicked(object sender, EventArgs eD)
        {
            Button button = sender as Button;
            string formName = button.AccessibleName;
            //var formChild = Activator.CreateInstance(Type.GetType(formName)) as Form;
            showChildForm(AppTools.GetFormByName(formName)); // new Form1());
            //MessageBox.Show(button.Tag.ToString());
        }

        private Form activeForm = null;
        private void showChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            activeForm.TopLevel = false;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            activeForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(activeForm);
            activeForm.Show();
        }
    }
}
