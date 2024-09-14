using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Manager.Models
{
    public class BookSaleContext
    {
        public BindingList<BookSale> BookSales { get; set; }
        public BookSaleContext()
        {
            BookSales = new BindingList<BookSale>();
        }
        public void add(BookSale bookSale)
        {
            BookSales.Add(bookSale);
        }

        public decimal getSalesTotal()
        {
            decimal total = 0M;
            foreach (BookSale bookSale in BookSales)
            {
                total += bookSale.ExtendedPrice();
            }
            return total;
        }

        public decimal getSalesCount()
        {
            return BookSales.Count();
        }

        public bool ContainsTitle(string title)
        {
            return BookSales.Any(bookSale => bookSale.title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }
        public void update(BookSale updatedBookSale)
        {
            var existingBookSale = BookSales.FirstOrDefault(bookSale => bookSale.id == updatedBookSale.id);

            if (existingBookSale != null)
            {
                existingBookSale.title = updatedBookSale.title;
                existingBookSale.image = updatedBookSale.image;
                existingBookSale.author = updatedBookSale.author;
                existingBookSale.publisher = updatedBookSale.publisher;
                existingBookSale.quantity = updatedBookSale.quantity;
                existingBookSale.price = updatedBookSale.price;
            }
        }
    }
}
