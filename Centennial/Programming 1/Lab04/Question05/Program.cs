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
            double angle;
            double temp;
            double studentScore;
            double number;
            double slope;
            double num1;
            double num2;
            double temp1;
            double temp2;
            double x;
            double y;
            double z;
            double p;
            double dist;
            double intVarTime;
            double hours;
            string shape;
            double length;
            int factor = 999999999;

            Console.WriteLine("Question 5a: What is the degree of the angle?");
            angle = Convert.ToDouble(Console.ReadLine());

            if (angle == 90)
            {
                Console.WriteLine($"The angle is a right angle.");
            }
            else
            {
                Console.WriteLine($"The angle is not a right angle.");
            }

            Console.WriteLine("Question 5b: What is the temperature?");
            temp = Convert.ToDouble(Console.ReadLine());

            if (temp > 100)
            {
                Console.WriteLine($"Above the boiling point of water.");
            }
            else
            {
                Console.WriteLine($"Below the boiling point of water.");
            }

            Console.WriteLine("Question 5c: Student score?");
            studentScore = Convert.ToDouble(Console.ReadLine());

            if (studentScore >= 70)
            {
                Console.WriteLine($"Pass.");
            }
            else
            {
                Console.WriteLine($"Fail.");
            }

            Console.WriteLine("Question 5d: What is the temperature?");
            temp = Convert.ToDouble(Console.ReadLine());

            if (temp > 98.2 || temp <= 100.2)
            {
                Console.WriteLine($"Normal.");
            }
            else
            {
                Console.WriteLine($"Not Normal.");
            }

            Console.WriteLine("Question 5e: Number?");
            number = Convert.ToDouble(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine($"{number + number}");
            }
            else
            {
                Console.WriteLine($"{number + -number}");
            }

            Console.WriteLine("Question 5f: Slope?");
            slope = Convert.ToDouble(Console.ReadLine());

            if (slope < 0.5 || slope > 0)
            {
                Console.WriteLine($"Slope is 0");
            }
            else
            {
                Console.WriteLine($"Below the boiling point of water.");
            }

            Console.WriteLine("Question 5g: Number 1?");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Number 2?");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 - num2 <= 0.001)
            {
                Console.WriteLine($"The answer is 0.");
            }
            else
            {
                Console.WriteLine($"The answer is {(num1 - num2) / 2.0}.");
            }

            Console.WriteLine("Question 5h: Temperature 1?");
            temp1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Temperature 2?");
            temp2 = Convert.ToDouble(Console.ReadLine());

            if (temp1 - temp2 > 2.3)
            {
                Console.WriteLine($"{(temp1 -temp2) * factor}.");
            }
            else
            {
                Console.WriteLine($"The answer is {temp1 -temp2}.");
            }

            Console.WriteLine("Question 5i: x value?");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("y value?");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("z value?");
            z = Convert.ToDouble(Console.ReadLine());

            if(x > y && z < 20)
            {
                Console.WriteLine("p value?");
                p = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Question 5j: Distance?");
            dist = Convert.ToDouble(Console.ReadLine());

            if (dist > 20 && dist < 35)
            {
                Console.WriteLine("Question 1j: Integer Variable Time?");
                intVarTime = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Question 5k: Hours?");
            hours = Convert.ToDouble(Console.ReadLine());

            if (hours < 40)
            {
                Console.WriteLine($"{8 * hours}");
            }
            else
            {
                Console.WriteLine($"{320 + (hours - 40) *12}");
            }

            Console.WriteLine("Question 5L: Shape? (R for rectangle, C for circle, T for triangle)");
            shape = Convert.ToString(Console.ReadLine());
            shape = shape.ToLower();

            Console.WriteLine("Length?");
            length = Convert.ToDouble(Console.ReadLine());

            if (shape == "r")
            {
                Console.WriteLine($"Area is {4 * length}.");
            }
            else if (shape == "c")
            {
                Console.WriteLine($"Area is {Math.PI * length * length}.");
            }
            else if (shape == "t")
            {
                Console.WriteLine($"Area is {0.433 * length * length}.");
            }
        }
    }
}
