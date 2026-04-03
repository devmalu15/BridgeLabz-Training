using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.LinkedList.InventoryManagementSystem
{
    public class InventoryList
    {
        public Node Head;

        public void AddItem(string name, int id, int qty, double price)
        {
            Node newNode = new Node(name, id, qty, price);
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            Node temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }

        public void RemoveByID(int id)
        {
            if (Head == null) return;
            if (Head.ItemID == id)
            {
                Head = Head.Next;
                return;
            }
            Node temp = Head;
            while (temp.Next != null && temp.Next.ItemID != id)
            {
                temp = temp.Next;
            }
            if (temp.Next != null)
            {
                temp.Next = temp.Next.Next;
            }
        }

        public void UpdateQuantity(int id, int newQty)
        {
            Node temp = Head;
            while (temp != null)
            {
                if (temp.ItemID == id)
                {
                    temp.Quantity = newQty;
                    return;
                }
                temp = temp.Next;
            }
        }

        public void Search(string query)
        {
            Node temp = Head;
            while (temp != null)
            {
                if (temp.ItemID.ToString() == query || temp.ItemName == query)
                {
                    Console.WriteLine("Found: " + temp.ItemName);
                    return;
                }
                temp = temp.Next;
            }
        }

        public void CalculateTotalValue()
        {
            double total = 0;
            Node temp = Head;
            while (temp != null)
            {
                total += temp.Price * temp.Quantity;
                temp = temp.Next;
            }
            Console.WriteLine("Total Inventory Value: " + total);
        }

        public void SortByName()
        {
            if (Head == null || Head.Next == null) return;
            bool swapped;
            do
            {
                swapped = false;
                Node temp = Head;
                while (temp.Next != null)
                {
                    if (string.Compare(temp.ItemName, temp.Next.ItemName) > 0)
                    {
                        string tName = temp.ItemName; int tId = temp.ItemID; int tQty = temp.Quantity; double tPrice = temp.Price;
                        temp.ItemName = temp.Next.ItemName; temp.ItemID = temp.Next.ItemID; temp.Quantity = temp.Next.Quantity; temp.Price = temp.Next.Price;
                        temp.Next.ItemName = tName; temp.Next.ItemID = tId; temp.Next.Quantity = tQty; temp.Next.Price = tPrice;
                        swapped = true;
                    }
                    temp = temp.Next;
                }
            } while (swapped);
        }

        public void DisplayAll()
        {
            Node temp = Head;
            while (temp != null)
            {
                Console.WriteLine("ID: " + temp.ItemID + " Name: " + temp.ItemName);
                temp = temp.Next;
            }
        }
    }
}
