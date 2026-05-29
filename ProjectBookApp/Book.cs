using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBookApp
{
    internal class Book
    {
        public Book(string title, string author, int quantity, bool isBarrowed)
        {
            this.bookId = bookId;
            this.title = title;
            this.author = author;
            this.quantity = quantity;
            this.isBarrowed = isBarrowed;
        }

        public int bookId { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public int quantity { get; set; }
        public bool isBarrowed { get; set; }

    }
}
