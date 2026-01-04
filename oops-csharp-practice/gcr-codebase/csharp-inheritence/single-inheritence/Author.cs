using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Inheritence.SingleInheritence
{
    public class Author : Book
    {
        public string name;
        public string bio;

        public void DisplayInfo()
        {
            Console.WriteLine("Book: " + title + " (" + publicationYear + ")");
            Console.WriteLine("Author: " + name);
            Console.WriteLine("Bio: " + bio);
        }
    }
}
