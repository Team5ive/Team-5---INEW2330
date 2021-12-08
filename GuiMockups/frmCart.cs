using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiMockups
{
    public partial class frmCart : Form
    {
        public frmCart()
        {
            InitializeComponent();
        }

        private void btnContinueShopping_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCustomerOrder order = new frmCustomerOrder();
            order.ShowDialog(); // reopen form to update quantities
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            ProgOps.AddToCart(dgvCart);
            ProgOps.MathForTotals(lblSubtotal, lblTax, lblNetTotal);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ProgOps.Remove(dgvCart);
            dgvCart.Rows.Clear();
            ProgOps.AddToCart(dgvCart);
            ProgOps.MathForTotals(lblSubtotal, lblTax, lblNetTotal);
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            ProgOps.ClearList();
            dgvCart.Rows.Clear();
            ProgOps.MathForTotals(lblSubtotal, lblTax, lblNetTotal);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (ProgOps.Name.Count > 0)
            {
                // submit orders to database( both orders and orderDetails) 
                var dateString = DateTime.Now.ToString("yyyy-MM-dd");
                string orderID = (ProgOps.ReadCurrentOrderID() + 1).ToString();
                string checkOutDigit = (ProgOps.ReadCurrentCheckDigit() + 1).ToString();
                ProgOps.checkOutOrder(dateString, orderID, checkOutDigit);
                // clear all order information 
                ProgOps.ClearList();
                dgvCart.Rows.Clear();
                ProgOps.MathForTotals(lblSubtotal, lblTax, lblNetTotal);
                // opens frmReceipt next 
                CrystalReports.crptCustomerReciept reciept = new CrystalReports.crptCustomerReciept();
                reciept.SetDatabaseLogon("group5fa212330", "5283165");
                frmReceipt frmReciept = new frmReceipt();
                frmReciept.crvReciept.ReportSource = null;
                frmReciept.crvReciept.ReportSource = reciept;
                frmReciept.Show();
            }
            else
            {
                MessageBox.Show("No items to checkout", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
