using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Tiger : Animal
    {
        public Tiger(string animalType, string name, string gender, int age, string color, double weight, string location) : base(animalType, name, gender, age, color, weight, location)
        {
        }
        public override void makeSound()
        {
            Console.WriteLine("The tiger roars!");
        }
    }
    public class MalayanTiger : Tiger
    {
        public double BiteForce;
        public MalayanTiger(string animalType, string name, string gender, int age, string color, double weight, string location, double biteForce) : base(animalType, name, gender, age, color, weight, location)
        { 
            BiteForce = biteForce;  //unik egenskap


        }
              public void biteForce()  
              {
                Console.WriteLine($"A Malayan tiger has a biteforce of {BiteForce} psi.");
              }
        
            public override void makeSound()
            {
            Console.WriteLine("The Malayan tiger sounds like a big cat.");
            }
    }
    public class SibirianTiger : Tiger
    {
        public double Speed;
        public SibirianTiger(string animalType, string name, string gender, int age, string color, double weight, string location, double speed) : base(animalType, name, gender, age, color, weight, location)
        {
            Speed = speed;  //unik egenskap


        }
        public void speed()
        {
            Console.WriteLine($"A Sibirian tiger runs {Speed} km/h.");
        }

        public override void makeSound()
        {
            Console.WriteLine("The Sibirian tiger sounds like a Russian giant pussycat.");
        }
    }
}




