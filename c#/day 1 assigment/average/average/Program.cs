using System;

namespace average
{
    class Program
    {
        static void Main(string[] args)
        { }
            public class Ex4
        {
            int Csharp;
            int html;
            int sql;
            int total;

            public void avg()
            {
                for (int i = 1; i <= 5; i++)
                {

                    for (int j = 0; j < i; j++)
                    {
                        Console.WriteLine("Enter Csharp marks for Student " + i);
                        Csharp = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter html marks for Student " + i);
                        html = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter sql marks for Student" + i);
                        sql = Convert.ToInt32(Console.ReadLine());
                        total = Csharp + html + sql;
                        total = total / 3;

                        if (total < 50)
                        {
                            Console.WriteLine("total  mark for student " + i + " is" + total);
                            Console.WriteLine("student {0} is Failed", i);
                        }
                        else
                        {
                            Console.WriteLine("total  mark for student " + i + " is" + total);
                            Console.WriteLine("student {0} is passed", i);
                        }
                    
                    }

                }
            }
        }
    }
    }
