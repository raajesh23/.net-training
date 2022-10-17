using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Assignment6
{
    public class Program3
    {
        int [] id = new int[10];
        
        string [] name = new string[10];
        float [] amount = new float[10];
        static void Main(string[] args)
        {
            Program3 p = new Program3();
           
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine("Enter product Id for product {0}: ",i+1);
                p.id[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter product Name for product {0}: ", i+1);
                p.name [i]= Console.ReadLine();
                Console.WriteLine("Enter product Price for product {0}: ", i+1);
                p.amount [i] = Convert.ToSingle(Console.ReadLine());
            }
           
                List<Products> products = new List<Products>
            {
               
            
                new Products { ProductId = p.id[0], Product_Name = p.name[0], Price = p.amount[0] },  
                new Products { ProductId = p.id[1], Product_Name = p.name[1], Price = p.amount[1] },
                new Products { ProductId = p.id[2], Product_Name = p.name[2], Price = p.amount[2]},
                new Products { ProductId = p.id[3], Product_Name = p.name[3], Price = p.amount[3] },
                new Products { ProductId = p.id[4], Product_Name = p.name[4], Price = p.amount[4] },
                new Products { ProductId = p.id[5], Product_Name = p.name[5], Price = p.amount[5] },
                new Products { ProductId = p.id[6], Product_Name = p.name[6], Price = p.amount[6] },
                new Products { ProductId = p.id[7], Product_Name = p.name[7], Price = p.amount[7] },
                new Products { ProductId = p.id[8], Product_Name = p.name[8], Price = p.amount[8] },
                new Products { ProductId = p.id[9], Product_Name = p.name[9], Price = p.amount[9] },
              
              
                    
                  
            };
            Display(products); 
            Console.Read();
        }
        public  static void Display(List<Products> products) 
        {
            Console.WriteLine();
            var val = products.OrderBy(a => a.Price).ToList();
            foreach (var p in val)
            {
                Console.WriteLine("name: {0}     id: {1}     price: {2} ", p.Product_Name,p.ProductId,p.Price);
            }
        } 
    }

    public class Products
    {
        

        public int ProductId { get; set; }
        public string Product_Name { get; set; }
        public float Price { get; set; }
        

    }
}
