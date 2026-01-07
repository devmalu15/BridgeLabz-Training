using System;

namespace EmployeeManagementSystem.EmployeeManagementSystem
{
    public class EmployeeManagementSystem
    {
        public static void Main(string[] args)
        {
            Employee[] Employees = new Employee[4];

            for (int i = 0; i < Employees.Length; i++)
            {
                Console.WriteLine("\nSelect Employee Type:");
                Console.WriteLine("1. Full Time Employee");
                Console.WriteLine("2. Part Time Employee");
                Console.Write("Enter choice: ");
                int Choice = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Employee ID: ");
                int Id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Employee Name: ");
                string Name = Console.ReadLine();

                Console.Write("Enter Department: ");
                string Department = Console.ReadLine();

                if (Choice == 1)
                {
                    Console.Write("Enter Monthly Salary: ");
                    double Salary = Convert.ToDouble(Console.ReadLine());

                    Employees[i] = EmployeeUtility.CreateFullTimeEmployee(
                        Id, Name, Salary, Department);
                }
                else if (Choice == 2)
                {
                    Console.Write("Enter Working Hours: ");
                    int Hours = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Salary: ");
                    double Salary = Convert.ToDouble(Console.ReadLine());

                    Employees[i] = EmployeeUtility.CreatePartTimeEmployee(
                        Id, Name, Hours, Salary, Department);
                }
                else
                {
                    Console.WriteLine("Invalid choice. Try again.");
                    i--;
                }
            }

            EmployeeProcessor Eprocessor = new EmployeeProcessor();
            Eprocessor.DisplayEmployees(Employees);
        }
    }
}
