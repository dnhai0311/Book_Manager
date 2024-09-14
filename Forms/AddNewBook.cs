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
        string id;
        BookSaleRepository bookSaleRepository;

        public delegate void BookAddedHandler(BookSale bookSale);
        public event BookAddedHandler? BookAdded;

        string defaultImagePath = @"..\..\..\Images\default-book-img.jpg";

        public AddNewBook(AuthorContext authorContext, PublisherContext publisherContext, BookSaleRepository bookSaleRepository, string id)
        {
            InitializeComponent();
            cbAuthor.DataSource = authorContext.GetAuthorNames();
            cbPublisher.DataSource = publisherContext.GetPublisherNames();
            this.bookSaleRepository = bookSaleRepository;
            if (id == String.Empty)
            {
                id = bookSaleRepository.SalesCount().ToString();
            }
            this.id = id;
        }

        private void AddNewBook_Load(object sender, EventArgs e)
        {
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

            if (File.Exists(imgPath) && imgPath != defaultImagePath)
            {
                try
                {
                    string destFolder = Path.Combine(Application.StartupPath, @"..\..\..\Images\");
                    string newFileName = id + Path.GetExtension(imgPath);
                    string newFilePath = Path.Combine(destFolder, newFileName);

                    File.Copy(imgPath, newFilePath, true);
                    imgPath = newFilePath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể sao chép ảnh: " + ex.Message);
                    return;
                }
            }
            BookAdded?.Invoke(bookSale);
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
