using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            double celcius =0;
            double fahren;

            do
            {
                fahren = (celcius * 9 / 5) + 32;
                celcius += 10;
                Console.WriteLine($"{fahren}");
            } while (celcius <= 100);
        }
    }
}
