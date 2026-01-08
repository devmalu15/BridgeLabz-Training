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

            // We use the Implementation class which contains the new logic
            EmployeeImpl obj = new EmployeeImpl();
            bool isRunning = true;

            Console.WriteLine("Welcome to Employee Wage Computation Program (Monthly Logic)");

            while (isRunning)
            {
                // Menu
                Console.WriteLine("\n--------------------------------");
                Console.WriteLine("Select an Option:");
                Console.WriteLine("1. Add New Employee (Generates 20-day Attendance)");
                Console.WriteLine("2. Process Work Hours (Randomly assigns hours for present days)");
                Console.WriteLine("3. Calculate & Show Monthly Wages");
                Console.WriteLine("4. Show All Details (Summary)");
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
                        // Uses the new AddEmployee method which sets up the 20-day boolean array
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

                        Console.Write("Enter Employee ID to process hours: ");
                        string searchId = Console.ReadLine();
                        bool found = false;

                        for (int i = 0; i < employeeCount; i++)
                        {
                            if (employees[i].employeeID == searchId)
                            {
                                found = true;
                                Console.WriteLine($"Found Employee: {employees[i].employeeName}");

                                // NEW LOGIC: We don't ask user for hours anymore.
                                // We call AddHours which randomly assigns 4-9 hours for every 'Present' day in the array.
                                obj.AddHours(employees[i]);

                                Console.WriteLine("Success: Random work hours generated for all 'Present' days in the month.");
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
                            Console.WriteLine("\n--- Monthly Wage Report ---");
                            for (int i = 0; i < employeeCount; i++)
                            {
                                // 1. Calculate Monthly Total
                                int monthlyWage = obj.CalculateMonthlyWage(employees[i]);

                                // 2. Calculate Daily Breakdown (demonstrating use of the method)
                                int[] dailyWages = obj.CalculateDailyWage(employees[i]);

                                Console.WriteLine($"\nID: {employees[i].employeeID} | Name: {employees[i].employeeName}");
                                Console.WriteLine($"Total Monthly Wage: {monthlyWage}");

                                // Optional: Show first 5 days as a sample
                                Console.Write("Daily Wage Sample (First 5 days): ");
                                for (int d = 0; d < 5; d++) Console.Write(dailyWages[d] + " ");
                                Console.WriteLine("...");
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
                            Console.WriteLine("\n--- All Employee Monthly Summary ---");
                            Console.WriteLine($"{"ID",-10} {"Name",-15} {"Type",-12} {"Wage/Hr",-10} {"Days Present",-15} {"Total Pay",-10}");
                            Console.WriteLine("-----------------------------------------------------------------------------");

                            for (int i = 0; i < employeeCount; i++)
                            {
                                // Calculate summary data for the table
                                int totalPay = obj.CalculateMonthlyWage(employees[i]);

                                // Count how many days were 'true' in the array
                                bool[] attendance = obj.Attendance(employees[i]);
                                int daysPresent = 0;
                                foreach (bool day in attendance) { if (day) daysPresent++; }

                                Console.WriteLine($"{employees[i].employeeID,-10} {employees[i].employeeName,-15} {employees[i].employment,-12} {employees[i].wagePerHr,-10} {daysPresent + "/20",-15} {totalPay,-10}");
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