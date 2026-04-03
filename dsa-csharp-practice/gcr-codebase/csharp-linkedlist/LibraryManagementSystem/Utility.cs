using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.LinkedList.LibraryManagementSystem
{
    public class Utility
    {
        public static void Main(string[] args)
        {
            LibraryList list = new LibraryList();
            
            list.AddBook("C# Basics", "Loveeeesh", "Tech", 1, "Available");
            list.AddBook("Data Structures", "Ramaa", "Tech", 2, "Available");
            list.AddBook("History of World", "Risita", "History", 3, "Checked Out");

            Console.WriteLine("All Books:");
            list.DisplayAll();

            Console.WriteLine("\nSearching for Ramaa:");
            list.Search("Ramaa");

            Console.WriteLine("\nUpdating C# Basics Status:");
            list.UpdateStatus(1, "Checked Out");
            list.DisplayAll();

            Console.WriteLine("\nCounting and Removing ID 2:");
            list.CountBooks();
            list.RemoveByID(2);
            list.DisplayAll();
        }
    }
}
