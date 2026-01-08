using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation.EmployeeWageCalculation
{
    public class EmployeeUtility
    {
        public static void Main(String[] args)
        {
            Employee[] employees = new Employee[2];

            IEmployable obj = new EmployeeImpl();

            for (int i = 0; i < 2; i++)
            {
                employees[i] = obj.AddEmployee();
                if (obj.Attendance(employees[i]))
                {
                    Console.WriteLine(employees[i].employeeName + " is present!");
                    obj.AddHours(employees[i]);
                }
                else
                {
                    Console.WriteLine(employees[i].employeeName + " is absent!");
                }
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"{employees[i].employeeName}({employees[i].employeeID})'s daily wage is {obj.CalculateDailyWage(employees[i])}");
            }


            //UC:1   -- taking input from user to add employees and showing if they are present or not.

            //UC:2   -- taking input for adding hours to an employee and also calculating and showing daily wages.
        }


    }
}
