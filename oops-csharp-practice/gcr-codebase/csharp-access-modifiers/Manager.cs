using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.AccessModifiers
{
    public class Manager : Employee
    {
        public void AssignDetails()
        {
            employeeID = 555;
            department = "HR";
            Console.WriteLine("Manager ID: " + employeeID);
            Console.WriteLine("Department: " + department);
        }

        public static void Main(string[] args)
        {
            Manager m = new Manager();
            m.AssignDetails();
            m.SetSalary(80000);
        }
    }
}
