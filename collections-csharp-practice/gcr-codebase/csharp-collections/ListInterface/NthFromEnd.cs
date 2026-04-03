using System;

public class NthFromEnd
{
    public static void Main(string[] args)
    {
        LinkedList<string> list = new LinkedList<string>(new[] { "Dev", "Risita", "Ramaa", "Priyansuuuuuu", "Gavindar" });
        int n = 2;
        
        LinkedListNode<string> main = list.First;
        LinkedListNode<string> refPtr = list.First;
        
        for (int i = 0; i < n; i++) refPtr = refPtr.Next;
        
        while (refPtr != null)
        {
            main = main.Next;
            refPtr = refPtr.Next;
        }
        Console.WriteLine(main.Value);
    }
}