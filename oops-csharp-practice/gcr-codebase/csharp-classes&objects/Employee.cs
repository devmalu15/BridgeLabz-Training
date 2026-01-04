using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ClassesAndObjects
{
    public class Employee
    {
        public class Employee
        {
            string name;
            int id;
            double salary;

            public Employee(string name, int id, double salary)
            {
                this.name = name;
                this.id = id;
                this.salary = salary;
            }

            public void DisplayDetails()
            {
                Console.WriteLine("Employee ID: " + id);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Salary: " + salary);
            }

            public static void Main(string[] args)
            {
                Employee emp = new Employee("Ravi Kumar", 101, 45000);
                emp.DisplayDetails();
            }
        }
    }
}
