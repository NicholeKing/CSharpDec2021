using System;

namespace classesDay2Demo
{
    public class Warlock : Character, ICastMagic
    {
        public int mana {get;set;}
        public Warlock(string n) : base(n)
        {
            name = n;
            strength = 8;
            intelligence = 18;
            mana = 200;
        }

        public void castSpell(string move)
        {
            Console.WriteLine($"{name} casts {move}!");
        }

        public override void attack()
        {
            Console.WriteLine($"{name} launched an attack!");
        }
    }
}