using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;


namespace ProjectBookApp
{
    public partial class UpdateBooks : UserControl
    {
        public int bookId { get; set; }
        public UpdateBooks()
        {
            InitializeComponent();
        }

        private async Task<List<Book>> GetBooks()
        {
            var client = new HttpClient();

            var books = await client.GetFromJsonAsync<List<Book>>(
                "https://localhost:7152/api/Books"
            );

            return books;
        }

        private async void UpdateBooks_Load(object sender, EventArgs e)
        {
            List<Book> books = await GetBooks();
            for (int i = 0; i < books.Count; i++)
            {
                choose_book.Items.Add(books[i].ToString());
            }
        }

        private async void choose_book_SelectedIndexChanged(object sender, EventArgs e)
        { 
            bookId = choose_book.SelectedIndex;
            List<Book> books = await GetBooks();

            txt_title.Text = books[bookId].title;
            txt_isbn.Text = books[bookId].isbn;
            txt_quantity.Value = books[bookId].quantity;
            txt_author.Text = books[bookId].author;
            txt_isBorrowed.Checked = books[bookId].isBorrowed;
        }

        private async void update_btn_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            List<Book> books = await GetBooks();

            if (txt_title.Text != String.Empty && txt_isbn.Text != String.Empty && txt_author.Text != String.Empty && txt_quantity.Value != 0)
            {
                var book = new
                {
                    bookId = books[bookId].bookId,
                    title = txt_title.Text,
                    author = txt_author.Text,
                    quantity = txt_quantity.Value,
                    isbn = txt_isbn.Text,
                    isBorrowed = txt_isBorrowed.Checked
                };

                var response = await client.PutAsJsonAsync(
                    $"https://localhost:7152/api/Books/{book.bookId}",
                    book
                );

                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Updated successfully");
            }

            

            txt_title.Text = String.Empty;
            txt_isbn.Text = String.Empty;
            txt_quantity.Value = txt_quantity.Minimum;
            txt_author.Text = String.Empty;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            txt_title.Text = String.Empty;
            txt_isbn.Text = String.Empty;
            txt_quantity.Value = txt_quantity.Minimum;
            txt_author.Text = String.Empty;
        }
    }
}
