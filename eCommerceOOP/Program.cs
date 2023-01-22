using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;

namespace eCommerceOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            interaction();
        }

        static void interaction()
        {
            List<Customer> Customers = new List<Customer>();



            Customer CurrentCustomer = null;
            string input;
            Console.WriteLine("Welcome to our eCommerceShop");
            while (true)
            {
                bool temp = false;
                Console.WriteLine("Please select one option: \n" +
                                  "1. Login \n" +
                                  "2. SignUp \n" +
                                  "3. Exit");
                input = Console.ReadLine();


                if (input == "1")
                {

                    Console.WriteLine("Please Enter Your Email");
                    string Email = Console.ReadLine();
                    Console.WriteLine("Please Enter Your Password");
                    string Password = Console.ReadLine();

                    foreach (var item in Customers)
                    {
                        if (item.Email == Email && item.Password == Password)
                            CurrentCustomer = (Customer)item;
                        temp = true;
                    }

                    if (temp)
                    {
                        while (true)
                        {
                            Console.WriteLine("Welcome to our Online Shopping Site.");
                            Console.WriteLine($"Your current balance: {CurrentCustomer.Balance}");
                            Console.WriteLine("Please select the action you want to do:");
                            Console.WriteLine("1. Load Balance\n" +
                                              "2. List Products\n" +
                                              "3. List the products in your cart\n" +
                                              "4. Buy what's in your cart\n" +
                                              "5. List the products I bought\n" +
                                              "6. Logout\n" +
                                              "7. Exit");
                            input = Console.ReadLine();

                            if (input == "1")
                            {
                                Console.WriteLine("Please enter the balance amount you want to load.");
                                input = Console.ReadLine();
                                CurrentCustomer.Balance = Convert.ToInt32(input);
                                Console.WriteLine("Your transaction has been successfully completed.");
                                continue;
                            }
                            else if (input == "2")
                            {
                                while (true)
                                {
                                    Console.WriteLine("Enter the number of the product you want to add to the cart.");
                                    Console.WriteLine($"1. Shoes: Color: {Shoes.Color}, Price: {Shoes.Price}, Remaining number of products: {Shoes.RemainingNumberOfProduct}");
                                    Console.WriteLine($"2. Shirts: Color: {Shirts.Color}, Price: {Shirts.Price}, Remaining number of products: {Shirts.RemainingNumberOfProduct}");
                                    Console.WriteLine($"3. Pants: Color: {Pants.Color}, Price: {Pants.Price}, Remaining number of products: {Pants.RemainingNumberOfProduct}");
                                    Console.WriteLine("4. Back");
                                    input = Console.ReadLine();

                                    if (input == "1")
                                    {
                                        Shoes shoes = new Shoes();
                                        CurrentCustomer.ShoppingCard.Add(shoes);
                                        Console.WriteLine("The product named shoes has been added to your cart.");
                                        continue;
                                    }
                                    else if (input == "2")
                                    {
                                        Shirts shirts = new Shirts();
                                        CurrentCustomer.ShoppingCard.Add(shirts);
                                        Console.WriteLine("The product named shirts has been added to your cart.");
                                        continue;
                                    }
                                    else if (input == "3")
                                    {
                                        Pants pants = new Pants();
                                        CurrentCustomer.ShoppingCard.Add(pants);
                                        Console.WriteLine("The product named pants has been added to your cart.");
                                        continue;
                                    }
                                    else if (input == "4")
                                    {

                                        Console.WriteLine("Returning to previous menu.");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You entered a wrong option.");
                                        continue;
                                    }
                                }

                            }
                            else if (input == "3")
                            {
                                int total_price = 0;

                                foreach (var item in CurrentCustomer.ShoppingCard)
                                {
                                    Console.WriteLine("Items in your cart");
                                    Console.WriteLine($"{item.Name_}:, Price: {item.Price_}");
                                    total_price += item.Price_;
                                }
                                Console.WriteLine("Total Price: " + total_price);
                                Console.WriteLine();
                                Console.WriteLine("----------------------------");
                                Console.WriteLine("----------------------------");
                                Console.WriteLine();
                                continue;
                            }

                            else if (input == "4")
                            {
                                int total_price = 0;
                                Console.WriteLine("Items in your cart");
                                foreach (var item in CurrentCustomer.ShoppingCard)
                                {
                                    Console.WriteLine($"{item.Name_}:, Price: {item.Price_}");
                                    total_price += item.Price_;
                                }

                                Console.WriteLine("Total Price: " + total_price);
                                if (total_price <= CurrentCustomer.Balance)
                                {

                                    foreach (var item in CurrentCustomer.ShoppingCard)
                                    {
                                        CurrentCustomer.PurchasedProducts.Add(item);

                                        if (item is Shoes)
                                        {
                                            Shoes.RemainingNumberOfProduct--;
                                        } else if (item is Shirts)
                                        {
                                            Shirts.RemainingNumberOfProduct--;
                                        } else if (item is Pants)
                                        {
                                            Pants.RemainingNumberOfProduct--;
                                        }

                                        CurrentCustomer.ShoppingCard.Remove(item);
                                    }
                                    CurrentCustomer.Balance -= total_price;
                                    Console.WriteLine("The purchase was made successfully.");
                                    Console.WriteLine($"Your remaining balance: {CurrentCustomer.Balance}");
                                    continue;
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient balance amount, please load balance.");
                                    continue;
                                }

                            }
                            else if (input == "5")
                            {
                                Console.WriteLine("List of products you have purchased: ");

                                foreach (var item in CurrentCustomer.PurchasedProducts)
                                {
                                    Console.WriteLine($"{item.Name_}:, Color: {item.Color_}, Price: {item.Price_}");
                                }
                                continue;

                            }

                            else if (input == "6")
                            {
                                Console.WriteLine("Returning to main menu: ");
                                break;
                            }
                            else if (input == "7")
                            {
                                Console.WriteLine("Exiting the system, thank you for choosing us.");
                                return;
                            }
                            else
                            {
                                Console.WriteLine("You entered a wrong option.");
                                continue;
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("You entered the wrong username and password, you are redirected to the main menu.");
                        continue;
                    }

                }
                else if (input == "2")
                {
                    Console.WriteLine("Please Enter Your FirstName");
                    string FirstName = Console.ReadLine();
                    Console.WriteLine("Please Enter Your LastName");
                    string LastName = Console.ReadLine();
                    Console.WriteLine("Please Enter Your Email");
                    string Email = Console.ReadLine();
                    Console.WriteLine("Please Enter Your Password");
                    string Password = Console.ReadLine();

                    Customer NewCustomer = new Customer(FirstName, LastName, Email, Password);
                    Customers.Add(NewCustomer);

                    Console.WriteLine("Your registration has been successfully completed, you are returning to the main menu.");
                    continue;

                }
                else if (input == "3")
                {
                    Console.WriteLine("You are leaving the system, we wish you a good day.");
                    break;
                }
                else
                {
                    Console.WriteLine("You entered an incorrect transaction, please try again.");
                    continue;
                }

            }
        }
    }
}