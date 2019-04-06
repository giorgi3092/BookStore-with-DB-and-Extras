/*
 * Author: Giorgi Aptsiauri 
 * Date: 2/10/2019
 * For class: COMPE 561
 * 
 * */

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Globalization;

namespace BookStore
{
    public partial class BookStoreForm : Form
    {
        #region Fields

        // used for current date to populate database
        private DateTime today { get; set; }

        // used for current date to populate database
        private int CurrentCustomerID { get; set; }

        // Stores the books read from book.txt file
        private List<Book> Books = new List<Book>();

        // retrieved books
        private DataSet RetrievedBooks = new DataSet();

        // Books DB ID storage
        private ArrayList BookIDStorage { get; set; }

        // Customers DB ID storage
        private ArrayList CustomerIDStorage { get; set; }

        // retrieved customers
        private DataSet RetrievedCustomers = new DataSet();

        // reference to calling form
        public Form RefToForm1 { get; set; }

        /// <summary>
        /// Total holds the subtotal amount (QTY*Price)
        /// </summary>
        private decimal SubtotalAmount { get; set; } = 0m;

        /// <summary>
        /// Tax holds the tax amount (0.1*SubtotalAmount)
        /// </summary>
        private decimal TaxAmount { get; set; } = 0m;

        /// <summary>
        /// Total holds the total amount to pay (SubtotalAmount + TaxAmount)
        /// </summary>
        private decimal TotalAmount { get; set; } = 0m;

        /// <summary>
        /// DELIM is used as a delimiter for a book.txt file, from which
        /// reading is indended to fill the "Books" array list with books
        /// </summary>
        const char DELIM = ',';

        /// <summary>
        /// the file from which to read books
        /// </summary>
        const string FILENAMEIN = "book.txt";

        /// <summary>
        /// After the user confirms the order, the summary of the order is written to this file.
        /// </summary>
        const string FILENAMEOUT = "orders.txt";

        /// <summary>
        /// for writing to the output file orders.txt
        /// </summary>
        FileStream outFile = null;

        /// <summary>
        /// handles writing to a file
        /// </summary>
        StreamWriter LineWriter = null;
        #endregion

        #region Default Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public BookStoreForm()
        {
            
            InitializeComponent();
        }

        
        #endregion

        #region ComboBox Change event-handler
        /// <summary>
        /// Event handler, envoked when book Combobox item is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            
            AuthorBox.Text = RetrievedBooks.Tables[0].Rows[BookList.SelectedIndex]["author"].ToString();
            ISBNBox.Text = RetrievedBooks.Tables[0].Rows[BookList.SelectedIndex]["isbn"].ToString();
            PriceBox.Text = RetrievedBooks.Tables[0].Rows[BookList.SelectedIndex]["price"].ToString();

        }

        /// <summary>
        /// Event handler, envoked when customer Combobox item is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region BookStoreForm Load
        /// <summary>
        /// Populate The combobox when the main BookStoreForm form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookStoreForm_Load(object sender, System.EventArgs e)
        {
            // establish connection to the database and populate book combobox
            Connect_DB_and_Populate_Books();

            // establish connection to the database and populate customers combobox
            Connect_DB_and_Populate_Customers();
        }
        #endregion

        #region "Add to cart" event-handler
        private void AddToCart_Click(object sender, System.EventArgs e)
        {

            if (BookList.SelectedItem == null || CustomerList.SelectedItem == null)
            {
                // user has not chosen a book
                MessageBox.Show("Please choose a book and a customer first");
                BookList.Focus();
            }
            else if(QuantityBox.Value == 0 && (BookList.SelectedItem != null && CustomerList.SelectedItem != null))
            {
                // user has not chosen the quantity (it is still 0)
                MessageBox.Show("Please set \"Quantity\" to a non-zero positive value");
                QuantityBox.Focus();
            }
            else if(Math.Round(QuantityBox.Value) == 0 ||
                    QuantityBox.Value / Math.Round(QuantityBox.Value) != 1
                )
            {
                // user has chosen 0 books
                MessageBox.Show("Please set \"Quantity\" to a whole number");
                QuantityBox.Focus();
                QuantityBox.Value = 0;
            }
            else
            {
                string selectedTitle = RetrievedBooks.Tables[0].Rows[BookList.SelectedIndex]["title"].ToString();
                decimal selectedPrice = decimal.Parse(RetrievedBooks.Tables[0].Rows[BookList.SelectedIndex]["price"].ToString());
                int selectedCustID =  Convert.ToInt32(CustomerIDStorage[CustomerList.SelectedIndex]);
                string selectedCustName = RetrievedCustomers.Tables[0].Rows[CustomerList.SelectedIndex]["first_name"].ToString() + " " + RetrievedCustomers.Tables[0].Rows[CustomerList.SelectedIndex]["last_name"].ToString();
                int selectedBookID = Convert.ToInt32(BookIDStorage[BookList.SelectedIndex]);

                // calculate amount fields
                SubtotalAmount += Math.Round(QuantityBox.Value * selectedPrice, 2);      // calculate subtotal field
                TaxAmount = Math.Round(0.1m * SubtotalAmount, 2);     //  calculate tax. 10% of SubtotalAmount
                TotalAmount = SubtotalAmount + TaxAmount;      // calculate the total amount. SubtotalAmount + TaxAmount

                // update amount fields
                UpdateAmountFields(SubtotalAmount, TaxAmount, TotalAmount);

                // add selected book and QTY to the DataGridView
                OrderSummarydataGridView.Rows.Add(selectedBookID, selectedTitle, QuantityBox.Value, "$" + selectedPrice, "$" + QuantityBox.Value * selectedPrice, selectedCustID, selectedCustName);
            }
        }
        #endregion

        #region "Confirm Order" event-handler
        /// <summary>
        /// Event-handler when user clicks "Confirm Order"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfirmOrderButton_Click(object sender, EventArgs e)
        {
            // check if the user added something to the cart
            if (TotalAmount == 0m)
            {
                MessageBox.Show("Please add book(s) to the order first");
                BookList.Focus();
            } else if (BookList.SelectedItem != null)
            {
                DialogResult dialogResult = MessageBox.Show("Please confirm your order", "Confirm your order", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int CurrQty = 0;
                    int CurrBookID = 0;
                    int CurrCustID = 0;
                    decimal CurrSubtotalAmount = 0;
                    decimal CurrTaxAmount = 0;
                    decimal CurrTotalAmount = 0;
                    string tempStr = null;
                    int MaxOrderID = 0;


                    //InsertIntoOrdersTable(CurrCustID, SubtotalAmount, TaxAmount, TotalAmount);


                    foreach (DataGridViewRow row in OrderSummarydataGridView.Rows)
                    {
                        CurrCustID = Convert.ToInt32(row.Cells["Customer_ID"].Value);

                        tempStr = row.Cells["Price"].Value.ToString();
                        tempStr = tempStr.Replace("$", "");

                        CurrSubtotalAmount = Convert.ToDecimal(row.Cells["Quantity"].Value) * Convert.ToDecimal(tempStr);
                        CurrTaxAmount = Math.Round(CurrSubtotalAmount * 0.1m, 2);
                        CurrTotalAmount = CurrSubtotalAmount + CurrTaxAmount;
                        CurrBookID = Convert.ToInt32(row.Cells["Book_ID"].Value);
                        CurrQty = Convert.ToInt32(row.Cells["Quantity"].Value);

                        InsertIntoOrdersTable(CurrCustID, CurrSubtotalAmount, CurrTaxAmount, CurrTotalAmount);
                        MaxOrderID = MAX_ID_FROM_ORDER_TABLE();
                        InsertIntoOrderDetailsTable(MaxOrderID, CurrBookID, CurrQty, CurrSubtotalAmount);
                    }
                    
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        
        #endregion

        #region "Cancel Order" event-handler
        /// <summary>
        /// Event-handler when user clicks "Cancel Order"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelOrderButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel this order?", "Cancel Order", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // clear Order Summary DataGridView visually
                OrderSummarydataGridView.Rows.Clear();

                // reset SubtotalAmount, TaxAmount and TotalAmount to $0
                SubtotalAmount = TaxAmount = TotalAmount = 0m;
                
                // update amount fields
                UpdateAmountFields(SubtotalAmount, TaxAmount, TotalAmount);
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }
        #endregion

        #region Helper Functions
        private void Connect_DB_and_Populate_Books()
        {

            try
            {
                string con_string = "datasource = localhost; username = root; password =; database=bookstore";
                MySqlConnection db_con = new MySqlConnection(con_string);
                MySqlDataAdapter da = new MySqlDataAdapter("select * from books ORDER BY book_id ASC", db_con);
                db_con.Open();
                BookIDStorage = new ArrayList();
                da.Fill(RetrievedBooks, "books");
                for (int i = 0; i < RetrievedBooks.Tables[0].Rows.Count; i++)
                {
                    BookList.Items.Add(RetrievedBooks.Tables[0].Rows[i]["title"].ToString());
                    BookIDStorage.Add(RetrievedBooks.Tables[0].Rows[i]["book_id"].ToString());
                }
                db_con.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// used to populate combobox in this form from database with "books" table
        /// </summary>
        private void Connect_DB_and_Populate_Customers()
        {
            try
            {
                string con_string = "datasource = localhost; username = root; password =; database=bookstore";
                MySqlConnection db_con = new MySqlConnection(con_string);
                MySqlDataAdapter da = new MySqlDataAdapter("select * from customer ORDER BY customer_id ASC", db_con);
                db_con.Open();
                CustomerIDStorage = new ArrayList();
                da.Fill(RetrievedCustomers, "customer");
                for (int i = 0; i < RetrievedCustomers.Tables[0].Rows.Count; i++)
                {
                    CustomerList.Items.Add(RetrievedCustomers.Tables[0].Rows[i]["first_name"].ToString() + " " + RetrievedCustomers.Tables[0].Rows[i]["last_name"].ToString());
                    CustomerIDStorage.Add(RetrievedCustomers.Tables[0].Rows[i]["customer_id"].ToString());
                }
                db_con.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        /// <summary>
        /// returns the latest ID of the entry into the orders table
        /// </summary>
        private int MAX_ID_FROM_ORDER_TABLE()
        {
            int max_id = 0;
            try
            {
                string con_string = "datasource = localhost; username = root; password =; database=bookstore";
                MySqlConnection db_con = new MySqlConnection(con_string);
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT MAX(order_id) FROM orders;", db_con);
                db_con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "orders");
                max_id = Convert.ToInt32(ds.Tables[0].Rows[0]["MAX(order_id)"].ToString());
                db_con.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return max_id;
        }


        /// <summary>
        /// Inserts into orders table
        /// </summary>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="isbn"></param>
        /// <param name="price"></param>
        private void InsertIntoOrdersTable(int customer_id, decimal sub_total, decimal tax, decimal total)
        {
            try
            {
                string MyConnection3 = "datasource=localhost;username=root;passwor=;database=bookstore";
                string Query = @"INSERT INTO orders(customer_id, sub_total, tax, total, order_date) VALUES ('" + customer_id + @"', '" + sub_total + @"', '" + tax + @"', '" + total + @"',  '" + DateTime.Now.ToString("yyyy-MM-dd") + @"');";
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
        /// Inserts into order_details table
        /// </summary>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="isbn"></param>
        /// <param name="price"></param>
        private void InsertIntoOrderDetailsTable(int order_id, int book_id, int qty_of_books, decimal line_total_per_book)
        {
            try
            {
                string MyConnection3 = "datasource=localhost;username=root;passwor=;database=bookstore";
                string Query = @"INSERT INTO order_details(order_id, book_id, qty_of_books, line_total_per_book) VALUES (" + order_id + @", " + book_id + @", " + qty_of_books + @", " + line_total_per_book + @");";
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
        /// Updates the amount text boxes: Subtotal, Tax, Total
        /// </summary>
        /// <param name="SubtotalAmount"></param>
        /// <param name="TaxAmount"></param>
        /// <param name="TotalAmount"></param>
        private void UpdateAmountFields(decimal SubtotalAmount, decimal TaxAmount, decimal TotalAmount)
        {
            SubtotalBox.Text = "$" + SubtotalAmount;
            TaxBox.Text = "$" + TaxAmount;
            TotalBox.Text = "$" + TotalAmount;
        }
       

        /// <summary>
        /// handles writing the order summary to the orders.txt file within the same directory
        /// </summary>
        private void WriteOrderSummaryToFile()
        {
            try
            {
                // open book.txt file for reading
                outFile = new FileStream(FILENAMEOUT, FileMode.Create, FileAccess.Write);
                LineWriter = new StreamWriter(outFile);
            }
            catch (UnauthorizedAccessException)
            {
                LineWriter.Close();
                outFile.Close();
                
                MessageBox.Show("It seems like you do not have access to the file or directory.");
            }
            catch (IOException)
            {
                LineWriter.Close();
                outFile.Close();
                
                MessageBox.Show("Unknown IO error occured.");
            }
            LineWriter.Write($"---------------------------------------------------------------------------------------------------{Environment.NewLine}");
            LineWriter.Write($"Your order summary{Environment.NewLine}");
            LineWriter.Write($"---------------------------------------------------------------------------------------------------{Environment.NewLine}");
            LineWriter.Write($"#  |                        Title                     |   QTY   |    Price    |     Line Total     {Environment.NewLine}");

            // write to the file
            for (int rows = 0; rows < OrderSummarydataGridView.Rows.Count; rows++)
            {
                LineWriter.Write(String.Format("{0,-3}|", rows + 1));
                for (int col = 0; col < OrderSummarydataGridView.Rows[rows].Cells.Count; col++)
                {
                    string value = OrderSummarydataGridView.Rows[rows].Cells[col].Value.ToString();


               //     LineWriter.Write($"{(col == 0 ? "Title: " : (col == 1 ? " QTY: " : col == 2 ? " Price: " : col == 3 ? " Line Total: " : "")):-25}{value},");
                    if(col == 0)
                    {
                        LineWriter.Write(String.Format("   {0, -47}|", value));
                    }
                    else if(col == 1)
                    {
                        LineWriter.Write(String.Format("   {0, -6}|", value));
                    }
                    else if (col == 2)
                    {
                        LineWriter.Write(String.Format("    {0, -9}|", value));
                    }
                    else if (col == 3)
                    {
                        LineWriter.Write(String.Format("     {0, -12}", value));
                    }

                }
                LineWriter.Write($"{Environment.NewLine}");
            }

            // one more line-break for nice formatting
            LineWriter.Write($"{Environment.NewLine}");

            // display subtotal, tax and total amoutns
            LineWriter.Write($"Subtotal: ${SubtotalAmount}{Environment.NewLine}" +
                $"Tax: ${TaxAmount}{Environment.NewLine}" +
                $"Total amount to pay: ${TotalAmount}{Environment.NewLine}");

            // close the file after writing
            LineWriter.Close();
            outFile.Close();
        }
        #endregion

        /// <summary>
        /// handles opening the parent form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookStoreForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.RefToForm1.Show();
        }


    }
}
