using System;

public class MealManager
    {
        public static void GeneratePlan<T>() where T : IMealPlan, new()
        {
            T plan = new T();
            Console.WriteLine($"\nGenerating {plan.Category} Meal Plan:");
            foreach (var item in plan.GetMeals())
            {
                Console.WriteLine($" - {item}");
            }
        }

        public static void ValidatePlan<T>(T plan) where T : IMealPlan
        {
            if (plan.GetMeals().Count > 0)
                Console.WriteLine($"[Success] {plan.Category} plan is valid.");
            else
                Console.WriteLine($"[Error] {plan.Category} plan is empty.");
        }
    }