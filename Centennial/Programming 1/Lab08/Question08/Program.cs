using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question08
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            int decrement = 1;
            int max = 1;


            Console.WriteLine("Number\t\tSquare Root\t\tCube Root");
            Console.WriteLine("------\t\t-----------\t\t---------");
            do
            {
                Console.WriteLine($"{num}\t\t{num * num}\t\t\t{num * num * num}");
                num -= decrement;
            } while (num >= max);
        }
    }
}
