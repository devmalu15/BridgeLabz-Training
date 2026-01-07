using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased
{
    public class CafeteriaMenu
    {
        public static void Main(string[] args)
        {
            string[] items = {
                "Veg Burger", "Cheese Pizza", "Red Pasta", "Club Sandwich", "Green Salad",
                "Cold Coffee", "Masala Tea", "Diet Coke", "French Fries", "Paneer Wrap"
            };

            DisplayMenu(items);

            Console.Write("\nPlease enter the item number: ");
            int index = int.Parse(Console.ReadLine());

            string selection = GetItemByIndex(items, index);

            if (selection != null)
            {
                Console.WriteLine("You have ordered: " + selection);
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        static void DisplayMenu(string[] arr)
        {
            Console.WriteLine("--- Daily Menu ---");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + arr[i]);
            }
        }

        static string GetItemByIndex(string[] arr, int i)
        {
            if (i >= 1 && i <= arr.Length)
            {
                return arr[i - 1];
            }
            return null;
        }
    }
}
