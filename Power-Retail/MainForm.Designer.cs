namespace PowerRetail
{
    partial class MainForm
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnToggleHideShowMenu = new System.Windows.Forms.Button();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.AutoScroll = true;
            this.panelLeft.BackColor = System.Drawing.Color.Gray;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(220, 699);
            this.panelLeft.TabIndex = 0;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.Gray;
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 699);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1008, 30);
            this.panelFooter.TabIndex = 1;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.panelChildForm);
            this.panelContent.Controls.Add(this.btnToggleHideShowMenu);
            this.panelContent.Controls.Add(this.panelLeft);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1008, 699);
            this.panelContent.TabIndex = 2;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(230, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(778, 699);
            this.panelChildForm.TabIndex = 2;
            // 
            // btnToggleHideShowMenu
            // 
            this.btnToggleHideShowMenu.BackColor = System.Drawing.Color.Gray;
            this.btnToggleHideShowMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnToggleHideShowMenu.FlatAppearance.BorderSize = 0;
            this.btnToggleHideShowMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleHideShowMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleHideShowMenu.Location = new System.Drawing.Point(220, 0);
            this.btnToggleHideShowMenu.Name = "btnToggleHideShowMenu";
            this.btnToggleHideShowMenu.Size = new System.Drawing.Size(10, 699);
            this.btnToggleHideShowMenu.TabIndex = 1;
            this.btnToggleHideShowMenu.Text = "<\r\n";
            this.btnToggleHideShowMenu.UseVisualStyleBackColor = false;
            this.btnToggleHideShowMenu.Click += new System.EventHandler(this.btnToggleHideShowMenu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelFooter);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Power Retail";
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelContent;
        public System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnToggleHideShowMenu;
    }
}

