using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GuiMockups
{
    public partial class frmEmployeesAccount : Form
    {
        string myState;
        int myBookmark;
        public frmEmployeesAccount()
        {
            InitializeComponent();
        }

        //Establish currency manager at class level of main form
        CurrencyManager employeesManager;

        private void frmEmployeesAccount_Load(object sender, EventArgs e)
        {
            //call the database command with parameters of text-boxes
            ProgOps.DatabaseCommand(tbxEmployeeID, tbxLastName, tbxFirstName, tbxReportTo, tbxAddress, tbxEmail, tbxCity, tbxState, tbxZip, tbxPhone, tbxUserName, tbxPassword, tbxIsManager);
            //fill currency manager
            employeesManager = (CurrencyManager)this.BindingContext[ProgOps.EmployeesTable];
            SetState("View");
        }

        private void tbxEmployeeID_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbxReportTo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbxIsManager_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (employeesManager.Position == 0)
            {
                SystemSounds.Beep.Play();
            }
            employeesManager.Position--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (employeesManager.Position == employeesManager.Count - 1)
            {
                SystemSounds.Beep.Play();
            }
            employeesManager.Position++;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Set State to Edit
            SetState("Edit");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbxLastName.Text == "" || tbxFirstName.Text == "" ||
            tbxReportTo.Text == "" || tbxAddress.Text == "" || tbxEmail.Text == "" || 
            tbxCity.Text == "" || tbxState.Text == "" || tbxZip.Text == "" ||
            tbxPhone.Text == "" || tbxUserName.Text == "" ||tbxPassword.Text == "" ||
            tbxIsManager.Text == "")
            {
                MessageBox.Show("Please fill out all fields", "Warning - Input all fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                employeesManager.EndCurrentEdit();
                MessageBox.Show("Record saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //return to a view state at the end of Save
                SetState("View");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            employeesManager.CancelCurrentEdit();
            if (myState.Equals("Add"))
            {
                employeesManager.Position = myBookmark;
            }
            //set state to View
            SetState("View");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            myBookmark = employeesManager.Position;
            //set state to Add
            SetState("Add New");
            employeesManager.AddNew();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure you want to delete " +
                    "this record?", "Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                    == DialogResult.Yes)
                {
                    employeesManager.RemoveAt(employeesManager.Position);
                }
                SetState("View");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void SetState(string appState)
        {
            myState = appState;
            switch (appState)
            {
                case "View":
                    tbxEmployeeID.BackColor = Color.White;
                    tbxEmployeeID.ForeColor = Color.Black;
                    tbxLastName.ReadOnly = true;
                    tbxFirstName.ReadOnly = true;
                    tbxReportTo.ReadOnly = true;
                    tbxAddress.ReadOnly = true;
                    tbxEmail.ReadOnly = true;
                    tbxCity.ReadOnly = true;
                    tbxState.ReadOnly = true;
                    tbxZip.ReadOnly = true;
                    tbxPhone.ReadOnly = true;
                    tbxUserName.ReadOnly = true;
                    tbxPassword.ReadOnly = true;
                    tbxIsManager.ReadOnly = true;

                    btnPrev.Enabled = true;
                    btnNext.Enabled = true;
                    btnAdd.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnClose.Enabled = true;
                    tbxLastName.Focus();
                    break;
                case "Add New":
                    tbxEmployeeID.BackColor = Color.Red;
                    tbxEmployeeID.ForeColor = Color.White;
                    tbxLastName.ReadOnly = false;
                    tbxFirstName.ReadOnly = false;
                    tbxReportTo.ReadOnly = false;
                    tbxAddress.ReadOnly = false;
                    tbxEmail.ReadOnly = false;
                    tbxCity.ReadOnly = false;
                    tbxState.ReadOnly = false;
                    tbxZip.ReadOnly = false;
                    tbxPhone.ReadOnly = false;
                    tbxUserName.ReadOnly = false;
                    tbxPassword.ReadOnly = false;
                    tbxIsManager.ReadOnly = false;


                    btnPrev.Enabled = false;
                    btnNext.Enabled = false;
                    btnAdd.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnClose.Enabled = false;
                    tbxLastName.Focus();
                    break;
                case "Edit":
                    tbxEmployeeID.BackColor = Color.Red;
                    tbxEmployeeID.ForeColor = Color.White;
                    tbxLastName.ReadOnly = false;
                    tbxFirstName.ReadOnly = false;
                    tbxReportTo.ReadOnly = false;
                    tbxAddress.ReadOnly = false;
                    tbxEmail.ReadOnly = false;
                    tbxCity.ReadOnly = false;
                    tbxState.ReadOnly = false;
                    tbxZip.ReadOnly = false;
                    tbxPhone.ReadOnly = false;
                    tbxUserName.ReadOnly = false;
                    tbxPassword.ReadOnly = false;
                    tbxIsManager.ReadOnly = false;

                    btnPrev.Enabled = false;
                    btnNext.Enabled = false;
                    btnAdd.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnClose.Enabled = false;
                    tbxLastName.Focus();
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            /*Message box that asks if user is sure they want to exit with yes/no response…
             * If yes is selected Exit…
             * If no is selected go back to form.*/
            try
            {
                DialogResult response;
                response = MessageBox.Show("Are you sure you want to Exit?",
                    "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (response == DialogResult.No)
                {
                    return;
                }
                ProgOps.UpdateOnClose();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
