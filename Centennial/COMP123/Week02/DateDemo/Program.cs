using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date(2020, 1, 14);
            Console.WriteLine(d1.Year);
            /*int days = 1;
            Console.WriteLine($"Adding {days} days");
            d1.AddDays(days);
            Console.WriteLine(d1);
            int months = 3;
            Console.WriteLine($"Adding {months} months and {days} days");
            d1.AddDays(months, days);
            Console.WriteLine(d1);
            Date_Old d2 = new Date_Old(2, 3, 5);
            Console.WriteLine($"Adding the date {d2}");
            d1.AddDays(d2);
            Console.WriteLine(d1);*/
        }
    }
    
}
