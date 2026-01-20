using System;

public interface IMealPlan
    {
        string Category { get; }
        List<string> GetMeals();
    }