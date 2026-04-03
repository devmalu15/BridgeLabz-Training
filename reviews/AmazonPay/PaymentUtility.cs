using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Reviews.AmazonPay
{
    public class PaymentUtility
    {
        

        public static void Main(String[] args)
        {
            int[,] accAndBal = new int[5, 3]
        {
            {1000010001, 1000, 250},
            {1000010002, 500, 90 },
            {1000010003, 1000, 250 },
            {1000010004, 1000, 250 },
            {1000010005, 1000, 250 },
        };

            Bank bank = new Bank(accAndBal);

            User user = new User("Dev", 11111);

            user.Payment(bank, 1000010001, "debit", 100);
            user.Payment(bank, 1000010002, "credit", 10);
            user.Payment(bank, 1000010003, "credit", 1000);
        }


    }
}
