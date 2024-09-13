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
        readonly BookSaleContext bookSaleContext;
        readonly BookSaleRepository bookSaleRepository;

        public ListBookSales()
        {
            InitializeComponent();
            authorContext = new AuthorContext();
            authorRepository = new AuthorRepository(authorContext);
            publisherContext = new PublisherContext();
            publisherRepository = new PublisherRepository(publisherContext);
            bookSaleContext = new BookSaleContext();
            bookSaleRepository = new BookSaleRepository(bookSaleContext, authorContext, publisherContext);
        }

        private void SáchMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddNewBook(authorContext, publisherContext, bookSaleRepository).ShowDialog();
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

        private void ListBookSales_Activated(object sender, EventArgs e)
        {
            bookSaleRepository.UpdateRepositoryWithAllBookSales();
            dgvListBookSales.Rows.Clear();
            int id = 0;
            foreach (var bookSale in bookSaleContext.BookSales)
            {
                dgvListBookSales.Rows.Add(
                    id,
                    bookSale.title,
                    Image.FromFile(bookSale.image),
                    bookSale.price.ToString("C"),
                    bookSale.quantity,
                    authorContext.Authors[bookSale.author].name,
                    publisherContext.Publishers[bookSale.publisher].name
                );
                id++;
            }
        }
    }
}
