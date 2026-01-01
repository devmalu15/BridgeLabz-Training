using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeLabsTrainingVS.ScenarioBased.Bank;

namespace BridgeLabsTrainingVS.ScenarioBased.BankProblem
{
    public class Branch
    {
        String bankName;
        String branchName;
        int branchCode;
        String branchLocation;
        BankAccount[] accInBranch;
        Client[] clients;
        String branchManager;

        public Branch(String branchName, String bankName, int branchCode, String branchLocation, String branchManager)
        {
            this.branchName = branchName;
            this.bankName = bankName;
            this.branchCode = branchCode;
            this.branchLocation = branchLocation;
            this.accInBranch = new BankAccount[1000];
            this.clients = new Client[200];
            this.branchManager = branchManager;
        }

        public BankAccount[] getAccounts()
        {
            return this.accInBranch;
        }

        public String getName()
        {
            return this.branchName;
        }

        public void setAccounts(BankAccount acc)
        {
            int count = 0;
            for (int i = 0; i < this.accInBranch.Length; i++)
            {
                if (this.accInBranch[i] == null)
                {
                    break;
                }
                else
                {
                    count++;
                }
            }
            this.accInBranch[count] = acc;
        }

        public Client[] getClients()
        {
            return this.clients;
        }

        public void setClients(Client client)
        {
            int count = 0;
            for(int i = 0; i < this.clients.Length; i++)
            {
                if (this.clients[i] == null)
                {
                    break;
                }
                else
                {
                    count++;
                }
            }
            this.clients[count] = client;
        }


    }
}
