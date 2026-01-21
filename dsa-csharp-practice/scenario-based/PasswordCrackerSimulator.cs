using System;
using System.Diagnostics;
using System.Text;

public class PasswordCrackerSimulator
{
    static long iterations = 0;
    public static void PasswordCracker(string password, int length)
    {
        string possibleChars = "abcdefghijklmnopqrstuvwxyz1234567890!@#$%^&*()_";
        char[] buffer = new char[length]; 
        iterations = 0;

        Console.WriteLine($"Starting attack on password '{password}'...");
        
        Stopwatch sw = new Stopwatch();
        sw.Start();

        bool success = SolveRecursive(password, possibleChars, buffer, 0);

        sw.Stop();
        
        if (success)
        {
            Console.WriteLine($"Time taken: {sw.ElapsedMilliseconds} ms");
            Console.WriteLine($"Total iterations: {iterations}");
        }
        else
        {
            Console.WriteLine("Password not found.");
            Console.WriteLine($"Total iterations: {iterations}");
        }
    }

    static bool SolveRecursive(string target, string chars, char[] buffer, int depth)
    {
        if (depth == buffer.Length)
        {
            iterations++;
            string guess = new string(buffer);
            
            if (guess == target)
            {
                Console.WriteLine($"CRACKED! The password is: {guess}");
                return true; 
            }
            return false; 
        }

        for (int i = 0; i < chars.Length; i++)
        {
            buffer[depth] = chars[i];

            if (SolveRecursive(target, chars, buffer, depth + 1))
            {
                return true;
            }
        }

        return false; 
    }

    public static void Main(String[] args)
    {
        PasswordCracker("zzzzzzz", 7);
    }
}