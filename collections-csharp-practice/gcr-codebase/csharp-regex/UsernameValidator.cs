using System;
using System.Text.RegularExpressions;

public class UsernameValidator
{
    public static void Main(String[] args)
    {
        string[] users = { "Priyansu_01", "123gavindar", "lovis", "Risita_2024" };
        string pattern = @"^[a-zA-Z][a-zA-Z0-9_]{4,14}$";

        foreach (var user in users)
        {
            bool isValid = Regex.IsMatch(user, pattern);
            Console.WriteLine($"{user}: {(isValid ? "✅ Valid" : "❌ Invalid")}");
        }
    }
}