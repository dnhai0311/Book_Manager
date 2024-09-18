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
using Unidecode.NET;

namespace Book_Manager.Forms
{
    public partial class AddNewBook : Form
    {
        string imgPath = string.Empty;
        int id;
        BookSale? bookSale;
        BookSaleRepository bookSaleRepository;

        public delegate void BookAddedHandler(BookSale bookSale);
        public event BookAddedHandler? BookAdded;

        string defaultImagePath;

        public AddNewBook(AuthorContext authorContext, PublisherContext publisherContext, BookSaleRepository bookSaleRepository)
        {
            InitializeComponent();
            cbAuthor.DataSource = authorContext.GetAuthorNames();
            cbPublisher.DataSource = publisherContext.GetPublisherNames();
            this.bookSaleRepository = bookSaleRepository;
            defaultImagePath = @"..\..\..\Images\default-book-img.jpg";
        }

        public AddNewBook(AuthorContext authorContext, PublisherContext publisherContext, BookSaleRepository bookSaleRepository, BookSale bookSale)
        {
            InitializeComponent();
            cbAuthor.DataSource = authorContext.GetAuthorNames();
            cbPublisher.DataSource = publisherContext.GetPublisherNames();
            this.bookSaleRepository = bookSaleRepository;
            txtTitle.Text = bookSale.title;
            txtPrice.Text = bookSale.price.ToString();
            txtQuantity.Text = bookSale.quantity.ToString();
            cbAuthor.SelectedIndex = bookSale.author;
            cbPublisher.SelectedIndex = bookSale.publisher;
            defaultImagePath = bookSale.image;

            lbTitle.Text = "Cập nhật sách";
            this.Text = "Cập nhật sách";
            btnAddNew.Text = "Cập nhật";

            txtTitle.SelectionStart = txtTitle.Text.Length;
            txtTitle.SelectionLength = 0;

            this.bookSale = bookSale;
            id = bookSale.id;
        }

        private void AddNewBook_Load(object sender, EventArgs e)
        {
            pbImage.Image = Image.FromFile(defaultImagePath);
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
            if (txtTitle.Text.Trim() == "" || txtPrice.Text.Trim() == "" || txtQuantity.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin~~");
                return;
            }
            if(bookSale==null) id = bookSaleRepository.GetNextId();
            if (File.Exists(imgPath) && imgPath != defaultImagePath)
            {
                try
                {
                    string destFolder = Path.Combine(@"..\..\..\Images\");
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

            if (bookSale == null) 
            {
                if (bookSaleRepository.ContainsTitle(txtTitle.Text.Trim()))
                {
                    MessageBox.Show("Tiêu đề sách đã có trong cơ sở dữ liệu~~");
                    return;
                }
                bookSale = new BookSale
                {
                    id = id,
                    title = txtTitle.Text.Trim(),
                    image = imgPath,
                    price = Convert.ToDecimal(txtPrice.Text),
                    quantity = Convert.ToInt32(txtQuantity.Text),
                    author = cbAuthor.SelectedIndex,
                    publisher = cbPublisher.SelectedIndex,
                };

                bookSaleRepository.AddSale(bookSale, true);

                MessageBox.Show("Thêm sách mới thành công!!");
            }
            else 
            {
                bookSale.title = txtTitle.Text.Trim();
                bookSale.price = Convert.ToDecimal(txtPrice.Text);
                bookSale.quantity = Convert.ToInt32(txtQuantity.Text);
                bookSale.author = cbAuthor.SelectedIndex;
                bookSale.publisher = cbPublisher.SelectedIndex;
                bookSale.image = imgPath;

                bookSaleRepository.UpdateSale(bookSale);

                MessageBox.Show("Cập nhật thông tin sách thành công!!");
            }
            BookAdded?.Invoke(bookSale);
            bookSale = null;
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
