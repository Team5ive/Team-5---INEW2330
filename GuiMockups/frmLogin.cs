using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace GuiMockups
{
    public partial class frmLogin : Form
    {
        public static List<string> vCodes = new List<string>();
        public static List<string> CustEmails = new List<string>();
        public static List<string> CustPass = new List<string>();
        public static List<string> EmpEmails = new List<string>();
        public static List<string> EmpPass = new List<string>();
        public static List<string> EmpIsManager = new List<string>();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ProgOps.OpenDatabase();
            ProgOps.GetCustInfo();
            ProgOps.GetEmpInfo();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProgOps.CloseDatabase();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
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

            for (int i = 0; i < CustEmails.Count; i++)
            {
                int listEmailHash = CustEmails[i].GetHashCode();
                if (emailHash == listEmailHash)
                {
                    custLogin = true;
                }
            }

            for (int i = 0; i < EmpEmails.Count; i++)
            {
                int listEmailHash = EmpEmails[i].GetHashCode();
                if (emailHash == listEmailHash)
                {
                    empLogin = true;
                }
            }

            if (custLogin == true || empLogin == true)
            {
                try
                {
                    // create and initializes variables
                    Random _random = new Random();
                    string to = tbxEmail.Text;
                    string from = "teamfiverestaurant@gmail.com";
                    int pos = _random.Next(vCodes.Count);
                    string code = vCodes[pos].ToString();
                    vCodes.RemoveAt(pos);

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
                }
                catch
                {
                    MessageBox.Show("Verification code not sent\n\nPlease try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("Verification code sent.(Email may be in spam folder)", "Delivered", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void lblSignIn_Click(object sender, EventArgs e)
        {
            string email = tbxEmail.Text;
            string pass = tbxPassword.Text;
            int emailHash = email.GetHashCode();
            int passHash = pass.GetHashCode();
            bool custLogin = false;
            bool empLogin = false;

            if (tbxEmail.Text == "")
            {
                //error message
                MessageBox.Show("Please enter an email address or username in the specified area.", "Error Obtaining Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxEmail.Focus();
                return;
            }
            if (tbxPassword.Text == "")
            {
                //error message
                MessageBox.Show("Please enter a password in the specified area.", "Error Obtaining Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxEmail.Focus();
                return;
            }

            for (int i = 0; i < CustEmails.Count; i++)
            {
                int listEmailHash = CustEmails[i].GetHashCode();
                int listPassHash = CustPass[i].GetHashCode();
                if (emailHash == listEmailHash && passHash == listPassHash)
                {
                    custLogin = true;
                }
            }

            for (int i = 0; i < EmpEmails.Count; i++)
            {
                int listEmailHash = EmpEmails[i].GetHashCode();
                int listPassHash = EmpPass[i].GetHashCode();
                if (emailHash == listEmailHash && passHash == listPassHash)
                {
                    empLogin = true;
                }
            }

            if (custLogin == true || empLogin == true)
            {
                if (custLogin == true)
                {
                    frmDisplayMenu frmDisplayMenu = new frmDisplayMenu();
                    frmDisplayMenu.ShowDialog();
                }
                if (empLogin == true)
                {
                    frmMain frmMain = new frmMain();
                    frmMain.ShowDialog();
                }
            }
            else
            {
                //error message
                MessageBox.Show("Sorry but the email/password you have entered does not match our existing records.\nPlease try again", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxEmail.Text = "";
                tbxPassword.Text = "";
                tbxEmail.Focus();
                return;
            }
        }
    }
}
