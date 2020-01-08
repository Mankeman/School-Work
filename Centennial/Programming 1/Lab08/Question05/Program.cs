using System;
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
            int feet = 3;
            double meter;

            Console.WriteLine("Feet\t\tMeter");
            Console.WriteLine("------\t\t-----");
            do
            {
                meter = (feet * 3.28);
                Console.WriteLine($"{feet}\t\t{meter}");
                feet+=3;
            } while (feet < 31);
        }
    }
}
