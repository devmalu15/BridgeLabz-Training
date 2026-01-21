using System;

public class BinaryGen
{
    public static void Main(string[] args)
    {
        int n = 5;
        Queue<string> q = new Queue<string>();
        q.Enqueue("1");
        
        for (int i = 0; i < n; i++)
        {
            string curr = q.Dequeue();
            Console.Write(curr + " ");
            q.Enqueue(curr + "0");
            q.Enqueue(curr + "1");
        }
        Console.WriteLine();
    }
}