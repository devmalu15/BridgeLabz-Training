using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Level3Methods
{
    public class TeamHeight
    {
        public static int[] HeightComparator(int[] arr)
        {
            int shortest = int.MaxValue;
            int tallest = int.MinValue;
            int sum = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < shortest)
                {
                    shortest = arr[i];
                }
                if (arr[i] > tallest)
                {
                    tallest = arr[i];
                }

                sum = sum + arr[i];

            }

            int mean = sum / 11;

            int[] result = { shortest, tallest, mean };

            return result;
        }


        public static void Main(String[] args)
        {
            int[] heightArr = new int[11];

            for(int i = 0; i < 11; i++)
            {
                Console.WriteLine("Enter player height : ");
                int height = int.Parse(Console.ReadLine());
                heightArr[i] = height;
            }

            int[] resultArr = HeightComparator(heightArr);

            Console.WriteLine("Shortest height : " + resultArr[0] +
                " Tallest Height : " + resultArr[1] +
                " and Mean Height : " + resultArr[2]);
        }
    }
}
