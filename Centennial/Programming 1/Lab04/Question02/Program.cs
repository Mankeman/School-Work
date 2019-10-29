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

            Console.WriteLine($"Question 1a is {a == 5}");
            Console.WriteLine($"Question 1b is {b * d == c * a}");
            Console.WriteLine($"Question 1c is {b == d || a == c}");
            Console.WriteLine($"Question 1d is {a == d || c != b}");
            Console.WriteLine($"Question 1e is {a == d || c == b}");
            Console.WriteLine($"Question 1f is {a == d && c != b}");
            Console.WriteLine($"Question 1g is {d % b * c > 5 || c % b * d < 7}");

        }
    }
}
