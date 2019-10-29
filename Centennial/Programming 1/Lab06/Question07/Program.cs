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
            double a;
            double b;
            double c;
            double p;
            double d;
            double q;

            Console.WriteLine("What is the value of A?");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the value of B?");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the value for C?");
            c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Invalid Input for A.");
            }

            p = (-b / (2 * a));
            d = (b * b) - (4 * a * c);

            if (d >= 0)
            {
                q = ((Math.Sqrt(d)) / (2 * a));
                Console.WriteLine($"{p + q} is p+q, while {p - q} is p-q.");
            }
            else
            {
                q = ((Math.Sqrt(-d)) / (2 * a));
                Console.WriteLine($"{p + q} is p+qi, while {p - q} is p-qi.");
            }

        }
    }
}
