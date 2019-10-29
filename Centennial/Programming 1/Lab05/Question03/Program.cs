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
            double intRate;
            double years;

            Console.WriteLine("How many years was your money left in the bank?");
            years = Convert.ToDouble(Console.ReadLine());

            if (years >= 5)
            {
                intRate = 7.5;
                Console.WriteLine($"The interest rate the bank can give you is {intRate}%.");
            }
            else
            {
                intRate = 5.4;
                Console.WriteLine($"The interest rate the bank can give you is {intRate}%.");
            }
        }
    }
}
