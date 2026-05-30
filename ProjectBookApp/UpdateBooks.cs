using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;
using System.Text.Json;


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

            var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:7152/api/Books");

            var response = await client.SendAsync(request);


            if (response.StatusCode != System.Net.HttpStatusCode.NoContent)
            {
            var data = await response.Content.ReadAsStringAsync();
                var books = JsonSerializer.Deserialize<List<Book>>(data);
                return books;
            }
            else 
            {
                return new List<Book>();
            }

        }

        private async void LoadList()
        {
            List<Book> books = await GetBooks();
            for (int i = 0; i < books.Count; i++)
            {
                choose_book.Items.Add(books[i].ToString());
            }
        }

        private async void UpdateBooks_Load(object sender, EventArgs e)
        {
            LoadList();
        }



        private async void choose_book_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookId = choose_book.SelectedIndex;
            List<Book> books = await GetBooks();

            txt_id.Text = books[bookId].bookId.ToString();
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

            if (txt_id.Text != String.Empty && txt_title.Text != String.Empty && txt_isbn.Text != String.Empty && txt_author.Text != String.Empty && txt_quantity.Value != 0)
            {
                try
                {
                    var book = new
                    {
                        bookId = txt_id.Text,
                        title = txt_title.Text,
                        author = txt_author.Text,
                        quantity = txt_quantity.Value,
                        isbn = txt_isbn.Text,
                        isBorrowed = txt_isBorrowed.Checked
                    };

                    var request = new HttpRequestMessage(HttpMethod.Put, $"https://localhost:7152/api/Books/{book.bookId}");
                    request.Content = new StringContent(JsonSerializer.Serialize(book), System.Text.Encoding.UTF8, "application/json");

                    var response = await client.SendAsync(request);

                    if (response.StatusCode == HttpStatusCode.NotFound)
                    {
                        MessageBox.Show("Book not found (404).", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (response.StatusCode == HttpStatusCode.InternalServerError)
                    {
                        MessageBox.Show("Server error (500). Please try again later.", "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Failed to update book: {(int)response.StatusCode} {response.ReasonPhrase}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"Network error while sending update: {ex.Message}", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
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

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
