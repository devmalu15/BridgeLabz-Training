using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.level1Array
{
    public class MatrixToArray
    {
        static void Main(string[] args)
        {
            Console.Write("Enter rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter columns: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Enter element [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[] flatArray = new int[rows * columns];
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    flatArray[index] = matrix[i, j];
                    index++;
                }
            }

            Console.WriteLine("1D Array elements:");
            for (int i = 0; i < flatArray.Length; i++)
            {
                Console.Write(flatArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
