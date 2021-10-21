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
            //open database
            ProgOps.OpenDatabase();
            tbxEmail.Focus();
            //fill lists
            ProgOps.GetCustInfo();
            ProgOps.GetEmpInfo();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProgOps.CloseDatabase();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            //opens frmforgotpass
            frmForgotPass frmForgotPass = new frmForgotPass();
            frmForgotPass.ShowDialog();
        }

        private void lblSignIn_Click(object sender, EventArgs e)
        {
            //clears lists
            CustEmails.Clear();
            CustPass.Clear();
            EmpEmails.Clear();
            EmpPass.Clear();
            //fills lists
            ProgOps.GetCustInfo();
            ProgOps.GetEmpInfo();
            //initializes variables
            string email = tbxEmail.Text;
            string pass = tbxPassword.Text;
            int emailHash = email.GetHashCode();
            int passHash = pass.GetHashCode();
            bool custLogin = false;
            bool empLogin = false;
            //tests empty email
            if (tbxEmail.Text == "")
            {
                //error message
                MessageBox.Show("Please enter an email address or username in the specified area.", "Error Obtaining Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxEmail.Focus();
                return;
            }
            //tests empty password
            if (tbxPassword.Text == "")
            {
                //error message
                MessageBox.Show("Please enter a password in the specified area.", "Error Obtaining Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxEmail.Focus();
                return;
            }
            //compares customer email and passwords to user email and passwords
            for (int i = 0; i < CustEmails.Count; i++)
            {
                int listEmailHash = CustEmails[i].GetHashCode();
                int listPassHash = CustPass[i].GetHashCode();
                if (emailHash == listEmailHash && passHash == listPassHash)
                {
                    custLogin = true;
                }
            }
            //compares employee email and passwords to user email and passwords
            for (int i = 0; i < EmpEmails.Count; i++)
            {
                int listEmailHash = EmpEmails[i].GetHashCode();
                int listPassHash = EmpPass[i].GetHashCode();
                if (emailHash == listEmailHash && passHash == listPassHash)
                {
                    empLogin = true;
                }
            }
            //looks for true bool
            if (custLogin == true || empLogin == true)
            {
                //shows different forms dependent on login
                if (custLogin == true)
                {
                    frmCustomerHome frmCustomerHome = new frmCustomerHome();
                    frmCustomerHome.ShowDialog();
                }
                if (empLogin == true)
                {
                    frmEmployeeHub frmEmployeeHub = new frmEmployeeHub();
                    frmEmployeeHub.ShowDialog();
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

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            //opens sign up form
            frmSignUp frmSignUp = new frmSignUp();
            frmSignUp.ShowDialog();
        }

        private void lblJoin_Click(object sender, EventArgs e)
        {
            //opens sign up form
            frmSignUp frmSignUp = new frmSignUp();
            frmSignUp.ShowDialog();
        }
    }
}
