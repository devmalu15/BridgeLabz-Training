using System;

public class MapInvert
{
    public static void Main(string[] args)
    {
        Dictionary<string, int> map = new Dictionary<string, int>
        {
            { "Ramaa", 1 }, { "Priyansuuuuuu", 2 }, { "Lovish", 1 }
        };
        Dictionary<int, List<string>> inverted = new Dictionary<int, List<string>>();
        
        foreach (var kvp in map)
        {
            if (!inverted.ContainsKey(kvp.Value)) inverted[kvp.Value] = new List<string>();
            inverted[kvp.Value].Add(kvp.Key);
        }
        
        foreach (var kvp in inverted) 
            Console.WriteLine($"{kvp.Key}: [{string.Join(", ", kvp.Value)}]");
    }
}