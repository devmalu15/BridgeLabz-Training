//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace BridgeLabz_Training.OOPS.BankingSystem
//{
//    internal class CurrentAccount:BankingAccount,ILoanable
//    {
//        public const double InterestRate = 0.06;
//        public CurrentAccount(long accountNumber, string holderName, double balance):base(accountNumber, holderName, balance) { }
//        public override double CalculateInterest()
//        {
//            return InterestRate*balance;
//        }
//        public void ApplyForLoan()
//        {
//            Console.WriteLine("Loan applied for current account");
//        }
//        public bool CalculateLoanEligibility(double amount)
//        {
//            return amount <= balance * 4;
//        }
//    }
//}
