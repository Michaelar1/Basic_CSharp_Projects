using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;  // Stores DateTime.Now as variable now.
            Console.WriteLine("It is currently: " + now);  // Prints to the console the current date and time
            Console.WriteLine("\nPlease enter a number: ");  // Prompts the user for a number
            int num = Convert.ToInt32(Console.ReadLine());  // Stores the number as int variable num
            TimeSpan span = new TimeSpan(0, num, 0, 0);  // Creates a TimeSpan where num is now an amount of hours
            DateTime later = now.Add(span);  // Adds the TimeSpan span to now to create the variable later, where the number of hours passed is the number input by the user
            Console.WriteLine("In {0} hours, it will be {1}.", num, later);  // Prints the result to the console.
            Console.ReadLine();
        }
    }
}
