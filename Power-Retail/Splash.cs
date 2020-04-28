using PowerRetail.classes;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PowerRetail
{
    public partial class Splash : Form
    {
        Timer splashTimer;
        private const int SPLASH_DURATION = 10;
        private int tickCount;

        public Splash()
        {
            InitializeComponent();
            splashTimer = new Timer();
            splashTimer.Tick += new EventHandler(SplashTimer_Tick);
            splashTimer.Enabled = true;
        }

        public Splash(Form main)
        {
            InitializeComponent();
            splashTimer = new Timer();
            splashTimer.Tick += new EventHandler(SplashTimer_Tick);
            splashTimer.Enabled = true;
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            UpdateAnimation();
        }

        private void UpdateAnimation()
        {
            if (tickCount % 10 == 0)
            {
                label1.Text = "Loading configuration.";
            }
            else if (tickCount % 10 == 1)
            {
                label1.Text = "Loading configuration...";
            }
            else if (tickCount % 10 == 2)
            {
                label1.Text = "Loading configuration.....";
            }
            else if (tickCount % 10 == 3)
            {
                label1.Text = "Loading configuration.......";
            }
            else if (tickCount % 10 == 4)
            {
                label1.Text = "Loading configuration.........";
            }
            else if (tickCount % 10 == 5)
            {
                label1.Text = "Loading configuration...........";
            }
            else if (tickCount % 10 == 6)
            {
                label1.Text = "Loading configuration.............";
            }
            else if (tickCount % 10 == 7)
            {
                label1.Text = "Loading configuration...............";
            }
            else if (tickCount % 10 == 8)
            {
                label1.Text = "Loading configuration.................";
            }
            else if (tickCount % 10 == 9)
            {
                label1.Text = "Loading configuration...................";
            }

            tickCount++;
            label2.Text = SPLASH_DURATION + " | " + tickCount.ToString();
            if (tickCount > SPLASH_DURATION) //change here if you have more image, the idea is to set a cycle of images
            {
                splashTimer.Enabled = false;
                Close();
            }
            this.Refresh();
        }
    }
}
