using PowerRetail.classes;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PowerRetail
{
    public partial class MainForm : Form
    {
        public Form activeForm { set; get; }
        public MainForm()
        {
            Application.Run(new Splash());
            Application.Run(new Login());

            InitializeComponent();

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
            showChildForm(AppTools.GetFormByName(formName));
            //showChildForm(new ItemList());
        }

        private void showChildForm(Form childForm)
        {
            if (childForm != null)
            {
                if (activeForm != null)
                {
                    if (childForm.Name.ToString() != activeForm.Name.ToString())
                    {
                        activeForm.Close();
                        activeForm = childForm;
                        activeForm.TopLevel = false;
                        activeForm.FormBorderStyle = FormBorderStyle.None;
                        activeForm.Dock = DockStyle.Fill;
                        panelChildForm.Controls.Add(activeForm);
                        activeForm.Show();
                    }
                }
                else
                {
                    activeForm = childForm;
                    activeForm.TopLevel = false;
                    activeForm.FormBorderStyle = FormBorderStyle.None;
                    activeForm.Dock = DockStyle.Fill;
                    panelChildForm.Controls.Add(activeForm);
                    activeForm.Show();
                }
            }
        }

        private void btnToggleHideShowMenu_Click(object sender, EventArgs e)
        {
            panelLeft.Visible = !panelLeft.Visible;
            if (btnToggleHideShowMenu.Text.Equals("<"))
                btnToggleHideShowMenu.Text = ">";
            else
                btnToggleHideShowMenu.Text = "<";
        }
    }
}
