using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem.LibraryManagementSystem
{
    interface IReservable
    {
        void ReserveItem(string borrowerName);
        bool CheckAvailability();
    }
}
