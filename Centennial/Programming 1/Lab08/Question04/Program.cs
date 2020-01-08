using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question04
{
    class Program
    {
        static void Main(string[] args)
        {
            int gallon=10;
            double liter;

            Console.WriteLine("Gallon\t\tLiter");
            Console.WriteLine("------\t\t-----");
            do
            {
                liter = (gallon * 3.785);
                Console.WriteLine($"{gallon}\t\t{liter}");
                gallon++;
            } while (gallon < 21);
        }
    }
}
