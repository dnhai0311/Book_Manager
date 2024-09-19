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
    public partial class ListBookSales : Form
    {
        private int debounceTime = 200;
        private bool isSearch;
        private System.Windows.Forms.Timer searchTimer;
        private string oldImg;

        AuthorContext authorContext;
        AuthorRepository authorRepository;
        PublisherContext publisherContext;
        PublisherRepository publisherRepository;
        BookSaleContext bookSaleContext;
        BookSaleRepository bookSaleRepository;


        public ListBookSales(bool isSearch = false)
        {
            InitializeComponent();

            this.isSearch = isSearch;

            oldImg = String.Empty;

            authorContext = new AuthorContext();
            authorRepository = new AuthorRepository(authorContext);
            publisherContext = new PublisherContext();
            publisherRepository = new PublisherRepository(publisherContext);
            bookSaleContext = new BookSaleContext();
            bookSaleRepository = new BookSaleRepository(bookSaleContext, authorContext, publisherContext);

            searchTimer = new System.Windows.Forms.Timer();
            searchTimer.Interval = debounceTime;
            searchTimer.Tick += SearchTimer_Tick;

            dgvListBookSales.CellContentClick += dgvListBookSales_CellContentClick;
        }

        private void SearchTimer_Tick(object? sender, EventArgs e)
        {

            searchTimer.Stop();
            SearchBooks(txtSearch.Text);
        }

        private void SáchMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addNewBookForm = new AddNewBook(authorContext, publisherContext, bookSaleRepository);
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

        void addBookToTable(BookSale bookSale)
        {
            Image img = Image.FromFile(bookSale.image);
            dgvListBookSales.Rows.Add(
                bookSale.id,
                bookSale.title,
                img,
                bookSale.price.ToString("C"),
                bookSale.quantity,
                authorContext.Authors[bookSale.author].name,
                publisherContext.Publishers[bookSale.publisher].name
            );
        }

        private void ListBookSales_Load(object sender, EventArgs e)
        {
            authorRepository.UpdateRepositoryWithAllAuthors();
            publisherRepository.UpdateRepositoryWithAllPublishers();
            bookSaleRepository.UpdateRepositoryWithAllBookSales();

            dgvListBookSales.RowTemplate.Height = 150;
            dgvListBookSales.Columns[0].Width = 40;
            if (isSearch)
            {
                menuStrip.Items.Remove(toolStripMenuItem1);
                menuStrip.Items.Remove(xemToolStripMenuItem);

                dgvListBookSales.Columns.RemoveAt(7);
                dgvListBookSales.Columns.RemoveAt(7);

                DataGridViewButtonColumn selectColumn = new DataGridViewButtonColumn
                {
                    HeaderText = "",
                    Name = "select",
                    Text = "Chọn",
                    UseColumnTextForButtonValue = true
                };
                dgvListBookSales.Columns.Add(selectColumn);
                dgvListBookSales.Columns[7].Width = 60;
            }
            else
            {
                dgvListBookSales.Columns[7].Width = 40;
                dgvListBookSales.Columns[8].Width = 40;
            }
            dgvListBookSales.AllowUserToAddRows = false;

            dgvListBookSales.Rows.Clear();

            foreach (var bookSale in bookSaleContext.BookSales)
            {
                addBookToTable(bookSale);
            }

        }

        private void OnBookAdded(BookSale bookSale)
        {
            addBookToTable(bookSale);
        }
        private void OnBookUpdated(BookSale bookSale)
        {
            var row = dgvListBookSales.Rows
            .Cast<DataGridViewRow>()
            .FirstOrDefault(r => (int)r.Cells[0].Value == bookSale.id);

            if (row != null)
            {
                row.Cells[1].Value = bookSale.title;
                row.Cells[2].Value = Image.FromFile(bookSale.image);
                row.Cells[3].Value = bookSale.price.ToString("C");
                row.Cells[4].Value = bookSale.quantity;
                row.Cells[5].Value = authorContext.Authors[bookSale.author].name;
                row.Cells[6].Value = publisherContext.Publishers[bookSale.publisher].name;
            }
            if (oldImg != bookSale.image)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                File.Delete(oldImg);
                oldImg = String.Empty;
            }
        }
        private void SearchBooks(string searchTerm)
        {
            dgvListBookSales.Rows.Clear();

            var filteredBooks = bookSaleContext.BookSales
    .Where(bookSale =>
        bookSale.title.Unidecode().IndexOf(searchTerm.Unidecode(), StringComparison.OrdinalIgnoreCase) >= 0 ||
        authorContext.Authors[bookSale.author].name.Unidecode().IndexOf(searchTerm.Unidecode(), StringComparison.OrdinalIgnoreCase) >= 0 ||
        publisherContext.Publishers[bookSale.publisher].name.Unidecode().IndexOf(searchTerm.Unidecode(), StringComparison.OrdinalIgnoreCase) >= 0
    )
    .ToList();


            foreach (var bookSale in filteredBooks)
            {
                addBookToTable(bookSale);

            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SearchBooks(txtSearch.Text);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchTimer.Stop();
            searchTimer.Start();
        }

        private void dgvListBookSales_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (isSearch && e.ColumnIndex == dgvListBookSales.Columns["select"].Index)
                {
                    int selectedBookSaleId = (int)dgvListBookSales.Rows[e.RowIndex].Cells[0].Value;

                    this.DialogResult = DialogResult.OK;
                    this.Tag = selectedBookSaleId;
                    this.Close();
                }
                else if (e.ColumnIndex == dgvListBookSales.Columns["modify"].Index)
                {
                    string title = dgvListBookSales.Rows[e.RowIndex].Cells["title"].Value.ToString() ?? string.Empty;
                    var bookSale = bookSaleRepository.GetBookSaleByTitle(title);
                    var addModifyBookForm = new AddNewBook(authorContext, publisherContext, bookSaleRepository, bookSale);

                    var row = dgvListBookSales.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => (int)r.Cells[0].Value == bookSale.id);
                    if (row != null)
                    {
                        oldImg = bookSale.image;
                        row.Cells[2].Value = null;
                        addModifyBookForm.BookAdded += OnBookUpdated;
                        addModifyBookForm.ShowDialog();
                        row.Cells[2].Value = Image.FromFile(bookSale.image);
                    }

                }

                else if (e.ColumnIndex == dgvListBookSales.Columns["delete"].Index)
                {
                    string title = dgvListBookSales.Rows[e.RowIndex].Cells["title"].Value.ToString() ?? string.Empty;
                    var bookSale = bookSaleRepository.GetBookSaleByTitle(title);

                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        bookSaleRepository.DeleteSale(bookSale);
                        MessageBox.Show("Xóa thành công!");

                        OnBookDeleted(bookSale);
                    }
                }
            }
        }
        private void OnBookDeleted(BookSale bookSale)
        {
            var rowToDelete = dgvListBookSales.Rows
                .Cast<DataGridViewRow>()
                .Where(row => (int)row.Cells[0].Value == bookSale.id)
                .FirstOrDefault();

            if (rowToDelete != null)
            {
                rowToDelete.Cells[2].Value = null;

                dgvListBookSales.Rows.RemoveAt(rowToDelete.Index);
            }

            if (bookSale.image != @"..\..\..\Images\default-book-img.jpg" && File.Exists(bookSale.image))
            {

                GC.Collect();
                GC.WaitForPendingFinalizers();
                File.Delete(bookSale.image);
            }
        }

    }
}
