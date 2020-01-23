using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadRectangleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BadRectangle bigRectangle = new BadRectangle();
            bigRectangle.length = 8;
            bigRectangle.width = 5;
            DescribeRectangle(bigRectangle);

            BadRectangle smallRectangle = new BadRectangle() { length = 3, width = 2 };
            DescribeRectangle(smallRectangle);
        }
        static void DescribeRectangle(BadRectangle rect)
        {
            Console.WriteLine($"Length: {rect.length}, Width: {rect.width}, Area: {rect.length * rect.width}");
        }
    }
    class BadRectangle
    {
        public int length;
        public int width;


    }
}
