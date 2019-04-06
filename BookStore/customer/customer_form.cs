/*
 * NOTE: this form was copied from book_form.cs so it contains misleading comments. Yet, functionality is exactly the same as book form's
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections;

namespace BookStore.order_form
{
    public partial class customer_form : Form
    {
        #region Fields
        // reference to calling form
        public Form RefToForm1 { get; set; }

        // retrieved customers
        private DataSet RetrievedCustomers = new DataSet();

        // "New Customer" clicked
        private bool NewCustomerClicked = new bool();

        // Customers DB ID storage
        private ArrayList IDStorage { get; set; }
        #endregion

        #region Default Constructor
        /// <summary>
        /// default constructor of the form
        /// </summary>
        public customer_form()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Load, Closing events
        /// <summary>
        /// Populate the combobox when the main customer_form form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customer_form_Load(object sender, EventArgs e)
        {
            // establish connection to the database and populate combobox
            Connect_DB_and_Populate();
        }


        /// <summary>
        /// Executed before closing this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customer_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.RefToForm1.Show();
        }
        #endregion

        #region Button Events
        /// <summary>
        /// Back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// New Customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void New_customer_button_button_Click(object sender, EventArgs e)
        {
            ClearTextFields();
            customers_comboBox.Enabled = false;
            NewCustomerClicked = true;
        }

        /// <summary>
        /// Save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_button_Click(object sender, EventArgs e)
        {
            if (!(customers_comboBox.SelectedItem == null) && NewCustomerClicked == false)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        // update book entry
                        UpdateCustomersTable(First_Name_text.Text, Last_name_text.Text, Address_text.Text, City_text.Text, States_text.Text, ZIP_text.Text, Phone_text.Text, Email_text.Text, int.Parse(IDStorage[customers_comboBox.SelectedIndex].ToString()));

                        // verify book entry
                        if (VerifyUpdatedBookEntry(First_Name_text.Text, Last_name_text.Text, Address_text.Text, City_text.Text, States_text.Text, ZIP_text.Text, Phone_text.Text, Email_text.Text, int.Parse(IDStorage[customers_comboBox.SelectedIndex].ToString())))
                            MessageBox.Show("Updated successfully");
                        else
                            MessageBox.Show("Update failed. Data not sent to the database");

                    }
                    catch (System.FormatException ex)
                    {
                        MessageBox.Show(ex.Message + " Please make sure you are using valid characters");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            } else if(NewCustomerClicked == true)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        // insert book entry
                        InsertIntoBooksTable(First_Name_text.Text, Last_name_text.Text, Address_text.Text, City_text.Text, States_text.Text, ZIP_text.Text, Phone_text.Text, Email_text.Text);

                        // Possible extra TO-DO: verify book insertion
                    }
                    catch (System.FormatException ex)
                    {
                        MessageBox.Show(ex.Message + " Please make sure you are using valid characters");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            } else
                MessageBox.Show("Something went wrong. Check your entries.");
        }

        /// <summary>
        /// Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int SelectedIndexTemp = customers_comboBox.SelectedIndex;
                try
                {
                    if (!VerifyUpdatedBookEntry(First_Name_text.Text, Last_name_text.Text, Address_text.Text, City_text.Text, States_text.Text, ZIP_text.Text, Phone_text.Text, Email_text.Text, int.Parse(IDStorage[SelectedIndexTemp].ToString())))
                    {
                        customers_comboBox.Items.Clear();
                        RetrievedCustomers.Clear();
                        IDStorage.Clear();
                        Connect_DB_and_Populate();

                        FillTextFields(SelectedIndexTemp);
                        customers_comboBox.SelectedIndex = SelectedIndexTemp;
                    }
                } catch(FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (IndexOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }
        #endregion

        #region Text Fields filling
        /// <summary>
        /// When book is selected, fill all text fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Books_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // populate the available text fields
            FillTextFields();
        }
        #endregion

        #region Helper Functions
        /// <summary>
        /// used to populate combobox in this form from database with "books" table
        /// </summary>
        private void Connect_DB_and_Populate()
        {
            try
            {
                string con_string = "datasource = localhost; username = root; password =; database=bookstore";
                MySqlConnection db_con = new MySqlConnection(con_string);
                MySqlDataAdapter da = new MySqlDataAdapter("select * from customer ORDER BY customer_id ASC", db_con);
                db_con.Open();
                IDStorage = new ArrayList();
                da.Fill(RetrievedCustomers, "customer");
                for (int i = 0; i < RetrievedCustomers.Tables[0].Rows.Count; i++)
                {
                    customers_comboBox.Items.Add(RetrievedCustomers.Tables[0].Rows[i]["first_name"].ToString() + " " + RetrievedCustomers.Tables[0].Rows[i]["last_name"].ToString());
                    IDStorage.Add(RetrievedCustomers.Tables[0].Rows[i]["customer_id"].ToString());
                }
                db_con.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Updates books table
        /// </summary>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="isbn"></param>
        /// <param name="price"></param>
        private void UpdateCustomersTable(string first_name, string last_name, string address, string city, string states, string ZIP, string phone, string email, int ID)
        {
            first_name = ReplaceEscSequences(first_name);
            last_name = ReplaceEscSequences(last_name);
            address = ReplaceEscSequences(address);
            city = ReplaceEscSequences(city);
            states = ReplaceEscSequences(states);
            ZIP = ReplaceEscSequences(ZIP);
            phone = ReplaceEscSequences(phone);
            email = ReplaceEscSequences(email);

            try
            {
                string MyConnection3 = "datasource=localhost;username=root;passwor=;database=bookstore";
                string Query = @"UPDATE customer SET first_name='" + first_name + @"', last_name='" + last_name + @"', address='" + address + @"', city='" + city + @"', states='" + states + @"', zip='" + ZIP + @"', home_phone='" + phone + @"', email='" + email + @"' WHERE customer_id = " + ID + @";";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection3);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();
                // MessageBox.Show("Data Deleted");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Inserts into books table
        /// </summary>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="isbn"></param>
        /// <param name="price"></param>
        private void InsertIntoBooksTable(string first_name, string last_name, string address, string city, string states, string ZIP, string phone, string email)
        {
            first_name = ReplaceEscSequences(first_name);
            last_name = ReplaceEscSequences(last_name);
            address = ReplaceEscSequences(address);
            city = ReplaceEscSequences(city);
            states = ReplaceEscSequences(states);
            ZIP = ReplaceEscSequences(ZIP);
            phone = ReplaceEscSequences(phone);
            email = ReplaceEscSequences(email);

            try
            {
                string MyConnection3 = "datasource=localhost;username=root;passwor=;database=bookstore";
                string Query = @"INSERT INTO customer(first_name, last_name, address, city, states, ZIP, home_phone, email) VALUES ('" + first_name + @"', '"+ last_name + @"', '"+ address + @"', '" + city + @"',  '" + states + @"',  '" + ZIP + @"',  '" + phone + @"',  '" + email + @"');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection3);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();
                // MessageBox.Show("Data Deleted");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Verify book table entry update
        /// </summary>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="isbn"></param>
        /// <param name="price"></param>
        private bool VerifyUpdatedBookEntry(string first_name, string last_name, string address, string city, string states, string ZIP, string phone, string email, int ID)
        {
            bool AllFine = false;

            try
            {
                string con_string = "datasource = localhost; username = root; password =; database=bookstore";
                MySqlConnection db_con = new MySqlConnection(con_string);
                MySqlDataAdapter da = new MySqlDataAdapter("select * from customer WHERE customer_id = " + ID + @";", db_con);
                db_con.Open();
                DataSet ds = new DataSet();

                da.Fill(ds, "books");
                if (string.Compare(ds.Tables[0].Rows[0]["first_name"].ToString(), first_name) == 0 &&
                    string.Compare(ds.Tables[0].Rows[0]["last_name"].ToString(), last_name) == 0 &&
                    string.Compare(ds.Tables[0].Rows[0]["address"].ToString(), address) == 0 &&
                    string.Compare(ds.Tables[0].Rows[0]["city"].ToString(), city) == 0 &&
                    string.Compare(ds.Tables[0].Rows[0]["states"].ToString(), states) == 0 &&
                    string.Compare(ds.Tables[0].Rows[0]["ZIP"].ToString(), ZIP) == 0 &&
                    string.Compare(ds.Tables[0].Rows[0]["home_phone"].ToString(), phone) == 0 &&
                    string.Compare(ds.Tables[0].Rows[0]["email"].ToString(), email) == 0) 
                    AllFine = true;
                
                db_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return AllFine;
        }

        /// <summary>
        /// Fills available text fields with the selected book from the combobox
        /// </summary>
        private void FillTextFields()
        {
            int SelectedIndexTemp = customers_comboBox.SelectedIndex;
            First_Name_text.Text = RetrievedCustomers.Tables[0].Rows[SelectedIndexTemp]["first_name"].ToString();
            Last_name_text.Text = RetrievedCustomers.Tables[0].Rows[SelectedIndexTemp]["last_name"].ToString();
            Address_text.Text = RetrievedCustomers.Tables[0].Rows[SelectedIndexTemp]["address"].ToString();
            City_text.Text = RetrievedCustomers.Tables[0].Rows[SelectedIndexTemp]["city"].ToString();
            States_text.Text = RetrievedCustomers.Tables[0].Rows[SelectedIndexTemp]["states"].ToString();
            ZIP_text.Text = RetrievedCustomers.Tables[0].Rows[SelectedIndexTemp]["zip"].ToString();
            Phone_text.Text = RetrievedCustomers.Tables[0].Rows[SelectedIndexTemp]["home_phone"].ToString();
            Email_text.Text = RetrievedCustomers.Tables[0].Rows[SelectedIndexTemp]["email"].ToString();
        }

        /// <summary>
        /// Fills available text fields with the selected book from the combobox
        /// </summary>
        private void FillTextFields(int SelectedIndexTemp)
        {
            First_Name_text.Text = RetrievedCustomers.Tables[0].Rows[SelectedIndexTemp]["first_name"].ToString();
            Last_name_text.Text = RetrievedCustomers.Tables[0].Rows[SelectedIndexTemp]["last_name"].ToString();
            Address_text.Text = RetrievedCustomers.Tables[0].Rows[SelectedIndexTemp]["address"].ToString();
            City_text.Text = RetrievedCustomers.Tables[0].Rows[SelectedIndexTemp]["city"].ToString();
            States_text.Text = RetrievedCustomers.Tables[0].Rows[SelectedIndexTemp]["states"].ToString();
            ZIP_text.Text = RetrievedCustomers.Tables[0].Rows[SelectedIndexTemp]["zip"].ToString();
            Phone_text.Text = RetrievedCustomers.Tables[0].Rows[SelectedIndexTemp]["home_phone"].ToString();
            Email_text.Text = RetrievedCustomers.Tables[0].Rows[SelectedIndexTemp]["email"].ToString();
        }

        /// <summary>
        /// clears all available text fields
        /// </summary>
        private void ClearTextFields()
        {
            First_Name_text.Clear();
            Last_name_text.Clear();
            Address_text.Clear();
            City_text.Clear();
            States_text.Clear();
            ZIP_text.Clear();
            Phone_text.Clear();
            Email_text.Clear();
        }

        /// <summary>
        /// replaces characetrs for query processing
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private string ReplaceEscSequences(string value)
        {
            value = value.Replace(@"'", @"''");
            value = value.Replace(@"\", @"\\");
            return value;
        }
        #endregion
    }
}