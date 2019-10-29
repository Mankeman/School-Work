using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question04
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            double temp;
            double height;
            int month;
            string input;
            int day;
            int employment;
            int identNum;
            double length;
            string key;
            string province;
            string tax;
            string residence;
            string position;

            Console.WriteLine("What's your age?");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What's your body temperature?");
            temp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What's your height in inches?");
            height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What's the current month number?");
            month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Letter input?");
            input = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Day of the month?");
            day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many years have you been employed at the company?");
            employment = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Day of the month?");
            identNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Length?");
            length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Key?");
            key = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Province?");
            province = Convert.ToString(Console.ReadLine());
            province = province.ToUpper();

            Console.WriteLine("Tax?");
            tax = Convert.ToString(Console.ReadLine());
            tax = tax.ToUpper();

            Console.WriteLine("Residence?");
            residence = Convert.ToString(Console.ReadLine());
            residence = residence.ToUpper();

            Console.WriteLine("Manager or Supervisor?");
            position = Convert.ToString(Console.ReadLine());
            position = position.ToUpper();

            Console.WriteLine($"Question 1A is {age = 30}");
            Console.WriteLine($"Question 1B is {temp = 98.6}");
            Console.WriteLine($"Question 1C is {height < 72}");
            if (month == 12)
            {
                Console.WriteLine($"Question 1D is true.");
            }
            else
            {
                Console.WriteLine($"Question 1D is false.");
            }
            if (input == "m")
            {
                Console.WriteLine($"Question 1E is true.");
            }
            else
            {
                Console.WriteLine($"Question 1E is false.");
            }
            if (age == 30 && height < 72)
            {
                Console.WriteLine($"Question 1F is true.");
            }
            else
            {
                Console.WriteLine($"Question 1F is false.");
            }
            if (day == 15 && month == 1)
            {
                Console.WriteLine($"Question 1G is true.");
            }
            else
            {
                Console.WriteLine($"Question 1G is false.");
            }
            if (age > 50 || employment >= 5)
            {
                Console.WriteLine($"Question 1H is true.");
            }
            else
            {
                Console.WriteLine($"Question 1H is false.");
            }
            if (identNum < 500 && age > 55)
            {
                Console.WriteLine($"Question 1I is true.");
            }
            else
            {
                Console.WriteLine($"Question 1I is false.");
            }
            if (length > 2 && length < 3)
            {
                Console.WriteLine($"Question 1J is true.");
            }
            else
            {
                Console.WriteLine($"Question 1J is false.");
            }
            if (age >= 30 && age <= 40)
            {
                Console.WriteLine($"Question 1K is true.");
            }
            else
            {
                Console.WriteLine($"Question 1K is false.");
            }
            if (age <30 || age >50)
            {
                Console.WriteLine($"Question 1L is true.");
            }
            else
            {
                Console.WriteLine($"Question 1L is false.");
            }
            if (key == "r")
            {
                Console.WriteLine($"Question 1M is true.");
            }
            else
            {
                Console.WriteLine($"Question 1M is false.");
            }
            if (province == "O" && tax == "Y")
            {
                Console.WriteLine($"Question 1N is true.");
            }
            else
            {
                Console.WriteLine($"Question 1N is false.");
            }
            if (age >= 17 && residence == "Y")
            {
                Console.WriteLine($"Question 1O is true.");
            }
            else
            {
                Console.WriteLine($"Question 1O is false.");
            }
            if (position == "MANAGER")
            {
                Console.WriteLine($"You're a Manager.");
            }
            else
            {
                Console.WriteLine($"You're a Supervisor.");
            }
        }
    }
}
