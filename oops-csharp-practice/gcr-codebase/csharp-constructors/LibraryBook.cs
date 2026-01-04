using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Constructors
{
    public class LibraryBook
    {
        string title;
        string author;
        double price;
        bool isAvailable;

        public LibraryBook(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            this.isAvailable = true;
        }

        public void BorrowBook()
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine("You have borrowed " + title);
            }
            else
            {
                Console.WriteLine("Book is currently unavailable.");
            }
        }

        public static void Main(string[] args)
        {
            LibraryBook lb = new LibraryBook("Harry Potter", "JK Rowling", 400);
            lb.BorrowBook();
            lb.BorrowBook();
        }
    }
}
