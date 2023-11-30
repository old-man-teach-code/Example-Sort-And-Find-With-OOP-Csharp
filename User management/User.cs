using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    public class User
    {
        public string Username { get; set; }
        public int PhoneNumber { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }

        public User()
        {

        }
        public User(string name, int phone, int amount, int price)
        {
            Username = name;
            PhoneNumber = phone;
            Amount = amount;
            Price = price;
        }

        public void AddUser()
        {
            Console.WriteLine("Enter username: ");
            Username = Console.ReadLine();

            Console.WriteLine("Enter phone number: ");
            string phone = Console.ReadLine();
            PhoneNumber = int.Parse(phone);

            Console.WriteLine("Enter amount: ");
            string amount = Console.ReadLine();
            Amount = int.Parse(amount);

            Console.WriteLine("Enter price: ");
            string price = Console.ReadLine();
            Price = int.Parse(price);

        }
        public void Output()
        {
            Console.WriteLine($"Name: {Username} - Phone: {PhoneNumber}");
        }
        public void Delete()
        {

        }
    }
}
