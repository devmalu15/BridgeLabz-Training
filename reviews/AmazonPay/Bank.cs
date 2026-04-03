using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Reviews.AmazonPay
{
    public class Bank
    {
        int[,] accountsAndDetails;
        int accNumIndex;
        int balanceIndex;
        int creditIndex;

        public Bank(int[,] accountsAndBalance)
        {
            this.accountsAndDetails = accountsAndBalance;
            this.accNumIndex = 0;
            this.balanceIndex = 1;
            this.creditIndex = 2;
        }

        public int[,] getAccAndBal()
        {
            return this.accountsAndDetails;
        }

        public void addBalance(int amount, int i)
        {
            this.accountsAndDetails[i, this.balanceIndex] = amount + this.accountsAndDetails[i, this.balanceIndex];
        }

        public void subtractBalance(int amount, int i)
        {
            this.accountsAndDetails[i, this.balanceIndex] = this.accountsAndDetails[i, this.balanceIndex] - amount;
        }

        public void getAccDetails(int i)
        {
            for(int j = 0; j < creditIndex + 1; j++) 
            {
                Console.WriteLine(this.accountsAndDetails[i, j] + "    ");
            }
        }
    }
}
