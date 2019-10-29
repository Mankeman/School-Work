using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MIN = 10;
            const int MAX = 20;
            int userInput;

            do
            {
                Console.WriteLine($"Please input a number between {MIN} and {MAX}.");
                userInput = Convert.ToInt32(Console.ReadLine());

            }while (userInput < MIN || userInput > MAX);
            //while (!(userInput >= MIN && userInput <= MAX));

            Console.WriteLine($"You input {userInput}.");
        }
    }
}
