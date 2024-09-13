using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Manager.Models
{
    public class BookSale
    {
        string strTitle;
        int intQuantity;
        decimal decPrice;

        public BookSale()
        {
            strTitle = string.Empty;
            intQuantity = 0;
            decPrice = 0;
        }

        public string Title
        {
            get { return strTitle; }
            set { strTitle = value; }
        }

        public int Quantity
        {
            get { return intQuantity; }
            set { intQuantity = value; }
        }

        public decimal Price
        {
            get { return decPrice; }
            set { decPrice = value; }
        }

        public decimal ExtendedPrice()
        {
            decimal decExtendedPrice = intQuantity * decPrice;
            return decExtendedPrice;
        }

        public decimal Discount()
        {
            decimal decDiscount = ExtendedPrice() * 0.1M;
            return decDiscount;
        }

        public decimal StudentDiscount()
        {
            decimal studentDiscount = ExtendedPrice() * 0.15M;
            return studentDiscount;
        }

    }
}