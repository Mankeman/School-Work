using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IntListDemo();
        }
        static void IntListDemo()
        {
            List<int> primes = new List<int>() { 3, 5, 7, 11, 13, 17, 19 };
            foreach(var item in primes)
            {
                Console.WriteLine(item);
            }
            int x = 23;
            Console.WriteLine($"Adding {x}");
            primes.Add(23);
            foreach (var item in primes)
            {
                Console.WriteLine(item);
            }
            x = 2;
            Console.WriteLine($"Inserting {x}");
            primes.Insert(0, x);
            foreach (var item in primes)
            {
                Console.WriteLine(item);
            }
            x = 7;
            Console.WriteLine($"{x} {(primes.Contains(x) ? "is" : "in not")} in the list");
            Console.WriteLine($"Removing {x}");
            primes.Remove(x);
            foreach(var item in primes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
