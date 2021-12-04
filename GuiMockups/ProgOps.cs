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

        
        //add command object
        private static SqlCommand _sqlEmployeesCommand;
        //add the data adapter
        private static SqlDataAdapter _daEmployees = new SqlDataAdapter();
        //add the data tables
        private static DataTable _dtEmployeesTable = new DataTable();
        private static StringBuilder errorMessages = new StringBuilder();

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


        //added for OrderDetails // added menuID
        private static List<string> _menu_ID = new List<string>();
        public static double subTotal = 0;

        // getters and setters for customer menu items
        public static List<string> Menu_ID
        {// added menuID
            get { return _menu_ID; }
            set { _menu_ID = value; }
        }
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
        private static string _manager;

        public static string Manager
        {
            get { return _manager; }
            set { _manager = value; }
        }
        public static string CustID
        {
            get { return _custID; }
            set { _custID = value; }
        }

        private static string _empID;

        public static string EmpID
        {
            get { return _empID; }
            set { _empID = value; }
        }

        public static DataTable EmployeesTable
        {//just get this object in the main form
            get { return _dtEmployeesTable; }
        }

        public static void OpenDatabase()
        {
            //open the connection to database
            _cntDatabase.Open();
        }
        public static void CloseDatabase()
        {
            //close connection
            _cntDatabase.Close();
        }
        public static void disposeConnection() {
            //dispose of database
            _cntDatabase.Dispose();
        }
        //frmCustomerOrder(Add to cart button)// added MenuID
        public static void GetDataForCart(string name, string priceString, string qtyString, string menuItem)
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
                Menu_ID.Add(menuItem);// added menuId
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
            Menu_ID.Clear();// added menuID
        }
        public static void AddToCart(DataGridView dv2)
        {
            //Fills frmCart DGV
            dv2.ColumnCount = 5;

            dv2.Columns[0].Name = "MenuID";// added menuID
            dv2.Columns[1].Name = "Menu Item";
            dv2.Columns[2].Name = "Price";
            dv2.Columns[3].Name = "Quantity";
            dv2.Columns[4].Name = "Total Price Per Line";

            for (int i = 0; i < Name.Count; i++)
            {
                int rowId = dv2.Rows.Add();
                dv2.Rows[rowId].Cells[0].Value = Menu_ID[i].ToString();// added menuID
                dv2.Rows[rowId].Cells[1].Value = Name[i].ToString();
                dv2.Rows[rowId].Cells[2].Value = Price_Per_Unit[i].ToString();
                dv2.Rows[rowId].Cells[3].Value = Quantity[i].ToString();
                dv2.Rows[rowId].Cells[4].Value = Total_Price_Per_Line[i].ToString();
            }
        }
        public static void EditCustomerReservations(string reservationID, string reservedDate, string tableNum)
        {
            try
            {
                //Reservation_ID, Customer_ID, ReserveDate, TableNumber
                string sqlStatement = "UPDATE group5fa212330.Reservations " + "SET ReserveDate = '" + reservedDate
                    + "', TableNumber = " + tableNum + " Where Reservation_ID = " + reservationID;

                //create update command
                SqlCommand _sqlEditReservationCommand = new SqlCommand(sqlStatement, _cntDatabase);
                //update command
                _sqlEditReservationCommand.ExecuteNonQuery();
                //dispose
                _sqlEditReservationCommand.Dispose();
                MessageBox.Show("Information has been Updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //show message on error
                MessageBox.Show(ex.Message, "Error in Updating your information.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void DeleteReservation(string reservationID)
        {

            try
            {
                // Insert for reservation
                string queryDelete = "DELETE FROM group5fa212330.Reservations WHERE Reservation_ID =  " + reservationID;                //create update command
                SqlCommand _sqlDeleteReservationCommand = new SqlCommand(queryDelete, _cntDatabase);
                //update command
                _sqlDeleteReservationCommand.ExecuteNonQuery();
                //dispose
                _sqlDeleteReservationCommand.Dispose();
            }
            catch (Exception ex)
            {
                //show message on error
                MessageBox.Show(ex.Message, "Error in Booking Reservation.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void ReservationCommand(DataGridView dvMain)
        {
            try
            {

                //statement for the DGV              
                string sqlStatement = "SELECT Reservation_ID, Customer_ID, Cust_FName, Cust_LName, ReserveDate, TableNumber From group5fa212330.Reservations r join group5fa212330.Customers c ON r.Customer_ID = c.Cust_ID Where ReserveDate >= GETDATE();";
                
                //set command object to null
                SqlCommand _sqlReservationsCommand = null;
                //reset data adapter and data-table to new
                _daResults = new SqlDataAdapter();
                _dtResultsTable = new DataTable();
                //establish a command object
                _sqlReservationsCommand = new SqlCommand(sqlStatement, _cntDatabase);
                //establish data adapter
                _daResults.SelectCommand = _sqlReservationsCommand;
                //fill the data table
                _daResults.Fill(_dtResultsTable);
                //bind data grid view to data table
                dvMain.DataSource = _dtResultsTable;

                //dispose of command, adapter, and table objects
                _sqlReservationsCommand.Dispose();
                _daResults.Dispose();
                _dtResultsTable.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        // gets the most current OrderID from database. 
        public static int ReadCurrentOrderID()
        {
            int OrderIDCurrent = 0;
            try
            {
                string queryString = "SELECT MAX(Order_ID) FROM group5fa212330.Orders";
                //create update command
                SqlCommand _sqlEmpCommand = new SqlCommand(queryString, _cntDatabase);
                //initializes reader
                SqlDataReader read = _sqlEmpCommand.ExecuteReader();

                // Call Read before accessing data. 
                if (read.HasRows)
                {
                    read.Read();
                    OrderIDCurrent = read.GetInt32(0);
                }

                // Call Close when done reading.
                read.Close();

                _sqlEmpCommand.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OrderIDCurrent;
        }

        public static int ReadCurrentInvoiceID()
        {
            int invoiceIDCurrent = 0;
            try
            {
                string queryString = "SELECT MAX(InvoiceID) FROM group5fa212330.Invoices";
                //create update command
                SqlCommand _sqlInvoiceCommand = new SqlCommand(queryString, _cntDatabase);
                //initializes reader
                SqlDataReader read = _sqlInvoiceCommand.ExecuteReader();

                // Call Read before accessing data. 
                if (read.HasRows)
                {
                    read.Read();
                    invoiceIDCurrent = read.GetInt32(0);
                }

                // Call Close when done reading.
                read.Close();

                _sqlInvoiceCommand.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return invoiceIDCurrent;
        }

        public static void checkOutOrder(string date, string orderIdentification)
        {
            try
            {
                // Orders: Order_ID Customer_ID, Employee_ID, Order_Date, TotalCost, Table_Num, Dine_in
                // (ordering from application employeeID = NULL , Table_Num = 0, Dine_in = 0)
                // inserts the variables into the database for customers
                string queryOrder = "INSERT INTO group5fa212330.Orders Values(" + _custID + ", NULL, '" + date + "', " + subTotal + ", 0, 0);";
                // create update command
                SqlCommand _sqlInsertOrderCommand = new SqlCommand(queryOrder, _cntDatabase);
                // update command
                _sqlInsertOrderCommand.ExecuteNonQuery();


                for (int i = 0; i < Menu_ID.Count; i++)
                {
                    // Order_details: Order_ID, Menu_ID, Qty
                    string queryOrderDetails = "INSERT INTO group5fa212330.Order_details Values(" + orderIdentification + ", " + Menu_ID[i] + ", " + Quantity[i] + " );";
                    // create update command
                    SqlCommand _sqlInsertDetailsCommand = new SqlCommand(queryOrderDetails, _cntDatabase);
                    // update command
                    _sqlInsertDetailsCommand.ExecuteNonQuery();
                    _sqlInsertDetailsCommand.Dispose();                    
                }

                _sqlInsertOrderCommand.Dispose();
                MessageBox.Show("Order Submitted!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error submitting orders/order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        public static void submitSuppliesOrder(string date, string invoiceIdent, double sub)
        {
            try
            {
                // Invoices: InvoiceID Employee_ID, OrderDate, TotalCost
                string querySuppliesOrder = "INSERT INTO group5fa212330.Invoices Values(" + _empID + ", '" + date + "', " + sub + ");";
                // create update command
                SqlCommand _sqlInsertSuppliesOrderCommand = new SqlCommand(querySuppliesOrder, _cntDatabase);
                // update command
                _sqlInsertSuppliesOrderCommand.ExecuteNonQuery();

                for (int i = 0; i < frmSupplies.items.Count; i++)
                {
                    // InvoiceDetails: InvoiceID, SupplierID, ProductID, QTY
                    string querySuppliesOrderDetails = "INSERT INTO group5fa212330.InvoiceDetails Values(" + invoiceIdent + ", " + frmSupplies.supID[i] + ", " + frmSupplies.prodID[i] + ", " + frmSupplies.quantites[i] + " );";
                    // create update command
                    SqlCommand _sqlInsertSuppliesDetailsCommand = new SqlCommand(querySuppliesOrderDetails, _cntDatabase);
                    // update command
                    _sqlInsertSuppliesDetailsCommand.ExecuteNonQuery();
                    _sqlInsertSuppliesDetailsCommand.Dispose();
                }

                _sqlInsertSuppliesOrderCommand.Dispose();
                MessageBox.Show("Order Submitted!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error submitting orders/order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        //totals for frmCart
        public static void MathForTotals(Label s, Label t, Label n)
        {
            subTotal = 0;
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
            int count = 0;
            bool zero = false;
            if (Name.Count > 0)
            {
                foreach (var item in Name)
                {
                    if (item == dgv1.CurrentRow.Cells[1].Value.ToString())
                    {
                        int currentQty = Int32.Parse(dgv1.CurrentRow.Cells[3].Value.ToString());
                        double price = Double.Parse(dgv1.CurrentRow.Cells[2].Value.ToString());
                        int newQty = currentQty - 1;
                        Quantity[count] = newQty.ToString();
                        double total = newQty * price;
                        Total_Price_Per_Line[count] = total.ToString();
                        if (newQty == 0)
                        {
                            zero = true;
                        }
                        break;
                    }
                    count++;
                }
                // if quantity less than 0 remove from list
                if (zero)
                {
                    Menu_ID.RemoveAt(count);
                    Name.RemoveAt(count);
                    Price_Per_Unit.RemoveAt(count);
                    Quantity.RemoveAt(count);
                    Total_Price_Per_Line.RemoveAt(count);
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
                    frmEditReservations.tablesBooked.Add(read["TableNumber"].ToString());
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
            }
            catch (Exception ex)
            {
                //show message on error
                MessageBox.Show(ex.Message, "Error in Updating your information.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DatabaseCommand(TextBox tbEmployeeID, TextBox tbLastName, TextBox tbFirstName, TextBox tbReportTo, TextBox tbAddress, TextBox tbEmail, TextBox tbCity, TextBox tbState, TextBox tbZip, TextBox tbPhone, TextBox tbUserName, TextBox tbPass, TextBox tbIsManager)
        {
            try
            {
                //string to build a query
                string query = "SELECT * FROM group5fa212330.Employees";
                //establish a command object
                _sqlEmployeesCommand = new SqlCommand(query, _cntDatabase);
                //establish data adapter
                _daEmployees = new SqlDataAdapter();
                _daEmployees.SelectCommand = _sqlEmployeesCommand;
                //fill the data table
                _dtEmployeesTable = new DataTable();
                _daEmployees.Fill(_dtEmployeesTable);
                //bind to controls to data table 
                tbEmployeeID.DataBindings.Add("Text", _dtEmployeesTable, "Employee_ID");
                tbLastName.DataBindings.Add("Text", _dtEmployeesTable, "Emp_LName");
                tbFirstName.DataBindings.Add("Text", _dtEmployeesTable, "Emp_FName");
                tbReportTo.DataBindings.Add("Text", _dtEmployeesTable, "ReportTo");
                tbAddress.DataBindings.Add("Text", _dtEmployeesTable, "Address");
                tbEmail.DataBindings.Add("Text", _dtEmployeesTable, "Email");
                tbCity.DataBindings.Add("Text", _dtEmployeesTable, "City");
                tbState.DataBindings.Add("Text", _dtEmployeesTable, "State");
                tbZip.DataBindings.Add("Text", _dtEmployeesTable, "Zip");
                tbPhone.DataBindings.Add("Text", _dtEmployeesTable, "Phone");
                tbUserName.DataBindings.Add("Text", _dtEmployeesTable, "UserName");
                tbPass.DataBindings.Add("Text", _dtEmployeesTable, "Password");
                tbIsManager.DataBindings.Add("Text", _dtEmployeesTable, "isManager");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void UpdateOnClose()
        {
            try
            {
                //save the updated employees table
                SqlCommandBuilder employeesAdapterCommands = new SqlCommandBuilder(_daEmployees);
                _daEmployees.Update(_dtEmployeesTable);
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(errorMessages.ToString(), "Error on UpdateOnClose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message, "Error on UpdateOnClose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                string query = "SELECT Email, UserName, Password, isManager, Employee_ID FROM group5fa212330.Employees";
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
                    frmLogin.EmpIsManager.Add((read["isManager"].ToString()));
                    frmLogin.employID.Add((read["Employee_ID"].ToString()));
                    frmLogin.employID.Add((read["Employee_ID"].ToString()));


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
                    frmTables.TableNum.Add((read["Table_Num"].ToString()));
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

        public static void DatabaseCommandSupplies(DataGridView dgvSupplies)
        {
            //set command object to null
            SqlCommand _sqlSuppliesCommand = null;
            //reset data adapter and data table to new
            SqlDataAdapter _daSupplies = new SqlDataAdapter();
            DataTable _dtSuppliesTable = new DataTable();

            try
            {
                string query = "SELECT p.ProductID AS 'P. ID', ProductName AS 'Product', " +
                    "UnitPrice AS 'Price Per', Qty AS 'Quantity', s.SupplierID AS 'S. ID', " +
                    "SupplierName AS 'Supplier', Address AS 'S. Address', Phone AS 'S. Phone' " +
                    "from group5fa212330.ProductSupplier ps " +
                    "join group5fa212330.Products p ON ps.ProductID = p.ProductID " +
                    "join group5fa212330.Suppliers s ON s.SupplierID = ps.SupplierID " +
                    "ORDER BY p.ProductID;";
                //est command object
                _sqlSuppliesCommand = new SqlCommand(query, _cntDatabase);
                //est data adapter
                _daSupplies.SelectCommand = _sqlSuppliesCommand;
                //fill data table
                _daSupplies.Fill(_dtSuppliesTable);
                //bind dgvSupplies to data table
                dgvSupplies.DataSource = _dtSuppliesTable;
            }
            catch (Exception ex)
            {
                //show message on error
                MessageBox.Show(ex.Message, "Error in filling Orders Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //dispose
            _sqlSuppliesCommand.Dispose();
            _daSupplies.Dispose();
            _dtSuppliesTable.Dispose();
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
                    frmEditOrders.MenuID.Add(Convert.ToInt32(read["Menu_ID"]));
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
        public static void InsertIntoOrderDetails(int qty, int orderId, int menuId, double total)
        {
            try
            {
                //inserts the variables into the database for customers
                string query1 = "INSERT INTO group5fa212330.Order_details(Order_ID, Menu_ID, Qty)";
                query1 += " VALUES(" + orderId + ", '" + menuId + "', '" + qty + "');";
                //create update command
                SqlCommand _sqlInsertItemCommand = new SqlCommand(query1, _cntDatabase);
                //update command
                _sqlInsertItemCommand.ExecuteNonQuery();

                string query = "UPDATE group5fa212330.Orders SET TotalCost = " + total + " WHERE Order_ID = " + orderId +";";
                //create update command
                SqlCommand _sqlUpdateOrderCommand = new SqlCommand(query, _cntDatabase);
                //update command
                _sqlUpdateOrderCommand.ExecuteNonQuery();

                _sqlInsertItemCommand.Dispose();
                _sqlUpdateOrderCommand.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error inserting or updating orders/order details Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void RemoveItems(int orderId, int menuId)
        {
            try
            {
                //inserts the variables into the database for customers
                string query1 = "DELETE FROM group5fa212330.Order_details WHERE Menu_ID = " + menuId + " AND Order_ID = " + orderId + ";";
                //create update command
                SqlCommand _sqlInsertItemCommand = new SqlCommand(query1, _cntDatabase);
                //update command
                _sqlInsertItemCommand.ExecuteNonQuery();

                _sqlInsertItemCommand.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error inserting or updating orders/order details Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}

