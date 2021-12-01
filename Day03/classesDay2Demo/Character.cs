using System;

namespace classesDay2Demo
{
    public abstract class Character
    {
        public string name;
        public int strength;
        public int intelligence;
        public int health;

        public Character(string name)
        {
            this.name = name;
            this.strength = 10;
            this.intelligence = 10;
            this.health = 100;
        }

        public void showStats()
        {
            Console.WriteLine("*************");
            Console.WriteLine($"Name:     {name}");
            Console.WriteLine($"Strength: {strength}");
            Console.WriteLine($"Intel:    {intelligence}");
            Console.WriteLine($"Health:   {health}");
        }

        public abstract void attack();
    }
}