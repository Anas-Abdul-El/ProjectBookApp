using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBookApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadControl(UserControl controls)
        {
            panelMain.Controls.Clear();
            controls.Dock = DockStyle.Fill;
            panelMain.Controls.Add(controls);
        }

        private void btn_add_books_panel_Click(object sender, EventArgs e)
        {
            LoadControl(new AddBooks());
        }

        private void btn_update_panel_Click(object sender, EventArgs e)
        {
            LoadControl(new UpdateBooks());
        }

        private void btn_del_panel_Click(object sender, EventArgs e)
        {
            LoadControl(new DeleteBooks());
        }

        private void reports_btn_panel_Click(object sender, EventArgs e)
        {
            LoadControl(new Report());
        }
    }
}
