using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Inheritence.HeirarchicalInheritence
{
    public class Utility
    {
        public static void Main(string[] args)
        {
            SavingsAccount sa = new SavingsAccount();
            sa.accountNumber = "SA123";
            sa.balance = 5000;
            sa.interestRate = 3.5;
            sa.DisplayAccountType();

            CheckingAccount ca = new CheckingAccount();
            ca.accountNumber = "CA456";
            ca.balance = 2000;
            ca.withdrawalLimit = 1000;
            ca.DisplayAccountType();

            Console.WriteLine("----------------");

            Teacher t = new Teacher();
            t.name = "abc";
            t.subject = "Physics";
            t.DisplayRole();

            Student s = new Student();
            s.name = "abc";
            s.grade = "10th";
            s.DisplayRole();
        }
    }
}
