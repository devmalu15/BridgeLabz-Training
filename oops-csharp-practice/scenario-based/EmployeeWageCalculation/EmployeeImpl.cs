using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation.EmployeeWageCalculation
{
    public class EmployeeImpl : IEmployable
    {

        public bool Attendance(Employee employee)      // returns true if employee is present and false if absent;
        {
            return employee.attendanceStatus;
        }

        public Employee AddEmployee()                 // takes employee data from console to create a new employee.
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

            bool status = true;

            if(random.Next(0, 2) == 1)
            {
                status = true;
            }
            else
            {
                status = false;
            }

                Employee newEmp = new Employee(id, name, 0, wage, status);

            Console.WriteLine("Employee added successfully!");
            return newEmp;
        }


        //UC:1 --- AddEmployee and Attendance methods added.




    }
}
