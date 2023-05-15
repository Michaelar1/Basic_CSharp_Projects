using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmissionAssignment
{
    class Constructors
    {
        public string name;  // Create two chained constructors
        public string address;
        public void Person(string name) : this(address, "739 Willet Rd")
        {

        }
        public void Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
    }
}
