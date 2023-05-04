using System;
using System.Collections.Generic;

  class Program
    {
    static void Main(string[] args)
    {
        string[] stringArray = { "stingray", "Hello!", "puppies", "outside" };  // Create a string array

        Console.WriteLine("Please choose a number 0-3");  // Prompts the user to choose the index from the array
        int stringIndex = Convert.ToInt32(Console.ReadLine());  // Stores the number chosen as stringIndex
        if (stringIndex <= 3)  // If the user chooses a valid number, the program returns the string at that index
        {
            Console.WriteLine(stringArray[stringIndex]);
        }
        else  // If the user chooses an invalid number, the program throws an error message
        {
            Console.WriteLine("You did not choose a number between 0 and 3.");
        }

        int[] intArray = { 5, 12, 9, 45, 42, 65, 89, 77 };  // Creates integer array

        Console.WriteLine("Please Choose a number 0-7.");  // Prompts the user to choose the index from the array
        int intIndex = Convert.ToInt32(Console.ReadLine());  // Stores the number chosen as intIndex
        if (intIndex <= 7)  // If the user chose a valid number, the program returns the number at that index
        {
            Console.WriteLine(intArray[intIndex]);
        }
        else  // If the user chose an invalid number, the program throws an error message.
        {
            Console.WriteLine("You did not choose a number between 0 and 7.");
        }

        List<string> stringList = new List<string>();  // Create stringList and add values
        stringList.Add("Hello, there!");
        stringList.Add("Hi!");
        stringList.Add("Bonjour!");
        stringList.Add("Konnichiwa!");
        stringList.Add("Goddag!");
        stringList.Add("Hej!");
        stringList.Add("Guten Tag!");

        Console.WriteLine("Please choose a number 0-6");  // Prompts the user to choose an index from the list
        int listIndex = Convert.ToInt32(Console.ReadLine());  // Stores the number chosen as listIndex

        if (listIndex <= 6)  // If the user chose a valid number, the program will return the string at that index
        {
            Console.WriteLine(stringList[listIndex]);
        }
        else  // If the user chose an invalid number, the program will throw an error message
        {
            Console.WriteLine("You did not choose a number from 0 to 6");
        }
        Console.ReadLine();  // Keeps the window open until the user takes another action.
        }
    }


