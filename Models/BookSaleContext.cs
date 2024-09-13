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
    }
}
