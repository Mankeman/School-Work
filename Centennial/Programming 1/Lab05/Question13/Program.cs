using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question13
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            int count = 1;

            Console.WriteLine("Let's play Rock Paper Scissors. Choose r for rock, p for paper and s for scissors.");
            choice = Convert.ToString(Console.ReadLine());
            do
            {
                count++;
                Random ranHandGenerator = new Random();
                int hand;
                hand = ranHandGenerator.Next(1,4);
                // 1 = rock, 2 = paper & 3 = scissors.
                if ((choice == "r" && hand == 1) || (choice == "p" && hand == 2) || (choice == "s" && hand == 3))
                {
                    Console.WriteLine("It's a tie, try again.");
                    count = 2;
                    choice = Convert.ToString(Console.ReadLine());
                }
                else if ((choice == "r" && hand == 2) || (choice == "p" && hand == 3) || (choice == "s" && hand == 1))
                {
                    Console.WriteLine("I win! Try again.");
                    count = 2;
                    choice = Convert.ToString(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("You win.");
                    count = 1;
                }
            } while(count == 2);
        }
    }
}
