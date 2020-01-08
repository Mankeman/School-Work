using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question02
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            double total=0;
            int count = 1;

            do
            {
                Console.WriteLine($"What is number #{count}?");
                num = Convert.ToDouble(Console.ReadLine());
                count++;
                total +=num;
            } while (count < 9);
            Console.WriteLine($"{total}");
        }
    }
}
