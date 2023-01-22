using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceOOP
{
    internal class Shirts: Product
    {
        public static int RemainingNumberOfProduct = 50;
        public static string Name = "Shirts";
        public static string Color = "White";
        public static int Price = 350;

        public Shirts()
        {
            base.Name_ = Name;
            base.Color_ = Color;
            base.Price_ = Price;
        }


    }
}
