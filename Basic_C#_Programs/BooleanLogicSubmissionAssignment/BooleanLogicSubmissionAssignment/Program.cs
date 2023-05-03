using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval Questions");  // Prints to console "Car Insurance Approval Questions"
            Console.WriteLine("\nWhat is your age?: ");  // Prompts user for their age
            int age = Convert.ToInt32(Console.ReadLine());  // Stores age as int variable age
            Console.WriteLine("\nHave you ever had a DUI? (Please enter \"true\" or \"false\": )");  // Asks user if they have ever had a DUI
            bool dui = Convert.ToBoolean(Console.ReadLine());  // Stores results as bool variable dui
            Console.WriteLine("\nHow many speeding tickets do you have?: ");  // Prompts user for the number of speeding tickets they have.
            int tickets = Convert.ToInt32(Console.ReadLine());  // Stores the number of tickets as int variable tickets

            bool apprAge = age > 15; // Compares age with approval age - if the age is over 15, the bool variable apprAge will be true
            bool apprDUI = dui == false;  // Compares DUI value - if the bool value of dui is false, bool variable apprDUI will be true
            bool apprTickets = tickets <= 3;  // Compares number of tickets with approval number of tickets - if the number of tickets is less than or equal to 3, the bool variable apprTickets will be true

            bool approval = (apprAge && apprDUI && apprTickets); // Uses boolean logic to make sure all values are true, else the approval value will be false
            Console.WriteLine("Qualified? \n" + approval); // Prints whether the applicant is qualified
            Console.ReadLine();  // Keeps program open until the user takes another action.


        }
    }
}
