using Book_Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Manager.Repositories
{
    public interface IBookSaleRepository
    {
        void AddSale(BookSale bookSale);
        List<BookSale> GetAllSales();
        decimal SalesTotal();
        decimal SalesCount();
    }
}
