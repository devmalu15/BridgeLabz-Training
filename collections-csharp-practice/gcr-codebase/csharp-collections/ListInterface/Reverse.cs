using System;

public class Reverse
{
    public static void Main(string[] args)
    {
        List<string> names = new List<string> { "Dev", "Risita", "Ramaa", "Priyansuuuuuu", "Lovish" };
        int start = 0, end = names.Count - 1;
        
        while (start < end)
        {
            string temp = names[start];
            names[start] = names[end];
            names[end] = temp;
            start++;
            end--;
        }
        Console.WriteLine(string.Join(", ", names));
    }
}