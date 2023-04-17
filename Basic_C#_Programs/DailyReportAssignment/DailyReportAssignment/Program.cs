using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \nStudent Daily Report");
            // Program requests the name of the student and saves the input as the string variable studentName.
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();
            // Program asks the student what course they are on and saves the input as string variable courseName.
            Console.WriteLine("Hello, " + studentName + "! What course are you on?");
            string courseName = Console.ReadLine();
            // Program asks the student what page number in their course they are on and saves it as integer variable pageNumber.
            Console.WriteLine("What page number in " + courseName + " are you on?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            // Program asks the student if they need help with anything and saves the input as boolean variable needHelp.
            Console.WriteLine("Excellent! Do you need help with anything? Please answer \"true\" or \"false\".");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());
            // Program asks the student if they had any positive experiences and stores the input as string variable positiveExperience.
            Console.WriteLine("Thank you for letting us know! Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperience = Console.ReadLine();
            // Program asks the student for feedback and stores it as string variable feedback.
            Console.WriteLine("We're so glad to hear it! Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            // Program asks the student how many hours they studied today and saves it as the integer variable hoursStudied.
            Console.WriteLine("Thank you for sharing! How many hours you studied today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());
            // Program thanks the student and lets them know that an Instructor will get back to them.
            Console.WriteLine("Wow! Great job! \nThank you for your answers. An Instructor will respond to this shortly. \nHave a great day!");
            // This keeps the program from closing out until the user takes action to do so.
            Console.ReadLine();
        }
    }
}
