using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.AccessModifiers
{
    public class EBook : LibraryBookAccess
    {
        public void DisplayInfo()
        {
            ISBN = "978-3-16-148410-0";
            title = "Digital Fortress";
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Title: " + title);
        }
    }
}
