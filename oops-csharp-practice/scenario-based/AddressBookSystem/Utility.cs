using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeLabsTrainingVS.ScenarioBased.AddressBook;

namespace BridgeLabsTrainingVS.ScenarioBased.AddressBookSystem
{
    public class Utility
    {
        private static string Version = "1.0";
        private static ConsoleColor ColorPrimary = ConsoleColor.Cyan;
        private static ConsoleColor ColorSecondary = ConsoleColor.Magenta;
        private static ConsoleColor ColorText = ConsoleColor.White;

        public static void SetupConsole()
        {
            Console.Title = $"Address Book System | Version {Version} | Dev";
            try { Console.SetWindowSize(90, 30); } catch { }
        }

        public static void PrintLogo()
        {
            Console.Clear();
            Console.ForegroundColor = ColorPrimary;
            Console.WriteLine(@"
      _   ___  ___  ___  ___  ___  ___    ___  ___  ___  _ __ 
     / \ | . \| . \| . \| __|/ __|/ __|  | . >| . || . || / / 
    | o || | || | ||   /| _> \__ \\__ \  | . \| | || | ||  \  
    |_n_||___/|___/|_\_\|___||___/|___/  |___/`___'`___'|_\_\ 
            ");
            Console.ForegroundColor = ColorSecondary;
            Console.WriteLine($"                                             [Version {Version}]");
            Console.WriteLine("    ==========================================================");
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void ShowMainMenu()
        {
            Console.ForegroundColor = ColorText;
            Console.WriteLine("    [1] ADD New Contact");
            Console.WriteLine("    [2] EXIT");
            Console.WriteLine();
            Console.ForegroundColor = ColorPrimary;
            Console.Write("    >> Select Option: ");
            Console.ResetColor();
        }

        public static Contact CreateContactWithUI()
        {
            PrintLogo();
            Console.ForegroundColor = ColorSecondary;
            Console.WriteLine("    --- ENTER CONTACT DETAILS ---");
            Console.WriteLine();

            string fName = InputField("First Name");
            string lName = InputField("Last Name");
            string addr = InputField("Address");
            string city = InputField("City");
            string state = InputField("State");
            string zip = InputField("Zip Code");
            string phone = InputField("Phone No");
            string email = InputField("Email");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("    [!] Capturing data...");
            System.Threading.Thread.Sleep(500);
            Console.ResetColor();

            return new Contact(fName, lName, addr, city, state, zip, phone, email);
        }

        private static string InputField(string label)
        {
            Console.ForegroundColor = ColorPrimary;
            Console.Write($"    {label.PadRight(12)}: ");
            Console.ForegroundColor = ColorText;
            return Console.ReadLine();
        }

        public static void WaitForKey()
        {
            Console.WriteLine();
            Console.WriteLine("    Press any key to continue...");
            Console.ReadKey();
        }
    
    }
}
