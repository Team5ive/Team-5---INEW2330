﻿using System;
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
            btnApp1.Visible = true;
            btnApp2.Visible = true;
            btnApp3.Visible = true;
            btnApp4.Visible = true;
            btnDessert1.Visible = false;
            btnDessert2.Visible = false;
            btnDessert3.Visible = false;
            btnDessert4.Visible = false;
            btnDrink1.Visible = false;
            btnDrink2.Visible = false;
            btnDrink3.Visible = false;
            btnDrink4.Visible = false;
            btnEntree1.Visible = false;
            btnEntree2.Visible = false;
            btnEntree3.Visible = false;
            btnEntree4.Visible = false;
            btnSoup1.Visible = false;
            btnSoup2.Visible = false;
            btnSoup3.Visible = false;
            btnSoup4.Visible = false;

        }

        private void btnEntrees_Click(object sender, EventArgs e)
        {
            btnApp1.Visible = false;
            btnApp2.Visible = false;
            btnApp3.Visible = false;
            btnApp4.Visible = false;
            btnDessert1.Visible = false;
            btnDessert2.Visible = false;
            btnDessert3.Visible = false;
            btnDessert4.Visible = false;
            btnDrink1.Visible = false;
            btnDrink2.Visible = false;
            btnDrink3.Visible = false;
            btnDrink4.Visible = false;
            btnEntree1.Visible = true;
            btnEntree2.Visible = true;
            btnEntree3.Visible = true;
            btnEntree4.Visible = true;
            btnSoup1.Visible = false;
            btnSoup2.Visible = false;
            btnSoup3.Visible = false;
            btnSoup4.Visible = false;
        }

        private void btnSoups_Click(object sender, EventArgs e)
        {
            btnApp1.Visible = false;
            btnApp2.Visible = false;
            btnApp3.Visible = false;
            btnApp4.Visible = false;
            btnDessert1.Visible = false;
            btnDessert2.Visible = false;
            btnDessert3.Visible = false;
            btnDessert4.Visible = false;
            btnDrink1.Visible = false;
            btnDrink2.Visible = false;
            btnDrink3.Visible = false;
            btnDrink4.Visible = false;
            btnEntree1.Visible = false;
            btnEntree2.Visible = false;
            btnEntree3.Visible = false;
            btnEntree4.Visible = false;
            btnSoup1.Visible = true;
            btnSoup2.Visible = true;
            btnSoup3.Visible = true;
            btnSoup4.Visible = true;
        }

        private void btnDesserts_Click(object sender, EventArgs e)
        {
            btnApp1.Visible = false;
            btnApp2.Visible = false;
            btnApp3.Visible = false;
            btnApp4.Visible = false;
            btnDessert1.Visible = true;
            btnDessert2.Visible = true;
            btnDessert3.Visible = true;
            btnDessert4.Visible = true;
            btnDrink1.Visible = false;
            btnDrink2.Visible = false;
            btnDrink3.Visible = false;
            btnDrink4.Visible = false;
            btnEntree1.Visible = false;
            btnEntree2.Visible = false;
            btnEntree3.Visible = false;
            btnEntree4.Visible = false;
            btnSoup1.Visible = false;
            btnSoup2.Visible = false;
            btnSoup3.Visible = false;
            btnSoup4.Visible = false;
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            btnApp1.Visible = false;
            btnApp2.Visible = false;
            btnApp3.Visible = false;
            btnApp4.Visible = false;
            btnDessert1.Visible = false;
            btnDessert2.Visible = false;
            btnDessert3.Visible = false;
            btnDessert4.Visible = false;
            btnDrink1.Visible = true;
            btnDrink2.Visible = true;
            btnDrink3.Visible = true;
            btnDrink4.Visible = true;
            btnEntree1.Visible = false;
            btnEntree2.Visible = false;
            btnEntree3.Visible = false;
            btnEntree4.Visible = false;
            btnSoup1.Visible = false;
            btnSoup2.Visible = false;
            btnSoup3.Visible = false;
            btnSoup4.Visible = false;
        }

        private void frmEditOrders_Load(object sender, EventArgs e)
        {
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
