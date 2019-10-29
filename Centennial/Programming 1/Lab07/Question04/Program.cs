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
            int number = 1;
            do
            {
                if (number %5==0)
                {
                    Console.WriteLine($"{number}*");
                }
                else
                {
                    Console.WriteLine(number);
                }
                number++;
                
            } while (number < 21);
        }
    }
}
