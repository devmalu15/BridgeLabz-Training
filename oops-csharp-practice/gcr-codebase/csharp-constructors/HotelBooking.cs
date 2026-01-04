using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Constructors
{
    public class HotelBooking
    {
        string guestName;
        string roomType;
        int nights;

        public HotelBooking()
        {
            guestName = "Guest";
            roomType = "Standard";
            nights = 1;
        }

        public HotelBooking(string guestName, string roomType, int nights)
        {
            this.guestName = guestName;
            this.roomType = roomType;
            this.nights = nights;
        }

        public HotelBooking(HotelBooking other)
        {
            this.guestName = other.guestName;
            this.roomType = other.roomType;
            this.nights = other.nights;
        }

        public static void Main(string[] args)
        {
            HotelBooking b1 = new HotelBooking("Sam", "Deluxe", 3);
            HotelBooking b2 = new HotelBooking(b1);
            Console.WriteLine("Booking copied for: " + b2.guestName);
        }
    }
}
