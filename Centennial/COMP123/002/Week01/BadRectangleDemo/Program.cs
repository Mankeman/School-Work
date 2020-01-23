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
            //declare our object
            BadRectangle bigRectangle;
            //initialized the above object
            bigRectangle = new BadRectangle();
            //set the two properties of the object
            bigRectangle.length = 8;
            bigRectangle.width = 5;
            DescribeRectangle(bigRectangle);
            BadRectangle small = new BadRectangle() { length = 3, width = 2 };
            DescribeRectangle(small);
        }
        static void DescribeRectangle(BadRectangle badRectangle)
        {
            Console.WriteLine($"{badRectangle.length} {badRectangle.width}");
        }
    }

    //declare my custom type
    class BadRectangle
    {
        public int length;
        public int width;
    }
}
