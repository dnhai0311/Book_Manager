using Book_Manager.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Manager.Repositories
{
    public class BookSaleRepository : IBookSaleRepository
    {
        BookSaleContext bookSaleContext { get; set; }
        readonly AuthorContext authorContext;
        readonly PublisherContext publisherContext;
        public BookSaleRepository(BookSaleContext bookSaleContext, AuthorContext authorContext, PublisherContext publisherContext)
        {
            this.bookSaleContext = bookSaleContext;
            this.authorContext = authorContext;
            this.publisherContext = publisherContext;
        }
        public void AddSale(BookSale bookSale)
        {
            this.bookSaleContext.add(bookSale);
            string query = "INSERT INTO booksales (title, image, price, quantity, author, publisher) " +
                "VALUES (@title, @image, @price, @quantity, @author, @publisher)";

            Database.Open();

            using (MySqlCommand command = new MySqlCommand(query, Database.con))
            {
                command.Parameters.AddWithValue("@title", bookSale.title);
                command.Parameters.AddWithValue("@image", bookSale.image);
                command.Parameters.AddWithValue("@price", bookSale.price);
                command.Parameters.AddWithValue("@quantity", bookSale.quantity);
                command.Parameters.AddWithValue("@author", bookSale.author);
                command.Parameters.AddWithValue("@publisher", bookSale.publisher);

                command.ExecuteNonQuery();
            }

            Database.Close();
        }
        public decimal SalesTotal()
        {
            return this.bookSaleContext.getSalesTotal();
        }
        public decimal SalesCount()
        {
            return this.bookSaleContext.getSalesCount();
        }
        public List<BookSale> GetAllBookSales()
        {
            var bookSales = new List<BookSale>();

            Database.Open();
            try
            {
                using (var cmd = new MySqlCommand("SELECT * FROM booksales", Database.con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var bookSale = new BookSale
                            {
                                title = reader.GetString("title"),
                                image = reader.GetString("image"),
                                price = reader.GetDecimal("price"),
                                quantity = reader.GetInt32("quantity"),
                                author = reader.GetInt32("author"),
                                publisher = reader.GetInt32("publisher")

                            };
                            bookSales.Add(bookSale);
                        }
                    }
                }
            }
            finally
            {
                Database.Close();
            }

            return bookSales;
        }

        public void UpdateRepositoryWithAllBookSales()
        {
            var bookSalesFromDb = GetAllBookSales();

            bookSaleContext.BookSales.Clear();
            foreach (var bookSale in bookSalesFromDb)
            {
                bookSaleContext.BookSales.Add(bookSale);
            }
        }
    }
}
