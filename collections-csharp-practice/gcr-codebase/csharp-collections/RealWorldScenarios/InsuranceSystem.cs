using System;
using System.Collections.Generic;

public class InsuranceSystem
{
    public class Policy
    {
        public string Id { get; set; }
        public string Owner { get; set; }
        public DateTime Expiry { get; set; }
        public string Type { get; set; }
    }

    public static void Main(string[] args)
    {
        HashSet<string> uniqueIds = new HashSet<string>();
        SortedList<DateTime, Policy> sortedByExpiry = new SortedList<DateTime, Policy>();
        List<Policy> allPolicies = new List<Policy>();

        AddPolicy(uniqueIds, sortedByExpiry, allPolicies, "P1", "Dev", DateTime.Now.AddDays(10), "Auto");
        AddPolicy(uniqueIds, sortedByExpiry, allPolicies, "P2", "Risita", DateTime.Now.AddDays(40), "Home");
        AddPolicy(uniqueIds, sortedByExpiry, allPolicies, "P3", "Ramaa", DateTime.Now.AddDays(5), "Health");
        AddPolicy(uniqueIds, sortedByExpiry, allPolicies, "P1", "DuplicateDev", DateTime.Now.AddDays(100), "Auto"); 

        Console.WriteLine("Expiring within 30 days:");
        foreach (var kvp in sortedByExpiry)
        {
            if (kvp.Key < DateTime.Now.AddDays(30))
                Console.WriteLine($"{kvp.Value.Owner} - {kvp.Value.Expiry.ToShortDateString()}");
        }
    }

    private static void AddPolicy(HashSet<string> ids, SortedList<DateTime, Policy> sorted, List<Policy> list, string id, string owner, DateTime date, string type)
    {
        if (ids.Add(id))
        {
            Policy p = new Policy { Id = id, Owner = owner, Expiry = date, Type = type };
            sorted.Add(date, p);
            list.Add(p);
        }
    }
}