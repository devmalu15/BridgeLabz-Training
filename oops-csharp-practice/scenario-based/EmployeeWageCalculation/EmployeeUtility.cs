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
                Console.WriteLine("5. Check Condition (20 Days Present OR 100 Hours Worked)");
                Console.WriteLine("6. Exit");
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
                        // --- Update Hours ---
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
                                obj.AddHours(employees[i]);
                                Console.WriteLine("Success: Random work hours generated for all 'Present' days.");
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
                                int monthlyWage = obj.CalculateMonthlyWage(employees[i]);
                                Console.WriteLine($"ID: {employees[i].employeeID} | Name: {employees[i].employeeName} | Total Wage: {monthlyWage}");
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
                                int totalPay = obj.CalculateMonthlyWage(employees[i]);

                                // Local logic to count days just for display
                                bool[] attendance = obj.Attendance(employees[i]);
                                int daysPresent = 0;
                                foreach (bool day in attendance) { if (day) daysPresent++; }

                                Console.WriteLine($"{employees[i].employeeID,-10} {employees[i].employeeName,-15} {employees[i].employment,-12} {employees[i].wagePerHr,-10} {daysPresent + "/20",-15} {totalPay,-10}");
                            }
                        }
                        break;

                    case 5:
                        // --- NEW: Check Condition (20 Days OR 100 Hours) ---
                        if (employeeCount == 0)
                        {
                            Console.WriteLine("No employees to check.");
                        }
                        else
                        {
                            Console.WriteLine("\n--- Condition Check (Target: 20 Days OR 100 Hours) ---");

                            for (int i = 0; i < employeeCount; i++)
                            {
                                Employee emp = employees[i];
                                int totalDays = 0;
                                int totalHours = 0;

                                // 1. Loop through arrays to count totals manually
                                // We assume array length is 20 based on your implementation
                                for (int d = 0; d < 20; d++)
                                {
                                    if (emp.attendanceStatusArr[d] == true)
                                    {
                                        totalDays++;
                                        // Sum the hours for that day
                                        totalHours += emp.workTime[d];
                                    }
                                }

                                // 2. Check the Condition
                                bool conditionMet = (totalDays >= 20) || (totalHours >= 100);

                                // 3. Calculate Current Wage based on hours worked
                                int currentWage = totalHours * emp.wagePerHr;

                                Console.WriteLine($"\nEmployee: {emp.employeeName} ({emp.employeeID})");
                                Console.WriteLine($" - Days Worked: {totalDays}/20");
                                Console.WriteLine($" - Hours Worked: {totalHours}");

                                if (conditionMet)
                                {
                                    Console.WriteLine(" -> STATUS: GOAL REACHED (100 Hrs or 20 Days completed)");
                                    Console.WriteLine($" -> Final Wage Calculation: {currentWage}");
                                }
                                else
                                {
                                    Console.WriteLine($" -> STATUS: In Progress (Needs {20 - totalDays} more days OR {100 - totalHours} more hours)");
                                    Console.WriteLine($" -> Current Wage Accumulation: {currentWage}");
                                }
                            }
                        }
                        break;

                    case 6:
                        Console.WriteLine("Exiting program...");
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select 1-6.");
                        break;
                }
            }

            //UC:1   -- taking input from user to add employees and showing if they are present or not.
            //UC:2   -- taking input for adding hours to an employee and also calculating and showing daily wages.
            //UC:4   -- taking inputs using switch cases and can add upto 1000 employees and manipulate their data.
            //UC:5   -- calculate monthly and daily wages.
            //UC:6   -- calculate wages until an empoloyee has worked for 20 days or 100 hours.
        }
    }
}