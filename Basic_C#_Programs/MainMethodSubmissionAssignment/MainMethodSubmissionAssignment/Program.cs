using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int toAdd = 22;  // Create int toAdd
            int intAddResult = Math.Adding(toAdd);  // Call Adding method from Math and pass in toAdd integer.
            Console.WriteLine(intAddResult);  // Print result from this method to the console.

            decimal decToAdd = 22.22m;  // Create decimal decToAdd
            decimal decAddResult = Math.Adding(decToAdd);  // Call overload Adding method from Math and pass in decToAdd decimal.
            Console.WriteLine(decAddResult);  // Print result from this overload method to the console.

            string strToAdd = "22";  // Create string strToAdd
            int strAddResult = Math.Adding(strToAdd);  // Calls overload Adding method from Math and pass in strToAdd string 
            Console.Write(strAddResult);  // Print result from this overload method to the console

            Console.ReadLine();  // Keeps program open until the user takes another action.
        }
    }
}
