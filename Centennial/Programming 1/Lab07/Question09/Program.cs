using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question09
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            int min = 1000000;

            do
            {
                min+=1;
                if (min % 3 == 0)
                {
                    sum += min;
                }
            } while (min < 2000000);
            Console.WriteLine($"{sum}");
        }
    }
}
