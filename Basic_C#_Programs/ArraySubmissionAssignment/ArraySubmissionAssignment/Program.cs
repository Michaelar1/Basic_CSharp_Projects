using System;
using System.Collections.Generic;

  class Program
    {
    static void Main(string[] args)
    {
        string[] stringArray = { "stingray", "Hello!", "puppies", "outside" };

        Console.WriteLine("Please choose a number 0-3");
        int stringIndex = Convert.ToInt32(Console.ReadLine());
        if (stringIndex <= 3)
        {
            Console.WriteLine(stringArray[stringIndex]);
        }
        else
        {
            Console.WriteLine("You did not choose a number between 0 and 3.");
        }

        int[] intArray = { 5, 12, 9, 45, 42, 65, 89, 77 };

        Console.WriteLine("Please Choose a number 0-7.");
        int intIndex = Convert.ToInt32(Console.ReadLine());
        if (intIndex <= 7)
        {
            Console.WriteLine(intArray[intIndex]);
        }
        else
        {
            Console.WriteLine("You did not choose a number between 0 and 7.");
        }

        List<string> stringList = new List<string>();
        stringList.Add("Hello, there!");
        stringList.Add("Hi!");
        stringList.Add("Bonjour!");
        stringList.Add("Konnichiwa!");
        stringList.Add("Goddag!");
        stringList.Add("Hej!");
        stringList.Add("Guten Tag!");

        Console.WriteLine("Please choose a number 0-6");
        int listIndex = Convert.ToInt32(Console.ReadLine());

        if (listIndex <= 6)
        {
            Console.WriteLine(stringList[listIndex]);
        }
        else
        {
            Console.WriteLine("You did not choose a number from 0 to 6");
        }
        Console.ReadLine();
        }
    }


