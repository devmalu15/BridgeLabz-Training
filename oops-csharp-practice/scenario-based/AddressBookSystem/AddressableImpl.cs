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
        int maxLen = 1000;
        public AddressBook findBook(AddressBook[] books, String bookName)
        {
            for(int i = 0; i < books.Length; i++)
            {
                if (books[i] != null)
                {
                    if (books[i].bookName == bookName)
                    {
                        return books[i];
                    }
                }
                
            }
            return null;
        }

        public Contact[] findByCity(AddressBook[] books, String searchCity)
        {
            Contact[] result = new Contact[1000];
            int count = 0;
            for(int i = 0; i < books.Length; i++)
            {
                if (books[i] != null)
                {
                    for(int j = 0; j < maxLen; j++)
                    {
                        if (books[i].contacts[j] != null)
                        {
                            if (books[i].contacts[j].city == searchCity)
                            {
                                result[count] = books[i].contacts[j];
                                count++;
                            }
                        }
                    }
                }
            }

            return result;
        }

        public Contact[] findByState(AddressBook[] books, String searchState)
        {
            Contact[] result = new Contact[1000];
            int count = 0;
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] != null)
                {
                    for (int j = 0; j < maxLen; j++)
                    {
                        if (books[i].contacts[j] != null)
                        {
                            if (books[i].contacts[j].state == searchState)
                            {
                                result[count] = books[i].contacts[j];
                                count++;
                            }
                        }
                    }
                }
            }

            return result;
        }
    }
}
