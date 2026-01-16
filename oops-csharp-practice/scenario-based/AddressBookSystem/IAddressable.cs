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
        AddressBook FindBook(AddressBook[] books, String bookName);
        Contact[] FindByCity(AddressBook[] books, String searchCity);
        Contact[] FindByState(AddressBook[] books, String searchState);

        Contact FindByCityAndName(AddressBook[] books, String searchCity, String searchName);
        Contact FindByStateAndName(AddressBook[] books, String searchState, String searchName);

        int CountByCity(AddressBook[] books, String searchCity);
        int CountByState(AddressBook[] books, String searchState);
    }
}
