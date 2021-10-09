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
        //add command object
        private static SqlCommand _sqlResultsCommand;
        //add the data adapter
        private static SqlDataAdapter _daResults = new SqlDataAdapter();
        //add the data tables
        private static DataTable _dtResultsTable = new DataTable();

        //add command object
        private static SqlCommand _sqlResultsCommand2;
        //add the data adapter
        private static SqlDataAdapter _daResults2 = new SqlDataAdapter();
        //add the data tables
        private static DataTable _dtResultsTable2 = new DataTable();
        //--- frmCustomerOrder

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
        public static void GetVerificationCodes()
        {
            try
            {
                //grabs all values from verify table
                string query = "SELECT * FROM group5fa212330.Verify";
                //create update command
                SqlCommand _sqlGetCodesCommand = new SqlCommand(query, _cntDatabase);
                //initializes reader
                SqlDataReader read = _sqlGetCodesCommand.ExecuteReader();
                //reads the connection and adds the codes to the list
                while (read.Read())
                {
                    frmLogin.vCodes.Add((read["VerificationCode"].ToString()));
                }
                //closes the reader
                read.Close();
                //update command
                _sqlGetCodesCommand.Dispose();
            }
            catch (Exception ex)
            {
                //error message
                MessageBox.Show(ex.Message, "Error Obtaining Verification Codes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void GetCustInfo()
        {
            try
            {
                //grabs all values from customers table
                string query = "SELECT Email, UserName, Password FROM group5fa212330.Customers";
                //create update command
                SqlCommand _sqlCustCommand = new SqlCommand(query, _cntDatabase);
                //initializes reader
                SqlDataReader read = _sqlCustCommand.ExecuteReader();
                //reads the connection and adds the codes to the list
                while (read.Read())
                {
                    frmLogin.CustEmails.Add((read["Email"].ToString()));
                    frmLogin.CustEmails.Add((read["UserName"].ToString()));
                    frmLogin.CustPass.Add((read["Password"].ToString()));
                    frmLogin.CustPass.Add((read["Password"].ToString()));
                }
                //closes the reader
                read.Close();
                //update command
                _sqlCustCommand.Dispose();
            }
            catch (Exception ex)
            {
                //error message
                MessageBox.Show(ex.Message, "Error Obtaining Customer Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void GetEmpInfo()
        {
            try
            {
                //grabs all values from employees table
                string query = "SELECT Email, UserName, Password, isManager FROM group5fa212330.Employees";
                //create update command
                SqlCommand _sqlEmpCommand = new SqlCommand(query, _cntDatabase);
                //initializes reader
                SqlDataReader read = _sqlEmpCommand.ExecuteReader();
                //reads the connection and adds the codes to the list
                while (read.Read())
                {
                    frmLogin.EmpEmails.Add((read["Email"].ToString()));
                    frmLogin.EmpEmails.Add((read["UserName"].ToString()));
                    frmLogin.EmpPass.Add((read["Password"].ToString()));
                    frmLogin.EmpPass.Add((read["Password"].ToString()));
                    frmLogin.EmpIsManager.Add((read["isManager"].ToString()));
                }
                //closes the reader
                read.Close();
                //update command
                _sqlEmpCommand.Dispose();
            }
            catch (Exception ex)
            {
                //error message
                MessageBox.Show(ex.Message, "Error Obtaining Employee Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}

