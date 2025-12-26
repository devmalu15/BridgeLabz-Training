using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.Methods
{
    public class MaxNumberOfHandshakes
    {
        static int CalculateNumberOfHandshakes(int numberOfStudents) { 
            return (numberOfStudents*(numberOfStudents-1)/2);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter number of students:");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            int numberOfPossibleHandshakes = CalculateNumberOfHandshakes(numberOfStudents);
            Console.WriteLine("The number of possible handshakes among N students : "+ numberOfPossibleHandshakes);
        }
    }
}
