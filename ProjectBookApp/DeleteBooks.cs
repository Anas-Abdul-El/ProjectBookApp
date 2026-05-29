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

            var books = await client.GetFromJsonAsync<List<Book>>(
                "https://localhost:7152/api/Books"
            );

            return books;
        }
        private  void Delete_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private async void DeleteBooks_Load(object sender, EventArgs e)
        {
            List<Book> books = await GetBooks();
            for (int i = 0; i < books.Count; i++)
            {
                Delete_list.Items.Add(books[i].ToString());
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();

            bookId = Delete_list.SelectedIndex;
            List<Book> books = await GetBooks();

            var response = await client.DeleteAsync(
        $"https://localhost:7152/api/Books/{books[bookId].bookId}"
    );
    
        }
    }
}
