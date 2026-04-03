using System.Text.RegularExpressions;

public class SentenceParser
{
    public static void Main(String[] args)
    {
        string text = "Ramaa and Gavindar visited the Eiffel Tower on 12/05/2023.";
        
        // Extract Capitalized Words
        var caps = Regex.Matches(text, @"\b[A-Z][a-z]*\b");
        // Extract Dates
        var dates = Regex.Matches(text, @"\b\d{2}/\d{2}/\d{4}\b");

        Console.WriteLine("Capitalized Words: " + string.Join(", ", caps));
        Console.WriteLine("Dates: " + string.Join(", ", dates));
    }
}