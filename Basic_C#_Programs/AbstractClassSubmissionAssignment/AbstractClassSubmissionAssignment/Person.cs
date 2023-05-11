using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    public abstract class Person  // Create abstract class Person
    {
        public string FirstName { get; set; }  // Give person string property FirstName
        public string LastName { get; set; }  // Give person string property LastName

        public abstract void SayName();  // Give person method SayName()
        
    }
}
