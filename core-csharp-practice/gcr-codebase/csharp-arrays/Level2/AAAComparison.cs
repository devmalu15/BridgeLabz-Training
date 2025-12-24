using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.programs
{
    public class AAAComaprison
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Amar's Age : ");
            int amarAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Akbar's Age : ");
            int akbarAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Anthony's Age : ");
            int anthonyAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Amar's Height : ");
            double amarHeight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Akbar's Height : ");
            double akbarHeight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Anthony's Height : ");
            double anthonyHeight = double.Parse(Console.ReadLine());


            int[] ageData = { amarAge, akbarAge, anthonyAge };
            double[] heightData = { amarHeight, akbarHeight, anthonyHeight };

            int youngest = int.MaxValue;
            double tallest = double.MinValue;

            for(int i = 0; i < 3; i++)
            {
                if(ageData[i] < youngest)
                {
                    youngest = ageData[i];
                }
            }


            for (int i = 0; i < 3; i++)
            {
                if (heightData[i] > tallest)
                {
                    tallest = heightData[i];
                }
            }


            Console.WriteLine("Youngest age is " + youngest + " and tallest height is " + tallest);


        }
    }
}
