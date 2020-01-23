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
            Date d1 = new Date(2020, 08, 20);
            Console.WriteLine(d1);
            d1.Add(10);
            Console.WriteLine(d1);
        }
    }
    class Date
    {
        int year;
        int month;
        int day;
        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }
        public void Add(int day)
        {
            this.day += day;
            Normalize();
        }
        public void Add (int month, int day)
        {
            this.month += month;
            this.day += day;
            Normalize();
        }
        public void Add(Date other)
        {

            Normalize();
        }
        private void Normalize()
        {

        }
    }
}
