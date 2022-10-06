using System;

namespace number_comparision
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("\n\n");
            Console.Write("Check whether two integers are equal or not:\n");
            Console.Write("-------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input 1st number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 2nd number: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
                Console.WriteLine("{0} and {1} are equal.\n", a, b);
            else
                Console.WriteLine("{0} and {1} are not equal.\n", a, b);
            Console.ReadLine();
        }
    }
}
