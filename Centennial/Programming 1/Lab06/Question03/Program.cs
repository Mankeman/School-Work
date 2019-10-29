using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCourse;
            string resStat;
            int domCost = 325;
            int intCost = 1375;

            Console.WriteLine("How many courses are you taking?");
            numCourse = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Are you a domestic or international student?");
            resStat = Convert.ToString(Console.ReadLine());
            resStat = resStat.ToLower();

            if (resStat == "domestic")
            {
                Console.WriteLine($"Your tuition cost total is {numCourse * domCost:c}.");
            }
            else if (resStat == "international")
            {
                Console.WriteLine($"Your tuition cost total is {numCourse * intCost:c}.");
            }
        }
    }
}
