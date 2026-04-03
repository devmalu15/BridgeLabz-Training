using System;

public class HospitalTriage
{
    public static void Main(string[] args)
    {
        PriorityQueue<string, int> pq = new PriorityQueue<string, int>();
        pq.Enqueue("Dev", 3);
        pq.Enqueue("Risita", 1); 
        pq.Enqueue("Gavindar", 2);
        
        while (pq.Count > 0) Console.WriteLine(pq.Dequeue());
    }
}