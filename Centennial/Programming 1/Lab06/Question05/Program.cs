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
            string weekChoice;

            Console.WriteLine("Using the first 3 letters of the day, what is the current day of the week?");
            weekChoice = Console.ReadLine();
            weekChoice = weekChoice.ToLower();
            if(weekChoice == "sun" || weekChoice == "wed")
            {
                Console.WriteLine("Home.");
            }
            else if (weekChoice == "mon" || weekChoice == "tue" || weekChoice == "thu" || weekChoice == "fri" || weekChoice == "sat")
            {
                Console.WriteLine("Work.");
            }
        }
    }
}
