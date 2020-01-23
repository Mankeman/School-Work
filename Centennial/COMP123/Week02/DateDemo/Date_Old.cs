using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDemo
{
    class Date_Old
    {
        int day;
        int month;
        int year;

        public Date_Old(int year, int month, int day)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public void AddDays(int days)
        {
            day += days;
            Normalize();
        }
        public void AddDays(int months, int days)
        {
            month += months;
            day += days;
            Normalize();
        }
        public void AddDays(Date_Old date) // int years, int months, int days
        {
            month += date.month;
            day += date.day;
            year += date.year;
            Normalize();
        }
        private void Normalize()
        {
            while (day > 30)
            {
                month++;
                day -= 30;
            }
            while (month > 12)
            {
                year++;
                month -= 12;
            }
        }
        public override string ToString()
        {
            return $"{month}/{day}/{year}";
        }
    }
}
