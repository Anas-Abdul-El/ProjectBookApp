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
    public partial class AddBooks : UserControl
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private  void AddBooks_Load(object sender, EventArgs e)
        {
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();

            if (txt_title.Text != String.Empty && txt_isbn.Text != String.Empty && txt_author.Text != String.Empty && txt_quantity.Value != 0)
            {
                var book = new
                {
                    bookId = 0,
                    title = txt_title.Text,
                    author = txt_author.Text,
                    quantity = txt_quantity.Value,
                    isBorrowed = true
                };

                var response = await client.PostAsJsonAsync(
                "https://localhost:7152/api/Books",
                book
            );

                txt_title.Text = String.Empty;
                txt_isbn.Text = String.Empty;
                txt_quantity.Value = txt_quantity.Minimum;
                txt_author.Text = String.Empty;

            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_title.Text = String.Empty;
            txt_isbn.Text = String.Empty;
            txt_quantity.Value = txt_quantity.Minimum;
            txt_author.Text = String.Empty;
        }
    }
}
