using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.LibraryOrganizer
{
    public class RunBookApp
    {
        public static void Main(string[] args)
        {
            IBookShelf library = new BookShelfImpl();
            bool running = true;

            Console.WriteLine("=== LIBRARY BOOKSHELF SYSTEM ===");

            while (running)
            {
                BookUtility.ShowMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string g = BookUtility.GetString("Genre");
                        string t = BookUtility.GetString("Title");
                        string a = BookUtility.GetString("Author");
                        library.AddBook(g, t, a);
                        break;
                    case "2":
                        string gRem = BookUtility.GetString("Genre");
                        string tRem = BookUtility.GetString("Title");
                        library.RemoveBook(gRem, tRem);
                        break;
                    case "3":
                        library.PrintCatalog();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            }
        }
    }
}

