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
    public partial class ListBookSales : Form
    {
        readonly AuthorContext authorContext;
        readonly AuthorRepository authorRepository; 
        readonly PublisherContext publisherContext;
        readonly PublisherRepository publisherRepository; 

        public ListBookSales()
        {
            InitializeComponent();
            authorContext = new AuthorContext();
            authorRepository = new AuthorRepository(authorContext);
            publisherContext = new PublisherContext();
            publisherRepository = new PublisherRepository(publisherContext);
        }

        private void SáchMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddNewBook(authorContext, publisherContext).ShowDialog();
        }

        private void TácGiảMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddNewAuthorOrPublisher(authorRepository, publisherRepository, "tác giả").ShowDialog();
        }

        private void NhàXuấtBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddNewAuthorOrPublisher(authorRepository, publisherRepository, "nhà xuất bản").ShowDialog();
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListBookSales_Load(object sender, EventArgs e)
        {
            authorRepository.UpdateRepositoryWithAllAuthors();
            publisherRepository.UpdateRepositoryWithAllPublishers();
        }

    }
}
