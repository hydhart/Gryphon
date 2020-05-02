namespace PowerRetail
{
    partial class UserList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dbGridListUser = new PowerRetail.components.DBGridList();
            this.ribbonMenu = new PowerRetail.components.Ribbon();
            this.SuspendLayout();
            // 
            // dbGridListUser
            // 
            this.dbGridListUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbGridListUser.Location = new System.Drawing.Point(0, 90);
            this.dbGridListUser.Name = "dbGridListUser";
            this.dbGridListUser.Size = new System.Drawing.Size(778, 609);
            this.dbGridListUser.TabIndex = 1;
            this.dbGridListUser.grid_DoubleClicked += new System.EventHandler(this.dbGridListUser_grid_DoubleClicked);
            // 
            // ribbonMenu
            // 
            this.ribbonMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonMenu.Location = new System.Drawing.Point(0, 0);
            this.ribbonMenu.Name = "ribbonMenu";
            this.ribbonMenu.ribbonGroupArray = new string[0];
            this.ribbonMenu.Size = new System.Drawing.Size(778, 90);
            this.ribbonMenu.TabIndex = 0;
            this.ribbonMenu.ribbonMenu_Clicked += new System.EventHandler(this.ribbonMenu_ribbonMenu_Clicked);
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 699);
            this.Controls.Add(this.dbGridListUser);
            this.Controls.Add(this.ribbonMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserList";
            this.Text = "UserList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserList_FormClosing);
            this.Load += new System.EventHandler(this.UserList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private components.Ribbon ribbonMenu;
        private components.DBGridList dbGridListUser;
    }
}