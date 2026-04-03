using System;

public class RemoveDuplicates
{
    public static void Main(string[] args)
    {
        List<string> input = new List<string> { "Ramaa", "Dev", "Ramaa", "Lovish" };
        HashSet<string> seen = new HashSet<string>();
        List<string> result = new List<string>();
        
        foreach (var item in input)
        {
            if (seen.Add(item)) result.Add(item);
        }
        Console.WriteLine(string.Join(", ", result));
    }
}