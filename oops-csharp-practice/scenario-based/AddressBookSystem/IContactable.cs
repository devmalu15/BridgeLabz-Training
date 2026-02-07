using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeLabsTrainingVS.ScenarioBased.AddressBook;

namespace BridgeLabsTrainingVS.ScenarioBased.AddressBookSystem
{
    public interface IContactable
    {
        void AddContact(AddressBook addressBook, Contact contact);
        void EditContact(AddressBook addressBook, Contact contact, string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string eMail);
        Contact ShowContact(AddressBook addressbook, String searchName);
        void DeleteContact(AddressBook addressBook, Contact contact);

        void SortContacts(AddressBook addressBook);
        void SortContactsByCity(AddressBook addressBook);
        void SortContactsByState(AddressBook addressBook);
        void SortContactsByZip(AddressBook addressBook);
    }
}
