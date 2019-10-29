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
            double payRate;
            double hours;
            double grossPay;
            double netPay;
            double withHoldTax;

            Console.WriteLine("What's your hourly pay rate?");
            payRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many hours did you work?");
            hours = Convert.ToDouble(Console.ReadLine());

            grossPay = hours * payRate;
            if (grossPay <= 300)
            {
                withHoldTax = 0.10;
            }
            else
            {
                withHoldTax = 0.12;
            }
            netPay = (grossPay * (1.0 - withHoldTax));
            Console.WriteLine($"Your net pay is {netPay:c}.");
        }
    }
}
