using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopTries
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Min = -10;
            const int Max = 20;
            const int Max_tries = 5;
            int userInput=0;
            int counter;

            for(counter = 0; counter < Max_tries; counter++)
            {
                Console.WriteLine($"Try #{counter + 1}: Please input a number between {Min} and {Max}.");
                userInput = Convert.ToInt32(Console.ReadLine());

                if(userInput >= Min && userInput <= Max)
                {
                    break;
                }
            }
            //if (userInput >= Min && userInput <= Max)
            if(counter != Max_tries)
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
