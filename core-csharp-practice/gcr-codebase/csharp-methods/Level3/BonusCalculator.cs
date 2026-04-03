using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Level3Methods
{
    
    public class BonusCalculator
    {
        public static void Main(string[] args)
        {
            int numEmployees = 10;
            double[,] employeeData = GenerateEmployeeData(numEmployees);
            double[,] financials = CalculateBonus(employeeData);

            DisplayResults(employeeData, financials);
        }

        static double[,] GenerateEmployeeData(int n)
        {
            Random rand = new Random();
            double[,] data = new double[n, 2];

            for (int i = 0; i < n; i++)
            {
                data[i, 0] = rand.Next(10000, 90000);
                data[i, 1] = rand.Next(1, 15);
            }
            return data;
        }

        static double[,] CalculateBonus(double[,] data)
        {
            int n = data.GetLength(0);
            double[,] results = new double[n, 2];

            for (int i = 0; i < n; i++)
            {
                double salary = data[i, 0];
                double years = data[i, 1];
                double bonus = 0;

                if (years > 5)
                    bonus = salary * 0.05;
                else
                    bonus = salary * 0.02;

                results[i, 0] = salary + bonus;
                results[i, 1] = bonus;
            }
            return results;
        }

        static void DisplayResults(double[,] original, double[,] calculated)
        {
            Console.WriteLine("Old Salary\tYears\tBonus\tNew Salary");
            double totalOld = 0;
            double totalNew = 0;
            double totalBonus = 0;

            for (int i = 0; i < original.GetLength(0); i++)
            {
                Console.WriteLine(original[i, 0] + "\t\t" + original[i, 1] + "\t" + calculated[i, 1] + "\t" + calculated[i, 0]);
                totalOld += original[i, 0];
                totalNew += calculated[i, 0];
                totalBonus += calculated[i, 1];
            }

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Total Old: " + totalOld);
            Console.WriteLine("Total Bonus Paid: " + totalBonus);
            Console.WriteLine("Total New: " + totalNew);
        }
    }
}
