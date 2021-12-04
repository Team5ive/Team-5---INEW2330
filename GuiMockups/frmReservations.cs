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
    public partial class frmReservations : Form
    {
        public static List<string> bookedTables = new List<string>();
        public static List<string> availableTables = new List<string>();
        public frmReservations()
        {
            InitializeComponent();
        }
        public static void createList()
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
            foreach (string i in bookedTables)
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
        private void btnBookNow_Click(object sender, EventArgs e)
        {
            //validation combo box option selection
            if (cbxTimes.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Reservation time.", "No Time Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbxPartySize.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Reservation time.", "No Time Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime todaysDate = DateTime.Now;
            DateTime selectedDate = calReservationDate.SelectionStart.Date;
            if (selectedDate > todaysDate)
            {
                //clear list.
                bookedTables.Clear();
                //fill bookedTables list 
                ProgOps.pullBookedTables(calReservationDate.SelectionStart.Date.ToString("yyyy-MM-dd"));
                //fill availableTables list
                createList();
                string strTime = cbxTimes.Text;
                DateTime convertTime = DateTime.Parse(strTime);

                //party size less than 4 and bookedTable list less than 10 means tables are available 
                if (Int32.Parse(cbxPartySize.Text) <= 4 && bookedTables.Count < 10)
                {
                    // book tables(date, time, table)
                    ProgOps.bookReservation(calReservationDate.SelectionStart.Date.ToString("yyyy-MM-dd"), convertTime.ToString("HH:mm"), availableTables[0]);
                }
                else if (Int32.Parse(cbxPartySize.Text) >= 4 && bookedTables.Count < 9)
                {
                    //book tables(date, time, table)
                    ProgOps.bookReservation(calReservationDate.SelectionStart.Date.ToString("yyyy-MM-dd"), convertTime.ToString("HH:mm"), availableTables[0]);
                    ProgOps.bookReservation(calReservationDate.SelectionStart.Date.ToString("yyyy-MM-dd"), convertTime.ToString("HH:mm"), availableTables[1]);
                }
                else
                {
                    //no available tables at specified time
                    MessageBox.Show("No tables available during the time slot selected", "Booked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbxTimes.SelectedIndex = -1;
                    return;
                }
                MessageBox.Show("Your Request for " + calReservationDate.SelectionStart.Date.ToString("yyyy-MM-dd") + " at " + strTime + " has been reserved!", "Reserved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Reservation only available as early as tomorrow", "Unable to process reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
    }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
