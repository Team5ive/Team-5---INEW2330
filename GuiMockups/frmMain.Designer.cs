
namespace GuiMockups
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblFineDiningSubtitle = new System.Windows.Forms.Label();
            this.lblFancyTitle = new System.Windows.Forms.Label();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuMainItmMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainItmSignLog = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainItmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainItmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxShell = new System.Windows.Forms.PictureBox();
            this.hlpFancy = new System.Windows.Forms.HelpProvider();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShell)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFineDiningSubtitle
            // 
            this.lblFineDiningSubtitle.AutoSize = true;
            this.lblFineDiningSubtitle.Font = new System.Drawing.Font("Vladimir Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineDiningSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.lblFineDiningSubtitle.Location = new System.Drawing.Point(116, 352);
            this.lblFineDiningSubtitle.Name = "lblFineDiningSubtitle";
            this.lblFineDiningSubtitle.Size = new System.Drawing.Size(475, 58);
            this.lblFineDiningSubtitle.TabIndex = 6;
            this.lblFineDiningSubtitle.Text = "Fine Dining and Breathing";
            // 
            // lblFancyTitle
            // 
            this.lblFancyTitle.AutoSize = true;
            this.lblFancyTitle.Font = new System.Drawing.Font("Vladimir Script", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFancyTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.lblFancyTitle.Location = new System.Drawing.Point(206, 35);
            this.lblFancyTitle.Name = "lblFancyTitle";
            this.lblFancyTitle.Size = new System.Drawing.Size(279, 116);
            this.lblFancyTitle.TabIndex = 4;
            this.lblFancyTitle.Text = "Fancy!";
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainItmMenu,
            this.mnuMainItmSignLog,
            this.mnuMainItmAbout,
            this.mnuMainItmHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.mnuMain.Size = new System.Drawing.Size(707, 24);
            this.mnuMain.TabIndex = 5;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuMainItmMenu
            // 
            this.mnuMainItmMenu.Name = "mnuMainItmMenu";
            this.mnuMainItmMenu.Size = new System.Drawing.Size(50, 22);
            this.mnuMainItmMenu.Text = "Menu";
            this.mnuMainItmMenu.Click += new System.EventHandler(this.mnuMainItmMenu_Click);
            // 
            // mnuMainItmSignLog
            // 
            this.mnuMainItmSignLog.Name = "mnuMainItmSignLog";
            this.mnuMainItmSignLog.Size = new System.Drawing.Size(92, 22);
            this.mnuMainItmSignLog.Text = "SignUp/Login";
            this.mnuMainItmSignLog.Click += new System.EventHandler(this.mnuMainItmSignLog_Click);
            // 
            // mnuMainItmAbout
            // 
            this.mnuMainItmAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuMainItmAbout.Name = "mnuMainItmAbout";
            this.mnuMainItmAbout.Size = new System.Drawing.Size(52, 22);
            this.mnuMainItmAbout.Text = "About";
            this.mnuMainItmAbout.Click += new System.EventHandler(this.mnuMainItmAbout_Click);
            // 
            // mnuMainItmHelp
            // 
            this.mnuMainItmHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuMainItmHelp.Name = "mnuMainItmHelp";
            this.mnuMainItmHelp.Size = new System.Drawing.Size(44, 22);
            this.mnuMainItmHelp.Text = "Help";
            this.mnuMainItmHelp.Click += new System.EventHandler(this.mnuMainItmHelp_Click);
            // 
            // pbxShell
            // 
            this.pbxShell.Image = ((System.Drawing.Image)(resources.GetObject("pbxShell.Image")));
            this.pbxShell.Location = new System.Drawing.Point(226, 120);
            this.pbxShell.Name = "pbxShell";
            this.pbxShell.Size = new System.Drawing.Size(264, 244);
            this.pbxShell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxShell.TabIndex = 7;
            this.pbxShell.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(707, 421);
            this.Controls.Add(this.lblFineDiningSubtitle);
            this.Controls.Add(this.lblFancyTitle);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.pbxShell);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fancy! - Fine Dining and Breathing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFineDiningSubtitle;
        private System.Windows.Forms.Label lblFancyTitle;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuMainItmMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuMainItmSignLog;
        private System.Windows.Forms.ToolStripMenuItem mnuMainItmAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuMainItmHelp;
        private System.Windows.Forms.PictureBox pbxShell;
        private System.Windows.Forms.HelpProvider hlpFancy;
    }
}