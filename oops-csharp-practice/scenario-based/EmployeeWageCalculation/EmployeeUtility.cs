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
            Employee[] employees = new Employee[2];

            IEmployable obj = new EmployeeImpl();

            for(int i = 0; i < 2; i++)
            {
                employees[i] = obj.AddEmployee();
                if (obj.Attendance(employees[i]))
                {
                    Console.WriteLine(employees[i].employeeName + " is present!");
                }
                else
                {
                    Console.WriteLine(employees[i].employeeName + " is absent!");
                }
            }


            //UC:1   -- taking input from user to add employees and showing if they are present or not.
        }
    }
}
