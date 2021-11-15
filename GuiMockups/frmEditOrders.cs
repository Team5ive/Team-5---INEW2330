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
    public partial class frmEditOrders : Form
    {
        public static List<int> Qty = new List<int>();
        public static List<string> ItemName = new List<string>();
        public static List<double> Cost = new List<double>();

        public frmEditOrders()
        {
            InitializeComponent();
        }

        private void btnAppetizers_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 22; i++)
            {           
                if (i == 5)
                {
                    dgvMenu.Rows[5].Visible = true;
                    dgvMenu.Rows[6].Visible = true;
                    dgvMenu.Rows[7].Visible = true;
                    dgvMenu.Rows[8].Visible = true;
                    dgvMenu.Rows[9].Visible = true;
                    i = 10;
                }
                CurrencyManager menuManager = (CurrencyManager)BindingContext[dgvMenu.DataSource];
                menuManager.SuspendBinding();
                dgvMenu.Rows[i].Visible = false;
                menuManager.ResumeBinding();
            }
        }

        private void btnEntrees_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 22; i++)
            {
                if (i == 0)
                {
                    dgvMenu.Rows[0].Visible = true;
                    dgvMenu.Rows[1].Visible = true;
                    dgvMenu.Rows[2].Visible = true;
                    dgvMenu.Rows[3].Visible = true;
                    dgvMenu.Rows[4].Visible = true;
                    i = 5;
                }
                dgvMenu.Rows[i].Visible = false;
            }
        }

        private void btnSoups_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 22; i++)
            {
                if (i == 10)
                {
                    dgvMenu.Rows[10].Visible = true;
                    dgvMenu.Rows[11].Visible = true;
                    dgvMenu.Rows[12].Visible = true;
                    dgvMenu.Rows[13].Visible = true;
                    i = 14;
                }
                CurrencyManager menuManager = (CurrencyManager)BindingContext[dgvMenu.DataSource];
                menuManager.SuspendBinding();
                dgvMenu.Rows[i].Visible = false;
                menuManager.ResumeBinding();
            }
        }

        private void btnDesserts_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 22; i++)
            {
                if (i == 18)
                {
                    dgvMenu.Rows[18].Visible = true;
                    dgvMenu.Rows[19].Visible = true;
                    dgvMenu.Rows[20].Visible = true;
                    dgvMenu.Rows[21].Visible = true;
                    break;
                }
                CurrencyManager menuManager = (CurrencyManager)BindingContext[dgvMenu.DataSource];
                menuManager.SuspendBinding();
                dgvMenu.Rows[i].Visible = false;
                menuManager.ResumeBinding();
            }
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 22; i++)
            {
                if (i == 14)
                {
                    dgvMenu.Rows[14].Visible = true;
                    dgvMenu.Rows[15].Visible = true;
                    dgvMenu.Rows[16].Visible = true;
                    dgvMenu.Rows[17].Visible = true;
                    i = 18;
                }
                CurrencyManager menuManager = (CurrencyManager)BindingContext[dgvMenu.DataSource];
                menuManager.SuspendBinding();
                dgvMenu.Rows[i].Visible = false;
                menuManager.ResumeBinding();
            }
        }

        private void frmEditOrders_Load(object sender, EventArgs e)
        {
            ProgOps.DatabaseCommandMenu(dgvMenu);

            double total = 0, tax = 0, grandTotal = 0;

            if (frmTables.tableNum > 0)
            {
                lblMarker.Text = frmTables.tableNum.ToString();
                lblOrderTypeOutput.Text = "Table " + frmTables.tableNum.ToString();
            }
            else
            {
                lblMarker.Text = "Online Order";
                lblOrderTypeOutput.Text = "Online";
            }
            tbxCustNameInput.Text = frmTables.customerName;
            ProgOps.GetOrderDetails(frmTables.orderNum);
            //adds the variables in the lists into the list boxes on start up
            for (int i = 0; i < Qty.Count; i++)
            {
                lbxQuantity.Items.Add(Qty[i]);
                lbxCost.Items.Add(Cost[i].ToString("c"));
                lbxItems.Items.Add(ItemName[i]);
                total += Cost[i];
            }
            tax = (total * .0825);
            grandTotal = total + tax;
            lblTaxOutput.Text = tax.ToString("c");
            lblTotalOutput.Text = total.ToString("c");
            lblGrandOutput.Text = grandTotal.ToString("c");
        }
    }
}
