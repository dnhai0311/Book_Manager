using Book_Manager.Models;
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
        public BookSaleRepository(BookSaleContext bookSaleContext)
        {
            this.bookSaleContext = bookSaleContext;
        }
        public void AddSale(BookSale bookSale)
        {
            this.bookSaleContext.add(bookSale);
        }
        public decimal SalesTotal()
        {
            return this.bookSaleContext.getSalesTotal();
        }
        public decimal SalesCount()
        {
            return this.bookSaleContext.getSalesCount();
        }
        public List<BookSale> GetAllSales()
        {
            return this.bookSaleContext.Sales;
        }
    }
}
