using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.LinkedList.TicketReservationSystem
{
    public class Utility
    {
        public static void Main(string[] args)
        {
            TicketList list = new TicketList();
            list.AddTicket(101, "Loveeeesh", "Avengers", "A1", "10:00");
            list.AddTicket(102, "Ramaa", "Barbie", "B2", "11:00");
            list.AddTicket(103, "Risita", "Avengers", "A2", "10:05");

            Console.WriteLine("Current Reservations:");
            list.DisplayAll();

            Console.WriteLine("\nSearching for 'Avengers':");
            list.Search("Avengers");

            Console.WriteLine("\nCancelling Ticket 102 (Ramaa):");
            list.RemoveTicket(102);
            list.CountTickets();
            list.DisplayAll();
        }
    }
}
