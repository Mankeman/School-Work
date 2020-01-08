using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question12a
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int rows;
            int count = 0;

            Console.WriteLine("How many rows?");
            rows = Convert.ToInt32(Console.ReadLine());

            do
            {
                a++;
                Console.Write($"*");
                if (a % 8 == 0)
                {
                    Console.WriteLine();
                    count++;
                }
            } while (count <rows);
        }
    }
}
