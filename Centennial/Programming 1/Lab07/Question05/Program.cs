﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question05
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            do
            {
                if (number % 7 == 0)
                {
                    Console.WriteLine($"*{number}");
                }
                else
                {
                    Console.WriteLine(number);
                }
                number++;

            } while (number < 41);
        }
    }
}
