using System;

public class MarketplaceUtility
    {
        public static void ApplyDiscount<C>(Product<C> product, double percentage) where C : ICategory, new()
        {
            double discountAmount = product.Price * (percentage / 100);
            product.Price -= discountAmount;
            Console.WriteLine($"Applied {percentage}% discount on {product.Name}. New Price: ${product.Price}");
        }
    }