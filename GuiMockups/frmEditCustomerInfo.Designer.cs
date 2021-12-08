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
            this.cbxPassword = new System.Windows.Forms.CheckBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.btnUpdateLogin = new System.Windows.Forms.Button();
            this.lblMsgUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.gbxPersonalInformation = new System.Windows.Forms.GroupBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.tbxZip = new System.Windows.Forms.TextBox();
            this.tbxState = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.gbxLoginInfo.SuspendLayout();
            this.gbxPersonalInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnUpdateInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.btnUpdateInfo.Location = new System.Drawing.Point(272, 414);
            this.btnUpdateInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(127, 33);
            this.btnUpdateInfo.TabIndex = 12;
            this.btnUpdateInfo.Text = "Update Info";
            this.btnUpdateInfo.UseVisualStyleBackColor = false;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // gbxLoginInfo
            // 
            this.gbxLoginInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.gbxLoginInfo.Controls.Add(this.cbxPassword);
            this.gbxLoginInfo.Controls.Add(this.tbxPassword);
            this.gbxLoginInfo.Controls.Add(this.tbxUserName);
            this.gbxLoginInfo.Controls.Add(this.btnUpdateLogin);
            this.gbxLoginInfo.Controls.Add(this.lblMsgUser);
            this.gbxLoginInfo.Controls.Add(this.lblPass);
            this.gbxLoginInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.gbxLoginInfo.Location = new System.Drawing.Point(497, 32);
            this.gbxLoginInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gbxLoginInfo.Name = "gbxLoginInfo";
            this.gbxLoginInfo.Padding = new System.Windows.Forms.Padding(4);
            this.gbxLoginInfo.Size = new System.Drawing.Size(407, 176);
            this.gbxLoginInfo.TabIndex = 14;
            this.gbxLoginInfo.TabStop = false;
            this.gbxLoginInfo.Text = "Login Information";
            // 
            // cbxPassword
            // 
            this.cbxPassword.AutoSize = true;
            this.cbxPassword.Location = new System.Drawing.Point(131, 99);
            this.cbxPassword.Name = "cbxPassword";
            this.cbxPassword.Size = new System.Drawing.Size(123, 20);
            this.cbxPassword.TabIndex = 11;
            this.cbxPassword.Text = "Show Password";
            this.cbxPassword.UseVisualStyleBackColor = true;
            this.cbxPassword.CheckedChanged += new System.EventHandler(this.cbxPassword_CheckedChanged);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(131, 70);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPassword.MaxLength = 50;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(196, 22);
            this.tbxPassword.TabIndex = 10;
            this.tbxPassword.UseSystemPasswordChar = true;
            // 
            // tbxUserName
            // 
            this.tbxUserName.Location = new System.Drawing.Point(131, 27);
            this.tbxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxUserName.MaxLength = 50;
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(196, 22);
            this.tbxUserName.TabIndex = 9;
            // 
            // btnUpdateLogin
            // 
            this.btnUpdateLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnUpdateLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.btnUpdateLogin.Location = new System.Drawing.Point(272, 135);
            this.btnUpdateLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateLogin.Name = "btnUpdateLogin";
            this.btnUpdateLogin.Size = new System.Drawing.Size(127, 33);
            this.btnUpdateLogin.TabIndex = 7;
            this.btnUpdateLogin.Text = "Update Login";
            this.btnUpdateLogin.UseVisualStyleBackColor = false;
            this.btnUpdateLogin.Click += new System.EventHandler(this.btnUpdateLogin_Click);
            // 
            // lblMsgUser
            // 
            this.lblMsgUser.AutoSize = true;
            this.lblMsgUser.Location = new System.Drawing.Point(8, 31);
            this.lblMsgUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsgUser.Name = "lblMsgUser";
            this.lblMsgUser.Size = new System.Drawing.Size(80, 16);
            this.lblMsgUser.TabIndex = 8;
            this.lblMsgUser.Text = "User Name:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(17, 74);
            this.lblPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(71, 16);
            this.lblPass.TabIndex = 7;
            this.lblPass.Text = "Password:";
            // 
            // gbxPersonalInformation
            // 
            this.gbxPersonalInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.gbxPersonalInformation.Controls.Add(this.tbxLastName);
            this.gbxPersonalInformation.Controls.Add(this.tbxAddress);
            this.gbxPersonalInformation.Controls.Add(this.tbxCity);
            this.gbxPersonalInformation.Controls.Add(this.tbxEmail);
            this.gbxPersonalInformation.Controls.Add(this.tbxPhone);
            this.gbxPersonalInformation.Controls.Add(this.tbxZip);
            this.gbxPersonalInformation.Controls.Add(this.tbxState);
            this.gbxPersonalInformation.Controls.Add(this.tbxFirstName);
            this.gbxPersonalInformation.Controls.Add(this.lblZip);
            this.gbxPersonalInformation.Controls.Add(this.lblCity);
            this.gbxPersonalInformation.Controls.Add(this.lblState);
            this.gbxPersonalInformation.Controls.Add(this.btnUpdateInfo);
            this.gbxPersonalInformation.Controls.Add(this.lblPhone);
            this.gbxPersonalInformation.Controls.Add(this.lblLast);
            this.gbxPersonalInformation.Controls.Add(this.lblAddress);
            this.gbxPersonalInformation.Controls.Add(this.lblFirst);
            this.gbxPersonalInformation.Controls.Add(this.lblEmail);
            this.gbxPersonalInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.gbxPersonalInformation.Location = new System.Drawing.Point(47, 32);
            this.gbxPersonalInformation.Margin = new System.Windows.Forms.Padding(4);
            this.gbxPersonalInformation.Name = "gbxPersonalInformation";
            this.gbxPersonalInformation.Padding = new System.Windows.Forms.Padding(4);
            this.gbxPersonalInformation.Size = new System.Drawing.Size(407, 454);
            this.gbxPersonalInformation.TabIndex = 13;
            this.gbxPersonalInformation.TabStop = false;
            this.gbxPersonalInformation.Text = "Personal Information";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(127, 79);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxLastName.MaxLength = 50;
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(193, 22);
            this.tbxLastName.TabIndex = 25;
            this.tbxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLastName_KeyPress);
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(127, 119);
            this.tbxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAddress.MaxLength = 50;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(193, 22);
            this.tbxAddress.TabIndex = 24;
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(127, 161);
            this.tbxCity.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCity.MaxLength = 50;
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(193, 22);
            this.tbxCity.TabIndex = 23;
            this.tbxCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCity_KeyPress);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(127, 334);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEmail.MaxLength = 50;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(193, 22);
            this.tbxEmail.TabIndex = 22;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(127, 292);
            this.tbxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPhone.MaxLength = 20;
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(193, 22);
            this.tbxPhone.TabIndex = 21;
            this.tbxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPhone_KeyPress);
            // 
            // tbxZip
            // 
            this.tbxZip.Location = new System.Drawing.Point(127, 251);
            this.tbxZip.Margin = new System.Windows.Forms.Padding(4);
            this.tbxZip.MaxLength = 5;
            this.tbxZip.Name = "tbxZip";
            this.tbxZip.Size = new System.Drawing.Size(193, 22);
            this.tbxZip.TabIndex = 20;
            this.tbxZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxZip_KeyPress);
            // 
            // tbxState
            // 
            this.tbxState.Location = new System.Drawing.Point(127, 204);
            this.tbxState.Margin = new System.Windows.Forms.Padding(4);
            this.tbxState.MaxLength = 2;
            this.tbxState.Name = "tbxState";
            this.tbxState.Size = new System.Drawing.Size(193, 22);
            this.tbxState.TabIndex = 19;
            this.tbxState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxState_KeyPress);
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(127, 32);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFirstName.MaxLength = 50;
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(193, 22);
            this.tbxFirstName.TabIndex = 18;
            this.tbxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFirstName_KeyPress);
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(45, 255);
            this.lblZip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(30, 16);
            this.lblZip.TabIndex = 17;
            this.lblZip.Text = "Zip:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(56, 165);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(33, 16);
            this.lblCity.TabIndex = 14;
            this.lblCity.Text = "City:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(45, 208);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(42, 16);
            this.lblState.TabIndex = 13;
            this.lblState.Text = "State:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(37, 295);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(50, 16);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone:";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(11, 82);
            this.lblLast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(76, 16);
            this.lblLast.TabIndex = 5;
            this.lblLast.Text = "Last Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(28, 123);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(62, 16);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address:";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(12, 36);
            this.lblFirst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(76, 16);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "First Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(45, 337);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // frmEditCustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(937, 549);
            this.Controls.Add(this.gbxLoginInfo);
            this.Controls.Add(this.gbxPersonalInformation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmEditCustomerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fancy! - Profile";
            this.Load += new System.EventHandler(this.frmEditCustomerInfo_Load);
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
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.GroupBox gbxPersonalInformation;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.TextBox tbxZip;
        private System.Windows.Forms.TextBox tbxState;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.CheckBox cbxPassword;
    }
}