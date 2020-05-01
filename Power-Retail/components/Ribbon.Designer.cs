namespace PowerRetail.components
{
    partial class Ribbon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.panelRibbonMenu = new System.Windows.Forms.Panel();
            this.panelRibbonGroup = new System.Windows.Forms.Panel();
            this.panelRibbonGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(270, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Tag = "#CLOSE";
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelRibbonMenu
            // 
            this.panelRibbonMenu.BackColor = System.Drawing.Color.Silver;
            this.panelRibbonMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRibbonMenu.Location = new System.Drawing.Point(0, 30);
            this.panelRibbonMenu.Name = "panelRibbonMenu";
            this.panelRibbonMenu.Size = new System.Drawing.Size(300, 60);
            this.panelRibbonMenu.TabIndex = 4;
            // 
            // panelRibbonGroup
            // 
            this.panelRibbonGroup.BackColor = System.Drawing.Color.Gainsboro;
            this.panelRibbonGroup.Controls.Add(this.btnClose);
            this.panelRibbonGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRibbonGroup.Location = new System.Drawing.Point(0, 0);
            this.panelRibbonGroup.Name = "panelRibbonGroup";
            this.panelRibbonGroup.Size = new System.Drawing.Size(300, 30);
            this.panelRibbonGroup.TabIndex = 3;
            // 
            // Ribbon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelRibbonMenu);
            this.Controls.Add(this.panelRibbonGroup);
            this.Name = "Ribbon";
            this.Size = new System.Drawing.Size(300, 90);
            this.panelRibbonGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelRibbonMenu;
        private System.Windows.Forms.Panel panelRibbonGroup;
    }
}
