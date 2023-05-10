using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsSubmissionAssignment
{
    public class Person  // Create Person class
    {
        public string FirstName { get; set; }  // Creates FirstName property   
        public string LastName { get; set; }  // Creates LastName property

        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);  // Prints person's full name to the console.
        }
        
    }
}
