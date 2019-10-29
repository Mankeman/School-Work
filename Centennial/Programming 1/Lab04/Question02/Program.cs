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
            double a = 5;
            double b = 2;
            double c = 4;
            double d = 5;

            Console.WriteLine($"Question 2a is {a == 5}");
            Console.WriteLine($"Question 2b is {b * d == c * a}");
            Console.WriteLine($"Question 2c is {b == d || a == c}");
            Console.WriteLine($"Question 2d is {a == d || c != b}");
            Console.WriteLine($"Question 2e is {a == d || c == b}");
            Console.WriteLine($"Question 2f is {a == d && c != b}");
            Console.WriteLine($"Question 2g is {d % b * c > 5 || c % b * d < 7}");

        }
    }
}
