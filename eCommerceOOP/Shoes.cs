using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace eCommerceOOP
{
    internal class Shoes: Product
    {
        public static int RemainingNumberOfProduct = 50;
        public static string Name = "Shoes";
        public static string Color = "Black";
        public static int Price = 500;

        public Shoes()
        {
            base.Name_ = Name;
            base.Color_ = Color;
            base.Price_ = Price;
        }
    }
}
