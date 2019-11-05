using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question06
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 20;
            do
            {
                if (number % 3 == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(number);
                }
                number++;

            } while (number < 61);
        }
    }
}
