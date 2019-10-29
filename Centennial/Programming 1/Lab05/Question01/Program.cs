using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question01
{
    class Program
    {
        static void Main(string[] args)
        {
            double payRate;

            Console.WriteLine("What is your hourly rate?");
            payRate = Convert.ToDouble(Console.ReadLine());

            if (payRate < 7.50)
            {
                Console.WriteLine("Error: Incorrect Value.");
            }
        }
    }
}
