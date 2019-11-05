using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question07
{
    class Program
    {
        static void Main(string[] args)
        {
            double number;
            double totalSum = 0;
            int max = 100;
            int counter = 1;
            do
            {
                Console.WriteLine("What number will you add?");
                number = Convert.ToDouble(Console.ReadLine());
                totalSum += number;
                if (totalSum > max)
                {
                    Console.WriteLine($"{totalSum}");
                    counter++;
                }
            } while (counter < 2);
        }
    }
}
