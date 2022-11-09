using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }


        public abstract void DoSound();
        public Animal()
        {

        }
    }

    class Horse:Animal
    {
        public int HoofSize { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Horse sound: Neigh");
        }
    }

    class Dog : Animal
    {
        public string FurColor { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Dog sound: Wof");
        }

}

    class Hedgehog : Animal
    {
        public int NumberOfSpikes { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Hedgehog sound: Peep");
        }

    }
    class Worm : Animal
    {
        public bool IsPoisonous { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Worm sound: Wriggling");
        }

    }
    class Bird : Animal
    {
        public int WingSpan { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Bird sound: Singing");
        }
    }
    class Wolf : Animal
    {
        public double PawSize { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Wolf sound: Howl");
        }
    }

    class Pelican : Bird
    {
        public int MyProperty { get; set; }
    }

    class Flamingo : Bird
    {
        public bool HasPinkLegs { get; set; }
    }

    class Swan : Bird
    {
        public int MyProperty { get; set; }
    }



}
