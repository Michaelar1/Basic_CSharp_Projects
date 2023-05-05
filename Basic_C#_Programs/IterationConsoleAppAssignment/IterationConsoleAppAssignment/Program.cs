using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment Part 1
            // Create a one-dimensional array of strings
            string[] greetingArray = { "Hello, ", "Hi, ", "Hey, ", "Ciao, ", "Aloha, ", "Hej, ", "Goddag, ", "Bonjour, ", "Guten Tag, ", "Hola, ", "Konniciwa, " };

            // Ask user to input text
            Console.WriteLine("What is your name?: ");
            string name = Console.ReadLine();

            // Creates a loop that iterates through each string in the array and adds user input
            for (int i = 0; i < greetingArray.Length; i++)
            {
                greetingArray[i] = greetingArray[i] + name;
            }

            // Creates a loop that prints off each string in the loop
            foreach (string greeting in greetingArray)
            {
                Console.WriteLine(greeting);
            }

            // Assignment Part 2
            // Create an infinite loop
            //int i = 0;
            //while (true) - This would infinitely increment and print i. By adding a constraint, this would fix the loop
            //{
            //    Console.WriteLine(i);
            //    i++
            //}

            // Fix the infinite loop
            int j = 0;
            while (j < 11)  // This adds a constraint so that this loop will only run until i=10.
            {
                Console.WriteLine(j);
                j++;
            }

            // Assignment Part 3
            // Write a loop where the comparison used to determine whether to continue iterating is "<"
            int k = 0;
            while (k < 6)
            {
                Console.WriteLine(k);
                k++;
            }

            // Write a loop where the comparison used to determine whether to keep iterating is "<="
            int l = 0;
            while (l <= 5)
            {
                Console.WriteLine(l);
                l++;
            }

            // Assignment Part 4
            //  Write a list of strings where each item in the list is unique
            List<string> names = new List<string>();
            names.Add("Michaela");
            names.Add("Matt");
            names.Add("Tammie");
            names.Add("Larry");
            names.Add("Johnna");
            names.Add("Robert");
            names.Add("Kerrie");
            names.Add("Lily");
            names.Add("Rebecca");
            names.Add("Gabby");
            names.Add("Nick");

            // Ask the user to input text to search for in the list
            Console.WriteLine("\nSearch for a name: ");
            string search = Console.ReadLine();
            bool isNameFound = (!names.Contains(search)) == false;
            
            do
            {
                for (int i=0; i < names.Count; i++)
                {
                    // Write a loop that iterates through the list and then displays the index of the list item that contains the matching text on the screen.
                    if (names.Contains(search))
                    {
                        Console.WriteLine(names.IndexOf(search));
                        isNameFound = true;  // Stops the do-while loop from executing once a match has been found
                        break;  // Stops the for loop from executing once a match has been found
                    }
                    // Add code to check if the user put in text that isn't on the list and tell the user if that is the case
                    else
                    {
                        Console.WriteLine("The name you searched for is not on the list");
                        Console.WriteLine("\nSearch for a name: ");
                        search = Console.ReadLine();
                    }
                }
            }
            while (isNameFound == false);

            // Assignment Part 5
            // Create a list of strings that has at least two identical strings in the list.
            List<string> fruits = new List<string>();
            fruits.Add("cherry");
            fruits.Add("apple");
            fruits.Add("pear");
            fruits.Add("strawberry");
            fruits.Add("blueberry");
            fruits.Add("banana");
            fruits.Add("strawberry");
            fruits.Add("raspberry");
            fruits.Add("blackberry");
            fruits.Add("mango");
            fruits.Add("starfruit");
            fruits.Add("peach");
            fruits.Add("plum");
            fruits.Add("blackberry");
            fruits.Add("cherry");

            // Ask the user to search in the list
            Console.WriteLine("\nSearch for a fruit:");
            string fruitSearch = (Console.ReadLine().ToLower());

            // Write a loop that iterates through the list and then displays the indices of the list item that contains the matching text on the screen.
            if (fruits.Contains(fruitSearch))
            {
                // Create a loop that iterates through the list and then displays the indices of the items matching the search
                for (int i = 0; i < fruits.Count; i++)
                {
                    if (fruitSearch == fruits[i])
                    {
                        Console.WriteLine(fruits[i] + " is at index " + i);
                    }
                }
            }
            else  // Add code to check if the user put in text that isn't on the list and tell the user if that is the case
            {
                Console.WriteLine("The fruit you searched for is not on the list");
            }

            // Assignment Part 6
            // Create a list of strings that has at least two identical strings in it
            List<string> pets = new List<string>();
            pets.Add("dog");
            pets.Add("cat");
            pets.Add("bird");
            pets.Add("dog");
            pets.Add("guinea pig");
            pets.Add("fish");
            pets.Add("reptile");
            pets.Add("rabbit");

            List<string> pets1 = new List<string>();

            // Create a foreach loop that evaluates each item on the list and displays a message showing
            // the string and whether or not it has already appered in the list
            foreach (string pet in pets)
            {
                if (pets1.Contains(pet))
                {
                    Console.WriteLine(pet + " - is a duplicate.");
                }
                else
                {
                    Console.WriteLine(pet + " - is unique.");
                }
                pets1.Add(pet);
            }
            Console.ReadLine();  // Keeps the window open until the user takes another action.
        }
    }
}
