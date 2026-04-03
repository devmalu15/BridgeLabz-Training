using System.Text.RegularExpressions;

public class ContactExtractor
{
    public static void Main()
    {
        string text = "Contact Lovis at lovis@example.com and Risita at https://risita.me";
        
        var emails = Regex.Matches(text, @"[\w\.-]+@[\w\.-]+\.[a-z]{2,}");
        var links = Regex.Matches(text, @"https?://[^\s]+");

        Console.WriteLine("Emails found:");
        foreach (Match m in emails) Console.WriteLine($"- {m.Value}");
        
        Console.WriteLine("Links found:");
        foreach (Match m in links) Console.WriteLine($"- {m.Value}");
    }
}