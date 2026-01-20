using System;

public class VegetarianMeal : IMealPlan
    {
        public string Category => "Vegetarian";
        public List<string> GetMeals() => new List<string> { "Salad", "Pasta", "Fruit Bowl" };
    }