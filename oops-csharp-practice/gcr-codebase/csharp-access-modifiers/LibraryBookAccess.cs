using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.AccessModifiers
{
    public class LibraryBookAccess
    {
        public string ISBN;
        protected string title;
        private string author;

        public void SetAuthor(string author)
        {
            this.author = author;
        }

        public string GetAuthor()
        {
            return author;
        }
    }
}
