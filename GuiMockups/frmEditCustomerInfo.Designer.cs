namespace GuiMockups
{
    partial class frmEditCustomerInfo
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
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.gbxLoginInfo = new System.Windows.Forms.GroupBox();
            this.btnUpdateLogin = new System.Windows.Forms.Button();
            this.lblMsgUser = new System.Windows.Forms.Label();
            this.tbxUserName = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.gbxPersonalInformation = new System.Windows.Forms.GroupBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.gbxLoginInfo.SuspendLayout();
            this.gbxPersonalInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnUpdateInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.btnUpdateInfo.Location = new System.Drawing.Point(196, 223);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(95, 27);
            this.btnUpdateInfo.TabIndex = 12;
            this.btnUpdateInfo.Text = "Update Info";
            this.btnUpdateInfo.UseVisualStyleBackColor = false;
            // 
            // gbxLoginInfo
            // 
            this.gbxLoginInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.gbxLoginInfo.Controls.Add(this.btnUpdateLogin);
            this.gbxLoginInfo.Controls.Add(this.lblMsgUser);
            this.gbxLoginInfo.Controls.Add(this.tbxUserName);
            this.gbxLoginInfo.Controls.Add(this.tbxPassword);
            this.gbxLoginInfo.Controls.Add(this.lblPass);
            this.gbxLoginInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.gbxLoginInfo.Location = new System.Drawing.Point(330, 26);
            this.gbxLoginInfo.Name = "gbxLoginInfo";
            this.gbxLoginInfo.Size = new System.Drawing.Size(261, 136);
            this.gbxLoginInfo.TabIndex = 14;
            this.gbxLoginInfo.TabStop = false;
            this.gbxLoginInfo.Text = "Login Information";
            // 
            // btnUpdateLogin
            // 
            this.btnUpdateLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnUpdateLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.btnUpdateLogin.Location = new System.Drawing.Point(160, 100);
            this.btnUpdateLogin.Name = "btnUpdateLogin";
            this.btnUpdateLogin.Size = new System.Drawing.Size(95, 27);
            this.btnUpdateLogin.TabIndex = 7;
            this.btnUpdateLogin.Text = "Update Login";
            this.btnUpdateLogin.UseVisualStyleBackColor = false;
            // 
            // lblMsgUser
            // 
            this.lblMsgUser.AutoSize = true;
            this.lblMsgUser.Location = new System.Drawing.Point(6, 25);
            this.lblMsgUser.Name = "lblMsgUser";
            this.lblMsgUser.Size = new System.Drawing.Size(63, 13);
            this.lblMsgUser.TabIndex = 8;
            this.lblMsgUser.Text = "User Name:";
            // 
            // tbxUserName
            // 
            this.tbxUserName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbxUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUserName.ForeColor = System.Drawing.Color.Black;
            this.tbxUserName.Location = new System.Drawing.Point(72, 24);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(159, 24);
            this.tbxUserName.TabIndex = 10;
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPassword.ForeColor = System.Drawing.Color.Black;
            this.tbxPassword.Location = new System.Drawing.Point(72, 59);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(159, 24);
            this.tbxPassword.TabIndex = 9;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(13, 60);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(56, 13);
            this.lblPass.TabIndex = 7;
            this.lblPass.Text = "Password:";
            // 
            // gbxPersonalInformation
            // 
            this.gbxPersonalInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.gbxPersonalInformation.Controls.Add(this.lblPhone);
            this.gbxPersonalInformation.Controls.Add(this.lblLast);
            this.gbxPersonalInformation.Controls.Add(this.lblAddress);
            this.gbxPersonalInformation.Controls.Add(this.tbxLastName);
            this.gbxPersonalInformation.Controls.Add(this.tbxPhone);
            this.gbxPersonalInformation.Controls.Add(this.lblFirst);
            this.gbxPersonalInformation.Controls.Add(this.tbxAddress);
            this.gbxPersonalInformation.Controls.Add(this.tbxFirstName);
            this.gbxPersonalInformation.Controls.Add(this.tbxEmail);
            this.gbxPersonalInformation.Controls.Add(this.lblEmail);
            this.gbxPersonalInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.gbxPersonalInformation.Location = new System.Drawing.Point(35, 26);
            this.gbxPersonalInformation.Name = "gbxPersonalInformation";
            this.gbxPersonalInformation.Size = new System.Drawing.Size(261, 234);
            this.gbxPersonalInformation.TabIndex = 13;
            this.gbxPersonalInformation.TabStop = false;
            this.gbxPersonalInformation.Text = "Personal Information";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(28, 130);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone:";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(8, 67);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(61, 13);
            this.lblLast.TabIndex = 5;
            this.lblLast.Text = "Last Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(21, 100);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address:";
            // 
            // tbxLastName
            // 
            this.tbxLastName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbxLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxLastName.ForeColor = System.Drawing.Color.Black;
            this.tbxLastName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbxLastName.Location = new System.Drawing.Point(79, 66);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(159, 24);
            this.tbxLastName.TabIndex = 6;
            // 
            // tbxPhone
            // 
            this.tbxPhone.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPhone.ForeColor = System.Drawing.Color.Black;
            this.tbxPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbxPhone.Location = new System.Drawing.Point(79, 129);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(159, 24);
            this.tbxPhone.TabIndex = 6;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(9, 29);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(60, 13);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "First Name:";
            // 
            // tbxAddress
            // 
            this.tbxAddress.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAddress.ForeColor = System.Drawing.Color.Black;
            this.tbxAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbxAddress.Location = new System.Drawing.Point(79, 99);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(159, 24);
            this.tbxAddress.TabIndex = 7;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxFirstName.ForeColor = System.Drawing.Color.Black;
            this.tbxFirstName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbxFirstName.Location = new System.Drawing.Point(79, 28);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(159, 24);
            this.tbxFirstName.TabIndex = 4;
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxEmail.ForeColor = System.Drawing.Color.Black;
            this.tbxEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbxEmail.Location = new System.Drawing.Point(79, 163);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(159, 24);
            this.tbxEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(34, 164);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // frmEditCustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(627, 287);
            this.Controls.Add(this.btnUpdateInfo);
            this.Controls.Add(this.gbxLoginInfo);
            this.Controls.Add(this.gbxPersonalInformation);
            this.Name = "frmEditCustomerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fancy! - Profile";
            this.gbxLoginInfo.ResumeLayout(false);
            this.gbxLoginInfo.PerformLayout();
            this.gbxPersonalInformation.ResumeLayout(false);
            this.gbxPersonalInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.GroupBox gbxLoginInfo;
        private System.Windows.Forms.Button btnUpdateLogin;
        private System.Windows.Forms.Label lblMsgUser;
        private System.Windows.Forms.Label tbxUserName;
        private System.Windows.Forms.Label tbxPassword;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.GroupBox gbxPersonalInformation;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label tbxLastName;
        private System.Windows.Forms.Label tbxPhone;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label tbxAddress;
        private System.Windows.Forms.Label tbxFirstName;
        private System.Windows.Forms.Label tbxEmail;
        private System.Windows.Forms.Label lblEmail;
    }
}