using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3
{
    internal interface IPerson
    {
        string Talk();
         
    }

    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }

        public Animal(string name, int age, int weight)
        {
            Name=name;
            Age=age;
            Weight=weight;
        }

        public abstract string DoSound();

        public virtual string Stats()
        {
            return $"Name: {Name} Age: {Age} Weight: {Weight}";
        }
       
    }

    class Horse : Animal
    {
        public int HoofSize { get; set; }

        public Horse(string name, int age, int weight, int hoofSize) :  base(name, age, weight) 
        {
            HoofSize = hoofSize;
        }
        public override string DoSound()
        {
            return "Horse sound: Neigh";
        }
        public override string Stats()
        {
            string baseProperties=base.Stats();
            return $"{baseProperties} Hoof size: {HoofSize}";
        }
    }

    class Dog : Animal
    {
        public string FurColor { get; set; }

        public Dog(string name, int age, int weight, string furColor) : base(name, age, weight)
        {
                FurColor = furColor;
        }
       
        public override string DoSound()
        {
            return "Dog sound: Wof";
        }

        public override string Stats()
        {
            string baseProperties = base.Stats();
            return $"{baseProperties} Fur color: {FurColor}";
        }

        public string Eat()
        { 
            return "Dog eats: meat"; 
        }                                                                       
    }                                 
                                      

    class Hedgehog : Animal
    {
        public int NumberOfSpikes { get; set; }

        public Hedgehog(string name, int age, int weight, int numberOfSpikes) : base(name, age, weight)
        {
            NumberOfSpikes = numberOfSpikes;
        }

        public override string DoSound()
        {
            return "Hedgehog sound: Peep";
        }

        public override string Stats()
        {
            string baseProperties = base.Stats();
            return $"{baseProperties} Number of spikes: {NumberOfSpikes}";
        }

    }
    class Worm : Animal
    {
        public bool IsPoisonous { get; set; }

        public Worm(string name, int age, int weight, bool isPoisonous) : base(name, age, weight)   
        {
            IsPoisonous = isPoisonous;
        }

        public override string DoSound()
        {
            return "Worm sound: Wriggling";
        }

        public override string Stats()
        {
            string baseProperties = base.Stats();
            return $"{baseProperties} Poisonous: {IsPoisonous}";
        }

    }
    class Bird : Animal
    {
        public int WingSpan { get; set; }
        public int NumberOfFeathers { get; set; } //New attribute

        public Bird(string name, int age, int weight, int wingSpan, int numberOfFeathers) : base(name, age, weight) 
        {
            WingSpan = wingSpan;
            NumberOfFeathers = numberOfFeathers;
        }
        public override string DoSound()
        {
            return "Bird sound: Singing";
        }

        public override string Stats()
        {
            string baseProperties = base.Stats();
            return $"{baseProperties} Wing span: {WingSpan} NumberOfFeathers: {NumberOfFeathers}";
        }

    }
    class Wolf : Animal
    {
        public double PawSize { get; set; }

        public Wolf(string name, int age, int weight, double pawSize) : base(name, age, weight)
        {
            PawSize = pawSize;
        }

        public override string DoSound()
        {
            return "Wolf sound: Howl";
        }
        public override string Stats()
        {
            string baseProperties = base.Stats();
            return $"{baseProperties} Paw size: {PawSize}";
        }
    }

    class Wolfman : Wolf, IPerson
        {

        public Wolfman(string name, int age, int weight, double pawSize) :base(name,age,weight, pawSize)
        {

        }
        public string Talk()
        {
            return "Wolfman talk: Hey howl";
        }
    }

    class Pelican : Bird
    {
        public int BeakSize { get; set; }

        public Pelican(string name, int age, int weight, int wingSpan, int numberOfFeathers, int beakSize) :base(name, age, weight, wingSpan, numberOfFeathers)
        {
            BeakSize = beakSize;
        }

        public override string Stats()
        {
            string baseProperties = base.Stats();
            return $"{baseProperties} Beak Size: {BeakSize}";
        }
    }

    class Flamingo : Bird
    {
        public bool HasPinkLegs { get; set; } = true;

        public Flamingo(string name, int age, int weight, int wingSpan, int numberOfFeathers, bool hasPinkLegs) : base(name, age, weight, wingSpan, numberOfFeathers)
        {
            HasPinkLegs = hasPinkLegs;
        }

        public override string Stats()
        {
            string baseProperties = base.Stats();
            return $"{baseProperties} Has pink legs: {HasPinkLegs}";
        }
    }

    class Swan : Bird
    {
        public Swan(string name, int age, int weight, int wingSpan, int numberOfFeathers, bool eatsFish) : base(name, age, weight, wingSpan, numberOfFeathers)
        {
            EatsFish = eatsFish;
        }

        public bool EatsFish { get; set; }

        public override string Stats()
        {
            string baseProperties = base.Stats();
            return $"{baseProperties} Eats fish: {EatsFish}";
        }
    }

    // Fråga 3.3.13: Om samtliga fåglar behöver ett nytt attribut lägger vi det i klassen Bird
    // Fråga 3.3.14: Om alla djur behöver det nya attributet lägger vi det i klassen Animal

   

    
}
