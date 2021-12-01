using System;
using System.Collections.Generic;

namespace afternoonQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet b1 = new Buffet();
            // b1.showMenu();

            // Step one: Create a card class
            // Step two: create a deck
            char heart = (char)9829;
            string[] suits = new string[] {"Heart", "Diamond", "Spade", "Club"};
            string[] cardVals = new string[] {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            List<string> Deck = new List<string>();
            for(int i = 0; i < cardVals.Length; i++)
            {
                for(int j = 0; j < suits.Length; j++)
                {
                    // add Cards to the list
                    string ourCard = cardVals[i] + suits[j] + (i + 1).ToString();
                    Deck.Add(ourCard);
                }
            }

            foreach(string d in Deck)
            {
                Console.WriteLine(d);
            }
            
            Console.WriteLine(heart);
        }
    }
}
