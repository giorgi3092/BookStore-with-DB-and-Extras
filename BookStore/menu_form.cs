using BookStore.order_form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Menu_Form : Form
    {
        public Menu_Form()
        {
            InitializeComponent();
        }

        private void Place_Order_button_Click(object sender, EventArgs e)
        {
            // open order window
            BookStoreForm orders = new BookStoreForm();
            orders.Show();
        }

        private void Manage_Books_button_Click(object sender, EventArgs e)
        {
            // open book window
            Book_Window_form books = new Book_Window_form();
            books.Show();
        }

        private void Manage_Customers_button_Click(object sender, EventArgs e)
        {
            
        }
    }
}