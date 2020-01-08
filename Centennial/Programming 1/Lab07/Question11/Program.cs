using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question11
{
    class Program
    {
        static void Main(string[] args)
        {
            int endOfYear;
            int depreciate = 4000;
            int machineCost=28000;
            int year=0;
            int acumDepreciate=0;

            

            Console.WriteLine($"Year        Depreciation         End-Of-Year        Accumulated");
            Console.WriteLine($"                                    Value           Depreciation");                  
            Console.WriteLine($"----        ------------         -----------        ------------");
            do
            {
                year++;
                endOfYear = machineCost - depreciate;
                machineCost -= depreciate;
                acumDepreciate += depreciate;
                Console.WriteLine($" {year}              {depreciate}                   {endOfYear}             {acumDepreciate}");
            } while (year < 7);
        }
    }
}
