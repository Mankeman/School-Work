using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question05
{
    class Program
    {
        static void Main(string[] args)
        {
            string message;

            Console.WriteLine("Write your message.");
            message = Convert.ToString(Console.ReadLine());
            int length = message.Length;
            if (length > 140)
            {
                Console.WriteLine("This message is too long.");
            }
            else
            {
                Console.WriteLine("This message is shorter than 140 characters.");
            }

        }
    }
}
