using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.keywords
{
    public class BankAccountSystem
    {
        static String bankName = "SBI";
        readonly String[] accounts;

        public BankAccountSystem(String[] accounts)
        {
            this.accounts = accounts;
        }

        public static int getTotalAccounts(BankAccountSystem bank)
        {
            int count = 0;

            for(int i = 0; i < bank.getAccounts().Length; i++)
            {
                if (bank.getAccounts()[i] == null)
                {
                    break;
                }
                else
                {
                    count++;
                }
            }

            return count;
        }

        public String[] getAccounts()
        {
            return this.accounts;
        }


        public static void Main(String[] args)
        {
            String[] accounts = new String[100];

            for (int i = 0; i < 97; i++)
            {
                accounts[i] = "ACC-" + (100 + i);
            }

            BankAccountSystem bank = new BankAccountSystem(accounts);
            Console.WriteLine(bank is BankAccountSystem);
            Console.WriteLine(getTotalAccounts(bank));
        }

    }
}
