using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week: ");  // Prompts the user for the current day of the week
            string dayInput = Console.ReadLine();  // Stores input as string variable dayInput

            try // Wrap parsing in try/catch block
            {
                Days day = (Days)Enum.Parse(typeof(Days), dayInput);  // Converts the string to an enum
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }
    }
}
