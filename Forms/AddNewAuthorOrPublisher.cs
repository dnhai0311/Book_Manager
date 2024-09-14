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
    public partial class AddNewAuthorOrPublisher : Form
    {
        string name;
        IAuthorRepository authorRepository;
        IPublisherRepository publisherRepository;

        public AddNewAuthorOrPublisher(IAuthorRepository authorRepository, IPublisherRepository publisherRepository, string name)
        {
            InitializeComponent();
            this.name = name;
            this.authorRepository = authorRepository;
            this.publisherRepository = publisherRepository;
            this.AcceptButton = btnSubmit;
        }

        private void AddNewAuthorOrPublisher_Load(object sender, EventArgs e)
        {
            lbName.Text += name;
            this.Text += name;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập~~");
                return;
            }
            if (name == "tác giả")
            {
                if (authorRepository.ContainsName(txtName.Text.Trim())) {
                    MessageBox.Show("Tên tác đã có trong cơ sở dữ liệu~~");
                    return;
                }
                var author = new Author
                {
                    name = txtName.Text.Trim()
                };

                authorRepository.AddAuthor(author);
                MessageBox.Show("Thêm tác giả mới thành công!!");
            }
            else
            {
                if (publisherRepository.ContainsName(txtName.Text.Trim())) {
                    MessageBox.Show("Tên nhà xuất bản đã có trong cơ sở dữ liệu~~");
                    return;
                }
                var publisher = new Publisher
                {
                    name = txtName.Text.Trim()
                };

                publisherRepository.AddPublisher(publisher);
                MessageBox.Show("Thêm nhà xuất bản mới thành công!!");
            }
        }
    }
}
