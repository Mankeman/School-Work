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
            string phrase;
            string[] letterCount = { "aCount", "bCount", "cCount", "dCount", "eCount", "fCount", "gCount", "hCount", "iCount", "jCount", "kCount", "lCount", "mCount", "nCount", "oCount", "pCount", "qCount", "rCount", "sCount", "tCount", "uCount", "vCount", "wCount", "xCount", "yCount", "zCount" };
            int count = 0;
            Console.WriteLine("What is your phrase?");
            phrase = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i] = letterCount[0])
                {
                    ++count;
                }
            }
            Console.WriteLine($"Vowel count: {count}");
        }
    }
}
