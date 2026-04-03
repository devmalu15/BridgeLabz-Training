using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.level1Array
{
    public class StudentVoting
    {
        static void Main(string[] args)
        {
            int[] ages = new int[10];

            for (int i = 0; i < ages.Length; i++)
            {
                Console.Write("Enter age for student " + (i + 1) + ": ");
                ages[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] < 0)
                {
                    Console.WriteLine("Invalid age entered.");
                }
                else if (ages[i] >= 18)
                {
                    Console.WriteLine("The student with the age " + ages[i] + " can vote.");
                }
                else
                {
                    Console.WriteLine("The student with the age " + ages[i] + " cannot vote.");
                }
            }
        }
    }
}
