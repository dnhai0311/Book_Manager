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
        AuthorContext authorContext;
        AuthorRepository authorRepository;
        PublisherContext publisherContext;
        PublisherRepository publisherRepository;
        BookSaleContext bookSaleContext;
        BookSaleRepository bookSaleRepository;


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
            var addNewBookForm = new AddNewBook(authorContext, publisherContext, bookSaleRepository, String.Empty);
            addNewBookForm.BookAdded += OnBookAdded;
            addNewBookForm.ShowDialog();

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

            dgvListBookSales.RowTemplate.Height = 150;
            dgvListBookSales.Columns[0].Width = 40;
            dgvListBookSales.Columns[7].Width = 40;
            dgvListBookSales.Columns[8].Width = 40;
            dgvListBookSales.AllowUserToAddRows = false;


            bookSaleRepository.UpdateRepositoryWithAllBookSales();
            dgvListBookSales.Rows.Clear();
            int id = 0;

            foreach (var bookSale in bookSaleContext.BookSales)
            {
                Image img = Image.FromFile(bookSale.image);

                dgvListBookSales.Rows.Add(
                    id,
                    bookSale.title,
                    img,
                    bookSale.price.ToString("C"),
                    bookSale.quantity,
                    authorContext.Authors[bookSale.author].name,
                    publisherContext.Publishers[bookSale.publisher].name
                );

                id++;
            }

        }

        private void OnBookAdded(BookSale bookSale)
        {
            int id = (int)bookSaleRepository.SalesCount()-1;
            Image img = Image.FromFile(bookSale.image);
            dgvListBookSales.Rows.Add(
                id,
                bookSale.title,
                img,
                bookSale.price.ToString("C"),
                bookSale.quantity,
                authorContext.Authors[bookSale.author].name,
                publisherContext.Publishers[bookSale.publisher].name
            );

        }
    }
}
