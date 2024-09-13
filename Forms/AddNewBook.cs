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
    public partial class AddNewBook : Form
    {
        string imgPath = string.Empty;
        BookSaleRepository bookSaleRepository;
        public AddNewBook(AuthorContext authorContext, PublisherContext publisherContext, BookSaleRepository bookSaleRepository)
        {
            InitializeComponent();
            cbAuthor.DataSource = authorContext.GetAuthorNames();
            cbPublisher.DataSource = publisherContext.GetPublisherNames();
            this.bookSaleRepository = bookSaleRepository;
        }

        private void AddNewBook_Load(object sender, EventArgs e)
        {
            string defaultImagePath = @"..\..\..\Images\default-book-img.jpg";
            pbImage.Image = Image.FromFile(defaultImagePath);
            pbImage.SizeMode = PictureBoxSizeMode.CenterImage;
            imgPath = defaultImagePath;
        }

        private void btnChangeImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff|All Files|*.*";
                openFileDialog.Title = "Chọn file ảnh";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pbImage.Image = Image.FromFile(openFileDialog.FileName);
                        pbImage.SizeMode = PictureBoxSizeMode.Zoom;
                        imgPath = openFileDialog.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể tải ảnh: " + ex.Message);
                    }
                }
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || txtPrice.Text == "" || txtQuantity.Text == "")
            {
                MessageBox.Show("Vui lòng nhập~~");
                return;
            }
            var bookSale = new BookSale
            {
                title = txtTitle.Text,
                image = imgPath,
                price = Convert.ToDecimal(txtPrice.Text),
                quantity = Convert.ToInt32(txtQuantity.Text),
                author = cbAuthor.SelectedIndex,
                publisher = cbPublisher.SelectedIndex,
            };
            bookSaleRepository.AddSale(bookSale);
            MessageBox.Show("Thêm sách mới thành công!!");
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
