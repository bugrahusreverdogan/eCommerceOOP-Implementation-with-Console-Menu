using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceOOP
{
    internal class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }

        public List<Product> ShoppingCard = new List<Product>();
        public List<Product> PurchasedProducts = new List<Product>();



        public Customer(string FirstName, string LastName, string Email, string Password) 
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Password = Password;
            this.Balance = 0;
        }
    }
    
}
