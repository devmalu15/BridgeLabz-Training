using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.level2Array
{
    public class BMI2D
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of persons: ");
            int number = int.Parse(Console.ReadLine());

            double[,] personData = new double[number, 3];
            string[] weightStatus = new string[number];

            for (int i = 0; i < number; i++)
            {
                Console.Write("Enter weight (kg) for person " + (i + 1) + ": ");
                double w = double.Parse(Console.ReadLine());
                if (w < 0)
                {
                    Console.WriteLine("Please enter positive value.");
                    i--;
                    continue;
                }
                personData[i, 0] = w;

                Console.Write("Enter height (m) for person " + (i + 1) + ": ");
                double h = double.Parse(Console.ReadLine());
                if (h < 0)
                {
                    Console.WriteLine("Please enter positive value.");
                    i--;
                    continue;
                }
                personData[i, 1] = h;

                personData[i, 2] = personData[i, 0] / (personData[i, 1] * personData[i, 1]);
                double bmi = personData[i, 2];

                if (bmi < 18.5) weightStatus[i] = "Underweight";
                else if (bmi < 25) weightStatus[i] = "Normal";
                else if (bmi < 30) weightStatus[i] = "Overweight";
                else weightStatus[i] = "Obese";
            }

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Person " + (i + 1) + ": H=" + personData[i, 1] + " W=" + personData[i, 0] + " BMI=" + personData[i, 2].ToString("F2") + " Status=" + weightStatus[i]);
            }
        }
    }
}
