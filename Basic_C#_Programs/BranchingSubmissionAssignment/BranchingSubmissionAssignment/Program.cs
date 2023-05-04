using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");  // Prints opening line
            Console.WriteLine("Please enter your package weight: ");  // Prompts the user for their package's weight
            decimal pkgWeight = Convert.ToDecimal(Console.ReadLine());  // Stores the package weight as decimal pkgWeight

            if (pkgWeight > 50)  // Branch 1: If the package weight is over 50 the the program comes to an end
            {
                Console.WriteLine("This package is too heavy to be shipped via Package Express. Have a good day!"); // Alerts the user that the package is to heavy and ends the program.
                Console.ReadLine();  // Keeps the window open until the user takes an action.
            }
            else  // Branch 1: If the package weight is under 50, the program continues and prompts the user for more information
            {
                Console.WriteLine("Please enter your package width: ");  // Prompts the user for their package's width
                decimal pkgWidth = Convert.ToDecimal(Console.ReadLine());  // Stores the package width as decimal pkgWidth
                Console.WriteLine("Please enter your package height: ");  // Prompts the user for their package's height
                decimal pkgHeight = Convert.ToDecimal(Console.ReadLine());  // Stores the package height as decimal pkgHeight
                Console.WriteLine("Please enter your package length: ");  // Prompts the user for their package's length
                decimal pkgLength = Convert.ToDecimal(Console.ReadLine());  // Stores the package weight as decimal pkgWeight

                if (pkgWidth + pkgHeight + pkgLength > 50)  // Branch 2: If the sum of the dimensions is greater than 50, the program ends
                {
                    Console.WriteLine("This package is too large to be shipped via Package Express. Have a good day!");  // Alerts the usert that the package is to large and ends the program
                    Console.ReadLine();  // Keeps the window open until the user takes an action
                }
                else  // Branch 2: If the package is an acceptable size, the program continues and calculates the price quote
                {
                    decimal calc = (pkgWidth * pkgHeight * pkgLength * pkgWeight) / 100;  // Calculates the price
                    decimal pkgQuote = Math.Round(calc, 2);  // Rounds price to the nearest cent
                    Console.WriteLine("Your estimated total for shipping this package is: $" + (String.Format("{0:0.00}", pkgQuote)) + ". Thank you!");  // Prints the price for the user
                    Console.ReadLine();  // Keeps the window open until the user takes an action
                };
            }

        }
    }
}
