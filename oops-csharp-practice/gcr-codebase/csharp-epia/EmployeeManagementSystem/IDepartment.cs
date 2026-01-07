using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementSystem.EmployeeManagementSystem
{

    //Create an interface IDepartment with methods like AssignDepartment() and GetDepartmentDetails().
    interface IDepartment
    {

        public void AssignDepartment(string deptName);

        public string showDepartmentDetails();

    }
}
