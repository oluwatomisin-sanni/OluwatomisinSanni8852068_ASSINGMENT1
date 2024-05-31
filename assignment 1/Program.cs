using System;
    namespace PetSimulation 
{
    class   Pet
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Happinness { get; set; }
        public int Hunger { get; set;}

        public Pet(string type , string name)
        {
            Type = type;
            Name = name;
            Health = 5;
            Happinness = 5;
            Hunger = 5;
        }
    }
    class Game
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the pet simulator !");

            Console.WriteLine("Pick your pet : Cat, Parrot, Tiger");
            string petType = Console.ReadLine();
            Console.WriteLine("What would you like to name your pet?");
            string petName = Console.ReadLine();    
            Pet myPet = new Pet(petType, petName);

            Console.WriteLine($"Welcome, {myPet.Name} the {myPet.Type}!");



        }
    }
}