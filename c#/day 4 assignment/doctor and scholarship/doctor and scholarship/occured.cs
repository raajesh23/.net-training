using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doctor_and_scholarship
{
    class occured

    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter a String value ");
            string value = Console.ReadLine();
            value = value.ToLower();
            Console.WriteLine("Enter a Char value to check the occurance ");
            char input = Convert.ToChar(Console.ReadLine());
            int count = 0;
            Occur(value, input, count);
            Console.ReadLine();
        }
        public static void Occur(string value, char input, int count)
        {



            for (int j = 0; j < value.Length; j++) //4
            {
                if (value[j] == input)
                {
                    count++; 
                }
            }
            if (count > 0)
            {
                Console.WriteLine("the given character {0} is occured for {1} times", input, count);
            }
            else
            {
                Console.WriteLine("the given character is not repeating");
            }
        }
    }
}
