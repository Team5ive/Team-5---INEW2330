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
        public frmTables()
        {
            InitializeComponent();
        }

        private void lblTable1_Click(object sender, EventArgs e)
        {
            //loads the shop now form on menu item click
            frmEditOrders frmEditOrders = new frmEditOrders();
            frmEditOrders.ShowDialog();
        }

        private void lblSuppliesView_Click(object sender, EventArgs e)
        {
            //loads the shop now form on menu item click
            frmSupplies frmSupplies = new frmSupplies();
            frmSupplies.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
