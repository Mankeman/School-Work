using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question03
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            int count = 1;
            double total = 0;
            int avgTotal = 10;
            double average;

            do
            {
                Console.WriteLine($"What is number #{count}?");
                num = Convert.ToDouble(Console.ReadLine());
                total += num;
                count++;
                average = total / avgTotal;
            } while (count < 11);
            Console.WriteLine(average);
        }
    }
}
