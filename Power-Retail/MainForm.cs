using PowerRetail.classes;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PowerRetail
{
    public partial class MainForm : Form
    {
        public Form activeListForm { set; get; }
        public Form activeCardForm { set; get; }
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
            showListForm(AppTools.GetFormByName(formName));
        }

        public void showListForm(Form childForm)
        {
            if (activeCardForm != null)
                activeCardForm.Close();
            if (childForm != null)
            {
                if (activeListForm != null)
                {
                    if (childForm.Name.ToString() != activeListForm.Name.ToString())
                    {
                        activeListForm.Close();
                        activeListForm = childForm;
                        activeListForm.TopLevel = false;
                        activeListForm.FormBorderStyle = FormBorderStyle.None;
                        activeListForm.Dock = DockStyle.Fill;
                        panelChildForm.Controls.Add(activeListForm);
                        activeListForm.Show();
                    }
                }
                else
                {
                    activeListForm = childForm;
                    activeListForm.TopLevel = false;
                    activeListForm.FormBorderStyle = FormBorderStyle.None;
                    activeListForm.Dock = DockStyle.Fill;
                    panelChildForm.Controls.Add(activeListForm);
                    activeListForm.Show();
                }
            }
        }
        public void showCardForm(Form childForm)
        {
            if (childForm != null)
            {
                if (activeCardForm != null)
                {
                    if (childForm.Name.ToString() != activeCardForm.Name.ToString())
                    {
                        activeCardForm.Close();
                        activeCardForm = childForm;
                        activeCardForm.TopLevel = false;
                        activeCardForm.FormBorderStyle = FormBorderStyle.None;
                        activeCardForm.Dock = DockStyle.Fill;
                        panelChildForm.Controls.Add(activeCardForm);
                        activeCardForm.Show();
                        activeCardForm.BringToFront();
                    }
                }
                else
                {
                    activeCardForm = childForm;
                    activeCardForm.TopLevel = false;
                    activeCardForm.FormBorderStyle = FormBorderStyle.None;
                    activeCardForm.Dock = DockStyle.Fill;
                    panelChildForm.Controls.Add(activeCardForm);
                    activeCardForm.Show();
                    activeCardForm.BringToFront();
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
