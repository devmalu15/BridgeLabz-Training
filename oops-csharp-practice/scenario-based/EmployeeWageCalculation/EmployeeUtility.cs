using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation.EmployeeWageCalculation
{
    public class EmployeeUtility
    {
        public static void Main(String[] args)
        {
            // Array with a limit of 1000
            Employee[] employees = new Employee[1000];
            int employeeCount = 0; // Tracks how many employees exist

            IEmployable obj = new EmployeeImpl();
            bool isRunning = true;

            Console.WriteLine("Welcome to Employee Wage Computation Program");

            while (isRunning)
            {
                // Menu
                Console.WriteLine("\n--------------------------------");
                Console.WriteLine("Select an Option:");
                Console.WriteLine("1. Add New Employee");
                Console.WriteLine("2. Record Hours & Attendance (Search by ID)");
                Console.WriteLine("3. Calculate & Show Daily Wages (All Employees)");
                Console.WriteLine("4. Show All Details of All Employees");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        // --- Add Employee ---
                        if (employeeCount < 1000)
                        {
                            employees[employeeCount] = obj.AddEmployee();
                            employeeCount++;
                        }
                        else
                        {
                            Console.WriteLine("Error: Database is full (Max 1000 employees).");
                        }
                        break;

                    case 2:
                        // --- Update Hours (Search by ID) ---
                        if (employeeCount == 0)
                        {
                            Console.WriteLine("No employees found. Please add an employee first.");
                            break;
                        }

                        Console.Write("Enter Employee ID to update: ");
                        string searchId = Console.ReadLine();
                        bool found = false;

                        for (int i = 0; i < employeeCount; i++)
                        {
                            if (employees[i].employeeID == searchId)
                            {
                                found = true;
                                Console.WriteLine($"Found Employee: {employees[i].employeeName}");

                                if (obj.Attendance(employees[i]))
                                {
                                    Console.WriteLine(employees[i].employeeName + " is present!");
                                    obj.AddHours(employees[i]);
                                }
                                else
                                {
                                    Console.WriteLine(employees[i].employeeName + " is absent!");
                                    employees[i].workTime = 0;
                                }
                                break;
                            }
                        }

                        if (!found)
                        {
                            Console.WriteLine($"Error: Employee with ID '{searchId}' not found.");
                        }
                        break;

                    case 3:
                        // --- Calculate Wages ---
                        if (employeeCount == 0)
                        {
                            Console.WriteLine("No data to display.");
                        }
                        else
                        {
                            Console.WriteLine("\n--- Daily Wage Report ---");
                            for (int i = 0; i < employeeCount; i++)
                            {
                                Console.WriteLine($"{employees[i].employeeName}({employees[i].employeeID})'s daily wage is {obj.CalculateDailyWage(employees[i])}");
                                Console.WriteLine(employees[i].ToString());
                            }
                        }
                        break;

                    case 4:
                        // --- Show All Fields ---
                        if (employeeCount == 0)
                        {
                            Console.WriteLine("No employees found.");
                        }
                        else
                        {
                            Console.WriteLine("\n--- All Employee Details ---");
                            Console.WriteLine($"{"ID",-10} {"Name",-15} {"Type",-12} {"Wage/Hr",-10} {"Hours",-8} {"Status",-10}");
                            Console.WriteLine("----------------------------------------------------------------------");

                            for (int i = 0; i < employeeCount; i++)
                            {
                                // Using formatted string to align columns cleanly
                                string status = employees[i].attendanceStatus ? "Present" : "Absent";
                                Console.WriteLine($"{employees[i].employeeID,-10} {employees[i].employeeName,-15} {employees[i].employment,-12} {employees[i].wagePerHr,-10} {employees[i].workTime,-8} {status,-10}");
                            }
                        }
                        break;

                    case 5:
                        Console.WriteLine("Exiting program...");
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select 1-5.");
                        break;
                }
            }

            //UC:1   -- taking input from user to add employees and showing if they are present or not.

            //UC:2   -- taking input for adding hours to an employee and also calculating and showing daily wages.

            //UC:4   -- taking inputs using switch cases and can add upto 1000 employees and manipulate their data and calculate daily wages.
        }
    }
}