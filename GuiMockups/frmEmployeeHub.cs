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
    public partial class frmEmployeeHub : Form
    {
        public frmEmployeeHub()
        {
            InitializeComponent();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            //sign out message
            MessageBox.Show("You have been signed out.", "Sign Out Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void frmEmployeeHub_Load(object sender, EventArgs e)
        {

        }

        private void btnCustOrders_Click(object sender, EventArgs e)
        {
            frmTables frmTables = new frmTables();
            frmTables.ShowDialog();
        }

        private void btnOrderSupplies_Click(object sender, EventArgs e)
        {
            frmSupplies frmSupplies = new frmSupplies();
            frmSupplies.ShowDialog();
        }

        private void btnChangeReserve_Click(object sender, EventArgs e)
        {

        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            frmEmployeesAccount editAccount = new frmEmployeesAccount();
            editAccount.ShowDialog();
        }

    }
}
