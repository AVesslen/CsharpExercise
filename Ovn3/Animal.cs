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

        public string Stats()
        {
            return "";
        }
    }

    class Horse : Animal
    {
        public int HoofSize { get; set; }
        public override string DoSound()
        {
            return "Horse sound: Neigh";
        }
    }

    class Dog : Animal
    {
        public string FurColor { get; set; }

        public override string DoSound()
        {
            return "Dog sound: Wof";
        }

    }

    class Hedgehog : Animal
    {
        public int NumberOfSpikes { get; set; }

        public override string DoSound()
        {
            return "Hedgehog sound: Peep";
        }

    }
    class Worm : Animal
    {
        public bool IsPoisonous { get; set; }
        public override string DoSound()
        {
            return "Worm sound: Wriggling";
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
    }
    class Wolf : Animal
    {
        public double PawSize { get; set; }
        public override string DoSound()
        {
            return "Wolf sound: Howl";
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
    }

    class Flamingo : Bird
    {
        public bool HasPinkLegs { get; set; } = true;
    }

    class Swan : Bird
    {
        public bool EatsFish { get; set; }
    }

    // Fråga 13: Om samtliga fåglar behöver ett nytt attribut lägger vi det i klassen Bird
    // Fråga 14: Om alla djur behöver det nya attributet lägger vi det i klassen Animal

    
}
