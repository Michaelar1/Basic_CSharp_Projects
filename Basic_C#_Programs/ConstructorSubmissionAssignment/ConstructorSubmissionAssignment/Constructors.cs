using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmissionAssignment
{
    class Person
    {
        public string name;  // Create two chained constructors
        public string address;
        public Person(string name) : this(name, "739 Willet Rd")
        {

        }
        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
    }
}
