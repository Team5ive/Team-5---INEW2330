
namespace GuiMockups
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbxSwirl2 = new System.Windows.Forms.PictureBox();
            this.pbxSwirl1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblAboutColorPane = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSwirl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSwirl1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Vladimir Script", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.lblTitle.Location = new System.Drawing.Point(299, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(535, 128);
            this.lblTitle.TabIndex = 49;
            this.lblTitle.Text = "About Us";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxSwirl2
            // 
            this.pbxSwirl2.Image = ((System.Drawing.Image)(resources.GetObject("pbxSwirl2.Image")));
            this.pbxSwirl2.Location = new System.Drawing.Point(812, 14);
            this.pbxSwirl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxSwirl2.Name = "pbxSwirl2";
            this.pbxSwirl2.Size = new System.Drawing.Size(352, 132);
            this.pbxSwirl2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSwirl2.TabIndex = 50;
            this.pbxSwirl2.TabStop = false;
            // 
            // pbxSwirl1
            // 
            this.pbxSwirl1.Image = ((System.Drawing.Image)(resources.GetObject("pbxSwirl1.Image")));
            this.pbxSwirl1.Location = new System.Drawing.Point(-24, 18);
            this.pbxSwirl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxSwirl1.Name = "pbxSwirl1";
            this.pbxSwirl1.Size = new System.Drawing.Size(348, 132);
            this.pbxSwirl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSwirl1.TabIndex = 51;
            this.pbxSwirl1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DimGray;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.btnClose.Location = new System.Drawing.Point(530, 620);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 63);
            this.btnClose.TabIndex = 52;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblAboutColorPane
            // 
            this.lblAboutColorPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lblAboutColorPane.Location = new System.Drawing.Point(0, 173);
            this.lblAboutColorPane.Name = "lblAboutColorPane";
            this.lblAboutColorPane.Size = new System.Drawing.Size(1182, 423);
            this.lblAboutColorPane.TabIndex = 58;
            // 
            // lblAbout
            // 
            this.lblAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.Location = new System.Drawing.Point(47, 190);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(1089, 389);
            this.lblAbout.TabIndex = 59;
            this.lblAbout.Text = resources.GetString("lblAbout.Text");
            this.lblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1179, 697);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.lblAboutColorPane);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbxSwirl1);
            this.Controls.Add(this.pbxSwirl2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fancy! - About Us";
            ((System.ComponentModel.ISupportInitialize)(this.pbxSwirl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSwirl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbxSwirl2;
        private System.Windows.Forms.PictureBox pbxSwirl1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblAboutColorPane;
        private System.Windows.Forms.Label lblAbout;
    }
}