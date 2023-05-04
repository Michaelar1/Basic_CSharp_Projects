using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsConsoleAppSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");  // Promts user for their name
            string name = Console.ReadLine();  // Stores name as string variable name
            Console.WriteLine("Hello, " + name +"! What is your favorite color?");  // Prompts user for their favorite color
            string favColor = Console.ReadLine();  // Stores user's favorite color as string variable favColor

            while (favColor != "brown")  // In any case that the favorite color is not brown, the program tells the user that it is an excellent favorite color
            {
                Console.WriteLine("That is an excellent favorite color!");
                break;  // Continues the program
            }
            Console.WriteLine("Pick a number from 1-10!");  // Prompts user to pick a number from 1-10
            int num = Convert.ToInt32(Console.ReadLine());  // Stores number as integer variable num
            do  // Do-While Loop: While the number picked is not 9, the program continues to run to let the user guess another number.
            {
                case 1:
                    Console.WriteLine("You chose 1. That is not the correct number. Try again!");
                    Console.WriteLine("Pick a number from 1-10!");
                    int num = Convert.ToInt32(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("You chose 2. That is not the correct number. Try again!");
                    Console.WriteLine("Pick a number from 1-10!");
                    int num = Convert.ToInt32(Console.ReadLine());
                    break;
                 case 3:
                    Console.WriteLine("You chose 3. That is not the correct number. Try again!");
                    Console.WriteLine("Pick a number from 1-10!");
                    int num = Convert.ToInt32(Console.ReadLine());
                    break;
                 case 4:
                    Console.WriteLine("You chose 4. That is not the correct number. Try again!");
                    Console.WriteLine("Pick a number from 1-10!");
                    int num = Convert.ToInt32(Console.ReadLine());
                    break;
                 case 5:
                    Console.WriteLine("You chose 5. That is not the correct number. Try again!");
                    Console.WriteLine("Pick a number from 1-10!");
                    int num = Convert.ToInt32(Console.ReadLine());
                    break;
                 case 6:
                    Console.WriteLine("You chose 6. That is not the correct number. Try again!");
                    Console.WriteLine("Pick a number from 1-10!");
                    int num = Convert.ToInt32(Console.ReadLine());
                    break;
                 case 7:
                    Console.WriteLine("You chose 7. That is not the correct number. Try again!");
                    Console.WriteLine("Pick a number from 1-10!");
                    int num = Convert.ToInt32(Console.ReadLine());
                    break;
                 case 8:
                    Console.WriteLine("You chose 8. That is not the correct number. Try again!");
                    Console.WriteLine("Pick a number from 1-10!");
                    int num = Convert.ToInt32(Console.ReadLine());
                    break;
                 case 9:
                    Console.WriteLine("You chose 9. You guessed correctly! You win!");
                    break;
                 case 10:
                    Console.WriteLine("You chose 10. That is not the correct number. Try again!");
                    Console.WriteLine("Pick a number from 1-10!");
                    int num = Convert.ToInt32(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("You did not choose a number from 1-10. Try again!");
                    Console.WriteLine("Pick a number from 1-10!");
                    int num = Convert.ToInt32(Console.ReadLine());
                    break;
            }
            while (num != 9);

            Console.ReadLine();
        }
    }
}
