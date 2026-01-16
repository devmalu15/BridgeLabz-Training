using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeLabsTrainingVS.ScenarioBased.AddressBook;

namespace BridgeLabsTrainingVS.ScenarioBased.AddressBookSystem
{
    public class AddressableImpl : IAddressable
    {
        public void AddContact(AddressBook addressBook, Contact contact)
        {
            int maxLen = 1000;
            for(int i = 0; i < maxLen; i++)
            {
                if (addressBook.contacts[i] == null)
                {
                    addressBook.contacts[i] = contact;
                    Console.WriteLine("Contact Added...");
                    break;
                }
                else if(i == maxLen - 1)
                {
                    Console.WriteLine("Contact List is Full, create another addressbook.");
                    break;
                }
                else
                {
                    continue;
                }
            } 


        }
    }
}
