using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * 
 * Team 5 
 * Kellie Moore
 * Anthony Gallegos
 * Daniel Deleon
 *
 */

namespace GuiMockups
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProgOps.disposeConnection();
        }

        private void mnuMainItmSignLog_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }

        private void mnuMainItmMenu_Click(object sender, EventArgs e)
        {
            frmDisplayMenu menu = new frmDisplayMenu();
            menu.ShowDialog();
        }

        private void mnuMainItmAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void mnuMainItmHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpFancy.HelpNamespace);

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            hlpFancy.HelpNamespace = Application.StartupPath + "\\FancyHelp.chm";
        }
    }
}
