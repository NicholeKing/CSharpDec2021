using System;

namespace classesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal("Lion", 250.5, "yellow");
            // Console.WriteLine(a.species);
            a.ShowStats();
            Animal b = new Animal("House cat", 4, 8.4, true, "white");
            // b.species = "Red panda";
            b.ShowStats();
            Console.WriteLine(b.Weight);
            b.feed();
            Console.WriteLine(b.Weight);
            // Imagine you're playing a video game
            // Your character has a health amount and your enemy has a health amount
            // When you get hit, you take damage - your health goes down
            // You have a health variable that you are able to modify
            // What if your enemy keeps resetting their health to 100? 
            // What if your enemy makes it so their hits take your health down to 0?
        }
    }
}
