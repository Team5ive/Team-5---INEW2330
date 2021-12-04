
namespace GuiMockups
{
    partial class frmEditReservations
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
            this.tbxReserveID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxTableNum = new System.Windows.Forms.TextBox();
            this.tbxCustFirst = new System.Windows.Forms.TextBox();
            this.tbxCustLast = new System.Windows.Forms.TextBox();
            this.tbxCustomerID = new System.Windows.Forms.TextBox();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.lblReservationID = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblReservationDate = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.cbxMonth = new System.Windows.Forms.ComboBox();
            this.cbxDay = new System.Windows.Forms.ComboBox();
            this.cbxYear = new System.Windows.Forms.ComboBox();
            this.lblDateSeparator = new System.Windows.Forms.Label();
            this.cbxHour = new System.Windows.Forms.ComboBox();
            this.lblPM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxReserveID
            // 
            this.tbxReserveID.Enabled = false;
            this.tbxReserveID.Location = new System.Drawing.Point(725, 28);
            this.tbxReserveID.Name = "tbxReserveID";
            this.tbxReserveID.ReadOnly = true;
            this.tbxReserveID.Size = new System.Drawing.Size(194, 20);
            this.tbxReserveID.TabIndex = 17;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(811, 300);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 35);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(638, 300);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 35);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxTableNum
            // 
            this.tbxTableNum.Location = new System.Drawing.Point(725, 262);
            this.tbxTableNum.Name = "tbxTableNum";
            this.tbxTableNum.Size = new System.Drawing.Size(194, 20);
            this.tbxTableNum.TabIndex = 13;
            // 
            // tbxCustFirst
            // 
            this.tbxCustFirst.Enabled = false;
            this.tbxCustFirst.Location = new System.Drawing.Point(724, 106);
            this.tbxCustFirst.Name = "tbxCustFirst";
            this.tbxCustFirst.Size = new System.Drawing.Size(194, 20);
            this.tbxCustFirst.TabIndex = 12;
            // 
            // tbxCustLast
            // 
            this.tbxCustLast.Enabled = false;
            this.tbxCustLast.Location = new System.Drawing.Point(724, 146);
            this.tbxCustLast.Name = "tbxCustLast";
            this.tbxCustLast.Size = new System.Drawing.Size(194, 20);
            this.tbxCustLast.TabIndex = 11;
            // 
            // tbxCustomerID
            // 
            this.tbxCustomerID.Enabled = false;
            this.tbxCustomerID.Location = new System.Drawing.Point(725, 67);
            this.tbxCustomerID.Name = "tbxCustomerID";
            this.tbxCustomerID.ReadOnly = true;
            this.tbxCustomerID.Size = new System.Drawing.Size(194, 20);
            this.tbxCustomerID.TabIndex = 10;
            // 
            // dgvReservations
            // 
            this.dgvReservations.AllowUserToAddRows = false;
            this.dgvReservations.AllowUserToDeleteRows = false;
            this.dgvReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReservations.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Location = new System.Drawing.Point(24, 26);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.RowHeadersWidth = 62;
            this.dgvReservations.RowTemplate.Height = 28;
            this.dgvReservations.Size = new System.Drawing.Size(543, 294);
            this.dgvReservations.TabIndex = 9;
            this.dgvReservations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservations_CellClick);
            // 
            // lblReservationID
            // 
            this.lblReservationID.Location = new System.Drawing.Point(573, 26);
            this.lblReservationID.Name = "lblReservationID";
            this.lblReservationID.Size = new System.Drawing.Size(146, 23);
            this.lblReservationID.TabIndex = 18;
            this.lblReservationID.Text = "Reservation ID:";
            this.lblReservationID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.Location = new System.Drawing.Point(573, 65);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(146, 23);
            this.lblCustomerID.TabIndex = 19;
            this.lblCustomerID.Text = "Customer ID:";
            this.lblCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReservationDate
            // 
            this.lblReservationDate.Location = new System.Drawing.Point(573, 182);
            this.lblReservationDate.Name = "lblReservationDate";
            this.lblReservationDate.Size = new System.Drawing.Size(146, 23);
            this.lblReservationDate.TabIndex = 20;
            this.lblReservationDate.Text = "Reservation Date:";
            this.lblReservationDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(572, 104);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(146, 23);
            this.lblFirstName.TabIndex = 21;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(572, 143);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(146, 23);
            this.lblLastName.TabIndex = 22;
            this.lblLastName.Text = "LastName:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.Location = new System.Drawing.Point(573, 260);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(146, 23);
            this.lblTableNumber.TabIndex = 23;
            this.lblTableNumber.Text = "Table Number:";
            this.lblTableNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbltime
            // 
            this.lbltime.Location = new System.Drawing.Point(573, 221);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(146, 23);
            this.lbltime.TabIndex = 25;
            this.lbltime.Text = "Reservation Time:";
            this.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxMonth
            // 
            this.cbxMonth.FormattingEnabled = true;
            this.cbxMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbxMonth.Location = new System.Drawing.Point(726, 184);
            this.cbxMonth.Name = "cbxMonth";
            this.cbxMonth.Size = new System.Drawing.Size(52, 21);
            this.cbxMonth.TabIndex = 26;
            // 
            // cbxDay
            // 
            this.cbxDay.FormattingEnabled = true;
            this.cbxDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbxDay.Location = new System.Drawing.Point(796, 184);
            this.cbxDay.Name = "cbxDay";
            this.cbxDay.Size = new System.Drawing.Size(52, 21);
            this.cbxDay.TabIndex = 27;
            // 
            // cbxYear
            // 
            this.cbxYear.FormattingEnabled = true;
            this.cbxYear.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023"});
            this.cbxYear.Location = new System.Drawing.Point(866, 184);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(52, 21);
            this.cbxYear.TabIndex = 28;
            // 
            // lblDateSeparator
            // 
            this.lblDateSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateSeparator.Location = new System.Drawing.Point(770, 184);
            this.lblDateSeparator.Name = "lblDateSeparator";
            this.lblDateSeparator.Size = new System.Drawing.Size(100, 21);
            this.lblDateSeparator.TabIndex = 29;
            this.lblDateSeparator.Text = " /                /";
            this.lblDateSeparator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxHour
            // 
            this.cbxHour.FormattingEnabled = true;
            this.cbxHour.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbxHour.Location = new System.Drawing.Point(726, 223);
            this.cbxHour.Name = "cbxHour";
            this.cbxHour.Size = new System.Drawing.Size(52, 21);
            this.cbxHour.TabIndex = 30;
            // 
            // lblPM
            // 
            this.lblPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPM.Location = new System.Drawing.Point(784, 223);
            this.lblPM.Name = "lblPM";
            this.lblPM.Size = new System.Drawing.Size(47, 21);
            this.lblPM.TabIndex = 31;
            this.lblPM.Text = "PM";
            this.lblPM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmEditReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 347);
            this.Controls.Add(this.lblPM);
            this.Controls.Add(this.cbxHour);
            this.Controls.Add(this.cbxYear);
            this.Controls.Add(this.cbxDay);
            this.Controls.Add(this.cbxMonth);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lblTableNumber);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblReservationDate);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblReservationID);
            this.Controls.Add(this.tbxReserveID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbxTableNum);
            this.Controls.Add(this.tbxCustFirst);
            this.Controls.Add(this.tbxCustLast);
            this.Controls.Add(this.tbxCustomerID);
            this.Controls.Add(this.dgvReservations);
            this.Controls.Add(this.lblDateSeparator);
            this.Name = "frmEditReservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Reservations";
            this.Load += new System.EventHandler(this.frmEditReservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxReserveID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxTableNum;
        private System.Windows.Forms.TextBox tbxCustFirst;
        private System.Windows.Forms.TextBox tbxCustLast;
        private System.Windows.Forms.TextBox tbxCustomerID;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.Label lblReservationID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblReservationDate;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblTableNumber;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.ComboBox cbxMonth;
        private System.Windows.Forms.ComboBox cbxDay;
        private System.Windows.Forms.ComboBox cbxYear;
        private System.Windows.Forms.Label lblDateSeparator;
        private System.Windows.Forms.ComboBox cbxHour;
        private System.Windows.Forms.Label lblPM;
    }
}