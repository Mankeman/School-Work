using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question05
{
    class Program
    {
        static char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        static int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19 };
        static string[] poem = { "Mary", "had", "a", "little", "lamb" };
        static string[] obama = { "Barack", "Hussein", "Obama" };

        static void Main(string[] args)
        {
            int array;
            char arrayChar;
            int num = 32;
            for (int i = 0; i < vowels.Length; i++)
            {
                Console.Write($"{vowels[i]}, ");
            }
            Console.WriteLine();
            for (int j = 0; j < vowels.Length; j++)
            {
                array = Convert.ToInt32(vowels[j] - num);
                arrayChar = Convert.ToChar(array);
                Console.Write($"{arrayChar}, ");

            }
        }
    }
}
