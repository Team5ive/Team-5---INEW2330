namespace GuiMockups
{
    partial class frmEditOrders
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
            this.lblBorder = new System.Windows.Forms.Label();
            this.btnEntrees = new System.Windows.Forms.Button();
            this.btnDesserts = new System.Windows.Forms.Button();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnSoups = new System.Windows.Forms.Button();
            this.btnAppetizers = new System.Windows.Forms.Button();
            this.lblBorder2 = new System.Windows.Forms.Label();
            this.lblBackColor = new System.Windows.Forms.Label();
            this.gbxTableNumber = new System.Windows.Forms.GroupBox();
            this.lblMarker = new System.Windows.Forms.Label();
            this.gbxItems = new System.Windows.Forms.GroupBox();
            this.lbxCost = new System.Windows.Forms.ListBox();
            this.lbxQuantity = new System.Windows.Forms.ListBox();
            this.lbxItems = new System.Windows.Forms.ListBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.gbxOrderInfo = new System.Windows.Forms.GroupBox();
            this.gbxPayInfo = new System.Windows.Forms.GroupBox();
            this.lblGrand = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblGrandOutput = new System.Windows.Forms.Label();
            this.lblTotalOutput = new System.Windows.Forms.Label();
            this.lblTaxOutput = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tbxCustNameInput = new System.Windows.Forms.TextBox();
            this.lblOrderTypeOutput = new System.Windows.Forms.Label();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.lblMultiplier = new System.Windows.Forms.Label();
            this.tbxQty = new System.Windows.Forms.TextBox();
            this.gbxTableNumber.SuspendLayout();
            this.gbxItems.SuspendLayout();
            this.gbxOrderInfo.SuspendLayout();
            this.gbxPayInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBorder
            // 
            this.lblBorder.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblBorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBorder.Location = new System.Drawing.Point(-1, -2);
            this.lblBorder.Name = "lblBorder";
            this.lblBorder.Size = new System.Drawing.Size(454, 194);
            this.lblBorder.TabIndex = 0;
            // 
            // btnEntrees
            // 
            this.btnEntrees.BackColor = System.Drawing.Color.Honeydew;
            this.btnEntrees.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEntrees.Location = new System.Drawing.Point(9, 72);
            this.btnEntrees.Name = "btnEntrees";
            this.btnEntrees.Size = new System.Drawing.Size(109, 44);
            this.btnEntrees.TabIndex = 1;
            this.btnEntrees.Text = "Entrees";
            this.btnEntrees.UseVisualStyleBackColor = false;
            this.btnEntrees.Click += new System.EventHandler(this.btnEntrees_Click);
            // 
            // btnDesserts
            // 
            this.btnDesserts.BackColor = System.Drawing.Color.Honeydew;
            this.btnDesserts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDesserts.Location = new System.Drawing.Point(9, 133);
            this.btnDesserts.Name = "btnDesserts";
            this.btnDesserts.Size = new System.Drawing.Size(109, 44);
            this.btnDesserts.TabIndex = 1;
            this.btnDesserts.Text = "Desserts";
            this.btnDesserts.UseVisualStyleBackColor = false;
            this.btnDesserts.Click += new System.EventHandler(this.btnDesserts_Click);
            // 
            // btnDrinks
            // 
            this.btnDrinks.BackColor = System.Drawing.Color.Honeydew;
            this.btnDrinks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDrinks.Location = new System.Drawing.Point(155, 72);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(109, 44);
            this.btnDrinks.TabIndex = 1;
            this.btnDrinks.Text = "Drinks";
            this.btnDrinks.UseVisualStyleBackColor = false;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click);
            // 
            // btnSoups
            // 
            this.btnSoups.BackColor = System.Drawing.Color.Honeydew;
            this.btnSoups.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSoups.Location = new System.Drawing.Point(155, 12);
            this.btnSoups.Name = "btnSoups";
            this.btnSoups.Size = new System.Drawing.Size(109, 44);
            this.btnSoups.TabIndex = 1;
            this.btnSoups.Text = "Soups";
            this.btnSoups.UseVisualStyleBackColor = false;
            this.btnSoups.Click += new System.EventHandler(this.btnSoups_Click);
            // 
            // btnAppetizers
            // 
            this.btnAppetizers.BackColor = System.Drawing.Color.Honeydew;
            this.btnAppetizers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAppetizers.Location = new System.Drawing.Point(9, 12);
            this.btnAppetizers.Name = "btnAppetizers";
            this.btnAppetizers.Size = new System.Drawing.Size(109, 44);
            this.btnAppetizers.TabIndex = 1;
            this.btnAppetizers.Text = "Appetizers";
            this.btnAppetizers.UseVisualStyleBackColor = false;
            this.btnAppetizers.Click += new System.EventHandler(this.btnAppetizers_Click);
            // 
            // lblBorder2
            // 
            this.lblBorder2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblBorder2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBorder2.Location = new System.Drawing.Point(452, -2);
            this.lblBorder2.Name = "lblBorder2";
            this.lblBorder2.Size = new System.Drawing.Size(10, 587);
            this.lblBorder2.TabIndex = 0;
            // 
            // lblBackColor
            // 
            this.lblBackColor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBackColor.Location = new System.Drawing.Point(461, -2);
            this.lblBackColor.Name = "lblBackColor";
            this.lblBackColor.Size = new System.Drawing.Size(647, 587);
            this.lblBackColor.TabIndex = 0;
            // 
            // gbxTableNumber
            // 
            this.gbxTableNumber.Controls.Add(this.lblMarker);
            this.gbxTableNumber.ForeColor = System.Drawing.Color.Orange;
            this.gbxTableNumber.Location = new System.Drawing.Point(469, 12);
            this.gbxTableNumber.Name = "gbxTableNumber";
            this.gbxTableNumber.Size = new System.Drawing.Size(627, 90);
            this.gbxTableNumber.TabIndex = 3;
            this.gbxTableNumber.TabStop = false;
            // 
            // lblMarker
            // 
            this.lblMarker.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblMarker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarker.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMarker.Location = new System.Drawing.Point(258, 16);
            this.lblMarker.Name = "lblMarker";
            this.lblMarker.Size = new System.Drawing.Size(112, 58);
            this.lblMarker.TabIndex = 1;
            this.lblMarker.Text = "1";
            this.lblMarker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxItems
            // 
            this.gbxItems.Controls.Add(this.lbxCost);
            this.gbxItems.Controls.Add(this.lbxQuantity);
            this.gbxItems.Controls.Add(this.lbxItems);
            this.gbxItems.Controls.Add(this.lblCost);
            this.gbxItems.Controls.Add(this.lblQty);
            this.gbxItems.Controls.Add(this.lblItems);
            this.gbxItems.Location = new System.Drawing.Point(469, 109);
            this.gbxItems.Name = "gbxItems";
            this.gbxItems.Size = new System.Drawing.Size(627, 267);
            this.gbxItems.TabIndex = 4;
            this.gbxItems.TabStop = false;
            // 
            // lbxCost
            // 
            this.lbxCost.FormattingEnabled = true;
            this.lbxCost.ItemHeight = 25;
            this.lbxCost.Location = new System.Drawing.Point(512, 24);
            this.lbxCost.Name = "lbxCost";
            this.lbxCost.Size = new System.Drawing.Size(115, 204);
            this.lbxCost.TabIndex = 1;
            // 
            // lbxQuantity
            // 
            this.lbxQuantity.FormattingEnabled = true;
            this.lbxQuantity.ItemHeight = 25;
            this.lbxQuantity.Location = new System.Drawing.Point(391, 24);
            this.lbxQuantity.Name = "lbxQuantity";
            this.lbxQuantity.Size = new System.Drawing.Size(122, 204);
            this.lbxQuantity.TabIndex = 1;
            // 
            // lbxItems
            // 
            this.lbxItems.FormattingEnabled = true;
            this.lbxItems.ItemHeight = 25;
            this.lbxItems.Location = new System.Drawing.Point(0, 24);
            this.lbxItems.Name = "lbxItems";
            this.lbxItems.Size = new System.Drawing.Size(392, 204);
            this.lbxItems.TabIndex = 1;
            // 
            // lblCost
            // 
            this.lblCost.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCost.Location = new System.Drawing.Point(512, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(115, 25);
            this.lblCost.TabIndex = 0;
            this.lblCost.Text = "Cost";
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQty
            // 
            this.lblQty.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQty.Location = new System.Drawing.Point(391, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(122, 25);
            this.lblQty.TabIndex = 0;
            this.lblQty.Text = "Quantity";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItems
            // 
            this.lblItems.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblItems.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblItems.Location = new System.Drawing.Point(0, 0);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(392, 25);
            this.lblItems.TabIndex = 0;
            this.lblItems.Text = "Item";
            this.lblItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxOrderInfo
            // 
            this.gbxOrderInfo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbxOrderInfo.Controls.Add(this.gbxPayInfo);
            this.gbxOrderInfo.Controls.Add(this.btnCheckout);
            this.gbxOrderInfo.Controls.Add(this.btnRemove);
            this.gbxOrderInfo.Controls.Add(this.tbxCustNameInput);
            this.gbxOrderInfo.Controls.Add(this.lblOrderTypeOutput);
            this.gbxOrderInfo.Controls.Add(this.lblOrderType);
            this.gbxOrderInfo.Controls.Add(this.lblCustomerName);
            this.gbxOrderInfo.Location = new System.Drawing.Point(469, 384);
            this.gbxOrderInfo.Name = "gbxOrderInfo";
            this.gbxOrderInfo.Size = new System.Drawing.Size(627, 193);
            this.gbxOrderInfo.TabIndex = 4;
            this.gbxOrderInfo.TabStop = false;
            // 
            // gbxPayInfo
            // 
            this.gbxPayInfo.BackColor = System.Drawing.Color.Linen;
            this.gbxPayInfo.Controls.Add(this.lblGrand);
            this.gbxPayInfo.Controls.Add(this.lblTotal);
            this.gbxPayInfo.Controls.Add(this.lblGrandOutput);
            this.gbxPayInfo.Controls.Add(this.lblTotalOutput);
            this.gbxPayInfo.Controls.Add(this.lblTaxOutput);
            this.gbxPayInfo.Controls.Add(this.lblTax);
            this.gbxPayInfo.Location = new System.Drawing.Point(373, 25);
            this.gbxPayInfo.Name = "gbxPayInfo";
            this.gbxPayInfo.Size = new System.Drawing.Size(248, 125);
            this.gbxPayInfo.TabIndex = 3;
            this.gbxPayInfo.TabStop = false;
            // 
            // lblGrand
            // 
            this.lblGrand.Location = new System.Drawing.Point(4, 103);
            this.lblGrand.Name = "lblGrand";
            this.lblGrand.Size = new System.Drawing.Size(100, 19);
            this.lblGrand.TabIndex = 0;
            this.lblGrand.Text = "Grand Total:";
            this.lblGrand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(40, 54);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(61, 19);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGrandOutput
            // 
            this.lblGrandOutput.Location = new System.Drawing.Point(181, 100);
            this.lblGrandOutput.Name = "lblGrandOutput";
            this.lblGrandOutput.Size = new System.Drawing.Size(61, 22);
            this.lblGrandOutput.TabIndex = 0;
            this.lblGrandOutput.Text = "0.00";
            this.lblGrandOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalOutput
            // 
            this.lblTotalOutput.Location = new System.Drawing.Point(181, 52);
            this.lblTotalOutput.Name = "lblTotalOutput";
            this.lblTotalOutput.Size = new System.Drawing.Size(61, 22);
            this.lblTotalOutput.TabIndex = 0;
            this.lblTotalOutput.Text = "0.00";
            this.lblTotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTaxOutput
            // 
            this.lblTaxOutput.Location = new System.Drawing.Point(181, 2);
            this.lblTaxOutput.Name = "lblTaxOutput";
            this.lblTaxOutput.Size = new System.Drawing.Size(61, 22);
            this.lblTaxOutput.TabIndex = 0;
            this.lblTaxOutput.Text = "0.00";
            this.lblTaxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTax
            // 
            this.lblTax.Location = new System.Drawing.Point(38, 2);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(61, 22);
            this.lblTax.TabIndex = 0;
            this.lblTax.Text = "Tax:";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCheckout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCheckout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCheckout.Location = new System.Drawing.Point(518, 156);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(103, 31);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemove.Location = new System.Drawing.Point(9, 156);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(103, 31);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbxCustNameInput
            // 
            this.tbxCustNameInput.Location = new System.Drawing.Point(11, 50);
            this.tbxCustNameInput.Name = "tbxCustNameInput";
            this.tbxCustNameInput.ReadOnly = true;
            this.tbxCustNameInput.Size = new System.Drawing.Size(260, 30);
            this.tbxCustNameInput.TabIndex = 1;
            // 
            // lblOrderTypeOutput
            // 
            this.lblOrderTypeOutput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderTypeOutput.Location = new System.Drawing.Point(108, 112);
            this.lblOrderTypeOutput.Name = "lblOrderTypeOutput";
            this.lblOrderTypeOutput.Size = new System.Drawing.Size(66, 20);
            this.lblOrderTypeOutput.TabIndex = 0;
            this.lblOrderTypeOutput.Text = "Table";
            // 
            // lblOrderType
            // 
            this.lblOrderType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderType.Location = new System.Drawing.Point(9, 112);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(124, 20);
            this.lblOrderType.TabIndex = 0;
            this.lblOrderType.Text = "Order Type:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCustomerName.Location = new System.Drawing.Point(9, 26);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(154, 25);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(9, 205);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.Size = new System.Drawing.Size(434, 311);
            this.dgvMenu.TabIndex = 5;
            this.dgvMenu.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMenu_CellMouseClick);
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.BackColor = System.Drawing.Color.Honeydew;
            this.btnAddToOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddToOrder.Location = new System.Drawing.Point(9, 529);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(109, 44);
            this.btnAddToOrder.TabIndex = 1;
            this.btnAddToOrder.Text = "ADD";
            this.btnAddToOrder.UseVisualStyleBackColor = false;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // lblMultiplier
            // 
            this.lblMultiplier.Location = new System.Drawing.Point(134, 543);
            this.lblMultiplier.Name = "lblMultiplier";
            this.lblMultiplier.Size = new System.Drawing.Size(35, 30);
            this.lblMultiplier.TabIndex = 6;
            this.lblMultiplier.Text = "X";
            // 
            // tbxQty
            // 
            this.tbxQty.Location = new System.Drawing.Point(175, 538);
            this.tbxQty.Name = "tbxQty";
            this.tbxQty.Size = new System.Drawing.Size(57, 30);
            this.tbxQty.TabIndex = 7;
            this.tbxQty.Text = "0";
            this.tbxQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmEditOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 583);
            this.Controls.Add(this.tbxQty);
            this.Controls.Add(this.lblMultiplier);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.gbxOrderInfo);
            this.Controls.Add(this.gbxItems);
            this.Controls.Add(this.gbxTableNumber);
            this.Controls.Add(this.btnAppetizers);
            this.Controls.Add(this.btnSoups);
            this.Controls.Add(this.btnDrinks);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.btnDesserts);
            this.Controls.Add(this.btnEntrees);
            this.Controls.Add(this.lblBackColor);
            this.Controls.Add(this.lblBorder2);
            this.Controls.Add(this.lblBorder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fancy! - Orders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditOrders_FormClosing);
            this.Load += new System.EventHandler(this.frmEditOrders_Load);
            this.gbxTableNumber.ResumeLayout(false);
            this.gbxItems.ResumeLayout(false);
            this.gbxOrderInfo.ResumeLayout(false);
            this.gbxOrderInfo.PerformLayout();
            this.gbxPayInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBorder;
        private System.Windows.Forms.Button btnEntrees;
        private System.Windows.Forms.Button btnDesserts;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnSoups;
        private System.Windows.Forms.Button btnAppetizers;
        private System.Windows.Forms.Label lblBorder2;
        private System.Windows.Forms.Label lblBackColor;
        private System.Windows.Forms.GroupBox gbxTableNumber;
        private System.Windows.Forms.Label lblMarker;
        private System.Windows.Forms.GroupBox gbxItems;
        private System.Windows.Forms.GroupBox gbxOrderInfo;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.ListBox lbxCost;
        private System.Windows.Forms.ListBox lbxQuantity;
        private System.Windows.Forms.ListBox lbxItems;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox tbxCustNameInput;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Label lblOrderTypeOutput;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.GroupBox gbxPayInfo;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblGrand;
        private System.Windows.Forms.Label lblTaxOutput;
        private System.Windows.Forms.Label lblTotalOutput;
        private System.Windows.Forms.Label lblGrandOutput;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Label lblMultiplier;
        private System.Windows.Forms.TextBox tbxQty;
    }
}