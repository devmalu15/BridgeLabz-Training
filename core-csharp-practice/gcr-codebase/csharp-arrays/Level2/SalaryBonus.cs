using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.programs
{
    public class SalaryBonus
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("enter number of employees : ");
            int numOfEmp = int.Parse(Console.ReadLine());
            double[,] data = new double[2, numOfEmp];
            int j = 1;
            double totalBonus = 0;
            double totalSalary = 0;
            double totalOldSalary = 0;


            for(int i = 0; i < numOfEmp; i++)
            {
                j--;
                Console.WriteLine("enter salary : ");
                int input1 = int.Parse(Console.ReadLine());
                data[j, i] = input1;
                totalOldSalary = totalOldSalary + input1;

                j++;
                Console.WriteLine("enter exp : ");
                int input2 = int.Parse(Console.ReadLine());
                data[j, i] = input2;
            }

            for (int i = 0; i < numOfEmp; i++)
            {
                double exp = data[j, i];
                if (exp > 5)
                {
                    j--;
                    data[j ,i] = data[j, i] + (data[j, i] * 0.05);
                    totalBonus = totalBonus + data[j, i];
                    j++;
                }
                else
                {
                    j--;
                    data[j, i] = data[j, i] + (data[j, i] * 0.02);
                    totalBonus = totalBonus + data[j, i];
                    j++;
                }
            }

            for (int i = 0; i < numOfEmp; i++)
            {
                j--;
                Console.WriteLine("salary plus bonus : ");
                Console.WriteLine(data[j, i]);
                totalSalary = totalSalary + data[j, i];

                j++;
                Console.WriteLine("exp : ");
                Console.WriteLine(data[j, i]);
        
            }

            Console.WriteLine("total old salary : " + totalOldSalary);
            Console.WriteLine("total new salary : " + totalSalary);
            Console.WriteLine("total bonus : " + totalBonus);


        }

    }
}
