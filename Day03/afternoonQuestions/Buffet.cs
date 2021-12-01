using System;
using System.Collections.Generic;

namespace afternoonQuestions
{
    public class Buffet
    {
        public List<Food> Menu;
        
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Pizza", 800, true, false),
                new Food("Chicken", 300, true, true),
                new Food("Broccoli", 100, false, false),
                new Food("Cheese", 800, true, false),
                new Food("Pizza", 800, true, false),
                new Food("Pizza", 800, true, false),
                new Food("Pizza", 800, true, false),
                new Food("Pizza", 800, true, false)
            };
        }

        public void showMenu()
        {
            foreach(Food f in Menu)
            {
                Console.WriteLine(f.Name);
            }
        }
        
        // public Food Serve()
        // {
        // }
    }
}