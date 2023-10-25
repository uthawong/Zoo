//Caroline Uthawong-Burr .Net23
namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tiger tiger = new Tiger("Tiger","Tigger", "Male", 13, "orange with black stripes", 200, "Asia.");
            tiger.AnimalInfo();
            tiger.whereToFind();
            tiger.makeSound();
            Console.WriteLine();

            MalayanTiger malayanTiger = new MalayanTiger("Tiger", "Malaya", "Female", 5, "reddish-orange", 60, "Malaysia.", 1050);
            malayanTiger.AnimalInfo();
            malayanTiger.whereToFind();
            malayanTiger.makeSound();
            malayanTiger.biteForce();
            Console.WriteLine();

            SibirianTiger sibirianTiger = new SibirianTiger("Tiger", "Vladimir", "Male", 65, "snow-white", 350, "Russia.", 220);
            sibirianTiger.AnimalInfo();
            sibirianTiger.whereToFind();
            sibirianTiger.makeSound();
            sibirianTiger.speed();
            Console.WriteLine();

            Flamingo flamingo = new Flamingo("Bird", "Swingy", "Female", 16, "pink", 30, "tropical and subtropical environments in Asia, America, Africa and Europe.");
            flamingo.AnimalInfo();
            flamingo.whereToFind();
            flamingo.makeSound();
            Console.WriteLine();

            Dolphin dolphin = new Dolphin("Mammal", "Flipper", "Male", 10, "gray", 60, "seas and oceans all around the world.");
            dolphin.AnimalInfo();
            dolphin.whereToFind();
            dolphin.makeSound();
        }
    }
}