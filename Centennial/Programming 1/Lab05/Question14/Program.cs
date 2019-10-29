using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question14
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerNum1;
            int playerNum2;
            int playerNum3;
            int botNum1;
            int botNum2;
            int botNum3;
            int points = 0;

            Console.WriteLine("What's your first number choice?");
            playerNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's your second number choice?");
            playerNum2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's your third number choice?");
            playerNum3 = Convert.ToInt32(Console.ReadLine());

            Random randomNumberGen1 = new Random();
            botNum1 = randomNumberGen1.Next(1, 5);
            botNum2 = randomNumberGen1.Next(1, 5);
            botNum3 = randomNumberGen1.Next(1, 5);

            switch (playerNum1)
            {
                default:
                    if (playerNum1 == botNum1)
                    {
                        points += 5;
                    }
                    else if (playerNum1 == botNum2 || playerNum1 == botNum3)
                    {
                        points += 2;
                    }
                    else
                    {
                        points += 0;
                    }
                    break;
            }
            switch (playerNum2)
            {
                default:
                    if (playerNum2 == botNum2)
                    {
                        points += 5;
                    }
                    else if (playerNum2 == botNum1 || playerNum2 == botNum3)
                    {
                        points += 2;
                    }
                    else
                    {
                        points += 0;
                    }
                    break;
            }
            switch (playerNum3)
            {
                default:
                    if (playerNum3 == botNum3)
                    {
                        points += 5;
                    }
                    else if (playerNum3 == botNum1 || playerNum3 == botNum2)
                    {
                        points += 2;
                    }
                    else
                    {
                        points += 0;
                    }
                    break;
            }
            Console.WriteLine($"{points}");
            Console.WriteLine($"Your numbers were {playerNum1}, {playerNum2} and {playerNum3} The numbers of the lottery were {botNum1}, {botNum2} and {botNum3}.");
            if (points == 15)
            {
                Console.WriteLine($"Congratulations! You have won {10000:c}.");
            }
            else if (points == 6 || points == 9 || points == 12)
            {
                Console.WriteLine($"Congratulations! You have won {1000:c}.");
            }
            else if (points == 4 || points == 7 || points == 10)
            {
                Console.WriteLine($"Congratulations! You have won {100:c}.");
            }
            else if (points == 2 || points == 5 ||)
            {
                Console.WriteLine($"Congratulations! You have won {10:c}.");
            }
            else if (points == 0)
            {
                Console.WriteLine($"Sorry. No numbers matched. No money gained.");
            }
        }
    }
}
