using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;

namespace GuiMockups
{
    class ProgOps
    {
        //connection string
        private const string CONNECT_STRING = @"Server=cstnt.tstc.edu;Database= inew2330fa21;User Id=group5fa212330;password=5283165";
        //build a connection to db
        private static SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);

        // this is a test, anthony. hello!
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
        // ----- frmCustomerOrder(imageChange, changeLabel)
        public static void imageChange(PictureBox pbxItem1, string menuID)
        {
            _sqlResultsCommand = new SqlCommand("SELECT Menu_Image FROM [group5fa212330].[Menu] WHERE Menu_ID = " + menuID, _cntDatabase);

            SqlDataAdapter da = new SqlDataAdapter(_sqlResultsCommand);

            DataSet ds = new DataSet();

            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)

            {

                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Menu_Image"]);

                pbxItem1.Image = new Bitmap(ms);

            }

            //dispose of command, adapter, and table objects
            _sqlResultsCommand.Dispose();
            _daResults.Dispose();
            _dtResultsTable.Dispose();
        }

        public static void changeLabels(Label description1, string menuID)
        {
            try
            {
                //string to build a query
                string query = "SELECT Menu_Description FROM [group5fa212330].[Menu] WHERE Menu_ID =" + menuID;
                //establish a command object
                _sqlResultsCommand2 = new SqlCommand(query, _cntDatabase);
                //establish data adapter
                _daResults2 = new SqlDataAdapter();
                _daResults2.SelectCommand = _sqlResultsCommand2;
                //fill the data table
                _dtResultsTable2 = new DataTable();
                _daResults2.Fill(_dtResultsTable2);
                //bind to controls to data table 
                description1.DataBindings.Add("Text", _dtResultsTable2, "Menu_Description");
                _sqlResultsCommand2.Dispose();
                _daResults2.Dispose();
                _dtResultsTable2.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }
    }


}

