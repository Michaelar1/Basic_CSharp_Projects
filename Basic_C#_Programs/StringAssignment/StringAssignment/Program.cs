using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = ("Michaela");
            string age = ("32");
            string learn = ("C#");

            string concatenate = ("Hello, my name is " + name + ", I am " + age + " years old and I am learning " + learn + ".");
            Console.WriteLine(concatenate);

            Console.WriteLine("There are " + name.Length + " letters in my name.");

            StringBuilder sb = new StringBuilder();

            sb.Append("I have the cutest dog, by the way.");
            sb.Append("His name is Strider; we named him after Aragorn in Lord of the Rings.");
            sb.Append("He is a year old and is full of energy.");
            sb.Append("He is mostly Golden Retriever with Husky mixed in and just a little bit of English Shepherd.");
            sb.Append("He can be rambunctious, but we love him just the same.");
        }
    }
}
