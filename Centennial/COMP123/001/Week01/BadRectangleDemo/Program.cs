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
            //declare a BadRectangle variable
            BadRectangle bigRectangle;
            //initialized the above variable
            bigRectangle = new BadRectangle();
            bigRectangle.length = 8;
            bigRectangle.width = 5;
            DescribeRectangle(bigRectangle);

            BadRectangle smallRectangle = new BadRectangle() { length = 3, width = 2 };
            DescribeRectangle(smallRectangle);
        }
        static void DescribeRectangle(BadRectangle rect)
        {
            Console.WriteLine($"Length: {rect.length} width:{rect.width}, area:{rect.length * rect.width}");
        }
    }
    //definition of the class BadRectangle
    class BadRectangle
    {
        //members declaration
        public int length;
        public int width;
    }
}
