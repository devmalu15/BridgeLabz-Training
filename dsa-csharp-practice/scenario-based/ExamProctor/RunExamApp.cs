using System;

public class RunExamApp
    {
        public static void Main(string[] args)
        {
            IExamProctor proctor = new ExamProctorImpl();
            bool running = true;

            Console.WriteLine("=== ONLINE EXAM SYSTEM ===");
            Console.WriteLine("Hint: Correct Answers -> Q1:A, Q2:B, Q3:C");

            while (running)
            {
                ExamUtility.ShowMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        int q = ExamUtility.GetInt("Question ID");
                        proctor.VisitQuestion(q);
                        break;
                    case "2":
                        int qa = ExamUtility.GetInt("Question ID");
                        string ans = ExamUtility.GetString("Answer (A/B/C/D)");
                        proctor.SubmitAnswer(qa, ans);
                        break;
                    case "3":
                        proctor.ShowLastVisited();
                        break;
                    case "4":
                        proctor.SubmitExam();
                        running = false; 
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            }
        }
    }