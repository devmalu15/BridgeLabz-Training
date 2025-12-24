using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.level1Array
{
    public class MeanHeight
    {
        static void Main(string[] args)
        {
            double[] heights = new double[11];
            double sum = 0;

            for (int i = 0; i < 11; i++)
            {
                Console.Write("Enter height for player " + (i + 1) + ": ");
                heights[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 11; i++)
            {
                sum += heights[i];
            }

            double mean = sum / 11;
            Console.WriteLine("The mean height of the football team is: " + mean);
        }
    }
}
