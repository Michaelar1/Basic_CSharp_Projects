using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            //int currentTemperature = 70;
            //int roomTemperature = 70;

            ////if(currentTemperature == roomTemperature)
            ////{
            ////    Console.WriteLine("It is exactly room temperature.");
            ////}
            ////else if (currentTemperature > roomTemperature)
            ////{
            ////    Console.WriteLine("It is warmer than room temperature.");
            ////}
            ////else if (roomTemperature > currentTemperature)
            ////{
            ////    Console.WriteLine("It is cooler than room temperature.");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("It is not exactly room temperature.");
            ////}

            //string comparisonResult = currentTemperature == roomTemperature ? "It is room temp." : "It is not room temp.";
            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();


            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "You have an awesome favorite number." : "You do not have an awesome favorite number.";

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
