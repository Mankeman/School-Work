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
            string residency;
            int courses;

            Console.WriteLine("Are you a domestic or foreign student?");
            residency = Convert.ToString(Console.ReadLine());
            residency = residency.ToLower();

            Console.WriteLine("How many courses are you taking?");
            courses = Convert.ToInt32(Console.ReadLine());

            if (residency == "domestic" && courses < 4)
            {
                Console.WriteLine($"Tuition fees are {425 * courses:c}.");
            }
            else if (residency == "domestic" && courses >= 4)
            {
                Console.WriteLine($"Tuition fees are {350 * courses:c}.");
            }
            else if (residency == "foreign" && courses < 4)
            {
                Console.WriteLine($"Tuition fees are {1225 * courses:c}.");
            }
            else if (residency == "foreign" && courses >= 4)
            {
                Console.WriteLine($"Tuition fees are {1175 * courses:c}.");
            }

        }
    }
}
