using System.Text.RegularExpressions;

public class FinanceExtractor
{
    public static void Main()
    {
        string text = "Ramaa spent $45.99 and Risita saved $ 10.50.";
        // Handles optional $, optional space, digits, and decimals
        var prices = Regex.Matches(text, @"\$?\s?\d+\.\d{2}");

        foreach (Match p in prices) Console.WriteLine($"Found Price: {p.Value.Trim()}");
    }
}