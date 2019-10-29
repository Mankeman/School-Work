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
            double grade;

            Console.WriteLine("Grade?");
            grade = Convert.ToDouble(Console.ReadLine());

            if (grade <= 70)
            {
                Console.WriteLine($"Fail");
            }
            else
            {
                Console.WriteLine($"Pass");
            }
        }
    }
}
