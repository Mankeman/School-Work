using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question08
{
    class Program
    {
        static void Main(string[] args)
        {
            string woodType;
            int pineTab = 100;
            int oakTab = 225;
            int mahogTab = 310;

            Console.WriteLine("For furniture, do you want pine, oak or mahogany?");
            woodType = Convert.ToString(Console.ReadLine());
            woodType = woodType.ToLower();

            if (woodType == "pine")
            {
                Console.WriteLine($"Pine tables cost {pineTab:c}.");
            }
            else if (woodType == "oak")
            {
                Console.WriteLine($"Oak tables cost {oakTab:c}.");
            }
            else if (woodType == "mahogany")
            {
                Console.WriteLine($"Mahogany tables cost {mahogTab:c}.");
            }
        }
    }
}
