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
        int count = 0;
        string selectedSection = "";

        private void frmCustomerOrder_Load(object sender, EventArgs e)
        {
            selectedSection = "Appetizers";
            gbxEntrees.Visible = false;
            gbxAppetizers.Visible = true;
            gbxSoups.Visible = false;
            gbxDesserts.Visible = false;
            gbxDrinks.Visible = false;
            ProgOps.imageChange(pbxApp1, "201");
            ProgOps.imageChange(pbxApp2, "202");
            ProgOps.imageChange(pbxApp3, "203");
            ProgOps.imageChange(pbxApp4, "204");
            lblCartItemAmount.Text = "Cart(" + ProgOps.Name.Count().ToString() + ")";

            
            

        }

        private void btnEntrees_Click(object sender, EventArgs e)
        {

            selectedSection = "Entrees";
            gbxEntrees.Visible = true;       
            gbxAppetizers.Visible = false;
            gbxSoups.Visible = false;
            gbxDesserts.Visible = false;
            gbxDrinks.Visible = false;
            ProgOps.imageChange(pbxEntree1, "101");
            ProgOps.imageChange(pbxEntree2, "102");
            ProgOps.imageChange(pbxEntree3, "103");
            ProgOps.imageChange(pbxEntree4, "104");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAppetizers_Click(object sender, EventArgs e)
        {
            selectedSection = "Appetizers";
            gbxEntrees.Visible = false;
            gbxAppetizers.Visible = true;
            gbxSoups.Visible = false;
            gbxDesserts.Visible = false;
            gbxDrinks.Visible = false;
            ProgOps.imageChange(pbxApp1, "201");
            ProgOps.imageChange(pbxApp2, "202");
            ProgOps.imageChange(pbxApp3, "203");
            ProgOps.imageChange(pbxApp4, "204");
        }

        private void btnSoups_Click(object sender, EventArgs e)
        {
            selectedSection = "Soups";
            gbxEntrees.Visible = false;
            gbxAppetizers.Visible = false;
            gbxSoups.Visible = true;
            gbxDesserts.Visible = false;
            gbxDrinks.Visible = false;
            ProgOps.imageChange(pbxSoup1, "301");
            ProgOps.imageChange(pbxSoup2, "302");
            ProgOps.imageChange(pbxSoup3, "303");
            ProgOps.imageChange(pbxSoup4, "304");
        }

        private void btnDesserts_Click(object sender, EventArgs e)
        {
            selectedSection = "Desserts";
            gbxDesserts.Visible = true;
            gbxEntrees.Visible = false;
            gbxAppetizers.Visible = false;
            gbxSoups.Visible = false;
            gbxDrinks.Visible = false;
            ProgOps.imageChange(pbxDessert1, "501");
            ProgOps.imageChange(pbxDessert2, "502");
            ProgOps.imageChange(pbxDessert3, "503");
            ProgOps.imageChange(pbxDessert4, "504");
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            selectedSection = "Drinks";
            
            gbxDrinks.Visible = true;
            gbxEntrees.Visible = false;
            gbxAppetizers.Visible = false;
            gbxSoups.Visible = false;
            gbxDesserts.Visible = false;
            ProgOps.imageChange(pbxDrink1, "401");
            ProgOps.imageChange(pbxDrink2, "402");
            ProgOps.imageChange(pbxDrink3, "403");
            ProgOps.imageChange(pbxDrink4, "404");

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {          
            count++;
            lblNum.Text = count.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (count >= 1)
            {
                count--;
                lblNum.Text = count.ToString();
            } 
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

            if (lblNum.Text == "0")
            {
                MessageBox.Show("Please select a quantity", "No quantity selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (selectedSection)
            {
                case "Appetizers":
                    if (!radApp1.Checked && !radApp2.Checked && !radApp3.Checked && !radApp4.Checked)
                    {
                        MessageBox.Show("Please select an item", "No item selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (radApp1.Checked)
                    {
                        ProgOps.GetDataForCart("Scallop", "24.99", lblNum.Text, "201");
                        lblNum.Text = "0";
                        count = 0;
                    }
                    if (radApp2.Checked)
                    {
                        ProgOps.GetDataForCart("Mesculin Salad", "19.99", lblNum.Text, "202");
                        lblNum.Text = "0";
                        count = 0;
                    }
                    if (radApp3.Checked)
                    {
                        ProgOps.GetDataForCart("Tuna-Urchin Toast", "21.99", lblNum.Text, "203");
                        lblNum.Text = "0";
                        count = 0;
                    }
                    if (radApp4.Checked)
                    {
                        ProgOps.GetDataForCart("Oysters", "19.99", lblNum.Text, "204");
                        lblNum.Text = "0";
                        count = 0;
                    }
                    break;
                case "Entrees":
                    if (!radEntree1.Checked && !radEntree2.Checked && !radEntree3.Checked && !radEntree4.Checked)
                    {
                        MessageBox.Show("Please select an item", "No item selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (radEntree1.Checked)
                    {
                        ProgOps.GetDataForCart("Krabby Patty", "10.00", lblNum.Text, "101");
                        lblNum.Text = "0";
                        count = 0;
                    }
                    if (radEntree2.Checked)
                    {
                        ProgOps.GetDataForCart("Dover Sole", "49.99", lblNum.Text, "102");
                        lblNum.Text = "0";
                        count = 0;
                    }
                    if (radEntree3.Checked)
                    {
                        ProgOps.GetDataForCart("Salmon Consommé", "59.99", lblNum.Text, "103");
                        lblNum.Text = "0";
                        count = 0;
                    }
                    if (radEntree4.Checked)
                    {
                        ProgOps.GetDataForCart("Surf and Turf", "69.99", lblNum.Text, "104");
                        lblNum.Text = "0";
                        count = 0;
                    }
                    break;
                case "Soups":
                    if (!radSoup1.Checked && !radSoup2.Checked && !radSoup3.Checked && !radSoup4.Checked)
                    {
                        MessageBox.Show("Please select an item", "No item selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (radSoup1.Checked)
                    {
                        ProgOps.GetDataForCart("Bouillabaisse", "29.99", lblNum.Text, "301");
                        lblNum.Text = "0";
                        count = 0;
                    }
                    if (radSoup2.Checked)
                    {
                        ProgOps.GetDataForCart("Cioppino", "29.99", lblNum.Text, "302");
                        lblNum.Text = "0";
                        count = 0;
                    }
                    if (radSoup3.Checked)
                    {
                        ProgOps.GetDataForCart("Shrimp Bisque", "29.99", lblNum.Text, "303");
                        lblNum.Text = "0";
                        count = 0;
                    }
                    if (radSoup4.Checked)
                    {
                        ProgOps.GetDataForCart("Oyster House Clam Chowder", "29.99", lblNum.Text, "304");
                        lblNum.Text = "0";
                        count = 0;
                    }
                    break;
                case "Desserts":
                    if (!radDessert1.Checked && !radDessert2.Checked && !radDessert3.Checked && !radDessert4.Checked)
                    {
                        MessageBox.Show("Please select an item", "No item selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (radDessert1.Checked)
                    {
                        ProgOps.GetDataForCart("Vacherin", "24.99", lblNum.Text, "501");
                        lblNum.Text = "0";
                        count = 0;
                    }
                    if (radDessert2.Checked)
                    {
                        ProgOps.GetDataForCart("Mille-Feuille", "19.99", lblNum.Text, "502");
                        lblNum.Text = "0";
                        count = 0;
                    }
                    if (radDessert3.Checked)
                    {
                        ProgOps.GetDataForCart("Baba Au Rhum", "21.99", lblNum.Text, "503");
                        lblNum.Text = "0";
                        count = 0;
                    }
                    if (radDessert4.Checked)
                    {
                        ProgOps.GetDataForCart("Black Forest", "27.99", lblNum.Text, "504");
                        lblNum.Text = "0";
                        count = 0;
                    }
                    break;
                case "Drinks":
                    if (!radDrink1.Checked && !radDrink2.Checked && !radDrink3.Checked && !radDrink4.Checked)
                    {
                        MessageBox.Show("Please select an item", "No item selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (radDrink1.Checked)
                    {
                        ProgOps.GetDataForCart("2009 Château Lafite Rothschild", "424.99", lblNum.Text, "401");
                        lblNum.Text = "0";
                        count = 0;
                    }
                    if (radDrink2.Checked)
                    {
                        ProgOps.GetDataForCart("2010 Domaine Romanee-Conti", "944.99", lblNum.Text, "402");
                        lblNum.Text = "0";
                        count = 0;
                    }
                    if (radDrink3.Checked)
                    {
                        ProgOps.GetDataForCart("2015 Guigal Côte Rôtie", "344.99", lblNum.Text, "403");
                        lblNum.Text = "0";
                        count = 0;
                    }
                    if (radDrink4.Checked)
                    {
                        ProgOps.GetDataForCart("Fountain Drink", "4.99", lblNum.Text, "404");
                        lblNum.Text = "0";
                        count = 0;
                    }
                    break;

                default:
                    break;
            }

            lblCartItemAmount.Text = "Cart(" + ProgOps.Name.Count().ToString() + ")";

        }

        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            frmCart cart = new frmCart();
            cart.ShowDialog();
            this.Close();// closes form to reload cart qty. re opens in close of cart form.
        }
    }
}
