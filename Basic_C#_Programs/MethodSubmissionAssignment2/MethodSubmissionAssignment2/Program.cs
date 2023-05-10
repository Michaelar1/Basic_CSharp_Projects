using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Math obj = new Math();  // Instantiate Math Class as object
            Console.WriteLine("Please enter an integer: ");  // Prompt user for an integer
            int multX = Convert.ToInt32(Console.ReadLine());  // store integer as int multX
            Console.WriteLine("Please either enter an integer or simply press enter to continue: ");  // Prompt user for another integer or to press enter to use default
            try  // If user enters a second integer, it will pass both parameters to the method
            {
                int multY = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(obj.Multiply(multX, multY));
                
            }
           catch  // Else, the method will accept the first parameter and use the default parameter as the second integer
            {
                Console.WriteLine(obj.Multiply(multX));
            }
     

            Console.ReadLine();
        }
    }
}
