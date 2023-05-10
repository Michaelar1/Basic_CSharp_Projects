using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();  // Instantiate Employee object
            employee.FirstName = "Sample";  // Set FirstName as "Sample"
            employee.LastName = "Student";  // Set LastName as "Student"

            employee.SayName();  // Call SayName() method

            Employee IQuittable = new Employee();  // Create an object of type IQuittable 
            employee.FirstName = "John"; 
            employee.LastName = "Smith";
            employee.Quit(employee);  // Call Quit() on IQuittable object
            Console.ReadLine();
        }
    }
}
