using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation.EmployeeWageCalculation
{
    public class EmployeeImpl : IEmployable
    {

        public bool[] Attendance(Employee employee)      // returns true if employee is present and false if absent;
        {
            return employee.attendanceStatusArr;

        }

        public Employee AddEmployee()                  // takes employee data from console to create a new employee.
        {
            Console.WriteLine("\n--- Add New Employee ---");


            Console.Write("Enter Employee ID: ");
            string id = Console.ReadLine();

            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Wage Per Hour: ");

            int wage;
            while (!int.TryParse(Console.ReadLine(), out wage))
            {
                Console.Write("Invalid input. Please enter a number for Wage: ");
            }

            Random random = new Random();

            bool[] arr = new bool[20];

            bool status = true;

            for (int i = 0; i < 20; i++)
            {
                if (random.Next(0, 2) == 1)
                {
                    status = true;
                }
                else
                {
                    status = false;
                }

                arr[i] = status;
            }


            //UC:3 added employee type
            Console.WriteLine("Employment Type:");
            Console.WriteLine("1. Permanent");
            Console.WriteLine("2. Part-time");
            Console.Write("Select (1 or 2): ");

            int choice;

            while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
            {
                Console.Write("Invalid choice. Please enter 1 for Permanent or 2 for Part-time: ");
            }


            string empType = (choice == 1) ? "Permanent" : "Part-time";

            int[] workHourArr = new int[20];
            Employee newEmp = new Employee(id, name, workHourArr, wage, arr, empType);

            Console.WriteLine("Employee added successfully!");
            return newEmp;
        }


        //UC:1 --- AddEmployee and Attendance methods added.


        public void AddHours(Employee employee)
        {

            Random random = new Random();
            for (int i = 0; i < employee.workTime.Length; i++)
            {
                if (employee.attendanceStatusArr[i] == true)
                {
                    employee.workTime[i] = employee.workTime[i] + random.Next(4, 9);
                }

            }


        }


        public int[] CalculateDailyWage(Employee employee)
        {
            int[] dailyWages = new int[20];
            for (int i = 0; i < employee.attendanceStatusArr.Length; i++)
            {
                if (employee.attendanceStatusArr[i] == true)
                {
                    dailyWages[i] = dailyWages[i] + (employee.workTime[i] * employee.wagePerHr);
                }
            }
            return dailyWages;
        }

        //UC:2 --- AddHours and CalculateDailyWage methods added.


        public int CalculateMonthlyWage(Employee employee)
        {
            int sum = 0;
            for (int i = 0; i < employee.attendanceStatusArr.Length; i++)
            {
                if (employee.attendanceStatusArr[i] == true)
                {
                    sum = sum + (employee.workTime[i] * employee.wagePerHr);
                }
            }

            return sum;
        }

        //UC:3 --- Calculate Monthly Wages method to calculate wages upto a month

    }
}
