using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased
{
    public class TestGrader
    {
        static string[] studentAnswers = new string[100]
{
    // 1-10: Mostly Correct & Case Issues
    "apple", "Apple", "APPLE", "apple", " apple", "apple ", "Apple", "apple", "APPLE", "apple",
    
    // 11-20: Common Typos (Partially Right)
    "aple", "appel", "appple", "apel", "alppe", "apple", "aple", "appel", "appl", "epple",
    
    // 21-30: Completely Wrong
    "banana", "orange", "pear", "fruit", "red", "car", "xyz", "hello", "book", "computer",
    
    // 31-40: Plurals & Grammatical (Partially Right)
    "apples", "an apple", "the apple", "Apples", "apples", "apple.", "apple!", "apple?", "apples", "apple",
    
    // 41-50: Mixed Bag
    "apple", "banana", "aple", "Apple", "orange", "apple", "grape", "app", "le", "apple",
    
    // 51-60: Way off / Empty
    "", " ", "null", "app", "le", "ppl", "a", "e", "applepie", "pineapple",
    
    // 61-70: Leet speak / Weird casing (Partially Right)
    "aPPle", "AppLe", "applE", "4pple", "@pple", "apple", "Apple", "APPLE", "apple", "aple",
    
    // 71-80: Hard Typos
    "abble", "ipple", "upple", "ample", "apply", "aptle", "apple", "apple", "orange", "banana",
    
    // 81-90: Correct
    "apple", "apple", "apple", "apple", "apple", "apple", "apple", "apple", "apple", "apple",
    
    // 91-100: Final Mix
    "Apple", "aple", "banana", "apple", "appel", "apples", "fruit", "red", "APPLE", "apple"
};


        static String rightAnswer = "apple";

        public static bool partialChecker(String str)
        {
            int lettercount = 0;
            if(str.Length >= rightAnswer.Length)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (rightAnswer.Contains(str[i]))
                    {
                        lettercount++;
                    }
                }
            }

            if((lettercount + 1) == str.Length || (lettercount - 1) == str.Length || lettercount == str.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static String Checker(String answers)
        {
           

                if (answers.ToLower() == rightAnswer.ToLower())
                {
                    return "correct!";
                }

                else if (answers.ToLower().Contains(rightAnswer.ToLower()) || partialChecker(answers))
                {
                    return "partially correct!";
                }
                else
                {
                    return "wrong!";
                }
               
            
            return null;
        }

        public static void DisplayMenu()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n==========================================");
                Console.WriteLine("          AUTOMATED TEST GRADER           ");
                Console.WriteLine("==========================================");
                Console.WriteLine($"Target Answer: \"{rightAnswer}\"");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("1. View All 100 Student Results");
                Console.WriteLine("2. View Grade Statistics (Summary)");
                Console.WriteLine("3. Test a Custom Answer");
                Console.WriteLine("4. Exit");
                Console.WriteLine("------------------------------------------");
                Console.Write("Enter your choice (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\n--- Detailed Results ---");
                        Console.WriteLine("{0,-20} | {1}", "Student Answer", "Result");
                        Console.WriteLine(new string('-', 40));

                        for (int i = 0; i < studentAnswers.Length; i++)
                        {
                            // Using string formatting {-20} to align columns
                            Console.WriteLine("{0,-20} | {1}", studentAnswers[i], Checker(studentAnswers[i]));
                        }
                        break;

                    case "2":
                        int correctCount = 0;
                        int partialCount = 0;
                        int wrongCount = 0;

                        // Loop through array to calculate stats
                        foreach (string ans in studentAnswers)
                        {
                            string result = Checker(ans);
                            if (result == "correct!") correctCount++;
                            else if (result == "partially correct!") partialCount++;
                            else wrongCount++;
                        }

                        Console.WriteLine("\n--- Class Statistics ---");
                        Console.WriteLine($"Total Students:    {studentAnswers.Length}");
                        Console.WriteLine($"Fully Correct:     {correctCount}");
                        Console.WriteLine($"Partially Correct: {partialCount}");
                        Console.WriteLine($"Wrong:             {wrongCount}");
                        break;

                    case "3":
                        Console.Write("\nEnter a test answer: ");
                        string input = Console.ReadLine();
                        string outcome = Checker(input);
                        Console.WriteLine($"\nInput: \"{input}\"");
                        Console.WriteLine($"Grade: {outcome}");
                        break;

                    case "4":
                        exit = true;
                        Console.WriteLine("Exiting grader...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        public static void Main(String[] args)
        {
            DisplayMenu();
        }


    }
}
