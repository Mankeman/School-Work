﻿using System;
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
            double a = 5;
            double b = 2;
            double c = 4;

            Console.WriteLine($"Question 1a is {a % b * c == c % b * a}");
            Console.WriteLine($"Question 1b is {b.a % b * c > c % b * a}");
            Console.WriteLine($"Question 1c is {b % c * a >= a % c * b}");
            Console.WriteLine($"Question 1d is {b % c * a != a % c * b}");

        }
    }
}