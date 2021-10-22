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

        private void frmCustomerOrder_Load(object sender, EventArgs e)
        {
            gbxEntrees.Visible = false;
            gbxAppetizers.Visible = true;
            gbxSoups.Visible = false;
            gbxDesserts.Visible = false;
            gbxDrinks.Visible = false;
            ProgOps.imageChange(pbxApp1, "201");
            ProgOps.imageChange(pbxApp2, "202");
            ProgOps.imageChange(pbxApp3, "203");
        }

        private void btnEntrees_Click(object sender, EventArgs e)
        {
            gbxEntrees.Visible = true;
            gbxAppetizers.Visible = false;
            gbxSoups.Visible = false;
            gbxDesserts.Visible = false;
            gbxDrinks.Visible = false;
            ProgOps.imageChange(pbxEntree1, "101");
            ProgOps.imageChange(pbxEntree2, "102");
            ProgOps.imageChange(pbxEntree3, "103");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAppetizers_Click(object sender, EventArgs e)
        {
            gbxEntrees.Visible = false;
            gbxAppetizers.Visible = true;
            gbxSoups.Visible = false;
            gbxDesserts.Visible = false;
            gbxDrinks.Visible = false;
            ProgOps.imageChange(pbxApp1, "201");
            ProgOps.imageChange(pbxApp2, "202");
            ProgOps.imageChange(pbxApp3, "203");
        }

        private void btnSoups_Click(object sender, EventArgs e)
        {
            gbxEntrees.Visible = false;
            gbxAppetizers.Visible = false;
            gbxSoups.Visible = true;
            gbxDesserts.Visible = false;
            gbxDrinks.Visible = false;
            ProgOps.imageChange(pbxSoup1, "301");
            ProgOps.imageChange(pbxSoup2, "302");
            ProgOps.imageChange(pbxSoup3, "303");
        }

        private void btnDesserts_Click(object sender, EventArgs e)
        {
            gbxDesserts.Visible = true;
            gbxEntrees.Visible = false;
            gbxAppetizers.Visible = false;
            gbxSoups.Visible = false;
            gbxDrinks.Visible = false;
            ProgOps.imageChange(pbxDessert1, "501");
            ProgOps.imageChange(pbxDessert2, "502");
            ProgOps.imageChange(pbxDessert3, "503");
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            gbxDrinks.Visible = true;
            gbxEntrees.Visible = false;
            gbxAppetizers.Visible = false;
            gbxSoups.Visible = false;
            gbxDesserts.Visible = false;
            ProgOps.imageChange(pbxDrink1, "401");
            ProgOps.imageChange(pbxDrink2, "402");
            ProgOps.imageChange(pbxDrink3, "403");
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
    }
}
