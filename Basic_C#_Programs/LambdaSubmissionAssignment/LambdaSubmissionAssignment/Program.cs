using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()  // Create a list of 10 employees, two of whom have FirstName = Joe
            {
                new Employee() {FirstName = "Joe", LastName = "Schmoe", Id = 1},
                new Employee() {FirstName = "Michaela", LastName = "Rehm", Id = 2},
                new Employee() {FirstName = "John", LastName = "Smith", Id = 3},
                new Employee() {FirstName = "Jane", LastName = "Doe", Id = 4},
                new Employee() {FirstName = "Alice", LastName = "Wonderland", Id = 5},
                new Employee() {FirstName = "Hans", LastName = "Andersen", Id = 6},
                new Employee() {FirstName = "Matthew", LastName = "Swartz", Id = 7},
                new Employee() {FirstName = "Sadie", LastName = "Hawkins", Id = 8},
                new Employee() {FirstName = "Odin", LastName = "Allfather", Id = 9},
                new Employee() {FirstName = "Joe", LastName = "Dirt", Id = 10}
            };

            List<Employee> Joe = new List<Employee>();  // Create a new list of all the employees named Joe with a foreach loop
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    Joe.Add(employee);
                }
            }

            foreach (Employee employee in Joe)  // Print results of first Joe list
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            List<Employee> Joe2 = employees.Where(x => x.FirstName == "Joe").ToList();  // Create a new list of all the employees named Joe with a lambda function
            foreach (Employee employee in Joe2)  // Print Joe2 list to console
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            List<Employee> Ids5 = employees.Where(x => x.Id > 5).ToList();  // Create a list of all employees with an ID greater than 5
            Console.WriteLine("Employees whose ID number is greater than 5: ");
            foreach (Employee employee in Ids5)  // Print Id5 list to console
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }
            Console.ReadLine();
        }
    }
}
