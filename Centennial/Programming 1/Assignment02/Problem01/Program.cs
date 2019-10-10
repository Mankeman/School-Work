using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {    /* Angelo Goncalves
              * 300-887-613
              * SEC. 005 
              * Create a program that calculates and displays the number of rolls of wall-paper needed to cover a room. 
         The salesclerk will provide the length, width, and ceiling height of the room, in feet. 
         He or she will also provide the number of square feet a single roll will cover.
         (You may assume that the paper will fit the wall exactly and there is no wastage) */

            string userInput;
            double lengthR;
            double widthR;
            double heightR;
            double sqFtSingRoll;
            int quantityRoll;

            Console.WriteLine("Problem 1.\n");
            Console.WriteLine("What is the length of the room? (in Feet)");
            userInput = Console.ReadLine();
            lengthR = Convert.ToDouble(userInput);

            Console.WriteLine("What is the width of the room? (in Feet)");
            userInput = Console.ReadLine();
            widthR = Convert.ToDouble(userInput);

            Console.WriteLine("What is the height of the room? (in Feet)");
            userInput = Console.ReadLine();
            heightR = Convert.ToDouble(userInput);

            Console.WriteLine("How much square feet does a single roll cover?");
            userInput = Console.ReadLine();
            sqFtSingRoll = Convert.ToDouble(userInput);

            quantityRoll = (int)(((2 * (lengthR * heightR)) + (2 *(widthR * heightR))) / sqFtSingRoll);

            Console.WriteLine($"The total amount of rolls you need are {quantityRoll}.\n");

        }
    }
}
