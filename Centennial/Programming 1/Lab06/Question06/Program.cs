using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question06
{
    class Program
    {
        static void Main(string[] args)
        {
            double prem = 1.20;
            double disc = 0.05;
            int textB = 125;
            int softCov;
            int hardCov;
            double total;

            Console.WriteLine("How many hardcover books are you buying?");
            hardCov = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many softcover books are you buying?");
            softCov = Convert.ToInt32(Console.ReadLine());

            if (hardCov + softCov >= 4)
            {
                total = (((hardCov * prem) + softCov) * textB) - disc;
                Console.WriteLine($"The total before tax will be {total:c}.");
            }
            if (hardCov + softCov < 4)
            {
                total = (((hardCov * prem) + softCov) * textB);
                Console.WriteLine($"The total before tax will be {total:c}.");
            }
        }
    }
}
