using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doctor_and_scholarship
{
   
    class Customer
    {
        int CustomerId;
        string Name;
        int age;
        string Phone;
        string City;

        public static void Main(string[] args)
        {
            Console.WriteLine("**********Customer Details**********");
            Customer c1 = new Customer(100, "raajesh", 22, "123423447", "Tiruvarur");
            DisplayCustomer(c1);
            Customer c2 = new Customer();
            GC.Collect();



        }

        public Customer()
        {

        }
        public Customer(int CustomerId, string Name, int age, string Phone, string City)
        {
            this.CustomerId = CustomerId;
            this.Name = Name;
            this.age = age;
            this.Phone = Phone;
            this.City = City;
        }
        public static void DisplayCustomer(Customer customer)
        {
            Console.WriteLine("Customer Id: " + customer.CustomerId);
            Console.WriteLine("Customer Name: " + customer.Name);
            Console.WriteLine("Customer age: " + customer.age);
            Console.WriteLine("Phone Number: " + customer.Phone);
            Console.WriteLine("City: " + customer.City);
        }

        ~Customer()
        {
            Console.WriteLine("Thank You...!!! Destructor Called");
            Console.ReadLine();
        }
    }
}