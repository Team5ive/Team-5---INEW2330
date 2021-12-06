namespace GuiMockups
{
    partial class frmReceipt
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
            this.crvReciept = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReciept
            // 
            this.crvReciept.ActiveViewIndex = -1;
            this.crvReciept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReciept.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReciept.DisplayStatusBar = false;
            this.crvReciept.DisplayToolbar = false;
            this.crvReciept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReciept.Location = new System.Drawing.Point(0, 0);
            this.crvReciept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.crvReciept.Name = "crvReciept";
            this.crvReciept.Size = new System.Drawing.Size(827, 452);
            this.crvReciept.TabIndex = 0;
            this.crvReciept.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 452);
            this.Controls.Add(this.crvReciept);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fancy! - Receipt";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvReciept;
    }
}