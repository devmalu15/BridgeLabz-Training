using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.LibraryOrganizer
{
    public class Book
    {
        public string Title;
        public string Author;
        public Book Next;

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            Next = null;
        }
    }
}
