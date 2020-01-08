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
            int num = 2;
            int increment = 2;
            int max = 20;


            Console.WriteLine("Number\t\tSquare Root\t\tCube Root");
            Console.WriteLine("------\t\t-----------\t\t---------");
            do
            {
                Console.WriteLine($"{num}\t\t{num*num}\t\t\t{num*num*num}");
                num+=increment;
            } while (num <= max);
        }
    }
}
