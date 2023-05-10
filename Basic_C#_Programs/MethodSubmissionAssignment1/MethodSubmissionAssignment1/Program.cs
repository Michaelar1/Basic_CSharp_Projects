using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Math.Adding(5, 8);  // Call Math.Adding Class, passing in parameters

           
            Math.Adding(firstParameter: 9, secondParameter: 15);  // Call Math.Adding Class, specifying parameters by name
            
            Console.ReadLine();
        }
    }
}
