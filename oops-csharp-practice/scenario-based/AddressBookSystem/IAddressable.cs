using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeLabsTrainingVS.ScenarioBased.AddressBook;

namespace BridgeLabsTrainingVS.ScenarioBased.AddressBookSystem
{
    public interface IAddressable
    {
        AddressBook findBook(AddressBook[] books, String bookName);
        Contact[] findByCity(AddressBook[] books, String searchCity);
        Contact[] findByState(AddressBook[] books, String searchState);

        Contact findByCityAndName(AddressBook[] books, String searchCity, String searchName);
        Contact findByStateAndName(AddressBook[] books, String searchState, String searchName);
    }
}
