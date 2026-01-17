using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.LibraryOrganizer
{
    public class BookUtility
    {
        public static void ShowMenu()
        {
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Borrow Book (Remove)");
            Console.WriteLine("3. Show Catalog");
            Console.WriteLine("4. Exit");
            Console.Write("Select: ");
        }

        public static string GetString(string prompt)
        {
            Console.Write($"    {prompt}: ");
            return Console.ReadLine();
        }
    }
}
