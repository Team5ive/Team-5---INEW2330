namespace GuiMockups
{
    partial class frmSupplies
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
            this.lbxQuantity = new System.Windows.Forms.ListBox();
            this.lbxCart = new System.Windows.Forms.ListBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.lblTables = new System.Windows.Forms.Label();
            this.dgvSupplies = new System.Windows.Forms.DataGridView();
            this.lblOnHandPrompt = new System.Windows.Forms.Label();
            this.lblToOrderPrompt = new System.Windows.Forms.Label();
            this.lblOnHand = new System.Windows.Forms.Label();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.lblTotalPrompt = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.lblTaxPrompt = new System.Windows.Forms.Label();
            this.lblSubtotalPrompt = new System.Windows.Forms.Label();
            this.cbxQuantity = new System.Windows.Forms.ComboBox();
            this.lblProductPrompt = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLowerSeparator = new System.Windows.Forms.Label();
            this.lblUpperSeparator = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplies)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxQuantity
            // 
            this.lbxQuantity.FormattingEnabled = true;
            this.lbxQuantity.ItemHeight = 20;
            this.lbxQuantity.Location = new System.Drawing.Point(420, 272);
            this.lbxQuantity.Name = "lbxQuantity";
            this.lbxQuantity.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbxQuantity.Size = new System.Drawing.Size(122, 224);
            this.lbxQuantity.TabIndex = 1;
            // 
            // lbxCart
            // 
            this.lbxCart.FormattingEnabled = true;
            this.lbxCart.ItemHeight = 20;
            this.lbxCart.Location = new System.Drawing.Point(-1, 272);
            this.lbxCart.Name = "lbxCart";
            this.lbxCart.Size = new System.Drawing.Size(415, 224);
            this.lbxCart.TabIndex = 1;
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuantity.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblQuantity.Location = new System.Drawing.Point(420, 244);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(122, 25);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCart
            // 
            this.lblCart.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblCart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCart.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCart.Location = new System.Drawing.Point(-1, 244);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(415, 25);
            this.lblCart.TabIndex = 0;
            this.lblCart.Text = "Cart";
            this.lblCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTables
            // 
            this.lblTables.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTables.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTables.Location = new System.Drawing.Point(-1, -1);
            this.lblTables.Name = "lblTables";
            this.lblTables.Size = new System.Drawing.Size(543, 32);
            this.lblTables.TabIndex = 7;
            this.lblTables.Text = "Supplies Inventory";
            this.lblTables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvSupplies
            // 
            this.dgvSupplies.AllowUserToAddRows = false;
            this.dgvSupplies.AllowUserToDeleteRows = false;
            this.dgvSupplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplies.Location = new System.Drawing.Point(-1, 34);
            this.dgvSupplies.Name = "dgvSupplies";
            this.dgvSupplies.ReadOnly = true;
            this.dgvSupplies.RowHeadersWidth = 51;
            this.dgvSupplies.Size = new System.Drawing.Size(543, 207);
            this.dgvSupplies.TabIndex = 8;
            this.dgvSupplies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplies_CellClick);
            // 
            // lblOnHandPrompt
            // 
            this.lblOnHandPrompt.Location = new System.Drawing.Point(570, 98);
            this.lblOnHandPrompt.Name = "lblOnHandPrompt";
            this.lblOnHandPrompt.Size = new System.Drawing.Size(140, 29);
            this.lblOnHandPrompt.TabIndex = 9;
            this.lblOnHandPrompt.Text = "Quantity On-hand:";
            this.lblOnHandPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblToOrderPrompt
            // 
            this.lblToOrderPrompt.Location = new System.Drawing.Point(570, 142);
            this.lblToOrderPrompt.Name = "lblToOrderPrompt";
            this.lblToOrderPrompt.Size = new System.Drawing.Size(140, 29);
            this.lblToOrderPrompt.TabIndex = 10;
            this.lblToOrderPrompt.Text = "Quantity to order:";
            this.lblToOrderPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOnHand
            // 
            this.lblOnHand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOnHand.Location = new System.Drawing.Point(716, 98);
            this.lblOnHand.Name = "lblOnHand";
            this.lblOnHand.Size = new System.Drawing.Size(151, 29);
            this.lblOnHand.TabIndex = 11;
            this.lblOnHand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddCart
            // 
            this.btnAddCart.Location = new System.Drawing.Point(751, 190);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(116, 35);
            this.btnAddCart.TabIndex = 13;
            this.btnAddCart.Text = "Add to cart";
            this.btnAddCart.UseVisualStyleBackColor = true;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // lblTotalPrompt
            // 
            this.lblTotalPrompt.Location = new System.Drawing.Point(669, 363);
            this.lblTotalPrompt.Name = "lblTotalPrompt";
            this.lblTotalPrompt.Size = new System.Drawing.Size(76, 29);
            this.lblTotalPrompt.TabIndex = 14;
            this.lblTotalPrompt.Text = "Total:";
            this.lblTotalPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(548, 287);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 54);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(548, 442);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 54);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit Order";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(548, 364);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(100, 54);
            this.btnClearAll.TabIndex = 18;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // lblTaxPrompt
            // 
            this.lblTaxPrompt.Location = new System.Drawing.Point(669, 325);
            this.lblTaxPrompt.Name = "lblTaxPrompt";
            this.lblTaxPrompt.Size = new System.Drawing.Size(76, 29);
            this.lblTaxPrompt.TabIndex = 19;
            this.lblTaxPrompt.Text = "Tax:";
            this.lblTaxPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtotalPrompt
            // 
            this.lblSubtotalPrompt.Location = new System.Drawing.Point(669, 287);
            this.lblSubtotalPrompt.Name = "lblSubtotalPrompt";
            this.lblSubtotalPrompt.Size = new System.Drawing.Size(76, 29);
            this.lblSubtotalPrompt.TabIndex = 20;
            this.lblSubtotalPrompt.Text = "Subtotal:";
            this.lblSubtotalPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxQuantity
            // 
            this.cbxQuantity.FormattingEnabled = true;
            this.cbxQuantity.Items.AddRange(new object[] {
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
            "20"});
            this.cbxQuantity.Location = new System.Drawing.Point(716, 143);
            this.cbxQuantity.Name = "cbxQuantity";
            this.cbxQuantity.Size = new System.Drawing.Size(151, 28);
            this.cbxQuantity.TabIndex = 21;
            // 
            // lblProductPrompt
            // 
            this.lblProductPrompt.Location = new System.Drawing.Point(570, 54);
            this.lblProductPrompt.Name = "lblProductPrompt";
            this.lblProductPrompt.Size = new System.Drawing.Size(140, 29);
            this.lblProductPrompt.TabIndex = 22;
            this.lblProductPrompt.Text = "Product:";
            this.lblProductPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProductName
            // 
            this.lblProductName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProductName.Location = new System.Drawing.Point(716, 54);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(151, 29);
            this.lblProductName.TabIndex = 23;
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(767, 442);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 54);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLowerSeparator
            // 
            this.lblLowerSeparator.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblLowerSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLowerSeparator.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblLowerSeparator.Location = new System.Drawing.Point(548, 244);
            this.lblLowerSeparator.Name = "lblLowerSeparator";
            this.lblLowerSeparator.Size = new System.Drawing.Size(345, 25);
            this.lblLowerSeparator.TabIndex = 25;
            this.lblLowerSeparator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUpperSeparator
            // 
            this.lblUpperSeparator.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUpperSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUpperSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpperSeparator.Location = new System.Drawing.Point(548, -1);
            this.lblUpperSeparator.Name = "lblUpperSeparator";
            this.lblUpperSeparator.Size = new System.Drawing.Size(345, 32);
            this.lblUpperSeparator.TabIndex = 26;
            this.lblUpperSeparator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubtotal.Location = new System.Drawing.Point(751, 287);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(116, 29);
            this.lblSubtotal.TabIndex = 27;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTax
            // 
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTax.Location = new System.Drawing.Point(751, 325);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(116, 29);
            this.lblTax.TabIndex = 28;
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(751, 363);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(116, 29);
            this.lblTotal.TabIndex = 29;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmSupplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(888, 505);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblUpperSeparator);
            this.Controls.Add(this.lblLowerSeparator);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductPrompt);
            this.Controls.Add(this.cbxQuantity);
            this.Controls.Add(this.lblSubtotalPrompt);
            this.Controls.Add(this.lblTaxPrompt);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblTotalPrompt);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.lblOnHand);
            this.Controls.Add(this.lblToOrderPrompt);
            this.Controls.Add(this.lblOnHandPrompt);
            this.Controls.Add(this.lbxQuantity);
            this.Controls.Add(this.dgvSupplies);
            this.Controls.Add(this.lbxCart);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblTables);
            this.Controls.Add(this.lblCart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmSupplies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fancy! - Supplies";
            this.Load += new System.EventHandler(this.Supplies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbxQuantity;
        private System.Windows.Forms.ListBox lbxCart;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Label lblTables;
        private System.Windows.Forms.DataGridView dgvSupplies;
        private System.Windows.Forms.Label lblOnHandPrompt;
        private System.Windows.Forms.Label lblToOrderPrompt;
        private System.Windows.Forms.Label lblOnHand;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Label lblTotalPrompt;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label lblTaxPrompt;
        private System.Windows.Forms.Label lblSubtotalPrompt;
        private System.Windows.Forms.ComboBox cbxQuantity;
        private System.Windows.Forms.Label lblProductPrompt;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblLowerSeparator;
        private System.Windows.Forms.Label lblUpperSeparator;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
    }
}