using System;
using System.Collections.Generic;

public class BankingSystemProblem
{
    public static void Main(string[] args)
    {
        Dictionary<int, double> accounts = new Dictionary<int, double>();
        Queue<string> withdrawalRequests = new Queue<string>();

        accounts[101] = 5000.00;
        accounts[102] = 10000.00;

        withdrawalRequests.Enqueue("Dev-101-500");
        withdrawalRequests.Enqueue("Risita-102-1000");
        withdrawalRequests.Enqueue("Lovish-101-200");

        while (withdrawalRequests.Count > 0)
        {
            Console.WriteLine("Processing Request: " + withdrawalRequests.Dequeue());
        }

        SortedDictionary<double, int> sortedCustomers = new SortedDictionary<double, int>();
        foreach(var kvp in accounts)
        {
            sortedCustomers.Add(kvp.Value, kvp.Key);
        }

        Console.WriteLine("\nCustomers sorted by balance:");
        foreach(var kvp in sortedCustomers)
        {
            Console.WriteLine($"Account {kvp.Value}: ${kvp.Key}");
        }
    }
}