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

        }
    }
}
