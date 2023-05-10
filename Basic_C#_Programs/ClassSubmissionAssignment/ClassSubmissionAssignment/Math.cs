using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    public static class Math  // Declare class as static
    {
        public static void Divide (int x)  // Creates a void method that inputs an integer and outputs that integer divided by 2
        {
            Console.WriteLine(x / 2);
        }

        public static void Addition(out int x, out int y)  // Create a method with output parameters
        {
            x = 42;
            y = 9;
            x += x;
            y += y;
            
        }

        public static int Divide(int x, int y)  // Overloads a method (Divide)
        {
            return x / y;
        }
    }
}
