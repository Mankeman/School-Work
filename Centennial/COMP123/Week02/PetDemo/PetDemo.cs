using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDemo
{
    class PetDemo
    {
        public string Name;
        private string Owner;
        public int Age;
        public string Description;
        private bool IsHouseTrained;
        public void PetDemo1(string name, int age, string description)
        {
            Name = name;
            Age = age;
            Description = description;
            //Owner = "No one";
            //IsHouseTrained = false;

            Console.WriteLine($"{name} is {age} years old. {description}");
        }
        public void SetOwner(string newOwner)
        {

        }
        public void Train()
        {
            IsHouseTrained = true;
        }
        public override string ToString()
        {
            return $"{Name}, {Owner}, {Age}, {Description}, {IsHouseTrained}";
        }
    }
}
