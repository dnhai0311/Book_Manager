using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Manager.Models
{
    public class BookSale
    {
        int intId;
        string strTitle;
        string strImage;
        int intAuthor;
        int intPublisher;
        int intQuantity;
        decimal decPrice;

        public BookSale()
        {
            intId = -1;
            strTitle = string.Empty;
            intQuantity = 0;
            decPrice = 0;
            strImage = string.Empty;
            intAuthor = -1;
            intPublisher = -1;
        }

        public int id
        {
            get { return intId; }
            set { intId = value; }
        }

        public string title
        {
            get { return strTitle; }
            set { strTitle = value; }
        }
        public string image
        {
            get { return strImage; }
            set { strImage = value; }
        }
        public int author
        {
            get { return intAuthor; }
            set { intAuthor = value; }
        }
        public int publisher
        {
            get { return intPublisher; }
            set { intPublisher = value; }
        }

        public int quantity
        {
            get { return intQuantity; }
            set { intQuantity = value; }
        }

        public decimal price
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

        public decimal TotalDiscount(bool discount, bool studentDiscount) {
            decimal totalDiscount = 0;
            if (discount)
            {
                totalDiscount += Discount();
            }
            if (studentDiscount)
            {
                totalDiscount += StudentDiscount();
            }
            return totalDiscount;
        }

        public decimal NextDue(bool discount, bool studentDiscount)
        {
            decimal decNextDue = ExtendedPrice() - TotalDiscount(discount,studentDiscount);
            return decNextDue;
        }

    }
}