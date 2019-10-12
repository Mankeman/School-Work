using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Number?");
            number = Convert.ToInt32(Console.ReadLine());

            /*if(number == 1)
            {
                Console.WriteLine("One");
            }
            else if(number == 2)
            {
                Console.WriteLine("Two");
            }
            else if (number == 4)
            {
                Console.WriteLine("Four");
            }
            else if (number == 5)
            {
                Console.WriteLine("Five");
            }
            else
            {
                Console.WriteLine("I don't know");
            }*/
            switch (number)
            {
                case 1: Console.WriteLine("One");
                    break;
                case 2: Console.WriteLine("Two");
                    break;
                case 4: Console.WriteLine("Four");
                    break;
                case 5: Console.WriteLine("Five");
                    break;
                case int x when x < 10:
                    Console.WriteLine(x);
                    break;
                default:
                    Console.WriteLine("I don't know");
                    break;
            }
        }
    }
}
