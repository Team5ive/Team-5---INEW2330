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
            ProgOps.DeleteReservation(tbxReserveID.Text);

            if (this.dgvReservations.DataSource != null)
            {
                this.dgvReservations.DataSource = null;
            }
            else
            {
                this.dgvReservations.Rows.Clear();
            }

            ProgOps.ReservationCommand(dgvReservations);
            MessageBox.Show("Reservation Deleted");
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
    }
}
