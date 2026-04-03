using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Reviews.AmazonPay
{
    public class User
    {
        String name;
        int uID;

        public User(String name, int uID)
        {
            this.name = name;
            this.uID = uID;
        }
    

    public void Payment(Bank bank, int accountNumber, String mode, int amount)
        {
            if (mode == "credit")
            {
                int creditLimit = 100;
                int realCost =  100;
                int cost = (int) (realCost * 0.8);
                for (int i = 0; i < bank.getAccAndBal().Length; i++)
                {
                    if (bank.getAccAndBal()[i, 0] == accountNumber)
                    {
                        if (creditLimit > bank.getAccAndBal()[i, 2])
                        {
                            Console.WriteLine("Credit Score is not sufficient!");
                            bank.getAccDetails(i);
                            break;
                        }
                        else if (cost > bank.getAccAndBal()[i, 1])
                        {
                            Console.WriteLine("Account Balance is insufficient!");
                            bank.getAccDetails(i);
                            break;
                        }
                        else
                        {
                            bank.subtractBalance(amount, i);
                            Console.WriteLine("Item ordered successfully!");
                            Console.WriteLine("Discount applied successfully!   real cost = " + realCost + "discounted = " + cost);
                            bank.getAccDetails(i);
                            break;
                        }
                    }
                }
            }

            if (mode == "debit")
            {
                int cost = 100;
                for (int i = 0; i < 100; i++)
                {
                    if (bank.getAccAndBal()[i, 0] == accountNumber)
                    {
                        if (cost > bank.getAccAndBal()[i, 1])
                        {
                            Console.WriteLine("Account Balance is not sufficient!");
                            bank.getAccDetails(i);
                            break;
                        }
                        else
                        {
                            bank.subtractBalance(amount, i);
                            Console.WriteLine("Item ordered successfully!");
                            bank.getAccDetails(i);
                            break;
                        }
                    }
                }
            }

            if (mode == "COD")
            {
                Console.WriteLine("Item ordered successfully!");
            }
        }
    }
}
