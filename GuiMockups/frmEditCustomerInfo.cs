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
            

            bool isFirstCharLetter = false, isSecondCharAlphaNum = false,
                    isAtSymbolPresent = false, spacesInEmail = false;
            bool validEmail = false;
            int countAt = 0, countPeriod = 0;

            try
            {
                if (tbxFirstName.Text.Trim() == "" || tbxLastName.Text.Trim() == "" ||
                tbxAddress.Text.Trim() == "" || tbxCity.Text.Trim() == "" || tbxState.Text.Trim() == "" ||
                tbxZip.Text.Trim() == "" || tbxPhone.Text.Trim() == "" || tbxEmail.Text.Trim() == "")
                {
                    MessageBox.Show("Please fill out all fields in personal information", "Warning - Personal information empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                for (int i = 0; i < tbxEmail.Text.Length; i++)
                {

                    if (i == 0 && char.IsLetter(tbxEmail.Text[i]))
                    {
                        isFirstCharLetter = true;
                    }
                    if (i == 1 && char.IsLetterOrDigit(tbxEmail.Text[i]))
                    {
                        isSecondCharAlphaNum = true;
                    }
                    if (tbxEmail.Text[i] == '@')
                    {
                        isAtSymbolPresent = true;
                        countAt++;
                    }
                    if (countAt >= 2)
                    {
                        isAtSymbolPresent = false;
                    }
                    if (tbxEmail.Text[i] == ' ')
                    {
                        spacesInEmail = true;
                    }

                    if (i == tbxEmail.Text.Length - 1)
                    {
                        if (isFirstCharLetter && isSecondCharAlphaNum && isAtSymbolPresent && !(spacesInEmail))
                        {
                            //updates customer information

                            ProgOps.updateCustomerInfo(tbxFirstName.Text, tbxLastName.Text, tbxAddress.Text, tbxCity.Text, tbxState.Text, tbxZip.Text, tbxPhone.Text, tbxEmail.Text);
                            MessageBox.Show("Account Updated Successfully", "Account Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else if (!isFirstCharLetter)
                        {
                            MessageBox.Show("First character must be a letter", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (!isSecondCharAlphaNum)
                        {
                            MessageBox.Show("Second character should be a letter/Number", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (!isAtSymbolPresent)
                        {
                            MessageBox.Show("Only allow one @ symbol in email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (spacesInEmail)
                        {
                            MessageBox.Show("Email cant contain spaces", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnUpdateLogin_Click(object sender, EventArgs e)
        {
            if (tbxUserName.Text.Trim() == "" || tbxPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please fill out all fields in login information", "Warning - Login information empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //update customer login information
            ProgOps.updateCustomerLogin(tbxUserName.Text, tbxPassword.Text);
        }

        private void tbxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only letter, back space
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' || (int)e.KeyChar == 8)
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
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' || (int)e.KeyChar == 8)
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
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' || (int)e.KeyChar == 8)
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
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' || (int)e.KeyChar == 8)
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
