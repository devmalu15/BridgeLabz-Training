using System;

using System;
using System.Collections.Generic;

namespace MealPlanSystem
{
    public interface IMealPlan
    {
        string Category { get; }
        List<string> GetMeals();
    }

    public class VegetarianMeal : IMealPlan
    {
        public string Category => "Vegetarian";
        public List<string> GetMeals() => new List<string> { "Salad", "Pasta", "Fruit Bowl" };
    }

    public class KetoMeal : IMealPlan
    {
        public string Category => "Keto";
        public List<string> GetMeals() => new List<string> { "Grilled Chicken", "Avocado", "Eggs" };
    }

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

    public class RunMealPlan
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Meal Plan Generator ---");
            
            MealManager.GeneratePlan<VegetarianMeal>();
            MealManager.GeneratePlan<KetoMeal>();

            var myKeto = new KetoMeal();
            MealManager.ValidatePlan(myKeto);
        }
    }