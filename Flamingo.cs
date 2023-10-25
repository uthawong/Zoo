using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Flamingo : Animal
    {
        public Flamingo(string animalType, string name, string gender, int age, string color, double weight, string location) : base(animalType, name, gender, age, color, weight, location)
        {
        }
        public override void makeSound()
        {
            Console.WriteLine("The flamingo makes a nasal honking call.");
        }
    }
}