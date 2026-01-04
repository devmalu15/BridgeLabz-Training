using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.AccessModifiers
{
    public class Employee
    {
        public int employeeID;
        protected string department;
        private double salary;

        public void SetSalary(double salary)
        {
            this.salary = salary;
        }
    }
}
