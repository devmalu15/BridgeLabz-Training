using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Constructors
{
    public class Book
    {
        string title;
        string author;
        double price;

        public Book()
        {
            title = "Unknown";
            author = "Unknown";
            price = 0.0;
        }

        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public static void Main(string[] args)
        {
            Book defaultBook = new Book();
            Book paramBook = new Book("C# Basics", "John Doe", 500);
            Console.WriteLine("Book Created");
        }
    }
}
