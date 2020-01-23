using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string owner;
            Console.WriteLine("What is the owner's name?");
            owner = Console.ReadLine();
            SetOwner(owner);
        }
    }
}
