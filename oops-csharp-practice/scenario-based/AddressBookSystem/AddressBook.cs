using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeLabsTrainingVS.ScenarioBased.AddressBook;

namespace BridgeLabsTrainingVS.ScenarioBased.AddressBookSystem
{
    public class AddressBook
    {
        public String bookName { get; set; }
        public Contact[] contacts { get; set; }

        public AddressBook(String bookName)
        {
            this.bookName = bookName;
            this.contacts = new Contact[1000];
        }
    }
}
