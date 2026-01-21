using System;

public class SetEqualityProblem
{
    public static void Main(string[] args)
    {
        HashSet<string> set1 = new HashSet<string> { "Dev", "Risita", "Ramaa" };
        HashSet<string> set2 = new HashSet<string> { "Ramaa", "Risita", "Dev" };
        Console.WriteLine(set1.SetEquals(set2));
    }
}