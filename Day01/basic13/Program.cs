using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {1,2,3,4,5};
            int[] maxArray = new int[] {-2,-3,-4,-1,-5};
            int[] avg = new int[] {2,10,3};
            // Console.WriteLine("Hello World!");
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            // LoopArray(nums);
            // FindMax(maxArray);
            // GetAverage(avg);
            // OddArray();
            GreaterThanY(nums, 3);
        }

        // All my functions go here
        public static void PrintNumbers()
        {
            // Print all of the integers from 1 to 255.
            for(int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintOdds()
        {
            // Print all of the odd integers from 1 to 255.
            for(int i = 1; i <= 255; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void PrintSum()
        {
            // Print all of the numbers from 0 to 255, 
            // but this time, also print the sum as you go. 
            // For example, your output should be something like this:
            
            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3
            int total = 0;
            for(int i = 0; i <= 255; i++)
            {
                total+=i;
                Console.WriteLine($"New Number: {i} Sum: {total}");
            }
        }

        public static void LoopArray(int[] numbers)
        {
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
        }

        public static int FindMax(int[] numbers)
        {
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
            int max = numbers[0];
            if(numbers.Length == 1)
            {
                max = numbers[0];
            }
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine(max);
            return max;
        }

        public static void GetAverage(int[] numbers)
        {
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum+=numbers[i];
            }
            Console.WriteLine(sum/numbers.Length);
        }

        public static List<int> OddArray()
        {
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
            List<int> myArray = new List<int>();
            for(int i = 1; i <= 255; i++)
            {
                if(i % 2 != 0)
                {
                    myArray.Add(i);
                }
            }
            // Console.WriteLine(myArray);
            foreach(int i in myArray)
            {
                Console.WriteLine(i);
            }
            return myArray;
        }

        public static int GreaterThanY(int[] numbers, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
            int count = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(y < numbers[i])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            return count;
        }
    }
}
