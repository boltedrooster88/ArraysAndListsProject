using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
           
            var numbers = new int [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            foreach (int i in numbers)
            {
                Console.WriteLine($"{i}");
            }
            /* Create two Lists of type int.
             * Name one List "evens"
           
             * Name the other List "odds"
             */
            var evens = new List<int>(numbers);

                    Console.WriteLine("Evens");

            foreach (int i in evens)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i}");
                }
            }

            var odds = new List<int>(numbers);
                    Console.WriteLine("Odd");

            foreach (int i in odds)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine($"{i}");
                }
            }

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }
}
