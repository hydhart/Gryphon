namespace PowerRetail
{
    partial class ItemCard
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
            this.ribbon1 = new PowerRetail.components.Ribbon();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Name = "ribbon1";
            this.ribbon1.ribbonGroupArray = new string[0];
            this.ribbon1.Size = new System.Drawing.Size(762, 90);
            this.ribbon1.TabIndex = 0;
            // 
            // ItemCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 660);
            this.Controls.Add(this.ribbon1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemCard";
            this.Text = "ItemCard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ItemCard_FormClosing);
            this.Load += new System.EventHandler(this.ItemCard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private components.Ribbon ribbon1;
    }
}