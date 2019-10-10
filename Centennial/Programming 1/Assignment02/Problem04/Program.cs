using System;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {   /* Angelo Goncalves
             * 300-887-613
             * SEC. 005 
             * Gerard-The Plumber bills customers by the length of a job as well as the number of joins that is needed. 
             * Write a program that prompts the user for the length of the job, the number of joins and the unit price per length and joins. 
             * The program calculates and displays the total cost of the job.*/

            string userInput3;
            double lengthJob;
            double numberJoin;
            double lengthP;
            double joinP;
            double priceTotal;

            Console.WriteLine("Problem 4.\n");

            Console.WriteLine("What's the length of the job?");
            userInput3 = Console.ReadLine();
            lengthJob = Convert.ToDouble(userInput3);

            Console.WriteLine("What's the number of joins needed for the job?");
            userInput3 = Console.ReadLine();
            numberJoin = Convert.ToDouble(userInput3);

            Console.WriteLine("What's the price of the length per unit?");
            userInput3 = Console.ReadLine();
            lengthP = Convert.ToDouble(userInput3);

            Console.WriteLine("What's the price of the join per unit?");
            userInput3 = Console.ReadLine();
            joinP = Convert.ToDouble(userInput3);

            priceTotal = (lengthJob * lengthP) + (joinP * numberJoin);

            Console.WriteLine($"The total cost of the job will be {priceTotal:c}.");

        }
    }
}
