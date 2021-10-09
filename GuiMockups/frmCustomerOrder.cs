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
    public partial class frmCustomerOrder : Form
    {
        public frmCustomerOrder()
        {
            InitializeComponent();
        }

        private void frmCustomerOrder_Load(object sender, EventArgs e)
        {
            ProgOps.imageChange(pbxMenu1, "101");
            ProgOps.imageChange(pbxMenu2, "102");
            ProgOps.imageChange(pbxMenu3, "103");
            ProgOps.changeLabels(lblDescription1, "101");
            ProgOps.changeLabels(lblDescription2, "102");
            ProgOps.changeLabels(lblDescription3, "103");
        }

        private void btnEntrees_Click(object sender, EventArgs e)
        {
            ProgOps.imageChange(pbxMenu1, "101");
            ProgOps.imageChange(pbxMenu2, "102");
            ProgOps.imageChange(pbxMenu3, "103");
            ProgOps.changeLabels(lblDescription1, "101");
            ProgOps.changeLabels(lblDescription2, "102");
            ProgOps.changeLabels(lblDescription3, "103");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
