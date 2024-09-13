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
        readonly string name;
        readonly IAuthorRepository authorRepository;
        readonly IPublisherRepository publisherRepository;

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
            if(txtName.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập~~");
                return;
            }
            if(name == "tác giả")
            {
                var author = new Author
                {
                    name = txtName.Text
                };

                authorRepository.AddAuthor(author);
                MessageBox.Show("Thêm tác giả mới thành công!!");
            }
            else
            {
                var publisher = new Publisher
                {
                    name = txtName.Text
                };

                publisherRepository.AddPublisher(publisher);
                MessageBox.Show("Thêm nhà xuất bản mới thành công!!");
            }
        }
    }
}
