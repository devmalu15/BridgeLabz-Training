using System;
using BridgeLabsTrainingVS.ScenarioBased.AddressBook;

namespace BridgeLabsTrainingVS.ScenarioBased.AddressBookSystem
{
    public class Utility
    {
        private static string Version = "1.9"; // Updated for Person Search
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

        // --- LEVEL 1: BOOK MANAGEMENT MENU ---
        public static void ShowBookMenu()
        {
            Console.ForegroundColor = ColorText;
            Console.WriteLine("    [1] CREATE New Address Book");
            Console.WriteLine("    [2] OPEN Existing Address Book");
            Console.WriteLine("    [3] DELETE Address Book");
            Console.WriteLine("    --------------------------------");
            Console.WriteLine("    [4] VIEW ALL by City");
            Console.WriteLine("    [5] VIEW ALL by State");
            Console.WriteLine("    [6] FIND Person by City");   // New Feature
            Console.WriteLine("    [7] FIND Person by State");  // New Feature
            Console.WriteLine("    --------------------------------");
            Console.WriteLine("    [8] EXIT Application");
            Console.WriteLine();
            Console.ForegroundColor = ColorPrimary;
            Console.Write("    >> Select Option: ");
            Console.ResetColor();
        }

        // --- LEVEL 2: CONTACT MANAGEMENT MENU ---
        public static void ShowContactMenu(string bookName)
        {
            PrintLogo();
            Console.WriteLine($"    CURRENT BOOK: [ {bookName} ]");
            Console.WriteLine("    ----------------------------------------------------------");
            Console.ForegroundColor = ColorText;
            Console.WriteLine("    [1] ADD New Contact");
            Console.WriteLine("    [2] EDIT Existing Contact");
            Console.WriteLine("    [3] DELETE Contact");
            Console.WriteLine("    [4] BACK to Main Menu");
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

        public static string GetInput(string prompt)
        {
            Console.WriteLine();
            Console.ForegroundColor = ColorSecondary;
            Console.Write($"    >> {prompt}: ");
            Console.ResetColor();
            return Console.ReadLine();
        }

        public static Contact GetUpdatedContactDetails(Contact existing)
        {
            PrintLogo();
            Console.ForegroundColor = ColorSecondary;
            Console.WriteLine($"    --- EDITING: {existing.firstName} {existing.lastName} ---");
            Console.WriteLine("    (Press ENTER to keep current value)");
            Console.WriteLine();

            string fName = InputEditField("First Name", existing.firstName);
            string lName = InputEditField("Last Name", existing.lastName);
            string addr = InputEditField("Address", existing.address);
            string city = InputEditField("City", existing.city);
            string state = InputEditField("State", existing.state);
            string zip = InputEditField("Zip Code", existing.zip);
            string phone = InputEditField("Phone No", existing.phoneNumber);
            string email = InputEditField("Email", existing.eMail);

            return new Contact(fName, lName, addr, city, state, zip, phone, email);
        }

        // --- Helper: Displays Search Results for Arrays ---
        public static void PrintSearchResults(Contact[] results)
        {
            PrintLogo();
            Console.WriteLine("    --- SEARCH RESULTS ---");
            Console.WriteLine();

            bool foundAny = false;
            int count = 1;

            if (results != null)
            {
                foreach (Contact c in results)
                {
                    if (c != null)
                    {
                        Console.WriteLine($"    [{count++}] {c.firstName} {c.lastName} | Phone: {c.phoneNumber} | {c.city}, {c.state}");
                        foundAny = true;
                    }
                }
            }

            if (!foundAny)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("    [!] No contacts found matching that criteria.");
                Console.ResetColor();
            }
        }

        // --- NEW Helper: Displays Single Contact Result ---
        public static void PrintSingleResult(Contact c)
        {
            PrintLogo();
            Console.WriteLine("    --- SEARCH RESULT ---");
            Console.WriteLine();

            if (c != null)
            {
                Console.WriteLine($"    Name:    {c.firstName} {c.lastName}");
                Console.WriteLine($"    Phone:   {c.phoneNumber}");
                Console.WriteLine($"    Email:   {c.eMail}");
                Console.WriteLine($"    Address: {c.address}, {c.city}, {c.state} - {c.zip}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("    [!] Person not found.");
                Console.ResetColor();
            }
        }

        private static string InputField(string label)
        {
            Console.ForegroundColor = ColorPrimary;
            Console.Write($"    {label.PadRight(12)}: ");
            Console.ForegroundColor = ColorText;
            return Console.ReadLine();
        }

        private static string InputEditField(string label, string currentValue)
        {
            Console.ForegroundColor = ColorPrimary;
            Console.Write($"    {label.PadRight(12)} [{currentValue}]: ");
            Console.ForegroundColor = ColorText;
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input)) return currentValue;
            return input;
        }

        public static void WaitForKey()
        {
            Console.WriteLine();
            Console.WriteLine("    Press any key to continue...");
            Console.ReadKey();
        }
    }
}