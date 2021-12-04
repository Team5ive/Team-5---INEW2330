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
    public partial class frmEditReservations : Form
    {
        public frmEditReservations()
        {
            InitializeComponent();
        }

        public static List<string> tablesBooked = new List<string>();
        List<string> availableTables = new List<string>();
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // deletes Reservation
            ProgOps.DeleteReservation(tbxReserveID.Text);
            MessageBox.Show("Reservation Deleted");
            //fill data grid view
            ProgOps.ReservationCommand(dgvReservations);        
        }
        public  void createList()
        {
            //adds to List
            availableTables.Clear();
            availableTables.Add("1");
            availableTables.Add("2");
            availableTables.Add("3");
            availableTables.Add("4");
            availableTables.Add("5");
            availableTables.Add("6");
            availableTables.Add("7");
            availableTables.Add("8");
            availableTables.Add("9");
            availableTables.Add("10");
            //remove based on tables booked
            foreach (string i in tablesBooked)
            {
                switch (i)
                {
                    case "1":
                        availableTables.Remove("1");
                        break;
                    case "2":
                        availableTables.Remove("2");
                        break;
                    case "3":
                        availableTables.Remove("3");
                        break;
                    case "4":
                        availableTables.Remove("4");
                        break;
                    case "5":
                        availableTables.Remove("5");
                        break;
                    case "6":
                        availableTables.Remove("6");
                        break;
                    case "7":
                        availableTables.Remove("7");
                        break;
                    case "8":
                        availableTables.Remove("8");
                        break;
                    case "9":
                        availableTables.Remove("9");
                        break;
                    case "10":
                        availableTables.Remove("10");
                        break;
                }

            }

        }
        private void frmEditReservations_Load(object sender, EventArgs e)
        {
            ProgOps.ReservationCommand(dgvReservations);
        }

        private void dgvReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxReserveID.Text = dgvReservations.CurrentRow.Cells[0].Value.ToString();
            tbxCustomerID.Text = dgvReservations.CurrentRow.Cells[1].Value.ToString();
            tbxCustFirst.Text = dgvReservations.CurrentRow.Cells[2].Value.ToString();
            tbxCustLast.Text = dgvReservations.CurrentRow.Cells[3].Value.ToString();
            String dateAndTime = dgvReservations.CurrentRow.Cells[4].Value.ToString();

            String[] dateTimeSplit = dateAndTime.Split('/', ' ',':');

            cbxMonth.SelectedItem = dateTimeSplit[0];
            cbxDay.SelectedItem = dateTimeSplit[1];
            cbxYear.SelectedItem = dateTimeSplit[2];
            cbxHour.SelectedItem = dateTimeSplit[3];



            //tbxReserveDate.Text = dgvReservations.CurrentRow.Cells[4].Value.ToString();
            tbxTableNum.Text = dgvReservations.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbxHour.SelectedIndex == -1 || cbxYear.SelectedIndex == -1 || cbxMonth.SelectedIndex == -1 ||
                cbxDay.SelectedIndex == -1)
            {
                MessageBox.Show("All fields must be filled", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //clear list.
            tablesBooked.Clear();
            

            string justDate = "";
            justDate = cbxYear.Text + "-" + cbxMonth.Text + "-" + cbxDay.Text; 
            string addTime = " " + (int.Parse(cbxHour.Text) + 12) + ":00";
            string updatedDateTime = justDate + addTime;

            //fill bookedTables list 
            ProgOps.pullBookedTables(justDate);
            //fill availableTables list
            createList();

            if (tablesBooked.Count < 10)
            {
                // edit/update reservation
                ProgOps.EditCustomerReservations(tbxReserveID.Text, updatedDateTime, availableTables[0]);
                //fill data grid view
                ProgOps.ReservationCommand(dgvReservations);
            }
            
        }
    }
}
