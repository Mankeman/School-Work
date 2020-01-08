using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question12b
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int topHalf;
            int botHalf;
            int count;

            Console.Write("Enter number of rows\n");
            number = Convert.ToInt32(Console.ReadLine());

            count = number - 1;
            for (botHalf = 1; botHalf <= number; botHalf++)
            {
                for (topHalf = 1; topHalf <= count; topHalf++)
                {
                    Console.Write(" ");
                }
                count--;
                for (topHalf = 1; topHalf <= 2 * botHalf - 1; topHalf++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            count = 1;
            /*for (botHalf = 1; botHalf <= number - 1; botHalf++)
            {
                for (topHalf = 1; topHalf <= count; topHalf++)
                {
                    Console.Write(" ");
                }
                count++;
                for (topHalf = 1; topHalf <= 2 * (number - botHalf) - 1; topHalf++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/
        }
    }

}
