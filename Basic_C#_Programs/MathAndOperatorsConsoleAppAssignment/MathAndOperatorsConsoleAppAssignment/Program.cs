using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndOperatorsConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer: ");  // Takes integer input from user
            int mult = Convert.ToInt32(Console.ReadLine());  // Stores input as int variable mult
            int multResult = mult * 50;  // Multiplies mult by 50
            Console.WriteLine(mult.ToString() + " times 50 = " + multResult.ToString());  // Prints result

            Console.WriteLine("Please enter another integer: "); // Takes integer input from user
            int addition = Convert.ToInt32(Console.ReadLine()); // Stores input as int variable addition
            int additionResult = addition + 25;  // Adds 25 to addition
            Console.WriteLine(addition.ToString() + " plus 25 = " + additionResult.ToString());  //Prints result

            Console.WriteLine("Please enter another integer: "); // Takes integer input from user
            double div = Convert.ToDouble(Console.ReadLine());  // Stores input as double variable div
            double divResult = div / 12.5;  // Divides div by 12.5
            Console.WriteLine(div.ToString() + " divided by 12.5 = " + divResult.ToString());  // Prints result

            Console.WriteLine("Please enter another integer: "); // Takes integer input from user
            int compare = Convert.ToInt32(Console.ReadLine());  // Stores input as int variable compare
            bool compareResult = compare > 50;  // Checks if the compare variable is larger than 50
            Console.WriteLine(compareResult); // Prints true or false

            Console.WriteLine("Please enter another integer, this time larger than 7: ");  // Takes integer input from user
            int remainder = Convert.ToInt32(Console.ReadLine());  // Stores input as int variable remainder
            int remainderResult = remainder % 7;  // Finds the remainder when the input is divided by 7
            Console.WriteLine("The remainder when you divide " + remainder.ToString() + " by 7 = " + remainderResult.ToString()); // Prints result
            Console.ReadLine(); // Keeps program open until the user takes another action.

        }
    }
}
