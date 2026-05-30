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
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjectBookApp
{
    public partial class Report : UserControl
    {
        public Report()
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
        private async void Report_Load(object sender, EventArgs e)
        {
            List<Book> books = await GetBooks();

            int totalBooks = books.Count;

            int totalAuthor = books
                .GroupBy(b => b.author)
                .Select(g => g.First())
                .ToList().Count;

            int isBorrowedBooks = books.Where(b => b.isBorrowed).ToList().Count;
            int available = totalBooks - isBorrowedBooks;

            txt_total.Text = "" + totalBooks;
            txt_author.Text = "" + totalAuthor;
            txt_borrowed.Text = "" + isBorrowedBooks;
            txt_available.Text = "" + available;


            chart1.Series.Clear();
            chart1.Titles.Clear();

            chart1.Titles.Add("Books status");

            Series series = new Series("Books")
            {
                ChartType = SeriesChartType.Pie
            };


            series.Points.AddXY("Borrowed", isBorrowedBooks);
            series.Points.AddXY("Available", available);

            chart1.Series.Add(series);

        }

        
    }
}
