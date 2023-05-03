using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");  // Prints Anonymous Income Comparisone Program
            Console.WriteLine("Person1: \nWhat is their hourly rate?: ");  // Promts the user for the hourly rate of Person 1
            decimal rate1 = Convert.ToDecimal(Console.ReadLine());  // Stores the hourly rate as decimal variable rate1
            Console.WriteLine("How many hours do they work in a week?: ");  // Prompts the user for hours that Person 1 works in a week
            decimal hours1 = Convert.ToDecimal(Console.ReadLine());  // Stores the hours as decimal variable hours1
            decimal salary1 = rate1 * hours1 * 52.0m;  // Calculates Person 1's yearly salary and stores it as decimal variable salary1

            Console.WriteLine("\n\nPerson 2: \nWhat is their hourly rate?: ");  // Prompts the user for the hourly rate of Person 2
            decimal rate2 = Convert.ToDecimal(Console.ReadLine());  // Stores the hourly rate as decimal variable rate2
            Console.WriteLine("How many hours do they work in a week?: ");  // Prompts the user for the hours that Person 2 workes in a week
            decimal hours2 = Convert.ToDecimal(Console.ReadLine());  // Stores the hours as decimal variable hours2
            decimal salary2 = rate2 * hours2 * 52.0m;  // Calculates Person 2's yearly salary and stores it as decimal variable salary2

            Console.WriteLine("\nAnnual salary of Person 1: \n$" + Convert.ToString(salary1));  // Prints the annual salary of Person1
            Console.WriteLine("\n\nAnnual salary of Person 2: \n$" + Convert.ToString(salary2));  // Prints the annual salary of Person 2
            Console.WriteLine("Does Person 1 make more money than Person 2?");  // Prints "Does Person 1 make more money than Person 2?"
            bool compare = salary1 > salary2;  // Compares the salaries and stores whether salary1 > salary2 as a boolean value "compare"
            Console.WriteLine(compare);  // Prints boolean value
            Console.ReadLine();  // Keeps program open until user takes another action.
        }
    }
}
