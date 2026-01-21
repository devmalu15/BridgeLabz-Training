using System;

public class Subset
{
    public static void Main(string[] args)
    {
        HashSet<string> parent = new HashSet<string> { "Dev", "Risita", "Ramaa", "Priyansuuuuuu" };
        HashSet<string> child = new HashSet<string> { "Dev", "Ramaa" };
        Console.WriteLine(child.IsSubsetOf(parent));
    }
}