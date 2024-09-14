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
    public partial class AddNewBill : Form
    {
        BookSaleContext bookSaleContext;
        BookSaleRepository bookSaleRepository;
        BookSale selectedBookSale;
        BookSale bill;
        public AddNewBill()
        {
            InitializeComponent();
            bookSaleContext = new BookSaleContext();
            bookSaleRepository = new BookSaleRepository(bookSaleContext);
            selectedBookSale = new BookSale();
            bill = new BookSale();
        }

        private void AddNewBill_Load(object sender, EventArgs e)
        {
            bookSaleRepository.UpdateRepositoryWithAllBookSales();
            var bookSales = bookSaleContext.BookSales;
            cbTitle.Items.Clear();
            foreach (var bookSale in bookSales)
            {
                cbTitle.Items.Add(bookSale.title);
            }
        }

        private void cbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTitle.SelectedIndex != -1)
            {
                txtQuantity.ReadOnly = false;

                int selectedIndex = cbTitle.SelectedIndex;
                selectedBookSale = bookSaleContext.BookSales[selectedIndex];
                txtPrice.Text = selectedBookSale.price.ToString("C");
                lbQuantity.Text = "Tồn kho: " + selectedBookSale.quantity.ToString();
                clear();
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Length <= 0)
            {
                lbNextDue.Text = string.Empty;
                clear();
                return;
            }
            if (Convert.ToInt32(txtQuantity.Text) > selectedBookSale.quantity)
            {
                MessageBox.Show("Vượt quá kho cho phép");
                clear();
                return;
            }
            cbDiscount.Enabled = true;
            cbStudentDiscount.Enabled = true;
            BookSale bookSale = new BookSale
            {
                quantity = Convert.ToInt32(txtQuantity.Text),
                price = selectedBookSale.price
            };

            bill = bookSale;

            txtExtendedPrice.Text = bookSale.ExtendedPrice().ToString("C");
            txtDiscount.Text = bookSale.Discount().ToString("C");
            UpdateNextDue();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void UpdateNextDue()
        {
            if (cbDiscount.Checked && cbStudentDiscount.Checked)
            {
                lbNextDue.Text = bill.NextDue(true, true).ToString("C");
            }
            else if (cbDiscount.Checked && !cbStudentDiscount.Checked)
            {
                lbNextDue.Text = bill.NextDue(true, false).ToString("C");
            }
            else if (!cbDiscount.Checked && cbStudentDiscount.Checked)
            {
                lbNextDue.Text = bill.NextDue(false, true).ToString("C");
            }
            else
            {
                lbNextDue.Text = bill.NextDue(false, false).ToString("C");
            }
        }

        private void cbDiscount_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNextDue();
        }

        private void clear()
        {
            txtQuantity.Clear();
            txtExtendedPrice.Clear();
            txtDiscount.Clear();
            lbNextDue.Text = string.Empty;
            cbDiscount.Enabled = false;
            cbStudentDiscount.Enabled = false;
        }

        private void tạoMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbTitle.SelectedIndex = -1;
            lbQuantity.Text = string.Empty;
            cbDiscount.Checked = false;
            cbStudentDiscount.Checked = false;
            txtQuantity.Clear();
            clear();
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
