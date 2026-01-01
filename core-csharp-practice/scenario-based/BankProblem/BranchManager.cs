using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeLabsTrainingVS.ScenarioBased.BankProblem;

namespace BridgeLabsTrainingVS.ScenarioBased.Bank
{
    public class BranchManager
    {
        String branchName;
        String managerName;
        int managerCode;
        String role;
        

        public BranchManager(String branchName, String managerName)
        {
            Random random = new Random();
            this.branchName = branchName;
            this.managerName = managerName;
            this.managerCode = random.Next(100000, 999999);
            this.role = "manager";
     
        }


        public void CreateClient(String clientName, String clientPassword, String branchName, Branch branch)
        {

            bool flag = false;
            if(branch.getClients()[0] != null)
            {
                for (int i = 0; i < branch.getClients().Length; i++)
                {
                    if (branch.getClients()[i].getName() == clientName)
                    {
                        flag = true;
                        break;
                    }
                }
            }
            else
            {
                flag = false;
            }


            if (flag == false)
            {
                Client client = new Client(clientName, clientPassword, branchName);
                branch.setClients(client);
                Console.WriteLine(client.ToString());
                Console.WriteLine(client.getCode());
                Console.WriteLine(branch.getClients()[0].getCode());
            }
            else
            {
                Console.WriteLine("client already exists");
            }
        }

        public void CreateAcc(String clientName, String clientPassword, String branchName, Branch branch, String accType, int fourDigitCode, String BankName)
        {
            bool flag = false;
            Client currClient = null;
            for (int i = 0; i < branch.getClients().Length; i++)
            {
                if (branch.getClients()[i].getName() == clientName)
                {
                    flag = true;
                    currClient = branch.getClients()[i];
                    break;
                }
            }

            if(flag == true)
            {
                BankAccount account = new BankAccount(clientName, accType, fourDigitCode, BankName, branchName);
                Console.WriteLine(account.ToString());
                currClient.setAccounts(account);

            }
            else
            {
                Console.WriteLine("client doesn't exist.");
            }
        }


    }
}
