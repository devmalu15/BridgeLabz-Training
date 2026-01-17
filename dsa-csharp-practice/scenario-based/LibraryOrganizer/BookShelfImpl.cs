using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.LibraryOrganizer
{
    public class BookShelfImpl : IBookShelf
    {
        public GenreBucket[] MapArray;
        public int Size = 10;

        public BookShelfImpl()
        {
            MapArray = new GenreBucket[Size];
        }

        public int GetHashIndex(string key)
        {
            int sum = 0;
            foreach (char c in key) sum += c;
            return sum % Size;
        }

        public void AddBook(string genre, string title, string author)
        {
            int index = GetHashIndex(genre);

            GenreBucket currentBucket = MapArray[index];
            GenreBucket targetBucket = null;

            while (currentBucket != null)
            {
                if (currentBucket.GenreName == genre)
                {
                    targetBucket = currentBucket;
                    break;
                }
                currentBucket = currentBucket.NextBucket;
            }

            if (targetBucket == null)
            {
                targetBucket = new GenreBucket(genre);
                targetBucket.NextBucket = MapArray[index];
                MapArray[index] = targetBucket;
            }

            Book newBook = new Book(title, author);
            if (targetBucket.BooksHead == null)
            {
                targetBucket.BooksHead = newBook;
            }
            else
            {
                newBook.Next = targetBucket.BooksHead;
                targetBucket.BooksHead = newBook;
            }
            Console.WriteLine($"    Added '{title}' to {genre}.");
        }

        public void RemoveBook(string genre, string title)
        {
            int index = GetHashIndex(genre);
            GenreBucket currentBucket = MapArray[index];

            while (currentBucket != null)
            {
                if (currentBucket.GenreName == genre)
                {
                    Book currentBook = currentBucket.BooksHead;
                    Book prevBook = null;

                    while (currentBook != null)
                    {
                        if (currentBook.Title == title)
                        {
                            if (prevBook == null)
                            {
                                currentBucket.BooksHead = currentBook.Next;
                            }
                            else
                            {
                                prevBook.Next = currentBook.Next;
                            }
                            Console.WriteLine($"    '{title}' removed from library.");
                            return;
                        }
                        prevBook = currentBook;
                        currentBook = currentBook.Next;
                    }
                    Console.WriteLine("    [!] Book not found in this genre.");
                    return;
                }
                currentBucket = currentBucket.NextBucket;
            }
            Console.WriteLine("    [!] Genre not found.");
        }

        public void PrintCatalog()
        {
            Console.WriteLine("\n    === LIBRARY CATALOG ===");
            for (int i = 0; i < Size; i++)
            {
                GenreBucket bucket = MapArray[i];
                while (bucket != null)
                {
                    Console.WriteLine($"    Genre: {bucket.GenreName} (Index {i})");
                    Book b = bucket.BooksHead;
                    if (b == null) Console.WriteLine("      (Empty)");
                    while (b != null)
                    {
                        Console.WriteLine($"      - {b.Title} by {b.Author}");
                        b = b.Next;
                    }
                    bucket = bucket.NextBucket;
                }
            }
            Console.WriteLine("    =======================\n");
        }
    }
}
