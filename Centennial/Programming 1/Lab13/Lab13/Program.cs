using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 5;
            char operation = '+';
            int result;
            ArithmeticOperation(a, b, operation, result);
            Console.WriteLine("{0} {2} {1} = {3}", a, b, operation, result);
            operation = '*';
            ArithmeticOperation(a, b, operation, result);

        }
        static void ArithmeticOperation(int a, int b, char operation, int result)
        {
            switch (operation)
            {
                case +:
                    result = a + b;
                    break;
            }
            Console.WriteLine("{0} {2} {1} = {3}", a, b, operation, result);
        }
    }
}
