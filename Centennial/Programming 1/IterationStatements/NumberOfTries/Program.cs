using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfTries
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Min = 10;
            const int Max = 20;
            const int Max_tries = 5;
            int userInput;
            int counter = 0;

            do
            {
                counter++;
                Console.WriteLine($"Try #{counter}: Please input a number between {Min} and {Max}.");
                userInput = Convert.ToInt32(Console.ReadLine());

            } while ((userInput < Min || userInput > Max) && counter < Max_tries);
            //while (!(userInput >= Min && userInput <= Max));

            if (userInput >= Min && userInput <= Max)
            {
                Console.WriteLine($"You input {userInput}.");
            }
            else
            {
                Console.WriteLine("Sorry, you did not input the right value");
            }
        }
    }
}
