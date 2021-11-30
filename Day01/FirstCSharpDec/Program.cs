// import
using System;
using System.Collections.Generic;

// think of namespace like a book in a library
namespace FirstCSharpDec
{
    // class 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my first C# project!");
            // Our code here
            // Anything inside of here is going to run
            // Console.WriteLine(args[0]);
            // name = 7;
            // string
            string name = "Nichole";
            name = "Chris";
            // int
            int num = 29;
            int num2 = 19;
            // bool
            bool isHungry = false;
            // char
            char letter = 'N';
            Console.WriteLine("Your num is " + num + num2);
            Console.WriteLine($"Your num is {num}");
            // Console.WriteLine(myAlgo());
            Random rand = new Random();
            Console.WriteLine(rand.Next(5, 11));
            int[] myArray = new int[] {1,2,3,4,5,6};
            //                         0 1 2 3 4 5
            myArray[2] = 18;
            Console.WriteLine(myArray[2]);

            List<string> names = new List<string>();
            names.Add("Nichole");
            names.Add("Chris");
            // Console.WriteLine(names[0]);
            // Console.WriteLine(names[1]);
            names.Insert(1, "Mike");
            // Console.WriteLine(names[1]);
            names.Remove("Nichole");
            names.RemoveAt(1);
            foreach(string n in names){
                Console.WriteLine(n);
            }
        }

        static int myAlgo()
        {
            return 7;
        }
    }
}
