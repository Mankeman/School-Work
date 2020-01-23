using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rationals
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational r1 = new Rational(1, 2);
            Rational r2 = new Rational(2, 1);
            Rational r3 = new Rational(0, 2);
            Rational r4 = new Rational(0, 1);

            Console.WriteLine($"The original values for the first object is {r1} and the second object is {r2}.");
            Console.WriteLine($"\nNow, There will be an increment in the first rational. The second object shall be added onto the first object.");
            r1.IncreaseBy(r2);
            Console.WriteLine($"\n{r1} is the new value for the first object after increasing it.");
            Console.WriteLine($"\n{r3} is the original value for the third object. {r4} is the original value for the fourth object.");
            Console.WriteLine($"\nNow, there will be a decrement in the 2 rationals. The third object will be subtracted onto the fourth object.");
            r3.DecreaseBy(r4);
            Console.WriteLine($"\n{r3} is the new value for the first object after decreasing it.\n");
        }
    }
    class Rational
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public Rational(int numerator = 0, int denominator = 1)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
        public void IncreaseBy(Rational other)
        {
            if (other.Denominator != Denominator)
            {
                Denominator = Denominator * other.Denominator;
                Numerator = ((Numerator * other.Denominator) + (other.Numerator * Denominator));
            }
            else
            {
                Denominator = other.Denominator;
                Numerator = ((Numerator * other.Denominator) + (other.Numerator * Denominator));
            }
        }
        public void DecreaseBy(Rational other)
        {
            if (other.Denominator != Denominator)
            {
                Denominator = Denominator * other.Denominator;
                Numerator = ((Numerator * other.Denominator) - (other.Numerator * Denominator));
            }
            else
            {
                Denominator = other.Denominator;
                Numerator = ((Numerator * other.Denominator) - (other.Numerator * Denominator));
            }
        }
    }
}
