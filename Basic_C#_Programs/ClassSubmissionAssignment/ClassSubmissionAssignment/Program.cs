using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please enter an integer: ");  // Prompts user for an integer
            int dividend = Convert.ToInt32(Console.ReadLine());  // Saves integer to int variable dividend
            Math.Divide(dividend);  // Calls Divide method and passes parameter variable Dividend

            int x;
            int y;
            Math.Addition(out x,out y); // Passes x an
            Console.WriteLine("x is now " + x);
            Console.WriteLine("y is now " + y);
            

           
            Console.WriteLine(Math.Divide(56, 2));  // Calls overload Divide Method


            Console.ReadLine();

        }
    }
}
