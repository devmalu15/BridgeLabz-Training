using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.AddressBookSystem
{
    public class AddressableImpl : IAddressable
    {
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
    }
}
