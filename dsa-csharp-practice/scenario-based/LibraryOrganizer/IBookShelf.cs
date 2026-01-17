using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.LibraryOrganizer
{
    public interface IBookShelf
    {
        void AddBook(string genre, string title, string author);
        void RemoveBook(string genre, string title);
        void PrintCatalog();
    }
}
