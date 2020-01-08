using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Angelo Goncalves
             * 300-887-613
             * 
             * Create a game similar to Hangman named GuessAWord in which a player guesses letters to try to replicate a hidden word. 
             * Store at least eight words in an array, and randomly select one to be the hidden word. 
             * Initially, display the hidden word using asterisks to represent each letter. 
             * Allow the user to guess letters to replace the asterisks in the hidden word until the user completes the entire word. 
             * If the user guesses a letter that is not in the hidden word, display an appropriate message. 
             * If the user guesses a letter that appears multiple times in the hidden word, make sure that each correct letter is placed.*/ 
 
            Random number = new Random();
            int wordChoice = number.Next(0, 9);
            string[] words = { "flamethrowing", "troublemaking", "copyrightable", "hydromagnetic", "uncopyrighted", "unproblematic", "multibranched", "metalworkings" };
            char[] letters = words[wordChoice].ToCharArray();
            string wordChosen = Convert.ToString(letters);
            int count=0;
            char hiddenChar = '*';
            var guessed = new List<char>();
            for (int i = 0; i < wordChosen.Length; i++)
            {
                count++;
            }
            do
            {
                Console.Write($"Word: ");
                foreach (var c in letters)
                {
                    if (guessed.Contains(c))
                        Console.Write(c);
                    else
                        Console.Write($"{hiddenChar}");
                }
                Console.WriteLine(count);
                Console.Write("Guess a letter >> ");
                char letter = Convert.ToChar(Console.ReadLine());

                if (words[wordChoice].Contains<char>(letter))
                {
                    guessed.Add(letter);
                    Console.WriteLine($"{letter} was in the word.");
                    count--;
                }
                else
                {
                    Console.WriteLine("You guessed wrong!");
                }
            } while (count>0);

            Console.WriteLine($"You Win.");
        }
    }
}
