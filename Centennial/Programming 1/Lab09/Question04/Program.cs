﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question04
{
    class Program
    {
        static char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        static int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19 };
        static string[] poem = { "Mary", "had", "a", "little", "lamb" };
        static string[] obama = { "Barack", "Hussein", "Obama" };

        static void Main(string[] args)
        {
            for (int i = 0; i < primes.Length; i++)
            {
                Console.Write($"{primes[i]}, ");
            }
            Console.WriteLine();
            for (int i = 0; i < primes.Length; i++)
            {
                Console.Write($"{primes[i] * primes[0]}, ");
            }
        }
    }
}