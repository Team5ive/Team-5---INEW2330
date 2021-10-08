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
        public frmReservations()
        {
            InitializeComponent();
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            //get the date selected in the month calendar assigns value to a string. 
            string calDate = calReservationDate.SelectionRange.Start.ToShortDateString();
        }
    }
}
