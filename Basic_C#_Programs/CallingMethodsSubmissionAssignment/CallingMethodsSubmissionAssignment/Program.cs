using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer: ");  // Prompts user to enter an integer
            int input = Convert.ToInt32(Console.ReadLine());  // Stores integer as int variable input
            Console.WriteLine(input + " plus five equals " + Operations.Adding(input));  // Call the Adding Operation method and print to console
            Console.WriteLine(input + " times ten equals " + Operations.Multiplying(input));  // Call the Multiplying Operation method and print to console
            Console.WriteLine(input + " minus three equals " + Operations.Subtract(input));  // Call the Subtract Operation method and print to console
            Console.ReadLine();  // Keeps program open until user takes another action.
          
        }
    }
}
