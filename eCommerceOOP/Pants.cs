using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceOOP
{
    internal class Pants : Product
    {
        public static int RemainingNumberOfProduct = 50;
        public static string Name = "Pants";
        public static string Color = "Black";
        public static int Price = 350;

        public Pants()
        {
            base.Name_= Name;
            base.Color_= Color;
            base.Price_= Price;
        }


    }
}
