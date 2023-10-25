using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Dolphin : Animal
    {
        public Dolphin(string animalType, string name, string gender, int age, string color, double weight, string location) : base(animalType, name, gender, age, color, weight, location)
        {
        }
        public override void makeSound()
        {
            Console.WriteLine("The dolphin makes a clicking and chattering sound.");
        }
    }
}