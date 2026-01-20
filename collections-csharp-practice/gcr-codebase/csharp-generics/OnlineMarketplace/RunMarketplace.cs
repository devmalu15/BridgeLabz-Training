using System;

public class RunMarketplace
    {
        public static void Main(string[] args)
        {
            var book = new Product<BookCategory>("C# Mastery", 50.00);
            var shirt = new Product<ClothingCategory>("Denim Shirt", 30.00);

            Console.WriteLine(book);
            Console.WriteLine(shirt);

            Console.WriteLine("\n--- Applying Discounts ---");
            MarketplaceUtility.ApplyDiscount(book, 10);
            MarketplaceUtility.ApplyDiscount(shirt, 20);
        }
    }