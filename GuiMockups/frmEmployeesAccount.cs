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
            ProgOps.DatabaseCommand(tbxEmployeeID, tbxLastName, tbxFirstName, tbxReportTo, tbxAddress, tbxEmail, tbxCity, tbxState, tbxZip, tbxPhone, tbxUserName, tbxPassword);
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
            //call validation function.
            /*if (!ValidateData())
            {
                return;
            }*/

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

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
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
                    btnPrev.Enabled = true;
                    btnNext.Enabled = true;
                    btnAdd.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnExit.Enabled = true;
                    tbxLastName.Focus();
                    break;
                case "Add New":
                    tbxEmployeeID.BackColor = Color.Red;
                    tbxEmployeeID.ForeColor = Color.White;
                    tbxLastName.ReadOnly = false;
                    tbxFirstName.ReadOnly = false;
                    btnPrev.Enabled = false;
                    btnNext.Enabled = false;
                    btnAdd.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnExit.Enabled = false;
                    tbxLastName.Focus();
                    break;
                case "Edit":
                    tbxEmployeeID.BackColor = Color.Red;
                    tbxEmployeeID.ForeColor = Color.White;
                    tbxLastName.ReadOnly = false;
                    tbxFirstName.ReadOnly = false;
                    btnPrev.Enabled = false;
                    btnNext.Enabled = false;
                    btnAdd.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnExit.Enabled = false;
                    tbxLastName.Focus();
                    break;
            }
        }


    }
}
