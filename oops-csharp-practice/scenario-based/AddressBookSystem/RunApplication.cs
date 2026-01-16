using System;
using BridgeLabsTrainingVS.ScenarioBased.AddressBook;

namespace BridgeLabsTrainingVS.ScenarioBased.AddressBookSystem
{
    public class RunApplication
    {
        // Storage for multiple books
        static AddressBook[] bookShelf = new AddressBook[10];
        static IAddressable bookManager = new AddressableImpl();
        static IContactable contactManager = new ContactableImpl();

        public static void Main(String[] args)
        {
            Utility.SetupConsole();
            bool appRunning = true;

            while (appRunning)
            {
                Utility.PrintLogo();
                Utility.ShowBookMenu(); // Show Level 1 Menu
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": // CREATE NEW BOOK
                        string newName = Utility.GetInput("Enter New Book Name");
                        if (bookManager.findBook(bookShelf, newName) != null)
                        {
                            Console.WriteLine("    [!] A book with this name already exists.");
                        }
                        else
                        {
                            AddNewBookToShelf(newName);
                        }
                        Utility.WaitForKey();
                        break;

                    case "2": // OPEN BOOK
                        string openName = Utility.GetInput("Enter Book Name to Open");
                        AddressBook selectedBook = bookManager.findBook(bookShelf, openName);

                        if (selectedBook != null)
                        {
                            // Enter the Level 2 Loop
                            ManageBookContacts(selectedBook);
                        }
                        else
                        {
                            Console.WriteLine("    [!] Book not found.");
                            Utility.WaitForKey();
                        }
                        break;

                    case "3": // DELETE BOOK
                        string delName = Utility.GetInput("Enter Book Name to DELETE");
                        DeleteBookFromShelf(delName);
                        Utility.WaitForKey();
                        break;

                    case "4": // EXIT
                        appRunning = false;
                        break;

                    default:
                        Console.WriteLine("    Invalid Option.");
                        break;
                }
            }
        }

        // --- LEVEL 2: MANAGING CONTACTS INSIDE A BOOK ---
        private static void ManageBookContacts(AddressBook currentBook)
        {
            bool inBook = true;
            while (inBook)
            {
                Utility.ShowContactMenu(currentBook.bookName);
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": // ADD Contact
                        Contact newContact = Utility.CreateContactWithUI();
                        contactManager.AddContact(currentBook, newContact);
                        Utility.WaitForKey();
                        break;

                    case "2": // EDIT Contact
                        string searchEdit = Utility.GetInput("Enter Name to Edit");
                        Contact editTarget = contactManager.ShowContact(currentBook, searchEdit);
                        if (editTarget != null)
                        {
                            Contact updated = Utility.GetUpdatedContactDetails(editTarget);
                            contactManager.EditContact(currentBook, editTarget,
                                updated.firstName, updated.lastName, updated.address,
                                updated.city, updated.state, updated.zip,
                                updated.phoneNumber, updated.eMail);
                            Console.WriteLine("    [!] Contact Updated.");
                        }
                        else Console.WriteLine("    [!] Not Found.");
                        Utility.WaitForKey();
                        break;

                    case "3": // DELETE Contact
                        string searchDel = Utility.GetInput("Enter Name to Delete");
                        Contact delTarget = contactManager.ShowContact(currentBook, searchDel);
                        if (delTarget != null)
                        {
                            contactManager.DeleteContact(currentBook, delTarget);
                            Console.WriteLine("    [!] Contact Deleted.");
                        }
                        else Console.WriteLine("    [!] Not Found.");
                        Utility.WaitForKey();
                        break;

                    case "4": // BACK
                        inBook = false;
                        break;
                }
            }
        }

        // --- HELPER: Add Book to Array ---
        private static void AddNewBookToShelf(string name)
        {
            for (int i = 0; i < bookShelf.Length; i++)
            {
                if (bookShelf[i] == null)
                {
                    bookShelf[i] = new AddressBook(name);
                    Console.WriteLine($"    [!] Address Book '{name}' Created Successfully.");
                    return;
                }
            }
            Console.WriteLine("    [!] No space left for new books.");
        }

        // --- HELPER: Delete Book from Array ---
        private static void DeleteBookFromShelf(string name)
        {
            for (int i = 0; i < bookShelf.Length; i++)
            {
                if (bookShelf[i] != null && bookShelf[i].bookName == name)
                {
                    bookShelf[i] = null;
                    Console.WriteLine($"    [!] Address Book '{name}' Deleted.");
                    return;
                }
            }
            Console.WriteLine("    [!] Book not found.");
        }
    }
}