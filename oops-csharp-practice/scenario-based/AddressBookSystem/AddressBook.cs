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
        public Contact[] contacts { get; set; }

        public AddressBook()
        {
            this.contacts = new Contact[1000];
        }
    }
}
