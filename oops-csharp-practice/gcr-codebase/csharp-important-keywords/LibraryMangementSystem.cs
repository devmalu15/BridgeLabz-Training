using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.keywords
{
    public class LibraryMangementSystem
    {
        static String libraryName = "Library";
        String title;
        String author;
        readonly int ISBN;

        public LibraryMangementSystem(String title, String author, int ISBN)
        {
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
        }

        public static String getLibraryName()
        {
            return libraryName;
        }

        public static void Main(String[] args)
        {
            LibraryMangementSystem book = new LibraryMangementSystem("abc", "abcde", 1234567);

            Console.WriteLine(book is LibraryMangementSystem);
            Console.WriteLine(getLibraryName());
        }


    }
}
