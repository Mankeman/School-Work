using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car a = new Car(2015, "Suzuki", "CVS", 25000);
            Console.WriteLine(a);

        }
    }
    public class Car
    {
        int year;
        string manufacturer;
        string model;
        bool isDriveable = true;
        double price;

        public Car(int year, string manufacturer, string model, double price, bool isDriveable = true)
        {
            this.year = year;
            this.manufacturer = manufacturer;
            this.model = model;
            this.price = price;
            this.isDriveable = isDriveable;
        }
        public override string ToString()
        {
            return $"{year} {manufacturer} {model} {price:c} {(isDriveable ? "Driveable": "Not Driveable")}";
        }

    }
}
