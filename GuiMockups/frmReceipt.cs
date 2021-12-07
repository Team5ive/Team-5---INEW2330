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
    public partial class frmReceipt : Form
    {
        public static int orderNumber = frmTables.orderNum;
        public frmReceipt()
        {
            InitializeComponent();
        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {

        }

        private void crvReciept_Load(object sender, EventArgs e)
        {
            int od = orderNumber;
        }
    }
}
