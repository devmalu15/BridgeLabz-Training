using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.Browser
{
    public class BrowserUtility
    {
        public static void ShowMenu()
        {
            Console.WriteLine("1. Visit URL");
            Console.WriteLine("2. Back");
            Console.WriteLine("3. Forward");
            Console.WriteLine("4. Close Tab");
            Console.WriteLine("5. Restore Tab");
            Console.WriteLine("6. Show State");
            Console.WriteLine("7. Exit");
            Console.Write("Select: ");
        }

        public static string GetString(string prompt)
        {
            Console.Write($"    {prompt}: ");
            return Console.ReadLine();
        }
    }
}
