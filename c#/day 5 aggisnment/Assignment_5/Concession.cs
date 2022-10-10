using ClassLibrary2;
using System;


namespace Assignment_5
{
    class Concession
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            int age=Convert.ToInt32(Console.ReadLine());
            Concession concession = new Concession();      //user defined{ USING DERECTIVE REFERENCE}.
             concession.CalculateConcession(age); 
            Console.ReadLine();

        }
    }
}
