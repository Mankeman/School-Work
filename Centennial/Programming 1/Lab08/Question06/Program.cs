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
            double fahrenStart;
            double fahrenEnd;
            double celcius;
            double increment;
            int formulaPartOne = 32;
            double formulaPartTwo = 1.8;

            Console.WriteLine("Fahrenheit start?");
            fahrenStart = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Fahrenheit end?");
            fahrenEnd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Increment?");
            increment = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Fahrenheit\t\tCelcius");
            Console.WriteLine("----------\t\t-------");
            do
            {
                celcius = ((fahrenStart - formulaPartOne) / formulaPartTwo);
                Console.WriteLine($"{fahrenStart}\t\t\t{celcius:f2}");
                fahrenStart+=increment;
            } while (fahrenStart < fahrenEnd+1);
        }
    }
}
