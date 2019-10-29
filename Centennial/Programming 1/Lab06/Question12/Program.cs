using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question12
{
    class Program
    {
        static void Main(string[] args)
        {
            double payRate;
            const double min = 5.65;
            const double max = 49.99;
            const int maxTries = 3;
            int counter = 0;
            int exist;

            do
            {
                counter++;
                exist = 0;
                Console.WriteLine($"Try #{counter}: What is your hourly payrate?");
                payRate = Convert.ToDouble(Console.ReadLine());
                if ((payRate < min || payRate > max) && counter < maxTries)
                {
                    Console.WriteLine("ERROR: INVALID AMOUNT.");
                    exist = 1;
                }
            }
            while (exist != 0);

                Console.WriteLine($"With a pay rate of {payRate:c}, you make {payRate * 40:c}.");
        }
    }
}
