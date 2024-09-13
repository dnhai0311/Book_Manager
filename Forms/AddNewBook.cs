using Book_Manager.Models;
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
        public AddNewBook(AuthorContext authorContext, PublisherContext publisherContext)
        {
            InitializeComponent();
            cbAuthor.DataSource = authorContext.GetAuthorNames();
            cbPublisher.DataSource = publisherContext.GetPublisherNames();
        }

        private void AddNewBook_Load(object sender, EventArgs e)
        {
            string defaultImagePath = @"..\..\..\Images\default-book-img.jpg";
            pbImage.Image = Image.FromFile(defaultImagePath);
            pbImage.SizeMode = PictureBoxSizeMode.CenterImage;
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
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể tải ảnh: " + ex.Message);
                    }
                }
            }
        }
    }
}
