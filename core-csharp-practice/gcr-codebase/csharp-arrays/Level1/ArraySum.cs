using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.level1Array
{
    public class ArraySum
    {
        static void Main(string[] args)
        {
            double[] values = new double[10];
            double total = 0.0;
            int index = 0;

            while (true)
            {
                Console.Write("Enter a number (0 or negative to stop): ");
                double input = double.Parse(Console.ReadLine());

                if (input <= 0)
                {
                    break;
                }

                if (index == 10)
                {
                    break;
                }

                values[index] = input;
                index++;
            }

            Console.WriteLine("Numbers entered:");
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(values[i]);
                total += values[i];
            }

            Console.WriteLine("Total sum: " + total);
        }
    }
}
