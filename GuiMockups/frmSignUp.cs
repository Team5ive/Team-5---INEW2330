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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            bool isFirstCharLetter = false, isSecondCharAlphaNum = false,
                isAtSymbolPresent = false, spacesInEmail = false;
            bool validEmail = false;
            int countAt = 0, countPeriod = 0;
            
            try
            {
                if (tbxFirstName.Text == "")
                {
                    //error message
                    MessageBox.Show("Please enter your First Name.", "Fill out all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxFirstName.Focus();
                    return;
                }
                if (tbxLastName.Text == "")
                {
                    //error message
                    MessageBox.Show("Please enter your Last Name.", "Fill out all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxLastName.Focus();
                    return;
                }
                if (tbxEmail.Text == "")
                {
                    //error message
                    MessageBox.Show("Please enter your Email.", "Fill out all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxEmail.Focus();
                    return;
                }
                if (tbxUserName.Text == "")
                {
                    //error message
                    MessageBox.Show("Please enter your Username.", "Fill out all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxUserName.Focus();
                    return;
                }
                if (tbxPassword.Text == "")
                {
                    //error message
                    MessageBox.Show("Please enter your Password.", "Fill out all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxPassword.Focus();
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
                            
                            ProgOps.createCustomerLogin(tbxFirstName.Text, tbxLastName.Text, tbxEmail.Text, tbxPassword.Text, tbxUserName.Text);
                            MessageBox.Show("Account Created Successfully", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void tbxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //no spaces allowed >:(
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
            
        }

        private void tbxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //no spaces allowed >:(
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            tbxFirstName.Focus();
        }

        private void frmSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProgOps.GetEmpInfo();
            ProgOps.GetCustInfo();
        }
    }
}
