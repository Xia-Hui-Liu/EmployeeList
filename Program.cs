using System;
using System.Collections.Generic;

namespace EmployeeList
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            while (true)
            {
                Console.WriteLine("Welcome to the personnel register! ");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. View personnel records");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Select an action:");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddEmployee(employees);
                        break;
                    case "2":
                        ShowPersonalRegister(employees);
                        break;
                    case "3":
                        Console.WriteLine("Program ends ...");
                        return;
                    default:
                        Console.WriteLine("Invalid selection. Try again");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddEmployee(List<Employee> employees)
        {
            Console.WriteLine("Enter the name of the employee:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the salary of the employee:");
            double salary;

            while (!double.TryParse(Console.ReadLine(), out salary))
            {
                Console.WriteLine("Invalid entry. Please enter a valid salary.");
                Console.WriteLine("Enter salary for the employee:");
            }

            // Create a new instance of the employee class and add to the registry
            employees.Add(new Employee { Name = name, Salary = salary });

            Console.WriteLine("Employee added to registry!");
        }

        static void ShowPersonalRegister(List<Employee> employees)
        {
            Console.WriteLine("Personalregister:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary}");
            }
        }
    }
}
