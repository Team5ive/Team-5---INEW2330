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
    public partial class frmCustomerHome : Form
    {
        public frmCustomerHome()
        {
            InitializeComponent();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            frmReservations reservations = new frmReservations();
            reservations.ShowDialog();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmCustomerOrder order = new frmCustomerOrder();
            order.ShowDialog();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmEditCustomerInfo editCustomerInfo = new frmEditCustomerInfo();
            editCustomerInfo.ShowDialog();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            //sign out message
            MessageBox.Show("You have been signed out.", "Sign Out Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
