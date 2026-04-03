using System;

public class Reverse
{
    public static void Main(string[] args)
    {
        Queue<string> q = new Queue<string>();
        q.Enqueue("Ramaa");
        q.Enqueue("Lovish");
        q.Enqueue("Dev");
        
        Stack<string> stack = new Stack<string>();
        while (q.Count > 0) stack.Push(q.Dequeue());
        while (stack.Count > 0) q.Enqueue(stack.Pop());
        
        Console.WriteLine(string.Join(", ", q));
    }
}