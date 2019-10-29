using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question06
{
    class Program
    {
        static void Main(string[] args)
        {
            double gradePointAvg;
            double adminScore;

            Console.WriteLine("What is your GPA?");
            gradePointAvg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your admission test score?");
            adminScore = Convert.ToDouble(Console.ReadLine());

            if ((gradePointAvg >= 3.0 && adminScore >= 60)||(gradePointAvg <3.0 && adminScore >= 80))
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
