using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question13
{
    class Program
    {
        static void Main(string[] args)
        {
            double highSchoolGrade;
            double adminTest;

            Console.WriteLine("What was your highschool grade?");
            highSchoolGrade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What was your admission test score?");
            adminTest = Convert.ToDouble(Console.ReadLine());
            if (highSchoolGrade >= 3.0 && adminTest >= 60)
            {
                Console.WriteLine("Accept!");
            }
            else if (highSchoolGrade < 3.0 && adminTest >= 80)
            {
                Console.WriteLine("Accept!");
            }
            else
            {
                Console.WriteLine("Reject.");
            }
        }
    }
}
