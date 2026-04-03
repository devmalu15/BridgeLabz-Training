using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.LinkedList.TicketReservationSystem
{
    public class TicketList
    {
        public Node Head;

        public void AddTicket(int id, string custName, string movie, string seat, string time)
        {
            Node newNode = new Node(id, custName, movie, seat, time);
            if (Head == null)
            {
                Head = newNode;
                Head.Next = Head;
                return;
            }
            Node temp = Head;
            while (temp.Next != Head)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
            newNode.Next = Head;
        }

        public void RemoveTicket(int id)
        {
            if (Head == null) return;
            if (Head.TicketID == id && Head.Next == Head)
            {
                Head = null;
                return;
            }
            Node temp = Head;
            Node prev = null;
            while (temp.TicketID != id)
            {
                prev = temp;
                temp = temp.Next;
                if (temp == Head) return;
            }
            if (temp == Head)
            {
                prev = Head;
                while (prev.Next != Head) prev = prev.Next;
                Head = Head.Next;
                prev.Next = Head;
            }
            else
            {
                prev.Next = temp.Next;
            }
        }

        public void Search(string query)
        {
            if (Head == null) return;
            Node temp = Head;
            do
            {
                if (temp.CustomerName == query || temp.MovieName == query)
                {
                    Console.WriteLine("Found Ticket: " + temp.TicketID + " for " + temp.CustomerName);
                }
                temp = temp.Next;
            } while (temp != Head);
        }

        public void CountTickets()
        {
            if (Head == null)
            {
                Console.WriteLine("Total Tickets: 0");
                return;
            }
            int count = 0;
            Node temp = Head;
            do
            {
                count++;
                temp = temp.Next;
            } while (temp != Head);
            Console.WriteLine("Total Tickets: " + count);
        }

        public void DisplayAll()
        {
            if (Head == null) return;
            Node temp = Head;
            do
            {
                Console.WriteLine("Ticket " + temp.TicketID + " | " + temp.MovieName + " | " + temp.SeatNumber);
                temp = temp.Next;
            } while (temp != Head);
        }
    }
}
