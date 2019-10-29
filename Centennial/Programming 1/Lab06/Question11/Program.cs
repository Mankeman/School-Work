using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question11
{
    class Program
    {
        static void Main(string[] args)
        {
            double payRate;

            Console.WriteLine("What is your hourly payrate?");
            payRate = Convert.ToDouble(Console.ReadLine());

            if (payRate < 5.65 && payRate >49.99)
            {
                Console.WriteLine("ERROR: INVALID AMOUNT.");
            }
        }
    }
}
