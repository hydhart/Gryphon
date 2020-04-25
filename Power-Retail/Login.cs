using PowerRetail.classes;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PowerRetail
{
    public partial class Login : Form
    {
        SqlConnection myDBConnection = null;

        public Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader reader = SQL.ExecCommand("SELECT [Password] FROM [User] WHERE UserID='" + txtUserID.Text + "'");
                if (reader.HasRows)
                {
                    if (reader.Read())
                        if (reader["Password"].ToString().Equals(txtPassword.Text))
                            this.Close();
                        else
                            labelMessageText.Text = "Invalid User ID or Password.";
                }
                else
                {
                    labelMessageText.Text = "Invalid User ID or Password.";
                    //Application.Exit();
                }
                SQL.CloseConnection();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            labelMessageText.Text = "";
            txtUserID.Text = "";
            txtPassword.Text = "";
        }
    }
}
