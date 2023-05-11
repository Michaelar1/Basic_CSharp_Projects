using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmissionAssignment
{
    public class Employee
    {
        public string FirstName { get; set; }  // Create FirstName Property
        public string LastName { get; set; }  // Create LastName Property
        public int ID { get; set; }  // Create ID property

        public static bool operator== (Employee employee, Employee employee1)  // Overload == operator to compare employees by ID
        {
            if (employee.ID == employee1.ID)
            {
                 return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator!= (Employee employee, Employee employee1)  // Overload != operator to pair with == operator overload
        {
            if (employee.ID != employee1.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
