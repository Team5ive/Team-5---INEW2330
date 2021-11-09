﻿
namespace GuiMockups
{
    partial class frmEmployeeHub
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnChangeReserve = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCustOrders = new System.Windows.Forms.Button();
            this.btnOrderSupplies = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBox2.Controls.Add(this.btnEditUser);
            this.groupBox2.Controls.Add(this.btnChangeReserve);
            this.groupBox2.Controls.Add(this.btnEditEmployee);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.groupBox2.Location = new System.Drawing.Point(286, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 101);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Managers";
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.btnEditUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditUser.ForeColor = System.Drawing.Color.Black;
            this.btnEditUser.Location = new System.Drawing.Point(278, 19);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(130, 66);
            this.btnEditUser.TabIndex = 5;
            this.btnEditUser.Text = "Edit User Account";
            this.btnEditUser.UseVisualStyleBackColor = false;
            // 
            // btnChangeReserve
            // 
            this.btnChangeReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.btnChangeReserve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChangeReserve.ForeColor = System.Drawing.Color.Black;
            this.btnChangeReserve.Location = new System.Drawing.Point(6, 19);
            this.btnChangeReserve.Name = "btnChangeReserve";
            this.btnChangeReserve.Size = new System.Drawing.Size(130, 66);
            this.btnChangeReserve.TabIndex = 2;
            this.btnChangeReserve.Text = "Change Reservations";
            this.btnChangeReserve.UseVisualStyleBackColor = false;
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.btnEditEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnEditEmployee.Location = new System.Drawing.Point(142, 19);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(130, 66);
            this.btnEditEmployee.TabIndex = 6;
            this.btnEditEmployee.Text = "Edit Employee Account";
            this.btnEditEmployee.UseVisualStyleBackColor = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblWelcome.Location = new System.Drawing.Point(0, -3);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(706, 55);
            this.lblWelcome.TabIndex = 9;
            this.lblWelcome.Text = "Welcome!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.btnCustOrders);
            this.groupBox1.Controls.Add(this.btnOrderSupplies);
            this.groupBox1.Location = new System.Drawing.Point(-4, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 101);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Associates";
            // 
            // btnCustOrders
            // 
            this.btnCustOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(139)))), ((int)(((byte)(156)))));
            this.btnCustOrders.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCustOrders.Location = new System.Drawing.Point(18, 19);
            this.btnCustOrders.Name = "btnCustOrders";
            this.btnCustOrders.Size = new System.Drawing.Size(130, 66);
            this.btnCustOrders.TabIndex = 1;
            this.btnCustOrders.Text = "Customer Orders";
            this.btnCustOrders.UseVisualStyleBackColor = false;
            this.btnCustOrders.Click += new System.EventHandler(this.btnCustOrders_Click);
            // 
            // btnOrderSupplies
            // 
            this.btnOrderSupplies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(139)))), ((int)(((byte)(156)))));
            this.btnOrderSupplies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOrderSupplies.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOrderSupplies.Location = new System.Drawing.Point(154, 19);
            this.btnOrderSupplies.Name = "btnOrderSupplies";
            this.btnOrderSupplies.Size = new System.Drawing.Size(130, 66);
            this.btnOrderSupplies.TabIndex = 2;
            this.btnOrderSupplies.Text = "Order Supplies";
            this.btnOrderSupplies.UseVisualStyleBackColor = false;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSignOut.ForeColor = System.Drawing.Color.Black;
            this.btnSignOut.Location = new System.Drawing.Point(620, -1);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(83, 29);
            this.btnSignOut.TabIndex = 12;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // frmEmployeeHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 151);
            this.ControlBox = false;
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEmployeeHub";
            this.Text = "Fancy! - Employee Hub";
            this.Load += new System.EventHandler(this.frmEmployeeHub_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnChangeReserve;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCustOrders;
        private System.Windows.Forms.Button btnOrderSupplies;
        private System.Windows.Forms.Button btnSignOut;
    }
}