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
        void AddSale(BookSale bookSale, bool isAddedDB);
        List<BookSale> GetAllBookSales();
        void UpdateRepositoryWithAllBookSales();
        decimal SalesTotal();
        decimal SalesCount();
        BookSale GetBookSaleByTitle(string title);
        public bool ContainsTitle(string title);
        public void UpdateSale(BookSale bookSale);
        public void DeleteSale(BookSale bookSale);
        public int GetNextId();
    }
}
