using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiMockups
{
    public partial class frmForgotPass : Form
    {
        string grabCode;
        bool employee;
        bool customer;
        public frmForgotPass()
        {
            InitializeComponent();
        }

        private void frmForgotPass_Load(object sender, EventArgs e)
        {
            lblVerifCode.Visible = false;
            tbxVerifCode.Visible = false;
            lblPassword.Visible = false;
            tbxPassword.Visible = false;
            lblVerify.Visible = false;
            lblChangePass.Visible = false;
            employee = false;
            customer = false;
        }

        private void lblSendCode_Click(object sender, EventArgs e)
        {
            string email = tbxEmail.Text;
            int emailHash = email.GetHashCode();
            bool custLogin = false;
            bool empLogin = false;

            ProgOps.GetVerificationCodes();
            if (tbxEmail.Text == "")
            {
                //error message
                MessageBox.Show("Please enter an email address in the specified area.", "Error Obtaining Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxEmail.Focus();
                return;
            }

            for (int i = 0; i < frmLogin.CustEmails.Count; i++)
            {
                int listEmailHash = frmLogin.CustEmails[i].GetHashCode();
                if (emailHash == listEmailHash)
                {
                    custLogin = true;
                }
            }

            for (int i = 0; i < frmLogin.EmpEmails.Count; i++)
            {
                int listEmailHash = frmLogin.EmpEmails[i].GetHashCode();
                if (emailHash == listEmailHash)
                {
                    empLogin = true;
                }
            }

            if (custLogin == true || empLogin == true)
            {
                if (custLogin == true)
                {
                    customer = true;
                }
                if (empLogin == true)
                {
                    employee = true;
                }
                try
                {
                    // create and initializes variables
                    Random _random = new Random();
                    string to = tbxEmail.Text;
                    string from = "teamfiverestaurant@gmail.com";
                    int pos = _random.Next(frmLogin.vCodes.Count);
                    string code = frmLogin.vCodes[pos].ToString();
                    grabCode = code;
                    frmLogin.vCodes.RemoveAt(pos);

                    //create and initialize smtpClient
                    var smtpClient = new SmtpClient("smtp.gmail.com")
                    {
                        Port = 587,
                        Credentials = new NetworkCredential(from, "TeamFive555"),
                        EnableSsl = true,
                    };

                    // custom email message to recipient
                    var mailMessage = new MailMessage
                    {
                        From = new MailAddress(from),
                        Subject = "Forgot Password?",
                        Body = "<h3><span style=\"text - decoration: underline; \"><span style=\"color: #b22222; text-decoration: underline;\">PASSWORD RESET REQUESTED</span></span></h3><p><em>Use the given verification code to reset your password</em></p><p>&nbsp;</p><p><span style=\"color: #bfc1c2;\">Verification Code:&nbsp;" + code + "</span></p>",
                        IsBodyHtml = true
                    };

                    mailMessage.Priority = MailPriority.Normal;
                    mailMessage.To.Add(to);

                    //Sends email
                    smtpClient.Send(mailMessage);
                    MessageBox.Show("Verification code sent. When recieved enter verification code and press the 'Verify' button.\n(Email with verification code may be in spam folder)", "Delivered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblVerifCode.Visible = true;
                    tbxVerifCode.Visible = true;
                    lblSendCode.Visible = false;
                    lblVerify.Visible = true;
                    tbxEmail.ReadOnly = true;
                    tbxVerifCode.Focus();
                }
                catch
                {
                    MessageBox.Show("Verification code not sent\n\nPlease try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //error message
                MessageBox.Show("Sorry but the email you have entered do not match our existing records.\nPlease try again", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxEmail.Text = "";
                tbxEmail.Focus();
                return;
            }
        }

        private void lblVerify_Click(object sender, EventArgs e)
        {
            int grabCodeHash = grabCode.GetHashCode();
            string verifCode = tbxVerifCode.Text;
            int verifHash = verifCode.GetHashCode();

            if (tbxVerifCode.Text == "")
            {
                //error message
                MessageBox.Show("Please enter your verification code in the specified area.", "Error Obtaining Verification Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxVerifCode.Focus();
                return;
            }
            if (grabCodeHash == verifHash)
            {
                tbxVerifCode.ReadOnly = true;
                lblChangePass.Visible = true;
                lblVerify.Visible = false;
                lblPassword.Visible = true;
                tbxPassword.Visible = true;
                MessageBox.Show("Verification Code Accepted. Please enter in your new password.", "Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxPassword.Focus();
            }
            else
            {
                //error message
                MessageBox.Show("The verification code you provided does not match our records. Please try again.", "Error Obtaining Verification Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxVerifCode.Focus();
                return;
            }
        }

        private void lblChangePass_Click(object sender, EventArgs e)
        {
            string pass = tbxPassword.Text;
            string email = tbxEmail.Text;
            if (pass.Length < 5 || pass.Length > 8)
            {
                //error message
                MessageBox.Show("Your password must be 5-8 characters.", "Error Obtaining Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxPassword.Clear();
                tbxPassword.Focus();
                return;
            }
            //check if password contains spaces
            for (int i = 0; i < pass.Length; i++)
            {
                if (pass[i] == ' ')
                {
                    //error message
                    MessageBox.Show("Your password must not contain spaces.", "Error Obtaining Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxPassword.Clear();
                    tbxPassword.Focus();
                    return;
                }
            }
            if (customer == true)
            {
                ProgOps.changeCustPassword(email, pass);
                this.Close();
            }
            if (employee == true)
            {
                ProgOps.changeEmpPassword(email, pass);
                this.Close();
            }
        }
    }
}
