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
            string prov;
            double provTax;
            double itemCost;

            Console.WriteLine("2 letter code for your province?");
            prov = Convert.ToString(Console.ReadLine());
            prov = prov.ToUpper();

            Console.WriteLine("Cost of item?");
            itemCost = Convert.ToDouble(Console.ReadLine());

            if (prov == "ON")
            {
                provTax = 1.14;
                Console.WriteLine($"The tax on the item is {(provTax * itemCost) - itemCost}");
            }
            else if (prov == "PQ")
            {
                provTax = 1.13;
                Console.WriteLine($"The tax on the item is {(provTax * itemCost) - itemCost}");
            }
            else
            {
                Console.WriteLine($"There is no tax on the item.");
            }
        }
    }
}
