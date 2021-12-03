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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // deletes Reservation
            ProgOps.DeleteReservation(tbxReserveID.Text);
            MessageBox.Show("Reservation Deleted");
            //fill data grid view
            ProgOps.ReservationCommand(dgvReservations);        
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
            tbxReserveDate.Text = dgvReservations.CurrentRow.Cells[4].Value.ToString();
            tbxTableNum.Text = dgvReservations.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            //fill data grid view
            ProgOps.ReservationCommand(dgvReservations);
        }
    }
}
