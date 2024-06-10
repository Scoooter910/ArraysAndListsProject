using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int array and populate it with numbers 1-10
            int[] myArray = new int[10];

            for (int i = 0; i < 10; i++)
            {
                myArray[i] = i + 1;
            }
            /* Create a list of type int
             * Name the list "evens"
             */
                List<int> evens = new List<int>();

            /* Create another list of type int
             * Name the list "odds"
             */
                List<int> odds = new List<int>();

            /* Using either a foreach or for loop,
            * iterate through the array you populated with 10 numbers.
            * Inside the scope of the loop,
            * check to see if each number in the array is even or odd.
            * If the number is even, add it to the evens list.
            * If the number is odd, add it to the odds list.
            */
            foreach (int number in myArray) 
            {
                if (number % 2 == 0)
                {
                    evens.Add(number);
                }
                else 
                {
                    odds.Add(number);
                }
             }


            /* Using a foreach loop,
             * display the numbers in your "evens" list
             */
            Console.WriteLine("Evens list");
            foreach (int even in evens)
            {
                Console.WriteLine(even);
            }

            /* Using a for loop,
             * display the numbers in your "odds" list
             */
            Console.WriteLine("Odds list");
            foreach (int odd in odds) 
            {
                Console.WriteLine(odd);
            }
        }

    }
}
