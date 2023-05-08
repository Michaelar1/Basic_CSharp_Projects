using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegersSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> dividends = new List<int>() { 8, 65, 42, 100, 99, 38, 63, 55, 70 };  // Creates a list of dividends
            Console.WriteLine("Please choose an integer: ");  // Prompts the user for a divisor
           
            try
            {
                int divisor = Convert.ToInt32(Console.ReadLine());  // Stores the divisor as int variable divisor.
                foreach (int dividend in dividends)  // Loops through all of the dividends
                {
                    int quotient = dividend / divisor;  // Divides each divident by the divisior and stores it as int variable quotient
                    Console.WriteLine(quotient);  // Prints each quotient
                }
            }
            catch (DivideByZeroException ex)  // Displays error message if user enters zero for the divisor
            {
                Console.WriteLine("You cannot divide by zero.");
            }
            catch (FormatException ex)  // Displays error message is user enters string for the divisor.
            {
                Console.WriteLine("Please be sure to enter whole number integers.");
            }
            catch (Exception ex)  // Displays error message for all other user errors
            {
                Console.WriteLine(ex.Message);
            }
            finally  // Keeps program open until user takes another action.
            {
                Console.ReadLine();
            }
        }
    }
}
