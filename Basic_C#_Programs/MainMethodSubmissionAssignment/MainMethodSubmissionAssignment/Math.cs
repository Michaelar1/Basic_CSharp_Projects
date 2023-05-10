using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmissionAssignment
{
    public class Math  // Create Class Math
    {
        public static int Adding(int x)  // Create addition method
        {
            return x + 73;
        }
        public static int Adding(decimal x)  // Create overload method of adding that uses decimal data types
        {
            int y = Convert.ToInt32(x + 73.37m);
            return y;
        }

        public static int Adding(string input) // Create overload method of adding method that will take a string.
        {
            int x = Convert.ToInt32(input);
            return x + 73;
        }
    }
}
