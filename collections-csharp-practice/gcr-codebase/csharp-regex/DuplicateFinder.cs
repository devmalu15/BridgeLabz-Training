using System.Text.RegularExpressions;

public class DuplicateFinder
{
    public static void Main()
    {
        string text = "Lovis is is going to to the the market.";
        // \b(\w+) matches a word, \s+ matches space, \1 matches the exact same word again
        var matches = Regex.Matches(text, @"\b(\w+)\s+\1\b", RegexOptions.IgnoreCase);

        Console.WriteLine("Repeated words found:");
        foreach (Match m in matches)
        {
            Console.WriteLine($"- {m.Groups[1].Value}");
        }
    }
}