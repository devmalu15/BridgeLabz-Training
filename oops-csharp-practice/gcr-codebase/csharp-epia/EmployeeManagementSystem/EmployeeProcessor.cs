using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementSystem.EmployeeManagementSystem
{
    class EmployeeProcessor
    {
        public void DisplayEmployees(Employee[] employees)
        {

            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].showDetails();
            }

        }
    }
}
