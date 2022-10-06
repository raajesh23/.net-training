using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doctor_and_scholarship
{
    class sales

    {
        int SalesNo;
        int ProductNo;
        float Price;
        string DateOfSale;
        int Qty;
        float TotalAmount;

        static void Main(string[] args)
        {
            sales s = new sales(41, 2613, 1890.56f, "28/12/2021", 8);
            s.Sales(s.Qty, s.Price);
            s.ShowData();
            Console.Read();
        }
        public sales(int SalesNo, int ProductNo, float Price, string DateOfSale, int Qty)
        {
            this.SalesNo = SalesNo;
            this.ProductNo = ProductNo;
            this.Price = Price;
            this.DateOfSale = DateOfSale;
            this.Qty = Qty;
        }
        public float Sales(int Qty, float Price)
        {
            TotalAmount = Qty * Price;
            return TotalAmount;
        }
        public void ShowData()
        {
            Console.WriteLine("**************SALES DETAILS*************");
            Console.WriteLine("Sales Number: " + SalesNo);
            Console.WriteLine("Product Number: " + ProductNo);
            Console.WriteLine("Price : " + Price);
            Console.WriteLine("Date of Sale: " + DateOfSale);
            Console.WriteLine("Quantity: " + Qty);
            Console.WriteLine("Total Amount: " + TotalAmount);
        }
    }
}
