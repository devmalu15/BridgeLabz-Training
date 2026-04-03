using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.level1Array
{
    public class PartialTables
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int[] multiplicationResult = new int[4];

            int arrayIndex = 0;
            for (int i = 6; i <= 9; i++)
            {
                multiplicationResult[arrayIndex] = number * i;
                arrayIndex++;
            }

            arrayIndex = 0;
            for (int i = 6; i <= 9; i++)
            {
                Console.WriteLine(number + " * " + i + " = " + multiplicationResult[arrayIndex]);
                arrayIndex++;
            }
        }
    }
}
