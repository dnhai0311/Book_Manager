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
        AuthorContext? authorContext;
        PublisherContext? publisherContext;

        public BookSaleRepository(BookSaleContext bookSaleContext)
        {
            this.bookSaleContext = bookSaleContext;
        }
        public BookSaleRepository(BookSaleContext bookSaleContext, AuthorContext authorContext, PublisherContext publisherContext)
        {
            this.bookSaleContext = bookSaleContext;
            this.authorContext = authorContext;
            this.publisherContext = publisherContext;
        }
        public void AddSale(BookSale bookSale, bool isAddedDB)
        {
            this.bookSaleContext.add(bookSale);

            if (isAddedDB)
            {
                string query = "INSERT INTO booksales (id, title, image, price, quantity, author, publisher) " +
                    "VALUES (@id ,@title, @image, @price, @quantity, @author, @publisher);";

                if (!Database.Open()) return;

                using (MySqlCommand command = new MySqlCommand(query, Database.con))
                {
                    command.Parameters.AddWithValue("@id", bookSale.id);
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

            if (!Database.Open()) return bookSales;

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
                                id = reader.GetInt32("id"),
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

        public BookSale GetBookSaleByTitle(string title)
        {
            var bookSale = new BookSale();

            if (!Database.Open()) return bookSale;

            try
            {
                using (var cmd = new MySqlCommand("SELECT * FROM booksales WHERE title = @title", Database.con))
                {
                    cmd.Parameters.AddWithValue("@title", title);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bookSale = new BookSale
                            {
                                id = reader.GetInt32("id"),
                                title = reader.GetString("title"),
                                image = reader.GetString("image"),
                                price = reader.GetDecimal("price"),
                                quantity = reader.GetInt32("quantity"),
                                author = reader.GetInt32("author"),
                                publisher = reader.GetInt32("publisher")
                            };
                        }
                    }
                }
            }
            finally
            {
                Database.Close();
            }

            return bookSale;
        }

        public bool ContainsTitle(string title)
        {
            return bookSaleContext.ContainsTitle(title);
        }

        public void UpdateSale(BookSale bookSale)
        {
            bookSaleContext.update(bookSale);
            string query = "UPDATE booksales SET title = @title, image = @image, price = @price, quantity = @quantity, " +
                           "author = @author, publisher = @publisher WHERE id = @id";

            if (!Database.Open()) return;

            using (MySqlCommand command = new MySqlCommand(query, Database.con))
            {
                command.Parameters.AddWithValue("@id", bookSale.id);
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

        public void DeleteSale(BookSale bookSale)
        {
            bookSaleContext.delete(bookSale);
            string query = "DELETE FROM booksales WHERE id = @id";

            if (!Database.Open()) return;

            using (MySqlCommand command = new MySqlCommand(query, Database.con))
            {
                command.Parameters.AddWithValue("@id", bookSale.id);

                command.ExecuteNonQuery();
            }

            Database.Close();
        }

        public int GetNextId()
        {
            string query = "SELECT MAX(id) + 1 FROM booksales";

            int nextId = 1;

            if (!Database.Open()) return nextId;

            using (MySqlCommand command = new MySqlCommand(query, Database.con))
            {
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    nextId = Convert.ToInt32(result);
                }
            }

            Database.Close();
            return nextId;
        }


    }
}
