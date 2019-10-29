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
            double firstDig;
            double secondDig;
            string sign;

            Console.WriteLine("Type in the first number.");
            firstDig = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type in the second number.");
            secondDig = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the operation you want to do? (If addition = A, subtraction = S, Multiplication = M, Division = D)");
            sign = Convert.ToString(Console.ReadLine());
            sign = sign.ToUpper();

            if(sign == "A")
            {
                Console.WriteLine($"{firstDig} + {secondDig} = {firstDig + secondDig}");
            }
            if (sign == "S")
            {
                Console.WriteLine($"{firstDig} - {secondDig} = {firstDig - secondDig}");
            }
            if (sign == "D")
            {
                Console.WriteLine($"{firstDig} / {secondDig} = {firstDig / secondDig}");
            }
            if (sign == "M")
            {
                Console.WriteLine($"{firstDig} * {secondDig} = {firstDig * secondDig}");
            }

            /*switch (sign)
            {
                case A:
                    Console.WriteLine($"{firstDig} + {secondDig} = {firstDig + secondDig}");
                    break;
                case D:
                    Console.WriteLine($"{firstDig} + {secondDig} = {firstDig + secondDig}");
                    break;
                case M:
                    Console.WriteLine($"{firstDig} + {secondDig} = {firstDig + secondDig}");
                    break;
                case S:
                    Console.WriteLine($"{firstDig} + {secondDig} = {firstDig + secondDig}");
                    break;

            }*/
        }
    }
}
