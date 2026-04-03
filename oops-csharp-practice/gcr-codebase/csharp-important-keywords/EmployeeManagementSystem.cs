using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.keywords
{
    public class EmployeeManagementSystem
    {
        static String companyName = "abc corp";
        readonly int empId;
        String empName;
        String designation;

        public EmployeeManagementSystem(int empId, String empName, String designation)
        {
            this.empId = empId;
            this.empName = empName;
            this.designation = designation;
        }

        public static EmployeeManagementSystem[] fillEmployees(int num)
        {
            EmployeeManagementSystem[] empArr = new EmployeeManagementSystem[num];
            Random random = new Random();
            for(int i = 0; i < num; i++)
            {
                EmployeeManagementSystem obj = new EmployeeManagementSystem(random.Next(1, 100000), random.Next(100000, 999999).ToString(), random.Next(100000, 999999).ToString());
                empArr[i] = obj;
            }

            return empArr;
        }

        public static int countEmp(EmployeeManagementSystem[] arr)
        {

            return arr.Length;

        }



        public static void Main(String[] args)
        {

            Console.WriteLine(countEmp(fillEmployees(1000)));


        }

    }
}
