using System;
using System.Collections.Generic;

namespace dictionaryPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            // Old arrays:
            // var arr = ["fdsf", "fdsfds", "Fdsfds"];
            Console.WriteLine("Hello World!");
            string[] names = new string[] {"Nichole", "Chris", "Mike", "Shawn"};
            List<string> languages = new List<string>();
            languages.Add("C#");
            languages.Add("Javascript");
            languages.Add("Python");
            languages.Add("Java");
            Dictionary<string,string> myExample = new Dictionary<string, string>();
            // myExample.Add("Name", "Nichole");
            // myExample.Add("Age", "27");
            for(int i = 0; i < names.Length; i++)
            {
                myExample.Add(names[i], languages[rand.Next(languages.Count)]);
            }
            foreach (KeyValuePair<string,string> entry in myExample)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
