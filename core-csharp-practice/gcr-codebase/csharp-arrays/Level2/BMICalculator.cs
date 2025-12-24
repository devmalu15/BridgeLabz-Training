using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.level2Array
{
    public class BMICalculator
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of persons: ");
            int n = int.Parse(Console.ReadLine());

            double[] weights = new double[n];
            double[] heights = new double[n];
            double[] bmis = new double[n];
            string[] status = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter weight (kg) for person " + (i + 1) + ": ");
                weights[i] = double.Parse(Console.ReadLine());
                Console.Write("Enter height (m) for person " + (i + 1) + ": ");
                heights[i] = double.Parse(Console.ReadLine());

                bmis[i] = weights[i] / (heights[i] * heights[i]);

                if (bmis[i] < 18.5)
                {
                    status[i] = "Underweight";
                }
                else if (bmis[i] < 25)
                {
                    status[i] = "Normal";
                }
                else if (bmis[i] < 30)
                {
                    status[i] = "Overweight";
                }
                else
                {
                    status[i] = "Obese";
                }
            }

            Console.WriteLine("\nResults:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Person " + (i + 1) + " - Height: " + heights[i] + ", Weight: " + weights[i] + ", BMI: " + bmis[i].ToString("F2") + ", Status: " + status[i]);
            }
        }
    }
}
