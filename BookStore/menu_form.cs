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
            // hide main form
            this.Hide();

            // show other form
            var Books = new BookStoreForm();
            Books.RefToForm1 = this;
            Books.ShowDialog();
        }

        private void Manage_Books_button_Click(object sender, EventArgs e)
        {
            // hide main form
            this.Hide();

            // show other form
            var Books = new Book_Window_form();
            Books.RefToForm1 = this;
            Books.ShowDialog();
        }

        private void Manage_Customers_button_Click(object sender, EventArgs e)
        {
            // hide main form
            this.Hide();

            // show other form
            var Books = new customer_form();
            Books.RefToForm1 = this;
            Books.ShowDialog();
        }
    }
}