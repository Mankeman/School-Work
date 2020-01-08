using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
                DisplayMenu();
        }
        static void DisplayMenu()
        {
            int menu;

            do
            {
                Console.WriteLine("Calculation Menu");
                Console.WriteLine("1) Calculate Sum.");
                Console.WriteLine("2) Calculate Sum of Squares.");
                Console.WriteLine("3) Calculate Sum of Cubes.");
                Console.WriteLine("4) Calculate Average");
                Console.WriteLine("0) To Exit.");
                menu = Convert.ToInt32(Console.ReadLine());

                if (menu == 1)
                {
                    CalculateSum(menu);
                }
                else if (menu == 2)
                {
                    CalculateSumOfSquares(menu);
                }
                else if (menu == 3)
                {
                    CalculateSumOfCubes(menu);
                }
                else if (menu == 4)
                {
                    CalculateAverage(menu);
                }
                else if (menu == 0)
                {
                    return;
                }
                Console.WriteLine();
            } while (menu != 0);
        }
        static int CalculateSum(int sum)
        {
            int firstNum;
            int secondNum;

            Console.WriteLine("Please input first number.");
            firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input first number.");
            secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Equation: {firstNum}+{secondNum}={firstNum + secondNum}");

            return sum;
        }
        static int CalculateSumOfSquares(int sum)
        {
            int firstNum;
            int secondNum;
            int square = 2;

            Console.WriteLine("Please input first number.");
            firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input first number.");
            secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Equation: {firstNum}^{square}+{secondNum}^{square}={(firstNum * firstNum) + (secondNum * secondNum)}");

            return sum;
        }
        static int CalculateSumOfCubes(int sum)
        {
            int firstNum;
            int secondNum;
            int cube = 3;
            Console.WriteLine("Please input first number.");
            firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input first number.");
            secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Equation: {firstNum}^{cube}+{secondNum}^{cube}={(firstNum * firstNum * firstNum) + (secondNum * secondNum * secondNum)}");

            return sum;
        }
        static double CalculateAverage(double average)
        {
            int quantity;
            int userInput;
            int numbers = 0;

            Console.WriteLine("How many numbers are you inputing?");
            quantity = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= quantity; i++)
            {
                Console.WriteLine($"Enter number #{i}.");
                userInput = Convert.ToInt32(Console.ReadLine());

                numbers += userInput ;
            }
            average = (numbers / quantity);
            Console.WriteLine($"The average is {average}.");

            return average;
        }
    }
}
