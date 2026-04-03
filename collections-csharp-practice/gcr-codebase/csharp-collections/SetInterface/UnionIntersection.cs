using System;

public class UnionIntersection
{
    public static void Main(string[] args)
    {
        HashSet<string> set1 = new HashSet<string> { "Dev", "Risita", "Ramaa" };
        HashSet<string> set2 = new HashSet<string> { "Priyansuuuuuu", "Lovish" };
        
        HashSet<string> union = new HashSet<string>(set1);
        union.UnionWith(set2);
        
        HashSet<string> intersect = new HashSet<string>(set1);
        intersect.IntersectWith(set2);
        
        Console.WriteLine("Union: " + string.Join(", ", union));
        Console.WriteLine("Intersection: " + string.Join(", ", intersect));
    }
}