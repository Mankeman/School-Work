using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question08
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            double sqFeet;
            int fee;
            double total;

            Console.WriteLine("What is the length of the lawn?");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the width of the lawn?");
            width = Convert.ToDouble(Console.ReadLine());

            sqFeet = length * width;
            if (sqFeet < 400)
            {
                fee = 25;
                total = fee * 20;
                Console.WriteLine($"The weekly fee is {fee:c}. The total for the 20 week job will be {total:c}.");
            }
            else if (sqFeet > 400 && sqFeet < 600)
            {
                fee = 35;
                total = fee * 20;
                Console.WriteLine($"The weekly fee is {fee:c}. The total for the 20 week job will be {total:c}.");
            }
            else
            {
                fee = 50;
                total = fee * 20;
                Console.WriteLine($"The weekly fee is {fee:c}. The total for the 20 week job will be {total:c}.");
            }
        }
    }
}
