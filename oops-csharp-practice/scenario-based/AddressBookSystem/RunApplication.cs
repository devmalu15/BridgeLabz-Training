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
            IContactable addressable = new ContactableImpl();

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
                        string searchName = Utility.GetSearchName();
                        Contact foundContact = addressable.ShowContact(myBook, searchName);

                        if (foundContact != null)
                        {
                            Contact updatedVars = Utility.GetUpdatedContactDetails(foundContact);

                            addressable.EditContact(
                                myBook,
                                foundContact,
                                updatedVars.firstName,
                                updatedVars.lastName,
                                updatedVars.address,
                                updatedVars.city,
                                updatedVars.state,
                                updatedVars.zip,
                                updatedVars.phoneNumber,
                                updatedVars.eMail
                            );

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n    [!] Contact updated successfully.");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n    [!] Contact not found.");
                            Console.ResetColor();
                        }
                        Utility.WaitForKey();
                        break;

                    case "3":
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