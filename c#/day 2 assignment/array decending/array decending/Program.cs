using System;

namespace array_decending
{
    class Program
    {
        static void Main(string[] args)
        {
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 9; j++)
                {
                    if (a[j] < a[j + 1])

                    {
                        int temp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("Descending order:");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(a[i] + "");
            }
            Console.ReadKey();
        }
    }
}
