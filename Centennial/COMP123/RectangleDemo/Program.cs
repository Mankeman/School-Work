using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle big = new Rectangle(8,5);
            Console.WriteLine(big);
        }
        static void DescribeRectangle(Rectangle rect)
        {
        }
    }
    class Rectangle
    {
        int length;
        int width;

        public Rectangle(int len, int wid)
        {
            length = len;
            width = wid;
        }
        public override string ToString()
        {
            return $"[{length}, {width}] Area: {length*width}";
        }
    }
}