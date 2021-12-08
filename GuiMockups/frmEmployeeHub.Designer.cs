
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
            this.gbxManagers = new System.Windows.Forms.GroupBox();
            this.btnChangeReserve = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.gbxAssociates = new System.Windows.Forms.GroupBox();
            this.btnCustOrders = new System.Windows.Forms.Button();
            this.btnOrderSupplies = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.gbxManagers.SuspendLayout();
            this.gbxAssociates.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxManagers
            // 
            this.gbxManagers.BackColor = System.Drawing.SystemColors.GrayText;
            this.gbxManagers.Controls.Add(this.btnChangeReserve);
            this.gbxManagers.Controls.Add(this.btnEditEmployee);
            this.gbxManagers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.gbxManagers.Location = new System.Drawing.Point(311, 105);
            this.gbxManagers.Name = "gbxManagers";
            this.gbxManagers.Size = new System.Drawing.Size(309, 101);
            this.gbxManagers.TabIndex = 11;
            this.gbxManagers.TabStop = false;
            this.gbxManagers.Text = "Managers";
            // 
            // btnChangeReserve
            // 
            this.btnChangeReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.btnChangeReserve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChangeReserve.ForeColor = System.Drawing.Color.Black;
            this.btnChangeReserve.Location = new System.Drawing.Point(22, 19);
            this.btnChangeReserve.Name = "btnChangeReserve";
            this.btnChangeReserve.Size = new System.Drawing.Size(130, 66);
            this.btnChangeReserve.TabIndex = 2;
            this.btnChangeReserve.Text = "Change Reservations";
            this.btnChangeReserve.UseVisualStyleBackColor = false;
            this.btnChangeReserve.Click += new System.EventHandler(this.btnChangeReserve_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.btnEditEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnEditEmployee.Location = new System.Drawing.Point(163, 19);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(130, 66);
            this.btnEditEmployee.TabIndex = 6;
            this.btnEditEmployee.Text = "Edit Employee Account";
            this.btnEditEmployee.UseVisualStyleBackColor = false;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblWelcome.Location = new System.Drawing.Point(0, -3);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(619, 105);
            this.lblWelcome.TabIndex = 9;
            this.lblWelcome.Text = "Welcome!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxAssociates
            // 
            this.gbxAssociates.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbxAssociates.Controls.Add(this.btnCustOrders);
            this.gbxAssociates.Controls.Add(this.btnOrderSupplies);
            this.gbxAssociates.Location = new System.Drawing.Point(4, 105);
            this.gbxAssociates.Name = "gbxAssociates";
            this.gbxAssociates.Size = new System.Drawing.Size(301, 101);
            this.gbxAssociates.TabIndex = 10;
            this.gbxAssociates.TabStop = false;
            this.gbxAssociates.Text = "Associates";
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
            this.btnOrderSupplies.Click += new System.EventHandler(this.btnOrderSupplies_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSignOut.ForeColor = System.Drawing.Color.Black;
            this.btnSignOut.Location = new System.Drawing.Point(525, 7);
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
            this.ClientSize = new System.Drawing.Size(620, 203);
            this.ControlBox = false;
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.gbxManagers);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.gbxAssociates);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmEmployeeHub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fancy! - Employee Hub";
            this.Load += new System.EventHandler(this.frmEmployeeHub_Load);
            this.gbxManagers.ResumeLayout(false);
            this.gbxAssociates.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxManagers;
        private System.Windows.Forms.Button btnChangeReserve;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox gbxAssociates;
        private System.Windows.Forms.Button btnCustOrders;
        private System.Windows.Forms.Button btnOrderSupplies;
        private System.Windows.Forms.Button btnSignOut;
    }
}