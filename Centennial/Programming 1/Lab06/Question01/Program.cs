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
            int userInput;

            Console.WriteLine("Please choose an Option from the menu.");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("0");
            userInput = Convert.ToInt32(Console.ReadLine());

           switch (userInput)
            {
                case 1:
                    Console.WriteLine("Calculate Area.");
                    break;
                case 2:
                    Console.WriteLine("Calculate Volume.");
                    break;
                case 3:
                    Console.WriteLine("Calculate Surface Area.");
                    break;
                case 0:
                    Console.WriteLine("Exit the program.");
                    break;
                default:
                    Console.WriteLine("ERROR: Invalid choice.");
                    break;
            }

        }
    }
}
