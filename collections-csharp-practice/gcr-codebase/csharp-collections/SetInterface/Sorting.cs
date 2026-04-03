using System;

public class Sorting
{
    public static void Main(string[] args)
    {
        HashSet<int> nums = new HashSet<int> { 5, 1, 9, 3 };
        List<int> sorted = new List<int>(nums);
        sorted.Sort();
        Console.WriteLine(string.Join(", ", sorted));
    }
}