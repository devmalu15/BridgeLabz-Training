using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation.EmployeeWageCalculation
{
    public class Employee
    {
        public String employeeID { get; }
        public String employeeName { get; set; }

        public int workTime { get; set; }
        public int wagePerHr { get; set; }

        public bool attendanceStatus { get; set; }

        public String employment { get; set; }

        public Employee(String employeeID, String employeeName, int workTime, int wagePerHr, bool attendanceStatus, String employment)
        { 

            this.employeeName = employeeName;
            this.wagePerHr = wagePerHr;

            this.workTime = workTime;
            this.employeeID = employeeID;

            this.attendanceStatus = attendanceStatus;

            this.employment = employment;
        }

        public override string? ToString()
        {
            return this.employeeID + " " + this.employeeName + " " + this.attendanceStatus + " " + this.employment;
        }
    }
}
