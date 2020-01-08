using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05
{
    class Program
    {

        static void Main(string[] args)
        {
            /* Angelo Goncalves
             * 300-887-613
             * 
             * A palindrome is a word, phrase, number or other sequence of units that can be read the same way in
               either direction. 
               The character palindromes are words that can be read the same way in either direction
               (radar, civic, sdfds, 1drd1). The number palindromes are numbers that can be read the same way in
               either direction (12321, 1221221).
               
               [25 points] Write a console application that reads a word and display if it is number palindrome, character
               palindrome, or not a palindrome at all. The application should ask for a new word until user enters word
               “end”. Before exiting application print out the list of all palindrome words that user has input.
               
               [60 points] Make the code more readable and non-repetitive by use of the methods. Your application
               should have at least one method that is called IsPalindrome that returns true if the provided argument is
               palindrome.*/


            string userInput;
            string reversedWord = "";
            string[] allUserWords = new string[100];
            int count = 0;

            const string FINISH_PROGRAM = "end";

            Console.WriteLine("This program will display if what you typed is a Palindrome or not. Type 'end' to end the program.");

            do
            {

                Console.WriteLine("Enter your phrase/word/number.");

                userInput = Console.ReadLine().ToLower();

                if (userInput == "end")
                {
                    Console.WriteLine($"All the words you typed were:");
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine($"{allUserWords[i]}");
                    }
                    break;
                }

                reversedWord = ReverseWord(userInput);

                if (IsPalindrome(reversedWord, userInput))
                {
                    PrintTypeOfPalindrome(reversedWord, userInput);
                    allUserWords[count] += userInput;
                    count++;
                }
                else
                {
                    Console.WriteLine($"This is not a Palindrome.");
                }

            } while (userInput != FINISH_PROGRAM);

        }
        static bool IsPalindrome(string reverseWord, string userInput)
        {
            return reverseWord == userInput;
        }
        static string ReverseWord(string userInput)
        {
            string[] userTemporaryStorage = new string[userInput.Length];
            string reversedWord = "";

            for (int i = 0; i < userInput.Length; i++)
            {
                userTemporaryStorage[i] = userInput.Substring(i, 1);
            }

            Array.Reverse(userTemporaryStorage);

            for (int i = 0; i < userInput.Length; i++)
            {
                reversedWord += userTemporaryStorage[i];
            }

            return reversedWord;
        }
        static void PrintTypeOfPalindrome(string reversedWord, string userInput)
        {
            int number;

            if (Int32.TryParse(userInput, out number))
            {
                Console.WriteLine("This is a Number Palindrome.");
                Console.WriteLine($"The palindrome you input was {reversedWord}");
            }
            else
            {
                Console.WriteLine("This is a Char Palindrome.");
                Console.WriteLine($"The palindrome you input was {reversedWord}");
            }
        }
    }
}
