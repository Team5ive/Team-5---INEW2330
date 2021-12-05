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
    public partial class frmTables : Form
    {
        public static List<string> TableNum = new List<string>();
        public static int orderNum;
        public double orderPrice;
        public static int customerId;
        public static int employeeId;
        public static int tableNum;
        public static bool dineIn;
        public static string customerName;
        public DataGridView orders { get { return this.dgvOrders; } }
        public frmTables()
        {
            InitializeComponent();
        }

        private void lblSuppliesView_Click(object sender, EventArgs e)
        {
            //loads the shop now form on menu item click
            frmSupplies frmSupplies = new frmSupplies();
            frmSupplies.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ProgOps.GetTablesInfo();
            ProgOps.DatabaseCommandOrders(dgvOrders);

            for (int i = 0; i < TableNum.Count; i++)
            {
                
                switch (Convert.ToInt32(TableNum[i]))
                {
                    case 0:
                        break;
                    case 1:
                        lblTable1.BackColor = Color.CornflowerBlue;
                        break;
                    case 2:
                        lblTable2.BackColor = Color.CornflowerBlue;
                        break;
                    case 3:
                        lblTable3.BackColor = Color.CornflowerBlue;
                        break;
                    case 4:
                        lblTable4.BackColor = Color.CornflowerBlue;
                        break;
                    case 5:
                        lblTable5.BackColor = Color.CornflowerBlue;
                        break;
                    case 6:
                        lblTable6.BackColor = Color.CornflowerBlue;
                        break;
                    case 7:
                        lblTable7.BackColor = Color.CornflowerBlue;
                        break;
                    case 8:
                        lblTable8.BackColor = Color.CornflowerBlue;
                        break;
                    case 9:
                        lblTable9.BackColor = Color.CornflowerBlue;
                        break;
                    case 10:
                        lblTable10.BackColor = Color.CornflowerBlue;
                        break;
                }
            }
        }

        private void dgvOrders_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow orders;
            //grab the row index number
            orders = dgvOrders.Rows[e.RowIndex];
            //add values to the variables dependent on which row is clicked
            orderNum = Convert.ToInt32(orders.Cells[0].Value);
            customerId = Convert.ToInt32(orders.Cells[1].Value);
            tableNum = Convert.ToInt32(orders.Cells[5].Value);
            dineIn = Convert.ToBoolean(orders.Cells[6].Value);
            orderPrice = Convert.ToDouble(orders.Cells[4].Value);
            ProgOps.GetOrderName(customerId);
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count < 0)
            {
                //error message
                MessageBox.Show("Must select an order to view", "Select Order", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }
            else
            {
                frmEditOrders frmEditOrders = new frmEditOrders();
                frmEditOrders.ShowDialog();
            }
        }

        private void dgvOrders_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvOrders.Columns["Order_Date"].Visible = false;
        }

        private void frmTables_Activated(object sender, EventArgs e)
        {
            ProgOps.GetTablesInfo();
            dgvOrders.Refresh();
            ProgOps.DatabaseCommandOrders(dgvOrders);
        }
    }
}
