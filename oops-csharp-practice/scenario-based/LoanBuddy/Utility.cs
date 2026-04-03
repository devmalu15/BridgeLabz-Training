using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.FinlyTech.LoanBuddy
{
    public class Utility
    {
        public void RunLoanProcess()
        {
            // --- HEADER ---
            Console.Clear();
            Console.WriteLine("=================================================");
            Console.WriteLine("       FINLYTECH LOAN BUDDY SYSTEM v1.0          ");
            Console.WriteLine("=================================================");
            Console.WriteLine("Welcome! Please enter applicant details below.\n");

            // --- STEP 1: GATHER APPLICANT DETAILS ---
            Console.Write("Enter Applicant Name: ");
            string name = Console.ReadLine();

            // Using helper method to keep main logic clean (see bottom of class)
            int creditScore = GetIntInput("Enter Credit Score (300-850): ");
            int income = GetIntInput("Enter Monthly Income: ");
            int loanAmount = GetIntInput("Enter Requested Loan Amount: ");

            // Create Applicant Object
            Applicant applicant = new Applicant(name, creditScore, loanAmount, income);

            // --- STEP 2: LOAN SELECTION ---
            Console.WriteLine("\n-------------------------------------------------");
            Console.WriteLine("Choose Loan Type:");
            Console.WriteLine("1. Home Loan     (Requires Credit: 400)");
            Console.WriteLine("2. Auto Loan     (Requires Credit: 300)");
            Console.WriteLine("3. Personal Loan (Requires Credit: 500)");
            Console.WriteLine("-------------------------------------------------");

            int choice = GetIntInput("Enter choice (1-3): ");
            int years = GetIntInput("Enter Loan Term (in Years): ");
            double interest = GetDoubleInput("Enter Annual Interest Rate (e.g. 5.5): ");

            // --- STEP 3: POLYMORPHISM / FACTORY LOGIC ---
            // We create the specific child class based on selection.
            // This ensures the correct 'requiredCredits' is automatically loaded.
            Loan activeLoan = null;
            string loanTypeString = "";

            switch (choice)
            {
                case 1:
                    loanTypeString = "Home";
                    activeLoan = new HomeLoan(years, interest, loanTypeString);
                    break;
                case 2:
                    loanTypeString = "Auto";
                    activeLoan = new AutoLoan(years, interest, loanTypeString);
                    break;
                case 3:
                    loanTypeString = "Personal";
                    activeLoan = new PersonalLoan(years, interest, loanTypeString);
                    break;
                default:
                    Console.WriteLine("Invalid selection. Defaulting to Personal Loan.");
                    loanTypeString = "Personal";
                    activeLoan = new PersonalLoan(years, interest, loanTypeString);
                    break;
            }

            // Create LoanApplication Object
            LoanApplication application = new LoanApplication(applicant, loanTypeString, years, interest);

            // --- STEP 4: PROCESSING (USING APPROVAL IMPLEMENTATION) ---
            IApproval approvalSystem = new ApprovalImpl();

            // Check Approval
            bool isApproved = approvalSystem.ApproveLoan(application, activeLoan);

            // Calculate EMI
            int monthlyEMI = approvalSystem.CalculateEMI(application);


            // --- STEP 5: FINAL REPORT (CLEAN OUTPUT) ---
            Console.WriteLine("\n\n");
            Console.WriteLine("=================================================");
            Console.WriteLine($"           LOAN APPLICATION REPORT              ");
            Console.WriteLine("=================================================");
            Console.WriteLine($" Applicant:       {applicant.name.ToUpper()}");
            Console.WriteLine($" Credit Score:    {applicant.creditScore}");
            Console.WriteLine($" Loan Type:       {loanTypeString} Loan");
            Console.WriteLine($" Required Score:  {activeLoan.requiredCredits}"); // Shows inheritance feature
            Console.WriteLine("-------------------------------------------------");

            if (isApproved)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" STATUS:          APPROVED");
                Console.ResetColor();
                Console.WriteLine($" Approved Amount: {applicant.loanAmount:C0}"); // Formats as currency
                Console.WriteLine($" Interest Rate:   {interest}%");
                Console.WriteLine($" Term:            {years} Years");
                Console.WriteLine("-------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($" ESTIMATED EMI:   {monthlyEMI:C0} / month");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" STATUS:          REJECTED");
                Console.ResetColor();
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine(" Reason(s):");
                if (applicant.creditScore < activeLoan.requiredCredits)
                {
                    Console.WriteLine($"  - Credit Score {applicant.creditScore} is below required {activeLoan.requiredCredits}.");
                }
                if (applicant.income * 2 < applicant.loanAmount)
                {
                    Console.WriteLine($"  - Loan amount exceeds 2x annual income capability.");
                }
            }
            Console.WriteLine("=================================================\n");

            // Allow user to see result before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        // --- HELPER METHODS FOR CLEANER INPUT ---

        private int GetIntInput(string prompt)
        {
            int result;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out result) && result >= 0)
                {
                    return result;
                }
                Console.WriteLine("Invalid input. Please enter a valid positive number.");
            }
        }

        private double GetDoubleInput(string prompt)
        {
            double result;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (double.TryParse(input, out result) && result >= 0)
                {
                    return result;
                }
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
