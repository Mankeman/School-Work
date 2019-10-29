using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question11
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumber;
            string answer;
            int guess;
            Console.WriteLine("Guess a random number between 1-10.");
            guess = Convert.ToInt32(Console.ReadLine());

            do
            {
                Random ranNumberGenerator = new Random();
                randomNumber = ranNumberGenerator.Next(1, 11);
                Console.WriteLine($"Your number is {randomNumber}. Am I too low, too high or correct?");
                answer = Convert.ToString(Console.ReadLine());
            } while (answer == "too low" || answer == "too high");
        }
    }
}
