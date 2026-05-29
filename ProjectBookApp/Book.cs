using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBookApp
{
    internal class Book
    {
        public Book(string title, string author,string isbn, int quantity, bool isBorrowed)
        {
            this.bookId = bookId;
            this.title = title;
            this.author = author;
            this.quantity = quantity;
            this.isBorrowed = isBorrowed;
            this.isbn = isbn;
        }

        public int bookId { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string isbn { get; set; }

        public int quantity { get; set; }
        public bool isBorrowed { get; set; }
        override
        public string ToString()
        {
            return "title: " + title + "\t" +  " author: " + author;
        }

    }
}
