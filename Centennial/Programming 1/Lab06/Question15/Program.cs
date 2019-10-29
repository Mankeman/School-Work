using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question15
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            double sqFeet;
            int fee;
            double total;
            int payment;
            double newTotal;
            double servCharge;
            double eachPay;

            Console.WriteLine("What is the length of the lawn?");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the width of the lawn?");
            width = Convert.ToDouble(Console.ReadLine());

            sqFeet = length * width;
            if (sqFeet < 400)
            {
                fee = 25;
                total = fee * 20;
                Console.WriteLine($"The weekly fee is {fee:c}. The total for the 20 week job will be {total:c}.");
            }
            else if (sqFeet > 400 && sqFeet < 600)
            {
                fee = 35;
                total = fee * 20;
                Console.WriteLine($"The weekly fee is {fee:c}. The total for the 20 week job will be {total:c}.");
            }
            else
            {
                fee = 50;
                total = fee * 20;
                Console.WriteLine($"The weekly fee is {fee:c}. The total for the 20 week job will be {total:c}.");
            }
            Console.WriteLine("Would you want to pay (1) once, (2) twice or (3) 20 times per year?");
            payment = Convert.ToInt32(Console.ReadLine());

            switch (payment)
            {
                case 1:
                    Console.WriteLine($"You must make one (1) payment. Each payment amount is {total:c}. The fee for the season is {total:c}.");
                    break;
                case 2:
                    servCharge = 5;
                    eachPay = (total / 2) + servCharge;
                    newTotal = eachPay * 2;
                    Console.WriteLine($"You must make two (2) payments. Each payment amount is {eachPay:c}. The fee for the season is {newTotal:c}.");
                    break;
                case 3:
                    servCharge = 3;
                    eachPay = (total / 20) + servCharge;
                    newTotal = eachPay * 20;
                    Console.WriteLine($"You must make twenty (20) payments. Each payment amount is {eachPay:c}. The fee for the season is {newTotal:c}.");
                    break;
            }

        }
    }
}
