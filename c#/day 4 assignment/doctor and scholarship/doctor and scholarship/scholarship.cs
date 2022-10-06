using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doctor_and_scholarship
{
    class scholarship
    {
        int TotalMark;
        float Fees;
        float ScholorshipAmount;

        static void Main(string[] args)
        {
            
            scholarship s = new scholarship();
            Console.WriteLine("Enter Total Marks");
            s.TotalMark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Fees amount");
            s.Fees = Convert.ToSingle(Console.ReadLine());
            s.ScholorshipAmount = s.Merit(s.TotalMark, s.Fees);
            Console.WriteLine("Scholorship Amount is " + s.ScholorshipAmount);
            Console.Read();

        }
        public float Merit(int TotalMarks, float Fees)
        {
           
            if (TotalMarks >= 70 && TotalMarks <= 80)
            {
                return (20.0f / 100) * Fees;
            }
            else if (TotalMarks > 80 && TotalMarks <= 90)
            {
                return (30.0f / 100) * Fees;
            }
            else if (TotalMarks > 90)
            {
                return (50.0f / 100) * Fees;
            }
            return 0;
        }

    }
}
