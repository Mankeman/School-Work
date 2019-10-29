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
            double a = 5;
            double b = 2;
            double c = 4;
            double d = 6;
            double e = 3;

            Console.WriteLine($"Question 1a is {a > b}");
            Console.WriteLine($"Question 1b is {a != b}");
            Console.WriteLine($"Question 1c is {d % b == c % b}");
            Console.WriteLine($"Question 1d is {a * c != d * b}");
            Console.WriteLine($"Question 1e is {d * b == c * e}");
            Console.WriteLine($"Question 1f is {a * b}");
            Console.WriteLine($"Question 1g is {a % b * c}");
            Console.WriteLine($"Question 1h is {c % b * a}");
            Console.WriteLine($"Question 1i is {b % c * a}");
            Console.WriteLine($"Question 1j is {true || false}");
            Console.WriteLine($"Question 1k is {7 > 3 && 5 < 2}");
            Console.WriteLine($"Question 1l is {5 * 4 < 20 || false}");
            Console.WriteLine($"Question 1m is {2 + 3 > 1 * 4 && 5 / 5 == 1}");

        }
    }
}
