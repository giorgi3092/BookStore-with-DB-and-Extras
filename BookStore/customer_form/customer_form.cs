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

        // retrieved books
        private DataSet RetrievedBooks = new DataSet();

        // "New Book" clicked
        private bool NewBookClicked = new bool();

        // Books DB ID storage
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
        /// Populate the combobox when the main BookStoreForm form loads
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
        /// New Book
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void New_Book_button_Click(object sender, EventArgs e)
        {
            ClearTextFields();
            Books_comboBox.Enabled = false;
            NewBookClicked = true;
        }

        /// <summary>
        /// Save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_button_Click(object sender, EventArgs e)
        {
            Price_text.Text = PriceDelimiter(Price_text.Text);
            if (!(Books_comboBox.SelectedItem == null) && NewBookClicked == false)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        // update book entry
                        UpdateBooksTable(Title_text.Text, Author_text.Text, ISBN_text.Text, decimal.Parse(Price_text.Text), int.Parse(IDStorage[Books_comboBox.SelectedIndex].ToString()));

                        // verify book entry
                        if (VerifyUpdatedBookEntry(Title_text.Text, Author_text.Text, ISBN_text.Text, decimal.Parse(Price_text.Text), int.Parse(IDStorage[Books_comboBox.SelectedIndex].ToString())))
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
            } else if(NewBookClicked == true)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        // insert book entry
                        InsertIntoBooksTable(Title_text.Text, Author_text.Text, ISBN_text.Text, decimal.Parse(Price_text.Text));

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
                int SelectedIndexTemp = Books_comboBox.SelectedIndex;
                try
                {
                    if (!VerifyUpdatedBookEntry(Title_text.Text, Author_text.Text, ISBN_text.Text, decimal.Parse(Price_text.Text), int.Parse(IDStorage[SelectedIndexTemp].ToString())))
                    {
                        Books_comboBox.Items.Clear();
                        RetrievedBooks.Clear();
                        IDStorage.Clear();
                        Connect_DB_and_Populate();

                        Title_text.Text = RetrievedBooks.Tables[0].Rows[SelectedIndexTemp]["title"].ToString();
                        Author_text.Text = RetrievedBooks.Tables[0].Rows[SelectedIndexTemp]["author"].ToString();
                        ISBN_text.Text = RetrievedBooks.Tables[0].Rows[SelectedIndexTemp]["isbn"].ToString();
                        Price_text.Text = RetrievedBooks.Tables[0].Rows[SelectedIndexTemp]["price"].ToString();
                        Books_comboBox.SelectedIndex = SelectedIndexTemp;
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
                MySqlDataAdapter da = new MySqlDataAdapter("select * from books ORDER BY book_id ASC", db_con);
                db_con.Open();
                IDStorage = new ArrayList();
                da.Fill(RetrievedBooks, "books");
                for (int i = 0; i < RetrievedBooks.Tables[0].Rows.Count; i++)
                {
                    Books_comboBox.Items.Add(RetrievedBooks.Tables[0].Rows[i]["title"].ToString());
                    IDStorage.Add(RetrievedBooks.Tables[0].Rows[i]["book_id"].ToString());
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
        private void UpdateBooksTable(string title, string author, string isbn, decimal price, int ID)
        {
            title = ReplaceEscSequences(title);
            author = ReplaceEscSequences(author);
            isbn = ReplaceEscSequences(isbn);

            try
            {
                string MyConnection3 = "datasource=localhost;username=root;passwor=;database=bookstore";
                string Query = @"UPDATE books SET title='"+ title + @"', author='" + author + @"', isbn='" + isbn + @"', price=" + price + @" WHERE book_id = " + ID + @";";
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
        private void InsertIntoBooksTable(string title, string author, string isbn, decimal price)
        {
            title = ReplaceEscSequences(title);
            author = ReplaceEscSequences(author);
            isbn = ReplaceEscSequences(isbn);

            try
            {
                string MyConnection3 = "datasource=localhost;username=root;passwor=;database=bookstore";
                string Query = @"INSERT INTO books(title, author, isbn, price) VALUES ('"+ title +@"', '"+ author +@"', '"+ isbn+ @"', '"+ price +@"');";
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
        private bool VerifyUpdatedBookEntry(string title, string author, string isbn, decimal price, int ID)
        {
            bool AllFine = false;

            try
            {
                string con_string = "datasource = localhost; username = root; password =; database=bookstore";
                MySqlConnection db_con = new MySqlConnection(con_string);
                MySqlDataAdapter da = new MySqlDataAdapter("select * from books WHERE book_id = " + ID + @";", db_con);
                db_con.Open();
                DataSet ds = new DataSet();

                da.Fill(ds, "books");
                if (string.Compare(ds.Tables[0].Rows[0]["title"].ToString(), title) == 0 &&
                    string.Compare(ds.Tables[0].Rows[0]["author"].ToString(), author) == 0 &&
                    string.Compare(ds.Tables[0].Rows[0]["isbn"].ToString(), isbn) == 0 &&
                    string.Compare(ds.Tables[0].Rows[0]["price"].ToString(), price.ToString()) == 0)
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
            Title_text.Text = RetrievedBooks.Tables[0].Rows[Books_comboBox.SelectedIndex]["title"].ToString();
            Author_text.Text = RetrievedBooks.Tables[0].Rows[Books_comboBox.SelectedIndex]["author"].ToString();
            ISBN_text.Text = RetrievedBooks.Tables[0].Rows[Books_comboBox.SelectedIndex]["isbn"].ToString();
            Price_text.Text = RetrievedBooks.Tables[0].Rows[Books_comboBox.SelectedIndex]["price"].ToString();
        }

        /// <summary>
        /// clears all available text fields
        /// </summary>
        private void ClearTextFields()
        {
            Title_text.Clear();
            Author_text.Clear();
            ISBN_text.Clear();
            Price_text.Clear();
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

        /// <summary>
        /// For price, ',' and '.' are same
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private string PriceDelimiter(string value)
        {
            value = value.Replace(@",", @".");
            return value;
        }

        /// <summary>
        /// used for price text box to disallow certain characters
        /// </summary>
        /// <param name="_text"></param>
        /// <param name="KeyChar"></param>
        /// <returns></returns>
        private bool alreadyExist(string _text, ref char KeyChar)
        {
            if (_text.IndexOf('.') > -1)
            {
                KeyChar = '.';
                return true;
            }
            if (_text.IndexOf(',') > -1)
            {
                KeyChar = ',';
                return true;
            }
            return false;
        }

        /// <summary>
        /// Makes sure only '.' or ',' characters are allowed in price text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Price_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            //check if '.' , ',' pressed
            char sepratorChar = 's';
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                // check if it's in the beginning of text not accept
                if (Price_text.Text.Length == 0) e.Handled = true;
                // check if it's in the beginning of text not accept
                if (Price_text.SelectionStart == 0) e.Handled = true;
                // check if there is already exist a '.' , ','
                if (alreadyExist(Price_text.Text, ref sepratorChar)) e.Handled = true;
                //check if '.' or ',' is in middle of a number and after it is not a number greater than 99
                if (Price_text.SelectionStart != Price_text.Text.Length && e.Handled == false)
                {
                    // '.' or ',' is in the middle
                    string AfterDotString = Price_text.Text.Substring(Price_text.SelectionStart);

                    if (AfterDotString.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
            //check if a number pressed

            if (Char.IsDigit(e.KeyChar))
            {
                //check if a coma or dot exist
                if (alreadyExist(Price_text.Text, ref sepratorChar))
                {
                    int sepratorPosition = Price_text.Text.IndexOf(sepratorChar);
                    string afterSepratorString = Price_text.Text.Substring(sepratorPosition + 1);
                    if (Price_text.SelectionStart > sepratorPosition && afterSepratorString.Length > 1)
                    {
                        e.Handled = true;
                    }

                }
            }

        }
        #endregion
    }
}