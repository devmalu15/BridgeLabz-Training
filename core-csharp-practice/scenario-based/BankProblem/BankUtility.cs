using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeLabsTrainingVS.ScenarioBased.BankProblem;

namespace BridgeLabsTrainingVS.ScenarioBased.Bank
{
    public class BankUtility
    {

        static Bank myBank;

        

        public static void Main(String[] args)
        {
            
            SetupBankSystem();

            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine($"      WELCOME TO {myBank.getName()} SYSTEM      "); 
                Console.WriteLine("========================================");
                Console.WriteLine("1. Branch Manager Login (Create Client/Account)");
                Console.WriteLine("2. Client Login (Deposit/Withdraw)");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ManagerMenu();
                        break;
                    case "2":
                        ClientMenu();
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Press Enter to try again.");
                        Console.ReadLine();
                        break;
                }
            }
        }

       

        private static void ManagerMenu()
        {
            Console.Clear();
            Console.WriteLine("--- MANAGER PORTAL ---");

            
            Console.Write("Enter Branch Name to manage: ");
            string branchName = Console.ReadLine();
            Branch selectedBranch = FindBranch(branchName);

            if (selectedBranch == null)
            {
                Console.WriteLine("Branch not found! Press Enter to return.");
                Console.ReadLine();
                return;
            }

           
            BranchManager manager = new BranchManager(selectedBranch.getName(), "System Admin");

            bool back = false;
            while (!back)
            {
                Console.WriteLine($"\nManaging Branch: {selectedBranch.getName()}");
                Console.WriteLine("1. Add New Client");
                Console.WriteLine("2. Add Account for Existing Client");
                Console.WriteLine("3. List All Clients in Branch");
                Console.WriteLine("4. Back to Main Menu");
                Console.Write("Choice: ");
                string subChoice = Console.ReadLine();

                switch (subChoice)
                {
                    case "1":
                        Console.Write("Enter New Client Name: ");
                        string cName = Console.ReadLine();
                        Console.Write("Enter Password: ");
                        string cPass = Console.ReadLine();

                       
                        manager.CreateClient(cName, cPass, selectedBranch.getName(), selectedBranch);
                        break;

                    case "2":
                        Console.Write("Enter Client Name: ");
                        string targetClient = Console.ReadLine();
                        Console.Write("Enter Account Type (Savings/Current): ");
                        string type = Console.ReadLine();

                        
                        manager.CreateAcc(targetClient, "dummyPass", selectedBranch.getName(), selectedBranch, type, 1234, "SBI");
                        break;

                    case "3":
                        PrintClients(selectedBranch);
                        break;

                    case "4":
                        back = true;
                        break;
                }
            }
        }

        private static void ClientMenu()
        {
            Console.Clear();
            Console.WriteLine("--- CLIENT PORTAL ---");

            
            Console.Write("Enter Branch Name: ");
            string bName = Console.ReadLine();
            Branch branch = FindBranch(bName);
            if (branch == null) { Console.WriteLine("Branch not found."); Console.ReadLine(); return; }

            Console.Write("Enter Your Name: ");
            string cName = Console.ReadLine();

            Client client = FindClientInBranch(branch, cName);

            if (client == null)
            {
                Console.WriteLine("Client not found or invalid credentials.");
                Console.ReadLine();
                return;
            }

            
            bool back = false;
            while (!back)
            {
                Console.WriteLine($"\nWelcome, {client.getName()}");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Show My Accounts");
                Console.WriteLine("4. Logout");
                Console.Write("Choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        
                        PrintClientAccounts(client);
                        Console.Write("Enter Account Number: ");
                        string accNumDep = Console.ReadLine();
                        Console.Write("Enter Amount: ");
                        int amtDep = int.Parse(Console.ReadLine());

                        
                        client.deposit(amtDep, client.getName(), accNumDep, 0000, client);
                        Console.WriteLine("Operation Complete.");
                        break;

                    case "2":
                        PrintClientAccounts(client);
                        Console.Write("Enter Account Number: ");
                        string accNumWit = Console.ReadLine();
                        Console.Write("Enter Amount: ");
                        int amtWit = int.Parse(Console.ReadLine());

                        
                        client.withdraw(amtWit, client.getName(), accNumWit, 0000, client);
                        Console.WriteLine("Operation Complete.");
                        break;

                    case "3":
                        PrintClientAccounts(client);
                        break;

                    case "4":
                        back = true;
                        break;
                }
            }
        }

        

        private static void SetupBankSystem()
        {
            
            myBank = new Bank("SBI", 10, 101);

           
            Branch mainBranch = new Branch("MainBranch", "SBI", 01, "Mumbai", "Manager1");

            
            Branch[] branches = myBank.getBranches();
            branches[0] = mainBranch;
        }

        private static Branch FindBranch(string name)
        {
            Branch[] branches = myBank.getBranches();
            for (int i = 0; i < branches.Length; i++)
            {
                if (branches[i] != null && branches[i].getName() == name)
                {
                    return branches[i];
                }
            }
            return null;
        }

        private static Client FindClientInBranch(Branch branch, string clientName)
        {
            Client[] clients = branch.getClients();
            for (int i = 0; i < clients.Length; i++)
            {
                if (clients[i] != null && clients[i].getName() == clientName)
                {
                    return clients[i];
                }
            }
            return null;
        }

        private static void PrintClients(Branch branch)
        {
            Client[] clients = branch.getClients();
            Console.WriteLine("\nList of Clients:");
            for (int i = 0; i < clients.Length; i++)
            {
                if (clients[i] != null)
                {
                    Console.WriteLine($"- {clients[i].getName()} (Code: {clients[i].getCode()})");
                }
            }
        }

        private static void PrintClientAccounts(Client client)
        {
            BankAccount[] accounts = client.getAcc();
            Console.WriteLine("\nYour Accounts:");
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] != null)
                {
                    
                    Console.WriteLine($"- Acc No: {accounts[i].getAccNum()}" + "     " + accounts[i].getAccBalance());
                    
                }
            }
        }


    }
    
}
