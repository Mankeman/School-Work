using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        static void Main(string[] args)
        {
            do
            {


                int userInput;
                Console.WriteLine("Write '1' for Obama, '2' for Poem, '3' for Primes.");
                userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {

                    case 1:
                        Obama();
                        break;
                    case 2:
                        Poem();
                        break;
                    case 3:
                        Primes();
                        break;
                }

            } while (Console.ReadLine() != "end");
        }
        static string[] Obama()
        {
            string[] obama = { "Barack", "Hussein", "Obama" };

            for (int i = 0; i < obama.Length; i++)
            {
                Console.WriteLine(obama[i]);
            }
            return obama;
        }
        static string[] Poem()
        {
            string[] poem = { "Mary", "had", "a", "little", "lamb" };

            for (int i = 0; i < poem.Length; i++)
            {
                Console.Write($"{poem[i]} ");
            }
            Console.WriteLine();
            return poem;
        }
        static int Primes()
        {
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19 };
            int sum = 0;
            for (int i = 0; i<primes.Length; i++)
			{
                sum += primes[i];
			}
            Console.WriteLine($"The sum of the primes is {sum}.");
            for (int i = 0; i < primes.Length; i++)
            {
                primes[i]=primes[i] * 2;
            }
            return sum;
        }
    }
}
