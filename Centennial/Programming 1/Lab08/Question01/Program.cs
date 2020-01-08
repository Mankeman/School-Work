using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            do
            {
                num+=2;
                Console.WriteLine(num);
            } while (num < 10);
        }
    }
}
