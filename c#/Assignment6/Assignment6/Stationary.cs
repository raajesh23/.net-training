using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment6
{
    class Stationary
    {
        static void Main(string[] args)
        {
            string[] products = new string[5];
            GetValues(products); 
            Console.Read();
        }
        public static void GetValues(string[] products)
        {
           
            for (int i = 0; i < products.Length; i++) 
            {
                Console.WriteLine("Enter the item {0}: ", i+1);
                products[i] = Console.ReadLine();
            }
            List<string> items = new List<string>();
            for (int i = 0; i < products.Length; i++) 
            {
                items.Add(products[i]);
            }

            Console.WriteLine("***************Purchased Item Bill****************");
             void Display() 
            {
                int count = 1;
                foreach (var val in items) 
                {
                    
                    Console.WriteLine("Purchased Item {0}: {1} ",count,val); 
                    count++;
                }
               
             }
            Display(); 
        }
      
    }
}
