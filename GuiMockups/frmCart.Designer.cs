namespace GuiMockups
{
    partial class frmCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCart));
            this.lblColor2 = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.lblColor1 = new System.Windows.Forms.Label();
            this.gbxTotals = new System.Windows.Forms.GroupBox();
            this.lblMsgSubtotal = new System.Windows.Forms.Label();
            this.lblNetTotal = new System.Windows.Forms.Label();
            this.lblMsgTaxAmount = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblMsgNetTotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnContinueShopping = new System.Windows.Forms.Button();
            this.pbxShell1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.gbxTotals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShell1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblColor2
            // 
            this.lblColor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.lblColor2.Location = new System.Drawing.Point(-14, 54);
            this.lblColor2.Name = "lblColor2";
            this.lblColor2.Size = new System.Drawing.Size(785, 5);
            this.lblColor2.TabIndex = 50;
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(147, 71);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 62;
            this.dgvCart.Size = new System.Drawing.Size(452, 222);
            this.dgvCart.TabIndex = 49;
            // 
            // lblColor1
            // 
            this.lblColor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lblColor1.Location = new System.Drawing.Point(53, 71);
            this.lblColor1.Name = "lblColor1";
            this.lblColor1.Size = new System.Drawing.Size(651, 222);
            this.lblColor1.TabIndex = 48;
            // 
            // gbxTotals
            // 
            this.gbxTotals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.gbxTotals.Controls.Add(this.lblMsgSubtotal);
            this.gbxTotals.Controls.Add(this.lblNetTotal);
            this.gbxTotals.Controls.Add(this.lblMsgTaxAmount);
            this.gbxTotals.Controls.Add(this.lblTax);
            this.gbxTotals.Controls.Add(this.lblMsgNetTotal);
            this.gbxTotals.Controls.Add(this.lblSubtotal);
            this.gbxTotals.Location = new System.Drawing.Point(21, 308);
            this.gbxTotals.Name = "gbxTotals";
            this.gbxTotals.Size = new System.Drawing.Size(352, 141);
            this.gbxTotals.TabIndex = 47;
            this.gbxTotals.TabStop = false;
            // 
            // lblMsgSubtotal
            // 
            this.lblMsgSubtotal.AutoSize = true;
            this.lblMsgSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.lblMsgSubtotal.Location = new System.Drawing.Point(67, 25);
            this.lblMsgSubtotal.Name = "lblMsgSubtotal";
            this.lblMsgSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblMsgSubtotal.TabIndex = 14;
            this.lblMsgSubtotal.Text = "Subtotal:";
            // 
            // lblNetTotal
            // 
            this.lblNetTotal.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblNetTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNetTotal.Location = new System.Drawing.Point(133, 94);
            this.lblNetTotal.Name = "lblNetTotal";
            this.lblNetTotal.Size = new System.Drawing.Size(135, 28);
            this.lblNetTotal.TabIndex = 19;
            this.lblNetTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMsgTaxAmount
            // 
            this.lblMsgTaxAmount.AutoSize = true;
            this.lblMsgTaxAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.lblMsgTaxAmount.Location = new System.Drawing.Point(14, 64);
            this.lblMsgTaxAmount.Name = "lblMsgTaxAmount";
            this.lblMsgTaxAmount.Size = new System.Drawing.Size(102, 13);
            this.lblMsgTaxAmount.TabIndex = 15;
            this.lblMsgTaxAmount.Text = "Tax Amount(8.25%):";
            // 
            // lblTax
            // 
            this.lblTax.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTax.Location = new System.Drawing.Point(133, 56);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(135, 28);
            this.lblTax.TabIndex = 18;
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMsgNetTotal
            // 
            this.lblMsgNetTotal.AutoSize = true;
            this.lblMsgNetTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.lblMsgNetTotal.Location = new System.Drawing.Point(62, 102);
            this.lblMsgNetTotal.Name = "lblMsgNetTotal";
            this.lblMsgNetTotal.Size = new System.Drawing.Size(54, 13);
            this.lblMsgNetTotal.TabIndex = 16;
            this.lblMsgNetTotal.Text = "Net Total:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotal.Location = new System.Drawing.Point(133, 17);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(135, 28);
            this.lblSubtotal.TabIndex = 17;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.btnCheckOut.Location = new System.Drawing.Point(591, 391);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(117, 41);
            this.btnCheckOut.TabIndex = 46;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.btnRemove.Location = new System.Drawing.Point(438, 324);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(117, 41);
            this.btnRemove.TabIndex = 45;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnClearCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.btnClearCart.Location = new System.Drawing.Point(591, 324);
            this.btnClearCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(117, 41);
            this.btnClearCart.TabIndex = 44;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.UseVisualStyleBackColor = false;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnContinueShopping
            // 
            this.btnContinueShopping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnContinueShopping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(207)))), ((int)(((byte)(96)))));
            this.btnContinueShopping.Location = new System.Drawing.Point(438, 391);
            this.btnContinueShopping.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContinueShopping.Name = "btnContinueShopping";
            this.btnContinueShopping.Size = new System.Drawing.Size(117, 41);
            this.btnContinueShopping.TabIndex = 43;
            this.btnContinueShopping.Text = "Continue Shopping";
            this.btnContinueShopping.UseVisualStyleBackColor = false;
            this.btnContinueShopping.Click += new System.EventHandler(this.btnContinueShopping_Click);
            // 
            // pbxShell1
            // 
            this.pbxShell1.Image = ((System.Drawing.Image)(resources.GetObject("pbxShell1.Image")));
            this.pbxShell1.Location = new System.Drawing.Point(-11, 5);
            this.pbxShell1.Name = "pbxShell1";
            this.pbxShell1.Size = new System.Drawing.Size(782, 46);
            this.pbxShell1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxShell1.TabIndex = 51;
            this.pbxShell1.TabStop = false;
            // 
            // frmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(757, 456);
            this.ControlBox = false;
            this.Controls.Add(this.pbxShell1);
            this.Controls.Add(this.lblColor2);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.lblColor1);
            this.Controls.Add(this.gbxTotals);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.btnContinueShopping);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fancy! - Check Out ";
            this.Load += new System.EventHandler(this.frmCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.gbxTotals.ResumeLayout(false);
            this.gbxTotals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShell1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxShell1;
        private System.Windows.Forms.Label lblColor2;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lblColor1;
        private System.Windows.Forms.GroupBox gbxTotals;
        private System.Windows.Forms.Label lblMsgSubtotal;
        private System.Windows.Forms.Label lblNetTotal;
        private System.Windows.Forms.Label lblMsgTaxAmount;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblMsgNetTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnContinueShopping;
    }
}