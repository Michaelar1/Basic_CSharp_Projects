using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();  // Instantiates new employee object
            employee.FirstName = "Sample";  // Sets FirstName to "Sample"
            employee.LastName = "Student";  // Sets LastName to "Student

            employee.SayName();  // Calls SayName() method for new employee.

            Console.ReadLine();
        }
    }
}
