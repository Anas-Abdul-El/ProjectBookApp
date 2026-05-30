using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBookApp
{
    public partial class DeleteBooks : UserControl
    {
        public int bookId { get; set; }
        public DeleteBooks()
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
            var books = await GetBooks();

            for (int i = 0; i < books.Count; i++)
            {
                Delete_list.Items.Add(books[i].ToString());
            }
        }
        private  void Delete_list_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private async void DeleteBooks_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var books = await GetBooks();
                var book = Delete_list.SelectedIndex;
                var client = new HttpClient();

                var request = new HttpRequestMessage(HttpMethod.Delete, $"https://localhost:7152/api/Books/{books[bookId].bookId}");

                var response = await client.SendAsync(request);

                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Book not found (404).", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show("book deleted");
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
    }
}
