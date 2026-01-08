using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.LinkedList.TicketReservationSystem
{
    public class Node
    {
        public int TicketID;
        public string CustomerName;
        public string MovieName;
        public string SeatNumber;
        public string BookingTime;
        public Node Next;

        public Node(int id, string custName, string movie, string seat, string time)
        {
            TicketID = id;
            CustomerName = custName;
            MovieName = movie;
            SeatNumber = seat;
            BookingTime = time;
            Next = null;
        }
    }
}
