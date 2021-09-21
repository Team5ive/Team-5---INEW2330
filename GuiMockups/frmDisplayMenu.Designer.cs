namespace GuiMockups
{
    partial class frmDisplayMenu
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
            this.lblFancy = new System.Windows.Forms.Label();
            this.lblDarkBanner = new System.Windows.Forms.Label();
            this.pbxMenu = new System.Windows.Forms.PictureBox();
            this.pbxShell = new System.Windows.Forms.PictureBox();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShell)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFancy
            // 
            this.lblFancy.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFancy.Font = new System.Drawing.Font("Palace Script MT", 50F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFancy.ForeColor = System.Drawing.Color.Gold;
            this.lblFancy.Location = new System.Drawing.Point(71, 0);
            this.lblFancy.Name = "lblFancy";
            this.lblFancy.Size = new System.Drawing.Size(152, 74);
            this.lblFancy.TabIndex = 8;
            this.lblFancy.Text = "Fancy!";
            this.lblFancy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDarkBanner
            // 
            this.lblDarkBanner.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDarkBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDarkBanner.Location = new System.Drawing.Point(-1, 0);
            this.lblDarkBanner.Name = "lblDarkBanner";
            this.lblDarkBanner.Size = new System.Drawing.Size(1111, 74);
            this.lblDarkBanner.TabIndex = 9;
            // 
            // pbxMenu
            // 
            this.pbxMenu.Image = global::GuiMockups.Properties.Resources.menu;
            this.pbxMenu.Location = new System.Drawing.Point(-1, 75);
            this.pbxMenu.Name = "pbxMenu";
            this.pbxMenu.Size = new System.Drawing.Size(1111, 509);
            this.pbxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMenu.TabIndex = 11;
            this.pbxMenu.TabStop = false;
            // 
            // pbxShell
            // 
            this.pbxShell.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbxShell.Image = global::GuiMockups.Properties.Resources.shell_1;
            this.pbxShell.Location = new System.Drawing.Point(3, 2);
            this.pbxShell.Name = "pbxShell";
            this.pbxShell.Size = new System.Drawing.Size(76, 72);
            this.pbxShell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxShell.TabIndex = 10;
            this.pbxShell.TabStop = false;
            // 
            // lblSignIn
            // 
            this.lblSignIn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.ForeColor = System.Drawing.Color.Gold;
            this.lblSignIn.Location = new System.Drawing.Point(924, 26);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(69, 20);
            this.lblSignIn.TabIndex = 12;
            this.lblSignIn.Text = "Sign In";
            // 
            // lblHome
            // 
            this.lblHome.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.Gold;
            this.lblHome.Location = new System.Drawing.Point(1027, 26);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(69, 20);
            this.lblHome.TabIndex = 12;
            this.lblHome.Text = "Home";
            // 
            // frmDisplayMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 583);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.lblSignIn);
            this.Controls.Add(this.pbxMenu);
            this.Controls.Add(this.pbxShell);
            this.Controls.Add(this.lblFancy);
            this.Controls.Add(this.lblDarkBanner);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDisplayMenu";
            this.Text = "frmDisplayMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShell)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxShell;
        private System.Windows.Forms.Label lblFancy;
        private System.Windows.Forms.Label lblDarkBanner;
        private System.Windows.Forms.PictureBox pbxMenu;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Label lblHome;
    }
}