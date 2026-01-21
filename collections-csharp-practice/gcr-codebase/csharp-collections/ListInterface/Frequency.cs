using System;

public class Frequency
{
    public static void Main(string[] args)
    {
        List<string> input = new List<string> { "Dev", "Gavindar", "Dev", "Risita" };
        Dictionary<string, int> freq = new Dictionary<string, int>();
        
        foreach (var item in input)
        {
            if (freq.ContainsKey(item)) freq[item]++;
            else freq[item] = 1;
        }

        foreach (var kvp in freq) Console.WriteLine($"{kvp.Key}: {kvp.Value}");
    }
}