using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxCounter;

            Console.WriteLine("Count to?");
            maxCounter = Convert.ToInt32(Console.ReadLine());

            for(int counter = 1; counter <= maxCounter; counter+=2)
            {
                Console.WriteLine(counter);
            }
        }
    }
}
