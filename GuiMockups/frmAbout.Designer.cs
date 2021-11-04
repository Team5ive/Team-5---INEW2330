
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
            ((System.ComponentModel.ISupportInitialize)(this.pbxSwirl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSwirl1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Vladimir Script", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.lblTitle.Location = new System.Drawing.Point(197, -2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(218, 83);
            this.lblTitle.TabIndex = 49;
            this.lblTitle.Text = "About";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxSwirl2
            // 
            this.pbxSwirl2.Image = ((System.Drawing.Image)(resources.GetObject("pbxSwirl2.Image")));
            this.pbxSwirl2.Location = new System.Drawing.Point(400, 12);
            this.pbxSwirl2.Name = "pbxSwirl2";
            this.pbxSwirl2.Size = new System.Drawing.Size(235, 86);
            this.pbxSwirl2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSwirl2.TabIndex = 50;
            this.pbxSwirl2.TabStop = false;
            // 
            // pbxSwirl1
            // 
            this.pbxSwirl1.Image = ((System.Drawing.Image)(resources.GetObject("pbxSwirl1.Image")));
            this.pbxSwirl1.Location = new System.Drawing.Point(-16, 12);
            this.pbxSwirl1.Name = "pbxSwirl1";
            this.pbxSwirl1.Size = new System.Drawing.Size(232, 86);
            this.pbxSwirl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSwirl1.TabIndex = 51;
            this.pbxSwirl1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DimGray;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.btnClose.Location = new System.Drawing.Point(261, 400);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 41);
            this.btnClose.TabIndex = 52;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(617, 453);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbxSwirl1);
            this.Controls.Add(this.pbxSwirl2);
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fancy! - About Page";
            ((System.ComponentModel.ISupportInitialize)(this.pbxSwirl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSwirl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbxSwirl2;
        private System.Windows.Forms.PictureBox pbxSwirl1;
        private System.Windows.Forms.Button btnClose;
    }
}