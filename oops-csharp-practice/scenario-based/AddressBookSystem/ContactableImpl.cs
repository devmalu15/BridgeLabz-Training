using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BridgeLabsTrainingVS.ScenarioBased.AddressBook;

namespace BridgeLabsTrainingVS.ScenarioBased.AddressBookSystem
{
    public class ContactableImpl : IContactable
    {
        int maxLen = 1000;
        public void AddContact(AddressBook addressBook, Contact contact)
        {
            
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

        public void EditContact(AddressBook addressBook, Contact contact, string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string eMail)
        {
            for(int i = 0; i < maxLen; i++)
            {
                if (addressBook.contacts[i] == contact)
                {
                    addressBook.contacts[i].firstName = firstName;
                    addressBook.contacts[i].lastName = lastName;
                    addressBook.contacts[i].address = address;
                    addressBook.contacts[i].city = city;
                    addressBook.contacts[i].state = state;
                    addressBook.contacts[i].zip = zip;
                    addressBook.contacts[i].phoneNumber = phoneNumber;
                    addressBook.contacts[i].eMail = eMail;
                    break;
                }
            }
        }

        public Contact ShowContact(AddressBook addressBook, String searchName)
        {
            for (int i = 0; i < maxLen; i++)
            {
                if (addressBook.contacts[i] != null)
                {
                    if (addressBook.contacts[i].firstName + " " + addressBook.contacts[i].lastName == searchName)
                    {
                        return addressBook.contacts[i];
                        break;
                    }
                }
                
            }
            return null;
        }

        public void DeleteContact(AddressBook addressBook, Contact contact)
        {
            for(int i = 0; i < maxLen; i++)
            {
                if (addressBook.contacts[i] == contact)
                {
                    addressBook.contacts[i] = null;
                    break;
                }
       
            }
        }
    }
}
