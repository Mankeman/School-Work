using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {   /* Angelo Goncalves
             * 300-887-613
             * SEC. 005 
             * A confectionary store wants a program that will prompt the user for the price of the candy and the amount of money she would like to spend.
             * Then, calculates and display the amount of candies that can be purchased.*/

            string userInput1;
            double candyPrice;
            double moneyOwn;
            int candyAmount;

            Console.WriteLine("Problem 2.\n");
            Console.WriteLine("How much is the price of the candy you want to buy? (in Dollars)");
            userInput1 = Console.ReadLine();
            candyPrice = Convert.ToDouble(userInput1);

            Console.WriteLine("How much money do you have? (in Dollars)");
            userInput1 = Console.ReadLine();
            moneyOwn = Convert.ToDouble(userInput1);

            candyAmount = (int)(moneyOwn / candyPrice);

            Console.WriteLine($"You can buy {candyAmount} piece(s) of candy. \n");

        }
    }
}
