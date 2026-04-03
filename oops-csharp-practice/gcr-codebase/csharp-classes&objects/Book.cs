using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ClassesAndObjects
{
    public class Book
    {
        string title;
        string author;
        double price;

        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine("Book Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: " + price);
        }

        public static void Main(string[] args)
        {
            Book myBook = new Book("The Alchemist", "Paulo Coelho", 350.50);
            myBook.DisplayBookInfo();
        }
    }
}
