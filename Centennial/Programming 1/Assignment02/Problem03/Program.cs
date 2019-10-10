using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {   /* Angelo Goncalves
             * 300-887-613
             * SEC. 005 
             * Othello’s Grocery would like a program that will prompt the user for the weight and price of the produce, 
             * the price and capacity of plastic bag and then calculates and displays the total cost of the sale. 
             * You may assume that all customers will require bags. 
             * You may use the following sample inputs: price 11₵per kg, weight 25kg and price of a plastic bag 5₵.*/

            string userInput2;
            double weightProd;
            double priceProd;
            double bagCost;
            double bagCap;
            double costTotal;

            Console.WriteLine("Problem 3.\n");
            Console.WriteLine("What's the price of the produce? (in Dollars)");
            userInput2 = Console.ReadLine();
            priceProd = Convert.ToDouble(userInput2);

            Console.WriteLine("What's the weight of the produce? (in Kg)");
            userInput2 = Console.ReadLine();
            weightProd = Convert.ToDouble(userInput2);

            Console.WriteLine("What's the price of the bag? (in Dollars)");
            userInput2 = Console.ReadLine();
            bagCost = Convert.ToDouble(userInput2);

            Console.WriteLine("What's the capacity of the bag? (in Kg)");
            userInput2 = Console.ReadLine();
            bagCap = Convert.ToDouble(userInput2);

            costTotal = (priceProd * weightProd) + (weightProd / bagCap * bagCost);

            Console.WriteLine($"The total cost will come to {costTotal:c}.\n");

        }
    }
}
