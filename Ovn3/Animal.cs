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

        public Animal()
        {

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
        public string Talk()
        {
            return "Wolfman talk: Hey howl";
        }
    }

    class Pelican : Bird
    {
        public int BeakSize { get; set; }

        public override string Stats()
        {
            string baseProperties = base.Stats();
            return $"{baseProperties} Beak Size: {BeakSize}";
        }
    }

    class Flamingo : Bird
    {
        public bool HasPinkLegs { get; set; } = true;
    }

    class Swan : Bird
    {
        public bool EatsFish { get; set; }
    }

    // Fråga 3.3.13: Om samtliga fåglar behöver ett nytt attribut lägger vi det i klassen Bird
    // Fråga 3.3.14: Om alla djur behöver det nya attributet lägger vi det i klassen Animal

   

    
}
