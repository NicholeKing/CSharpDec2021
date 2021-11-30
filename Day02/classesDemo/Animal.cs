using System;

namespace classesDemo
{
    public class Animal
    {
        public string species;
        public int numLegs;
        private double weight;
        public double Weight
        {
            get {return weight;}
        }
        public bool isMammal;
        public string color;
        public int numEyes = 0;

        public Animal(string sp, int legs, double wgt, bool isMam, string clr)
        {
            species = sp;
            numLegs = legs;
            weight = wgt;
            isMammal = isMam;
            color = clr;
        }

        public Animal(string sp, double wgt, string clr)
        {
            species = sp;
            numLegs = 4;
            weight = wgt;
            isMammal = true;
            color = clr;
        }

        public Animal(string sp, double wgt, bool isMam, string clr)
        {
            species = sp;
            numLegs = 2;
            weight = wgt;
            isMammal = isMam;
            color = clr;
        }

        public Animal(string sp, int legs, double wgt, string clr)
        {
            species = sp;
            numLegs = legs;
            weight = wgt;
            isMammal = false;
            color = clr;
        }

        // public Animal(string clr = "none", int numLegs = 0)
        // {
        //     species = "fjdis";
        //     numLegs = numLegs;
        //     weight = 12.23;
        //     isMammal = true;
        //     color = clr;
        // }

        // Methods that the animal can do
        public virtual void ShowStats()
        {
            Console.WriteLine("*******************");
            Console.WriteLine($"Species:   {species}");
            Console.WriteLine($"# of Legs: {numLegs}");
            Console.WriteLine($"Weight:    {weight} lbs");
            Console.WriteLine($"Mammal:    {isMammal}");
            Console.WriteLine($"Color:     {color}");
        }

        public void feed()
        {
            weight += 1.2;
        }
    }
}