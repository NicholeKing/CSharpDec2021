using System;

namespace classesDemo
{
    public class Bird : Animal
    {
        public bool canFly;
        public Bird(string sp, int numLegs, double wgt, string clr, bool fly) : base(sp, numLegs, wgt, clr)
        {
            canFly = fly;
        }
    }
}