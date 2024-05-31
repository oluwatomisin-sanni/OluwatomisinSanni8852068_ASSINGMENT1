using System;
    namespace PetSimulation 
{
    class   Pet
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Happiness { get; set; }
        public int Hunger { get; set;}

        public Pet(string type , string name)
        {
            Type = type;
            Name = name;
            Health = 5;
            Happiness = 5;
            Hunger = 5;
        }
        public void Eat()
        {
            Hunger = Math.Max(0, Hunger -2);
            Health = Math.Min(10, Health +1);  
            Console.WriteLine($"Thank you! , That was yummy.\n{Name}'s hunger has reduced.\nHealth Boost +1 ");
        }
        public void Play()
        {
            if ( Hunger > 9 ) 
            {
                Console.WriteLine($"{Name} is too hungry to play");
            }
            Happiness= Math.Min(10, Happiness +3);
            Hunger = Math.Min(10, Hunger +2);
            Console.WriteLine($"That was fun! Snack time ?\n {Name}'s happiness has increased, but so has hunger. ");
        }
        public void Rest()
        {
            Health = Math.Min (10, Health +3);
            Happiness = Math.Max (0, Happiness -2);
            Console.WriteLine($"Up and ready to Play! \n {Name}'s health is up! ");
        }

        public void SeeStats()
        {
            Console.WriteLine($"{Name} the {Type}");
            Console.WriteLine($"HUNGER: {Hunger}/10 \n HAPPINESS: {Happiness}/10 \n HEALTH: {Health}/10");
        }

        public void PassTime()
        { 
            Hunger=Math.Min(10, Hunger +2);
            Happiness=Math.Max(1, Happiness -2);
        }

        public void CheckStats()
        {
            if (Hunger >= 8 ) 
            {
                Console.WriteLine($"{Name} is Hungry");
            }
            if ( Health <= 2 )
            {
                Console.WriteLine($"{Name} needs to rest");
            }
            if( Happiness <= 3 )
            {
                Console.WriteLine($"{Name} is unhappy!!");
            }
            if (Hunger == 10)
            {
                Health=Math.Min (0, Health -2);
                Console.WriteLine($"Starving! Starving! \n Health is reducing !");
            }
            if(Happiness == 0)
            {
                Health = Math.Max(0, Health - 2);
                Console.WriteLine($"Bored! Bored! \n Health is reducing !");
            }
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

            while(true)
            { 
                myPet.SeeStats();
                Console.WriteLine($"");
            }

        }
    }
}