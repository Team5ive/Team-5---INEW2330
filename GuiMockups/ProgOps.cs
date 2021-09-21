using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GuiMockups
{
    class ProgOps
    {
        //connection string
        private const string CONNECT_STRING = @"Server=cstnt.tstc.edu;Database= inew2330fa21;User Id=group5fa212330;password=5283165";
        //build a connection to db
        private static SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);
        public static void OpenDatabase()
        {
            //open the connection to database
            _cntDatabase.Open();
            MessageBox.Show("Open Database Successful", "Open Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void CloseDatabase()
        {
            //close connection
            _cntDatabase.Close();
            //dispose of database
            _cntDatabase.Dispose();
            MessageBox.Show("Close Database Successful", "Close Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }


}

