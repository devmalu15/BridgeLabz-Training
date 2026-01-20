using System;

public class KetoMeal : IMealPlan
    {
        public string Category => "Keto";
        public List<string> GetMeals() => new List<string> { "Grilled Chicken", "Avocado", "Eggs" };
    }