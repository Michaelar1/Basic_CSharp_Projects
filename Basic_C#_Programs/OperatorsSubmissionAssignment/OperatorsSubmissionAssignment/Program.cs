using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();  // Create new employee
            employee.FirstName = "John";
            employee.LastName = "Smith";
            employee.ID = 111;

            // Test false -- Create different employee
            //Employee employee1 = new Employee(); 
            //employee1.FirstName = "Jane";
            //employee1.LastName = "Doe";
            //employee1.ID = 222;

            // Test true - Create same employee
            Employee employee1 = new Employee();
            employee1.FirstName = "Jon";  // Changed spelling of first name to make sure program is comparing just the ID
            employee1.LastName = "Smith";
            employee1.ID = 111;

            if (employee == employee1)  // If/else loop to print to the console whether or not these are the same employees
            {
                Console.WriteLine("These are the same employee.");
            }
            else
            {
                Console.WriteLine("These are two different employees.");
            }
            Console.ReadLine();
        }
    }
}
