using System;

public class Rotate
{
    public static void Main(string[] args)
    {
        List<string> names = new List<string> { "Dev", "Risita", "Ramaa", "Priyansuuuuuu", "Lovish" };
        int k = 2;
        k %= names.Count;
        
        List<string> temp = names.GetRange(0, names.Count - k);
        names.RemoveRange(0, names.Count - k);
        names.AddRange(temp);
        
        Console.WriteLine(string.Join(", ", names));
    }
}