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

namespace BookStore.order_form
{
    public partial class Book_Window_form : Form
    {
        #region Fields
        // reference to calling form
        public Form RefToForm1 { get; set; }
        #endregion

        #region Default Constructor
        /// <summary>
        /// default constructor of the form
        /// </summary>
        public Book_Window_form()
        {
            InitializeComponent();
        }
        #endregion

        #region order_form Load Event
        /// <summary>
        /// Populate the combobox when the main BookStoreForm form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Book_Window_form_Load(object sender, EventArgs e)
        {
            // establish connection to the database and populate combobox
            Connect_DB_and_Populate();
        }
        #endregion

        /// <summary>
        /// Executed before closing this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        

        /// <summary>
        /// Executed when Back Button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
                MySqlDataAdapter da = new MySqlDataAdapter("select * from books", db_con);
                db_con.Open();
                DataSet ds = new DataSet();

                da.Fill(ds, "books");
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Books_comboBox.Items.Add(ds.Tables[0].Rows[i]["title"].ToString());
                }
                db_con.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        private void Book_Window_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.RefToForm1.Show();
        }
    }
}
