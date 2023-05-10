using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    public class Employee : Person  // Create Employee class which inherits from Person Class
    {
        public override void SayName()  // Implement SayName() within Employee class
        {
            base.SayName();
        }
    }
}
