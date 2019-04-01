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

namespace BookStore
{
    public partial class BookStoreForm : Form
    {
        #region Fields
        /// <summary>
        /// Stores the books read from book.txt file
        /// </summary>
        private List<Book> Books = new List<Book>();

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
        /// for reading input file book.txt
        /// </summary>
        FileStream inFile = null;

        /// <summary>
        /// for writing to the output file orders.txt
        /// </summary>
        FileStream outFile = null;

        /// <summary>
        /// handles reading from a file
        /// </summary>
        StreamReader LineReader = null;

        /// <summary>
        /// handles writing to a file
        /// </summary>
        StreamWriter LineWriter = null;

        /// <summary>
        /// keeps the line read form the book.txt file
        /// </summary>
        String LineIn;

        /// <summary>
        /// for separating "LineIn" array of fields into separate fields for further processing
        /// </summary>
        String[] fields;
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
        /// Event handler, envoked when Combobox item is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            for(int i = 0; i < BookList.Items.Count; i++)
            {
                if(BookList.SelectedIndex == i)
                {
                    AuthorBox.Text = Books[i].Author;
                    ISBNBox.Text = Books[i].ISBN;
                    PriceBox.Text = Books[i].Price.ToString();
                }
            }
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
            // open file handlers to read data from book.txt
            OpenBookFileReader();

            // loads the books from book.txt into the "Books" arraylist
            LoadBooks();

            // loads "Books" items into the combobox
            PopulateComboBox();

        }
        #endregion

        #region "Add to cart" event-handler
        private void AddToCart_Click(object sender, System.EventArgs e)
        {

            if (BookList.SelectedItem == null)
            {
                // user has not chosen a book
                MessageBox.Show("Please choose the book first");
                BookList.Focus();
            }
            else if(QuantityBox.Value == 0 && BookList.SelectedItem != null)
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

                // calculate amount fields
                SubtotalAmount += Math.Round(QuantityBox.Value * Books[BookList.SelectedIndex].Price, 2);      // calculate subtotal field
                TaxAmount = Math.Round(0.1m * SubtotalAmount, 2);     //  calculate tax. 10% of SubtotalAmount
                TotalAmount = SubtotalAmount + TaxAmount;      // calculate the total amount. SubtotalAmount + TaxAmount

                // update amount fields
                UpdateAmountFields(SubtotalAmount, TaxAmount, TotalAmount);

                // add selected book and QTY to the DataGridView
                OrderSummarydataGridView.Rows.Add(Books[BookList.SelectedIndex].Title, QuantityBox.Value, "$" + Books[BookList.SelectedIndex].Price, "$" + QuantityBox.Value * Books[BookList.SelectedIndex].Price);
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
                    // write the order summary to the orders.txt file within the same directory
                    WriteOrderSummaryToFile();   
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
        /// loads the books into the Books arraylist
        /// </summary>
        private void LoadBooks()
        {
            // read the first line from book.txt
            LineIn = LineReader.ReadLine();

            // while valid records are read from the book.txt file, continue parsing and processing them
            // also add the books into the combobox
            while (LineIn != null)
            {
                // create a new Book object
                Book TempBook = new Book();

                try
                {
                    // parse the line from book.txt into multiple Array items
                    fields = LineIn.Split(DELIM);
                }
                catch(OutOfMemoryException)
                {
                    LineReader.Close();
                    inFile.Close();
                    
                    MessageBox.Show("Your computer is out of memory. Probably, the book.txt is not correctly formatted.");
                }

                // assign the read data to the TempBook's fields
                TempBook.Author = fields[0];
                TempBook.ISBN = fields[1];
                TempBook.Price = Convert.ToDecimal(fields[2]);
                TempBook.Title = fields[3];

                // add the TempBook to the BookList
                Books.Add(TempBook);

                // read the next line of book.txt
                LineIn = LineReader.ReadLine();
            }
        }

        /// <summary>
        /// opens a file for reading later
        /// </summary>
        private void OpenBookFileReader()
        {
            try
            {
                // open book.txt file for reading
                inFile = new FileStream(FILENAMEIN, FileMode.Open, FileAccess.Read);
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show($"Sorry, we searched high and low but couldn't find \"{e.FileName}\" file");
            }
            catch (Exception)
            {
                MessageBox.Show($"Sorry, something went really bad while accessing \"book.txt\" in the program's current directory");
            }

            try
            {
                LineReader = new StreamReader(inFile);
            } 
            catch(IOException)
            {
                MessageBox.Show($"Sorry, something went wrong with the file");
            }
            
        }

        /// <summary>
        /// populates the combobox with the items of the "Books" arraylist
        /// </summary>
        private void PopulateComboBox()
        {
            for (int i = 0; i < Books.Count; i++)
            {
                BookList.Items.Add(Books[i].Title);
            }
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
    }
}
