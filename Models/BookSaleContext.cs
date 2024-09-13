using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Manager.Models
{
    public class BookSaleContext
    {
        public List<BookSale> Sales { get; set; }
        public BookSaleContext()
        {
            Sales = new List<BookSale>();
        }
        public void add(BookSale bookSale)
        {
            Sales.Add(bookSale);
        }

        public decimal getSalesTotal()
        {
            decimal total = 0M;
            foreach (BookSale bookSale in Sales)
            {
                total += bookSale.ExtendedPrice();
            }
            return total;
        }

        public decimal getSalesCount()
        {
            return Sales.Count();
        }
    }
}
