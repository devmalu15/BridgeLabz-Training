using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.Bank
{
    public class Client
    {
        String clientName;
        int clientCode;
        String role;
        String branchName;
        BankAccount[] accounts;
        String clientPassword;

        public Client(String clientName, String clientPassword, String branchName)
        {
            Random random = new Random();
            this.clientName = clientName;
            this.clientPassword = clientPassword;
            this.clientCode = random.Next(10000, 99999);
            this.role = "client";
            this.accounts = new BankAccount[5];
            this.branchName = branchName;
        }

        public int getCode()
        {
            return this.clientCode;
        }


        public BankAccount[] getaccNum()
        {
            return this.accounts;
        }

        public String getName()
        {
            return this.clientName;
        }

        public BankAccount[] getAcc()
        {
            return this.accounts;
        }

        public void setAccounts(BankAccount acc)
        {
            int count = 0;
            for (int i = 0; i < this.accounts.Length; i++)
            {
                if (this.accounts[i] == null)
                {
                    break;
                }
                else
                {
                    count++;
                }
            }
            this.accounts[count] = acc;
        }

        public void deposit(int amount, String clientName, String accNumber, int fourDigitCode, Client client)
        {
            for(int i = 0; i < client.getAcc().Length; i++)
            {
                if (client.getAcc()[i].getAccNum() == accNumber)
                {
                    client.getAcc()[i].increaseBalance(amount);
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        public void withdraw(int amount, String clientName, String accNumber, int fourDigitCode, Client client)
        {
            for (int i = 0; i < client.getAcc().Length; i++)
            {
                if (client.getAcc()[i].getAccNum() == accNumber)
                {
                    client.getAcc()[i].decreaseBalance(amount);
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
