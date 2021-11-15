﻿using System;
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

        //lists for cart form
        private static List<string> _name = new List<string>();
        private static List<string> _quantity = new List<string>();

        private static List<string> _pricePerUnit = new List<string>();
        private static List<string> _totalPriceLine = new List<string>();

        // getters and setters for customer menu items
        public static List<string> Price_Per_Unit
        {
            get { return _pricePerUnit; }
            set { _pricePerUnit = value; }
        }
        public static List<string> Total_Price_Per_Line
        {
            get { return _totalPriceLine; }
            set { _totalPriceLine = value; }
        }
        public static List<string> Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public static List<string> Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        private static string _custID;

        public static string CustID
        {
            get { return _custID; }
            set { _custID = value; }
        }
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
            MessageBox.Show("Close Database Successful", "Close Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void disposeConnection() {
             //dispose of database
            _cntDatabase.Dispose();
        }
        //frmCustomerOrder(Add to cart button)
        public static void GetDataForCart(string name, string priceString, string qtyString)
        {
            double price = Double.Parse(priceString);
            int qty = Int32.Parse(qtyString);
            double total = 0;

            //***for your add to cart
            bool found = false;

            int count = 0;
            foreach (var item in _name)
            {

                if (item == name)
                {
                    int currentQty = Int32.Parse(Quantity[count]);
                    currentQty += qty;
                    Quantity[count] = currentQty.ToString();
                    found = true;
                    total = currentQty * price;
                    Total_Price_Per_Line[count] = total.ToString();
                    MessageBox.Show("Updated");
                }
                count++;
            }

            if (!found)
            {
                Name.Add(name);
                Price_Per_Unit.Add(priceString);
                Quantity.Add(qtyString);
                total = qty * price;
                Total_Price_Per_Line.Add(total.ToString());
                MessageBox.Show("New Addition!");
            }
        }
        //frmCarts
        public static void ClearList()
        {
            //clear list 
            Price_Per_Unit.Clear();
            Name.Clear();
            Quantity.Clear();
            Total_Price_Per_Line.Clear();
        }
        public static void AddToCart(DataGridView dv2)
        {
            //***for your shopping cart
            dv2.ColumnCount = 4;

            dv2.Columns[0].Name = "Menu Item";
            dv2.Columns[1].Name = "Price";
            dv2.Columns[2].Name = "Quantity";
            dv2.Columns[3].Name = "Total Price Per Line";

            for (int i = 0; i < Name.Count; i++)
            {
                int rowId = dv2.Rows.Add();
                dv2.Rows[rowId].Cells[0].Value = Name[i].ToString();
                dv2.Rows[rowId].Cells[1].Value = Price_Per_Unit[i].ToString();
                dv2.Rows[rowId].Cells[2].Value = Quantity[i].ToString();
                dv2.Rows[rowId].Cells[3].Value = Total_Price_Per_Line[i].ToString();
            }
        }
        //totals for frmCart
        public static void MathForTotals(Label s, Label t, Label n)
        {
            double subTotal = 0;
            double tax = 0;
            double net = 0;
            double chargeTax = .0825;

            for (int i = 0; i < Total_Price_Per_Line.Count(); i++)
            {
                subTotal += Convert.ToDouble(Total_Price_Per_Line[i]);
            }

            tax = subTotal * chargeTax;
            net = subTotal + tax;

            s.Text = subTotal.ToString("C");
            t.Text = tax.ToString("C");
            n.Text = net.ToString("C");

        }
        public static void Remove(DataGridView dgv1)
        {
            //remove 1 from quantity based on current selected row in data grid view.
            //Error
            int count = 0;
            bool zero = false;
            if (Name.Count > 0)
            {
                foreach (var item in Name)
                {
                    if (item == dgv1.CurrentRow.Cells[0].Value.ToString())
                    {
                        int currentQty = Int32.Parse(dgv1.CurrentRow.Cells[2].Value.ToString());
                        double price = Double.Parse(dgv1.CurrentRow.Cells[1].Value.ToString());
                        int newQty = currentQty - 1;
                        Quantity[count] = newQty.ToString();
                        double total = newQty * price;
                        Total_Price_Per_Line[count] = total.ToString();
                        if (newQty == 0)
                        {
                            zero = true;
                        }

                    }
                    count++;
                }
                if (zero)
                {
                    Name.Remove(dgv1.CurrentRow.Cells[0].Value.ToString());
                    Price_Per_Unit.Remove(dgv1.CurrentRow.Cells[1].Value.ToString());
                    Quantity.Remove(dgv1.CurrentRow.Cells[2].Value.ToString());
                    Total_Price_Per_Line.Remove(dgv1.CurrentRow.Cells[3].Value.ToString());
                }
            }
        }

        public static void pullBookedTables(string date)
        {
            try
            {
                //grabs all the book tables base on date passed in
                string query = "SELECT TableNumber FROM group5fa212330.Reservations WHERE CAST(ReserveDate AS DATE) ='" + date + "'";
                //create update command
                SqlCommand _sqlBookedTableCommand = new SqlCommand(query, _cntDatabase);
                //initializes reader
                SqlDataReader read = _sqlBookedTableCommand.ExecuteReader();
                //reads the connection and adds the codes to the list
                while (read.Read())
                {
                    frmReservations.bookedTables.Add(read["TableNumber"].ToString());
                }
                //closes the reader
                read.Close();
                //update command
                _sqlBookedTableCommand.Dispose();
            }
            catch (Exception ex)
            {
                //error message
                MessageBox.Show(ex.Message, "Error Obtaining Employee Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void bookReservation(string date, string time, string table)
        {
            try
            {
                // Insert for reservation
                string sqlStatement = "INSERT INTO group5fa212330.Reservations Values(" + _custID + ", '" + date + " " + time + "', " + table + ")";
                //create update command
                SqlCommand _sqlReservationCommand = new SqlCommand(sqlStatement, _cntDatabase);
                //update command
                _sqlReservationCommand.ExecuteNonQuery();
                //dispose
                _sqlReservationCommand.Dispose();
            }
            catch (Exception ex)
            {
                //show message on error
                MessageBox.Show(ex.Message, "Error in Booking Reservation.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void insertCustInfo(TextBox firstName, TextBox lastName, TextBox address, TextBox city, TextBox state, TextBox zip, TextBox phone, TextBox email, TextBox userName, TextBox password)
        {
            //string to build a query
            string query = "SELECT * FROM group5fa212330.Customers WHERE Cust_ID =" + _custID;
            //establish a command object
            _sqlResultsCommand2 = new SqlCommand(query, _cntDatabase);
            //establish data adapter
            _daResults2 = new SqlDataAdapter();
            _daResults2.SelectCommand = _sqlResultsCommand2;
            //fill the data table
            _dtResultsTable2 = new DataTable();
            _daResults2.Fill(_dtResultsTable2);
            //bind to controls to data table 
            // Cust_FName, Cust_LName, Address, City, State, Zip, Phone, Email, UserName
            firstName.DataBindings.Add("Text", _dtResultsTable2, "Cust_FName");
            lastName.DataBindings.Add("Text", _dtResultsTable2, "Cust_LName");
            address.DataBindings.Add("Text", _dtResultsTable2, "Address");
            city.DataBindings.Add("Text", _dtResultsTable2, "City");
            state.DataBindings.Add("Text", _dtResultsTable2, "State");
            zip.DataBindings.Add("Text", _dtResultsTable2, "Zip");
            phone.DataBindings.Add("Text", _dtResultsTable2, "Phone");
            email.DataBindings.Add("Text", _dtResultsTable2, "Email");
            userName.DataBindings.Add("Text", _dtResultsTable2, "UserName");
            password.DataBindings.Add("Text", _dtResultsTable2, "Password");
            _sqlResultsCommand2.Dispose();
            _daResults2.Dispose();
            _dtResultsTable2.Dispose();
        }
        public static void createCustomerLogin(string firstName, string lastName, string email, string pass, string userName)
        {
            try
            {
                // Update query for customer login information
                string sqlStatement = "INSERT INTO group5fa212330.customers(Cust_FName, Cust_LName, Address, City, " +
                    "State, Zip, Phone, Email, UserName, Password) " +
                    "VALUES('" + firstName + "', '" + lastName + "', '[Address]', '[city]', 'ST', '[ZIP]', '[PHONE]', '" + email + "', '" + userName + "', '" + pass + "') ";

                //create update command
                SqlCommand _sqlCreateLoginCommand = new SqlCommand(sqlStatement, _cntDatabase);
                //update command
                _sqlCreateLoginCommand.ExecuteNonQuery();
                //dispose
                _sqlCreateLoginCommand.Dispose();
            }
            catch (Exception ex)
            {
                //show message on error
                MessageBox.Show(ex.Message, "Error in Updating your information.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void updateCustomerLogin(string userName, string password)
        {
            try
            {
                // Update query for customer login information
                string sqlStatement = "UPDATE group5fa212330.customers " + "SET UserName = '" + userName
                    + "', Password = '" + password + "' Where Cust_ID = " + _custID;

                //create update command
                SqlCommand _sqlCustomerLoginCommand = new SqlCommand(sqlStatement, _cntDatabase);
                //update command
                _sqlCustomerLoginCommand.ExecuteNonQuery();
                //dispose
                _sqlCustomerLoginCommand.Dispose();
                MessageBox.Show("Information has been Updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //show message on error
                MessageBox.Show(ex.Message, "Error in Updating your information.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void updateCustomerInfo(string firstName, string lastName, string address, string city, string state, string zip, string phone, string email) 
        {      
            try
            {
                //update query for customer information
                string sqlStatement = "UPDATE group5fa212330.customers " + "SET Cust_FName = '" + firstName 
                    + "', Cust_LName = '" + lastName + "', Address = '" + address
                    + "', City = '" + city + "', State = '" + state + "', Zip = '"
                    + zip + "', Phone = '" + phone + "', Email = '" + email 
                    + "' Where Cust_ID = " + _custID ;
                //create update command
                SqlCommand _sqlCustomerInfoCommand = new SqlCommand(sqlStatement, _cntDatabase);
                //update command
                _sqlCustomerInfoCommand.ExecuteNonQuery();
                //dispose
                _sqlCustomerInfoCommand.Dispose();
                MessageBox.Show("Information has been Updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //show message on error
                MessageBox.Show(ex.Message, "Error in Updating your information.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                string query = "SELECT Email, UserName, Password, Cust_ID FROM group5fa212330.Customers";
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
                    frmLogin.custID.Add((read["Cust_ID"].ToString()));
                    frmLogin.custID.Add((read["Cust_ID"].ToString()));
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
        public static void changeEmpPassword(string email, string pass)
        {
            try
            {
                string query = "Update group5fa212330.Employees Set Password='" + pass + "' Where Email='" + email + "'" + ";";
                //create update command
                SqlCommand _sqlEmpPassCommand = new SqlCommand(query, _cntDatabase);
                //update command
                _sqlEmpPassCommand.ExecuteNonQuery();
                //dispose
                _sqlEmpPassCommand.Dispose();
                MessageBox.Show("Your password has been changed.", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //show message on error
                MessageBox.Show(ex.Message, "Error in Updating Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void changeCustPassword(string email, string pass)
        {
            try
            {
                string query = "Update group5fa212330.Customers Set Password='" + pass + "' Where Email='" + email + "'" + ";";
                //create update command
                SqlCommand _sqlCustPassCommand = new SqlCommand(query, _cntDatabase);
                //update command
                _sqlCustPassCommand.ExecuteNonQuery();
                //dispose
                _sqlCustPassCommand.Dispose();
                MessageBox.Show("Your password has been changed.", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //show message on error
                MessageBox.Show(ex.Message, "Error in Updating Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void GetTablesInfo()
        {
            try
            {
                //grabs all values from customers table
                string query = "SELECT o.Order_ID, o.Customer_ID, o.TotalCost, o.Table_Num, o.Dine_In, c.Cust_FName FROM group5fa212330.Orders o JOIN group5fa212330.Customers c ON o.Customer_ID = c.Cust_ID";
                //create update command
                SqlCommand _sqlCustCommand = new SqlCommand(query, _cntDatabase);
                //initializes reader
                SqlDataReader read = _sqlCustCommand.ExecuteReader();
                //reads the connection and adds the codes to the list
                while (read.Read())
                {
                    //frmTables.OrderId.Add((read["Order_ID"].ToString()));
                    //frmTables.CustId.Add((read["Customer_ID"].ToString()));
                    //frmTables.TotalCost.Add((read["TotalCost"].ToString()));
                    frmTables.TableNum.Add((read["Table_Num"].ToString()));
                    //frmTables.DineIn.Add((read["Dine_In"].ToString()));
                    //frmTables.CustName.Add((read["Cust_FName"].ToString()));
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
        //for data grid view on frmTables
        public static void DatabaseCommandOrders(DataGridView dgvOrders)
        {
            //set command object to null
            SqlCommand _sqlOrdersCommand = null;
            //reset data adapter and data table to new
            SqlDataAdapter _daOrders = new SqlDataAdapter();
            DataTable _dtOrdersTable = new DataTable();

            try
            {
                string query = "SELECT * FROM group5fa212330.Orders;";
                //est command object
                _sqlOrdersCommand = new SqlCommand(query, _cntDatabase);
                //est data adapter
                _daOrders.SelectCommand = _sqlOrdersCommand;
                //fill data table
                _daOrders.Fill(_dtOrdersTable);
                //bind dgvGames to data table
                dgvOrders.DataSource = _dtOrdersTable;
            }
            catch (Exception ex)
            {
                //show message on error
                MessageBox.Show(ex.Message, "Error in filling Orders Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //dispose
            _sqlOrdersCommand.Dispose();
            _daOrders.Dispose();
            _dtOrdersTable.Dispose();
        }
        public static void GetOrderName(int custId)
        {
            try
            {
                //grabs all values from customers table
                string query = "SELECT c.Cust_FName FROM group5fa212330.Customers c JOIN group5fa212330.Orders o ON c.Cust_ID = o.Customer_ID WHERE c.Cust_ID = " + custId + ";";
                //create update command
                SqlCommand _sqlCustCommand = new SqlCommand(query, _cntDatabase);
                //initializes reader
                SqlDataReader read = _sqlCustCommand.ExecuteReader();
                //reads the connection and adds the codes to the list
                while (read.Read())
                {
                    frmTables.customerName = read["Cust_FName"].ToString();
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
        public static void GetOrderDetails(int orderNum)
        {
            try
            {
                //grabs all values from customers table
                string query = "SELECT od.Order_ID, od.Qty, od.Menu_ID, m.MenuItem, m.Cost FROM group5fa212330.Order_Details od JOIN group5fa212330.Menu m ON od.Menu_ID = m.Menu_ID WHERE Order_ID = " + orderNum + ";";
                //create update command
                SqlCommand _sqlOrderDetailsCommand = new SqlCommand(query, _cntDatabase);
                //initializes reader
                SqlDataReader read = _sqlOrderDetailsCommand.ExecuteReader();
                //reads the connection and adds the codes to the list
                while (read.Read())
                {
                    frmEditOrders.Qty.Add(Convert.ToInt32(read["Qty"]));
                    frmEditOrders.ItemName.Add(Convert.ToString(read["MenuItem"]));
                    frmEditOrders.Cost.Add(Convert.ToDouble(read["Cost"]));
                }
                //closes the reader
                read.Close();
                //update command
                _sqlOrderDetailsCommand.Dispose();
            }
            catch (Exception ex)
            {
                //error message
                MessageBox.Show(ex.Message, "Error Obtaining Customer Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void DatabaseCommandMenu(DataGridView dgvMenu)
        {
            //set command object to null
            SqlCommand _sqlMenuCommand = null;
            //reset data adapter and data table to new
            SqlDataAdapter _daMenu = new SqlDataAdapter();
            DataTable _dtMenuTable = new DataTable();

            try
            {
                string query = "SELECT Menu_ID, MenuItem, Cost FROM group5fa212330.Menu;";
                //est command object
                _sqlMenuCommand = new SqlCommand(query, _cntDatabase);
                //est data adapter
                _daMenu.SelectCommand = _sqlMenuCommand;
                //fill data table
                _daMenu.Fill(_dtMenuTable);
                //bind dgvGames to data table
                dgvMenu.DataSource = _dtMenuTable;
            }
            catch (Exception ex)
            {
                //show message on error
                MessageBox.Show(ex.Message, "Error in filling Orders Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //dispose
            _sqlMenuCommand.Dispose();
            _daMenu.Dispose();
            _dtMenuTable.Dispose();
        }
    }


}

