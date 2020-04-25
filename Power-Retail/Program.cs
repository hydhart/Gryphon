using System;
using System.Windows.Forms;

namespace PowerRetail
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Splash(new MainForm()));
            //Application.Run(new Splash());
            Application.Run(new MainForm());
        }
    }
}
