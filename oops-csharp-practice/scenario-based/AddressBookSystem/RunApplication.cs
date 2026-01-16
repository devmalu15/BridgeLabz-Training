using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeLabsTrainingVS.ScenarioBased.AddressBook;

namespace BridgeLabsTrainingVS.ScenarioBased.AddressBookSystem
{
    public class RunApplication
    {
        public static void Main(String[] args)
        {
            Utility.SetupConsole();

            AddressBook myBook = new AddressBook();
            IAddressable addressable = new AddressableImpl();

            bool isRunning = true;

            while (isRunning)
            {
                Utility.PrintLogo();
                Utility.ShowMainMenu();

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Contact newContact = Utility.CreateContactWithUI();
                        addressable.AddContact(myBook, newContact);
                        Utility.WaitForKey();
                        break;

                    case "2":
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("    Invalid Choice.");
                        System.Threading.Thread.Sleep(1000);
                        break;
                }
            }
        
        }
    }
}
