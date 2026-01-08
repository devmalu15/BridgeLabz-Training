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
        public bool Attendance(Employee employee);


        //UC:1 -- can add employees and check if they are present or absent.
    }
}
