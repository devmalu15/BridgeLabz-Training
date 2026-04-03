using System;
using System.Collections.Generic;

public class VotingSystem
{
    public static void Main(string[] args)
    {
        Dictionary<string, int> votes = new Dictionary<string, int>();

        Vote(votes, "Priyansuuuuuu");
        Vote(votes, "Gavindar");
        Vote(votes, "Priyansuuuuuu");
        Vote(votes, "Lovish");
        Vote(votes, "Gavindar");
        Vote(votes, "Gavindar");

        SortedDictionary<string, int> sortedResults = new SortedDictionary<string, int>(votes);

        foreach (var v in sortedResults)
        {
            Console.WriteLine($"{v.Key}: {v.Value}");
        }
    }

    private static void Vote(Dictionary<string, int> votes, string candidate)
    {
        if (votes.ContainsKey(candidate)) votes[candidate]++;
        else votes[candidate] = 1;
    }
}