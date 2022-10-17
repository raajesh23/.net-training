using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No of matches: ");
            int matches = Convert.ToInt32(Console.ReadLine());
            Cricket.PointsCalculation(matches);
            Console.Read();
        }
    }
    class Cricket
    {
       
        Cricket c = new Cricket();
        public static List<int> PointsCalculation(int no_of_matches)
        {
            int avg =0;
            int sum =0;
            List<int> scores = new List<int>();
            for (int i = 0; i < no_of_matches; i++)
            {
                Console.WriteLine("Enter the score for match {0}: ",i+1);
                int marks = Convert.ToInt32(Console.ReadLine());
                scores.Add(marks);
               
            }

           foreach(int s in scores)
            {
                sum += s;
            }

           void CalcAvg(int Total,int matches)
            {
                Console.WriteLine("The Total score for all the matches are: " + sum);
                avg = sum / no_of_matches;
                Console.WriteLine("The avg score of this team is: " + avg);
            }
            CalcAvg(sum,no_of_matches);
            return scores.ToList();
        }
       
    }
}
