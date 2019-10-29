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
            double iQScore;

            Console.WriteLine("Enter your IQ Score.");
            iQScore = Convert.ToDouble(Console.ReadLine());

            if (iQScore <= 0 || iQScore >= 200)
            {
                Console.WriteLine("ERROR: Invalid Input!");
            }
            else if (iQScore > 100)
            {
                Console.WriteLine("Above Average.");
            }
            else if (iQScore == 100)
            {
                Console.WriteLine("Average.");
            }
            else if (iQScore < 100)
            {
                Console.WriteLine("Below Average.");
            }
        }
    }
}
