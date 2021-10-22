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
    public partial class frmEditCustomerInfo : Form
    {
        public frmEditCustomerInfo()
        {
            InitializeComponent();
        }

        private void frmEditCustomerInfo_Load(object sender, EventArgs e)
        {
            //fill text boxes with customers information
            ProgOps.insertCustInfo(tbxFirstName, tbxLastName, tbxAddress, tbxCity, tbxState, tbxZip, tbxPhone, tbxEmail, tbxUserName, tbxPassword);
        }

        private void cbxPassword_CheckedChanged(object sender, EventArgs e)
        {
            //show or hide password
            if (cbxPassword.Checked)
            {
                tbxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbxPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            //updates customer information
            ProgOps.updateCustomerInfo(tbxFirstName.Text, tbxLastName.Text, tbxAddress.Text, tbxCity.Text, tbxState.Text, tbxZip.Text, tbxPhone.Text, tbxEmail.Text);
        }

        private void btnUpdateLogin_Click(object sender, EventArgs e)
        {
            //update customer login information
            ProgOps.updateCustomerLogin(tbxUserName.Text, tbxPassword.Text);
        }

        private void tbxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only letter, back space
            if (e.KeyChar >= 'A' && e.KeyChar <= 'z' || (int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only letter, back space
            if (e.KeyChar >= 'A' && e.KeyChar <= 'z' || (int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbxCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only letter, back space
            if (e.KeyChar >= 'A' && e.KeyChar <= 'z' || (int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbxState_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only letter, back space
            if (e.KeyChar >= 'A' && e.KeyChar <= 'z' || (int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbxZip_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only numbers, back space
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || (int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only numbers, back space, dashes
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || (int)e.KeyChar == 8 || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
