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
        public static List<string> custID = new List<string>();
        public static List<string> employID = new List<string>();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //open database
            ProgOps.OpenDatabase();
            tbxEmail.SelectAll();
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

        private void btnSignIn_Click(object sender, EventArgs e)
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
                string customerID = custID[i];
                if (emailHash == listEmailHash && passHash == listPassHash)
                {
                    ProgOps.CustID = customerID;
                    custLogin = true;
                }
            }
            //compares employee email and passwords to user email and passwords
            for (int i = 0; i < EmpEmails.Count; i++)
            {
                int listEmailHash = EmpEmails[i].GetHashCode();
                int listPassHash = EmpPass[i].GetHashCode();
                string isManager = EmpIsManager[i];
                string employeeID = employID[i];
                if (emailHash == listEmailHash && passHash == listPassHash)
                {
                    ProgOps.EmpID = employeeID;
                    ProgOps.Manager = isManager;
                    empLogin = true;
                }
            }
            //looks for true bool
            if (custLogin == true || empLogin == true)
            {
                //shows different forms dependent on login
                if (custLogin == true)
                {
                    tbxEmail.Text = "";
                    tbxPassword.Text = "";
                    frmCustomerHome frmCustomerHome = new frmCustomerHome();
                    frmCustomerHome.ShowDialog();

                }
                if (empLogin == true)
                {
                    tbxEmail.Text = "";
                    tbxPassword.Text = "";
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
    }
}
