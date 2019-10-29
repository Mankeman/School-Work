using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question03
{
    class Program
    {
        static void Main(string[] args)
        {
            string provCode;

            Console.WriteLine("Province code?");
            provCode = Convert.ToString(Console.ReadLine());

            provCode = provCode.ToUpper();

            if (provCode == "ON")
            {
                Console.WriteLine($"You live in Ontario.");
            }
            else
            {
                Console.WriteLine($"You do not live in Ontario");
            }


        }
    }
}
