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

            int[] number = { 5, 8, 1, 4, 11 };
            Array.Sort(number);

            for (int i = 0; i < number.Length; i++)
            {
                Console.Write($"{number[i]}, ");
            }
            Array.Reverse(number);
            Console.WriteLine();
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write($"{number[i]}, ");
            }
        }
    }
}
