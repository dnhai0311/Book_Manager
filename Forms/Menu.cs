using Book_Manager.Models;
using Book_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Manager.Forms
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();

        }

        private void ListBookSalesForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnListBookSales_Click(object sender, EventArgs e)
        {
            var listBookSalesForm = new ListBookSales();
            listBookSalesForm.Show();
            this.Hide();
            listBookSalesForm.FormClosed += ListBookSalesForm_FormClosed;
        }

        private void btnListSales_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
