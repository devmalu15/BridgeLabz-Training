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
                    case "1": // ADD
                        Contact newContact = Utility.CreateContactWithUI();
                        addressable.AddContact(myBook, newContact);
                        Utility.WaitForKey();
                        break;

                    case "2": // EDIT
                        string searchNameEdit = Utility.GetSearchName();
                        Contact contactToEdit = addressable.ShowContact(myBook, searchNameEdit);

                        if (contactToEdit != null)
                        {
                            Contact updatedVars = Utility.GetUpdatedContactDetails(contactToEdit);

                            addressable.EditContact(
                                myBook,
                                contactToEdit,
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

                    case "3": // DELETE
                        string searchNameDelete = Utility.GetSearchName();

                        // 1. Find the contact first
                        Contact contactToDelete = addressable.ShowContact(myBook, searchNameDelete);

                        if (contactToDelete != null)
                        {
                            // 2. Pass the found object to DeleteContact
                            addressable.DeleteContact(myBook, contactToDelete);

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\n    [!] Contact '{searchNameDelete}' deleted successfully.");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n    [!] Contact not found. Cannot delete.");
                            Console.ResetColor();
                        }
                        Utility.WaitForKey();
                        break;

                    case "4": // EXIT
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