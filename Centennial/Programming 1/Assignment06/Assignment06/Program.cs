using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06
{
    /* Write a method named IsPerfect that ask user for an integer number and display if the number is
    perfect.
    A number is perfect if it equals the sum of all the smaller positive integers that divide evenly
    into it.
    For example, 6 is perfect because 1, 2, and 3 divide evenly into it and their sum is 6.
    Write method GetNumber that will keep asking user to input an integer number until valid number is
    provided.This method will return provided value.
    In the Main method of the console application call GetNumber method to get the user input.
    By calling IsPerfect method in main check if the number is perfect. Display the result. */
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = GetNumber();

            if (IsPerfect(userInput))
            {
                Console.WriteLine($"{userInput} is a perfect number");
            }
            else
            {
                Console.WriteLine($"{userInput} is not a perfect number");
            }
        }
        static bool IsPerfect(int userInput)
        {
            int sum = 0;
            const int ZERO = 0;
            bool perfectNumber = false;
            for (int i = 1; i < userInput; i++)
            {
                if (userInput % i == ZERO)
                {
                    sum += i;
                }
            }
            if (sum == userInput)
            {
                perfectNumber = true;
            }
            return perfectNumber;
        }
        static int GetNumber()
        {
            int number = 0;
            while (number <= 0)
            {
                Console.WriteLine("Please write a positive integer number");
                while(!int.TryParse(Console.ReadLine(),out number))
                {
                    Console.WriteLine("This value is not an integer.");
                }
            }
            return number;
        }
    }
}