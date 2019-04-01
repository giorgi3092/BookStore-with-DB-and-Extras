/*
 * Author: Giorgi Aptsiauri 
 * Date: 2/10/2019
 * For class: COMPE 561
 * 
 * Description: this class defines a book to be used in the BookStore app
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Book
    {
        #region Book fields
        /// <summary>
        /// Book class fields
        /// </summary>
        public string Author { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }
        #endregion

        #region Default constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Book() { }
        #endregion

        #region
        /// <summary>
        /// Explicit-value constructor
        /// </summary>
        /// <param name="Author"></param>
        /// <param name="ISBN"></param>
        /// <param name="Price"></param>
        /// <param name="Title"></param>
        public Book(string Author, string ISBN, decimal Price, string Title)
        {
            this.Author = Author;
            this.ISBN = ISBN;
            this.Price = Price;
            this.Title = Title;
        }
        #endregion

    }
}
