using System.Text.RegularExpressions;

public class TextCleaner
{
    public static void Main()
    {
        // Problem 8: Multiple Spaces
        string input = "Gavindar   is    coding   now.";
        string clean = Regex.Replace(input, @"\s+", " ");
        
        // Problem 9: Censor
        string sentence = "This is a damn bad example from Priyansu.";
        string censored = Regex.Replace(sentence, @"\b(damn|stupid)\b", "****", RegexOptions.IgnoreCase);

        Console.WriteLine($"Cleaned: {clean}");
        Console.WriteLine($"Censored: {censored}");
    }
}