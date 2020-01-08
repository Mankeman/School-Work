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
            /*Angelo Goncalves
             * 300-887-613
             * 
             * 
             1.(25 points) Prompt a user to input minimum and maximum number.  
             * a. A minimum number must be a positive number. Keep asking a user until the positive number is provided. 
             * b. A maximum number must be greater than the minimum number. Keep asking user until the correct number is provided. 
             * c. Generate a random number between provided minimum and maximum number. 
             * (for instance, if the user inputs 1 and 10 for minimum and maximum number, the number that can be generated is any number between 1 and 10 inclusive) 
             2. (40 points) Keep asking a user to guess the random number until the number is guest correctly. 
             *For each try that is not correct display a message indicating whether the user’s guess was too high, too low. 
             *If the number is correct, display the message that the number is correct and the number of trays the user made before correctly guessing the random number. 
             3. (20 points) On each try the player is criticized for making a “dumb” guess. For example, if the player guesses that the random number is 4 and is told that 
             *the guess is too low, and then the player subsequently makes a guess lower than 4, display a message that the user should have known not to make such a low guess.*/
                int randNumber;
                int min;
                int max;
                int randGuess;
                int count = 0;

                Random ranNumberGenerator = new Random();

                do
                {
                    Console.WriteLine("Please input minimum number.");
                    min = Convert.ToInt32(Console.ReadLine());
                } while (min < 0);
                do
                {
                    Console.WriteLine("Please input maximum number.");
                    max = Convert.ToInt32(Console.ReadLine());
                } while (max < min);

                randNumber = ranNumberGenerator.Next(min, max + 1);

                do
                {
                    Console.WriteLine("Please guess my random number.");
                    randGuess = Convert.ToInt32(Console.ReadLine());
                    count++;
                    if (randGuess < randNumber)
                    {
                        Console.WriteLine("Your guess is too low. Try again.");
                        if (randGuess >= min)
                        {
                            min = randGuess;
                        }
                        else
                        {
                            Console.WriteLine("You should have known not to guess such a small number.");
                        }
                    }
                    else
                    {
                        if (randGuess > randNumber)
                        {
                            Console.WriteLine("Your guess is too high. Try again.");
                            if (randGuess <= max)
                            {
                                max = randGuess;
                            }
                            else
                            {
                                Console.WriteLine("You should have known not to guess such a big number. Try again.");
                            }
                        }
                    }
                } while (randGuess != randNumber);
                Console.WriteLine($"Your guess is correct. Random Number:{randNumber}. Tries Count:{--count}.");
            }
        }
    }