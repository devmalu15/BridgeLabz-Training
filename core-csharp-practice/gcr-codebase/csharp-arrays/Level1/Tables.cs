using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.level1Array
{
    public class Tables
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int[] results = new int[10];

            for (int i = 1; i <= 10; i++)
            {
                results[i - 1] = number * i;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(number + " * " + (i + 1) + " = " + results[i]);
            }
        }
    }
}
