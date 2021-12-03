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
    public partial class frmSupplies : Form
    {
        public frmSupplies()
        {
            InitializeComponent();
        }

        public static List<string> items = new List<string>();
        public static List<string> quantites = new List<string>();
        public static List<string> unitPrices = new List<string>();
        public static List<string> supID = new List<string>();
        public static List<string> prodID = new List<string>();


        double subTotal;


        private void Supplies_Load(object sender, EventArgs e)
        {
            ProgOps.DatabaseCommandSupplies(dgvSupplies);
            cbxQuantity.SelectedIndex = 0;
            lblProductName.Text = dgvSupplies.CurrentRow.Cells[1].Value.ToString();
            lblOnHand.Text = dgvSupplies.CurrentRow.Cells[3].Value.ToString();
        }

        private void dgvSupplies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblProductName.Text = dgvSupplies.CurrentRow.Cells[1].Value.ToString();
            lblOnHand.Text = dgvSupplies.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if (cbxQuantity.SelectedItem == null)
            {
                MessageBox.Show("Please select quantity!", "No quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool found = false;
            int count = 0;
            foreach (var item in items)
            {

                if (item == lblProductName.Text)
                {
                    int qty = Int32.Parse(quantites[count]);
                    qty += Int32.Parse(cbxQuantity.SelectedItem.ToString());
                    quantites[count] = qty.ToString();
                    found = true;
                }
                count++;
            }

            if (!found)
            {
                items.Add(lblProductName.Text);
                quantites.Add(cbxQuantity.SelectedItem.ToString());
                unitPrices.Add(dgvSupplies.CurrentRow.Cells[2].Value.ToString());
                supID.Add(dgvSupplies.CurrentRow.Cells[4].Value.ToString());
                prodID.Add(dgvSupplies.CurrentRow.Cells[0].Value.ToString());

            }
            // clear both carts 
            lbxCart.Items.Clear();
            lbxQuantity.Items.Clear();
            

            cbxQuantity.SelectedIndex = 0;

            // repopulateListBoxes
            populateListBoxes();

            //update totals
            MathForOrder(lblSubtotal, lblTax, lblTotal);
        }
        private void MathForOrder(Label sub, Label totalTaxes, Label netPay) 
        {
            subTotal = 0.0;
            double tax = 0.0;
            double net = 0.0;
            double chargeTax = .0825;

            for (int i = 0; i <unitPrices.Count(); i++)
            {
                subTotal += (Convert.ToDouble(unitPrices[i]) * Convert.ToDouble(quantites[i]));
            }

            tax = subTotal * chargeTax;
            net = subTotal + tax;

            sub.Text = subTotal.ToString("C");
            totalTaxes.Text = tax.ToString("C");
            netPay.Text = net.ToString("C");
        }

        private void populateListBoxes()
        {
            //repopulate the list boxes
            for (int i = 0; i < items.Count; i++)
            {
                lbxCart.Items.Add(items[i]);
                lbxQuantity.Items.Add(quantites[i]);

            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbxCart.SelectedIndex == -1)
            {
                MessageBox.Show("Select an item to remove from the list", "Item not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // removes all items at the selected index
            items.RemoveAt(lbxCart.SelectedIndex);
            quantites.RemoveAt(lbxCart.SelectedIndex);
            unitPrices.RemoveAt(lbxCart.SelectedIndex);
            supID.RemoveAt(lbxCart.SelectedIndex);
            prodID.RemoveAt(lbxCart.SelectedIndex);


            //update totals
            MathForOrder(lblSubtotal, lblTax, lblTotal);            
            // clear both carts 
            lbxCart.Items.Clear();
            lbxQuantity.Items.Clear();
            // repopulate
            populateListBoxes();

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            //clear all lists and 0 out totals
            lbxCart.Items.Clear();
            lbxQuantity.Items.Clear();
            items.Clear();
            quantites.Clear();
            unitPrices.Clear();

            MathForOrder(lblSubtotal, lblTax, lblTotal);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (items.Count > 0)
            {
                //todays date
                var dateString = DateTime.Now.ToString("yyyy-MM-dd");
                // submit order and order details
                string invoiceID = (ProgOps.ReadCurrentInvoiceID() + 1).ToString();
                ProgOps.submitSuppliesOrder(dateString, invoiceID, subTotal);
                //clear all lists and 0 out totals
                lbxCart.Items.Clear();
                lbxQuantity.Items.Clear();
                items.Clear();
                quantites.Clear();
                unitPrices.Clear();
                MathForOrder(lblSubtotal, lblTax, lblTotal);
            }            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
