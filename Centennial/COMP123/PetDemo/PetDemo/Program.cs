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
            Pet p1 = new Pet ("Lucas", 3, "Beautiful pom with white fur", null,true);
            Pet p2 = new Pet("Markus", 1, "Pure-bred Siberian Husky with silver fur", "Maria", false);
            Pet p3 = new Pet("Deborah", 7, "Morkie mix with brown fur","Thomas",false);
            Pet p4 = new Pet("Nicky", 2, "German Sheppard/Chihuahua mix","Angelo",true);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);
        }
    }
    class Pet
    {
        public string Name;
        public string Owner;
        public int Age;
        public string Description;
        public bool IsHouseTrained;
        
        public Pet(string name, int age, string description, string owner, bool isHouseTrained)
        {
            this.Age = age;
            this.Name = name;
            this.Description = description;
            if (owner != null)
            {
                this.Owner = owner;
            }
            else
            {
                this.Owner = "No one";
            }
            if (isHouseTrained == false)
            {
                this.IsHouseTrained = false;
            }
            else
            {
                Train();
            }
        }
        public override string ToString()
        {
            if (IsHouseTrained)
            {
                return $"The pets name is {Name}, and the owner's name is {Owner}. At the age of {Age}, the dog is a {Description} and is house trained.\n";
            }
            else
            {
                return $"The pets name is {Name}, and the owner's name is {Owner}. At the age of {Age}, the dog is a {Description} and is not house trained.\n";
            }
        }
        public void SetOwner(string owner)
        {
            this.Owner = owner;
        }
        public void Train()
        {
            this.IsHouseTrained = true;
        }
    }
}
