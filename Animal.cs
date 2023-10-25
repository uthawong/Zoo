using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zoo
{
    public class Animal
    {
       private string AnimalType { get; set; }  //static fields
        private string Name { get; set; }
        private string Gender { get; set; }
        private int Age { get; set; }
        private string Color { get; set; }
        private double Weight { get; set; }
        private string Location { get; set; }

        public Animal(string animalType, string name, string gender, int age, string color, double weight, string location)  // contructors
        {
            AnimalType = animalType; 
            Name = name;
            Gender = gender;
            Age = age;
            Color = color;
            Weight = weight;
            Location = location;
        }
        public void AnimalInfo()
        {
            Console.WriteLine($"Animal type: {AnimalType} \nName: {Name} \nGender: {Gender} \nAge: {Age} \nColor: {Color} \nWeight: {Weight}");
        }
        public void whereToFind() 
        {
            Console.WriteLine($"{Name} can usually be found in their natural habitat in {Location}");
        }
        public virtual void makeSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
}

