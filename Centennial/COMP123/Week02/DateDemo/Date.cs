using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDemo
{
    class Date
    {
        string[] name = "Jan Feb Mar Apr May Jun Jul Aug Sep Oct Nov Dec".Split();
        public int Day { get; private set; }
        public int Month { get; private set; }
        public int Year { get; private set; }
        public Date (int year, int month, int day)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        
        public override string ToString()
        {
            return $"{name[Month-1]}/{Day}/{Year}";
        }
    }
}
