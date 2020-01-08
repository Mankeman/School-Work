using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("What is the number to reverse?");
            num = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            Console.WriteLine(result);
        }
    }
}
