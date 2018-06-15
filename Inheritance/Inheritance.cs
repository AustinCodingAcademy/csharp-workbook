using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bluejay = new Bird();
            NonFlyingBird pengi = new NonFlyingBird();

            Console.WriteLine("Hello World!");
        }
    }

    class Animal
    {
        public void eat() {
            Console.WriteLine("Nom, nom, nom.");
        }

        public void breath() {
            Console.WriteLine("Breath in, breath out.");
        }
    }

    class Vertebrate : Animal
    {
        public bool backbone = true;
    }

    class Invertebrate : Animal
    {
        public bool backbone = false;
    }

    class Bird : Vertebrate
    {
        public bool feathers = true;

        public virtual void fly()
        {
            Console.WriteLine("Flap, flap, flap");
        }
    }

    class NonFlyingBird : Bird
    {
        public override void fly()
        {
            Console.WriteLine("No dice.");
        }
    }
}
