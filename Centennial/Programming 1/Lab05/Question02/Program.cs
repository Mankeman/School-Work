using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question02
{
    class Program
    {
        static void Main(string[] args)
        {
            double payRate;

            Console.WriteLine("What is your hourly rate?");
            payRate = Convert.ToDouble(Console.ReadLine());

            if (payRate < 7.50 || payRate > 49.99)
            {
                Console.WriteLine("Error: Incorrect Value.");
            }
            else
            {
                Console.WriteLine("The rate is okay.");
            }
        }
    }
}
