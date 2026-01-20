using System;

public class ExamUtility
    {
        public static void ShowMenu()
        {
            Console.WriteLine("1. Go to Question (Navigation)");
            Console.WriteLine("2. Answer Question");
            Console.WriteLine("3. Check Last Visited");
            Console.WriteLine("4. Submit Exam");
            Console.WriteLine("5. Exit");
            Console.Write("Select: ");
        }

        public static int GetInt(string prompt)
        {
            Console.Write($"    {prompt}: ");
            return int.Parse(Console.ReadLine());
        }

        public static string GetString(string prompt)
        {
            Console.Write($"    {prompt}: ");
            return Console.ReadLine();
        }
    }