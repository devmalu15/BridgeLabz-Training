using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.LinkedList.InventoryManagementSystem
{
    public class Utility
    {
        public static void Main(string[] args)
        {
            InventoryList list = new InventoryList();
            list.AddItem("Laptop", 101, 5, 1000);
            list.AddItem("Mouse", 102, 50, 20);
            list.AddItem("Keyboard", 103, 30, 50);

            Console.WriteLine("Original Inventory:");
            list.DisplayAll();

            Console.WriteLine("\nTotal Value:");
            list.CalculateTotalValue();

            Console.WriteLine("\nUpdating Mouse Qty and Removing Laptop:");
            list.UpdateQuantity(102, 45);
            list.RemoveByID(101);
            list.DisplayAll();

            Console.WriteLine("\nSorted by Name:");
            list.SortByName();
            list.DisplayAll();
        }
    
}
}
