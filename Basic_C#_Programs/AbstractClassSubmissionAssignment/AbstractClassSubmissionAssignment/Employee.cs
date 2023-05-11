using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    public class Employee : Person, IQuittable  // Create Employee class which inherits from Person Class and IQuittable interface
    {
        public override void SayName()  // Implement SayName() within Employee class
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
        public void Quit(Employee employee)
        {
            Console.WriteLine("{0} {1} quits.", FirstName, LastName);
        }

    }
}
