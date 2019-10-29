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
            double firstNum;
            double secondNum;
            string operation;

            Console.WriteLine("Operation?");
            operation = Convert.ToString(Console.ReadLine());

            Console.WriteLine("First Number?");
            firstNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Second Number?");
            secondNum = Convert.ToDouble(Console.ReadLine());

            if (operation == "+")
            {
                Console.WriteLine($"{firstNum} + {secondNum} = {firstNum + secondNum}");
            }
            else
            {
                Console.WriteLine($"{firstNum} - {secondNum} = {firstNum - secondNum}");
            }
        }
    }
}
