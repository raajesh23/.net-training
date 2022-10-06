using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doctor_and_scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
        public static void Display()
        {
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("First Name " + firstName.ToUpper());

            Console.WriteLine("Last Name " + lastName.ToUpper());
        }

    }
}
