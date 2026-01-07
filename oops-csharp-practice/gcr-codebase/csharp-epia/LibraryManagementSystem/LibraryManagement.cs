using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem.LibraryManagementSystem
{
    public class LibraryManagement
    {
        static void Main()
        {
            Console.WriteLine("=== LIBRARY MANAGEMENT SYSTEM ===");
            Console.WriteLine();

            List<LibraryItem> Items = new List<LibraryItem>();

            Console.Write("Enter number of library items: ");
            int Count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine("\nSelect Item Type:");
                Console.WriteLine("1. Book");
                Console.WriteLine("2. Magazine");
                Console.WriteLine("3. DVD");
                Console.Write("Enter choice: ");

                int Choice = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Item ID: ");
                int Id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Title: ");
                string Title = Console.ReadLine();

                LibraryItem Item;

                switch (Choice)
                {
                    case 1:
                        Console.Write("Enter Author: ");
                        string Author = Console.ReadLine();

                        Console.Write("Enter Price: ");
                        int Price = Convert.ToInt32(Console.ReadLine());

                        Item = new Book(Id, Title, Author, Price);
                        break;

                    case 2:
                        Console.Write("Enter Publisher: ");
                        string Publisher = Console.ReadLine();

                        Console.Write("Enter Issue Month: ");
                        string IssueMonth = Console.ReadLine();

                        Item = new Magazine(Id, Title, Publisher, IssueMonth);
                        break;

                    case 3:
                        Console.Write("Enter Director: ");
                        string Director = Console.ReadLine();

                        Console.Write("Enter Duration (minutes): ");
                        int Duration = Convert.ToInt32(Console.ReadLine());

                        Item = new DVD(Id, Title, Director, Duration);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        i--;
                        continue;
                }

                Items.Add(Item);
            }

            Console.WriteLine("\n=== LIBRARY ITEMS ===");

            foreach (LibraryItem Item in Items)
            {
                Item.GetItemDetails();

                if (Item is IReservable Reservable)
                {
                    bool Available = Reservable.CheckAvailability();
                    Console.WriteLine("Available: " + Available);

                    if (Available)
                    {
                        Console.Write("Enter User ID to reserve: ");
                        string UserId = Console.ReadLine();
                        Reservable.ReserveItem(UserId);
                    }
                }

            }

        }
    }
}
