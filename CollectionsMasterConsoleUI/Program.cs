﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] arrayOf50 = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(arrayOf50);

            //TODO: Print the first number of the array
            Console.WriteLine("First Number: " + arrayOf50[0]);

            //TODO: Print the last number of the array            
            Console.WriteLine("Last Number: " + arrayOf50[arrayOf50.Length - 1]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            
            NumberPrinter(arrayOf50);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            ReverseArray(arrayOf50);//I am not sure that this is what was being requested
            //Array.Reverse(arrayOf50);
            

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");
            
            NumberPrinter(arrayOf50);

            Console.WriteLine("-------------------");
            
            

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            
            ThreeKiller(arrayOf50);
            
            NumberPrinter(arrayOf50);
            
            Console.WriteLine("-------------------");
            

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(arrayOf50);
            
            NumberPrinter(arrayOf50);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            
            List<int> intList = new List<int>();

            //TODO: Print the capacity of the list to the console
            
            Console.WriteLine("Capacity: " + intList.Capacity);
            
            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            
            Populater(intList);

            //TODO: Print the new capacity
            
            Console.WriteLine("New Capacity: " + intList.Capacity);
            

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            
            
            string userNumber = Console.ReadLine();
            int value;
            if (int.TryParse(userNumber, out value))
            {
                NumberChecker(intList, int.Parse(userNumber));
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            
            NumberPrinter(intList);
            
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            
            OddKiller(intList);
            
            NumberPrinter(intList);
            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            
            intList.Sort();
            
            NumberPrinter(intList);
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            
            int[] intListToArray = intList.ToArray();

            //TODO: Clear the list
            
            intList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            foreach (var item in numbers)
            {
                if (numbers[item] % 3 == 0)
                {
                    numbers[item] = 0;
                }
                else if (numbers[item] == 3)
                {
                    numbers[item] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine("Number is present");
            }
            else
            {
                Console.WriteLine("Number is not present");
            }
            
        }

        private static void Populater(List<int> numberList)
        {
            for (int i = 0; i <= 50; i++)
            {
                Random rng = new Random();
                numberList.Add(rng.Next(0, 50)); 
            }
            

        }

        private static void Populater(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Random rng = new Random();
                numbers[i] = rng.Next(0, 50);
            }

        }        

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
