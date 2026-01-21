using System;

public class SymmetricDifference
{
    public static void Main(string[] args)
    {
        HashSet<string> set1 = new HashSet<string> { "Dev", "Gavindar" };
        HashSet<string> set2 = new HashSet<string> { "Gavindar", "Lovish" };
        
        set1.SymmetricExceptWith(set2);
        Console.WriteLine(string.Join(", ", set1));
    }
}

