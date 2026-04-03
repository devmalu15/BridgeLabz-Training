using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.LinkedList.StudentRecordManagement
{
    public class Utility
    {
        public static void Main(string[] args)
        {
            StudentList list = new StudentList();
            list.AddAtEnd(101, "Loveeeesh", 20, "A");
            list.AddAtEnd(102, "Ramaa", 21, "B");
            list.AddAtBeginning(100, "Risita", 19, "A");

            
            list.AddAtPosition(2, 103, "Loveeeesh", 22, "C");

            Console.WriteLine("All Students:");
            list.DisplayAll();

            Console.WriteLine("\nUpdating Ramaa's Grade:");
            list.UpdateGrade(102, "A+");
            list.SearchByRollNumber(102);

            Console.WriteLine("\nDeleting Risita (100):");
            list.DeleteByRollNumber(100);
            list.DisplayAll();
        }
    }
}
