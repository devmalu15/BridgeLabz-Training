using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.AccessModifiers
{
    public class BankAccount
    {
        public string accountNumber;
        protected string accountHolder;
        private double balance;

        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("New Balance: " + balance);
        }
    }
}
