using System;

public class WordFrequency
{
    public static void Main(string[] args)
    {
        string text = "Dev hello Dev hello Risita";
        var words = text.Split(' ');
        Dictionary<string, int> freq = new Dictionary<string, int>();
        
        foreach (var w in words)
        {
            if (freq.ContainsKey(w)) freq[w]++;
            else freq[w] = 1;
        }
        foreach (var kvp in freq) Console.WriteLine($"{kvp.Key}: {kvp.Value}");
    }
}