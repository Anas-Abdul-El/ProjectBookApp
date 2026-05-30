using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ProjectBookApp
{
    public partial class Books : UserControl
    {
        public Books()
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

        private async void Books_Load(object sender, EventArgs e)
        {
            BooksDataGrid.ReadOnly = true;

            BooksDataGrid.AllowUserToAddRows = false;
            BooksDataGrid.AllowUserToDeleteRows = false;
            BooksDataGrid.AllowUserToResizeRows = false;

            BooksDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BooksDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BooksDataGrid.MultiSelect = false;

            var books = await GetBooks();

            BooksDataGrid.DataSource = books;
        }
    }
}
