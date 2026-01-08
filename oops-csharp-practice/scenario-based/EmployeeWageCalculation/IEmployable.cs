using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation.EmployeeWageCalculation
{
    public interface IEmployable
    {

        public Employee AddEmployee();
        public bool[] Attendance(Employee employee);


        //UC:1 -- can add employees and check if they are present or absent.

        public void AddHours(Employee employee);

        public int[] CalculateDailyWage(Employee employee);

        //UC:2 -- can add workHours to any employee and calculate their daily wage

        public int CalculateMonthlyWage(Employee employee);
    }
}
