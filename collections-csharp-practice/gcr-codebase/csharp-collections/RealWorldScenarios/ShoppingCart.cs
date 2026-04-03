using System;
using System.Collections.Generic;

public class ShoppingCart
{
    public static void Main(string[] args)
    {
        SortedDictionary<double, string> cartByPrice = new SortedDictionary<double, string>();
        Dictionary<string, double> productPrices = new Dictionary<string, double>();

        AddItem(cartByPrice, productPrices, "Apple", 1.20);
        AddItem(cartByPrice, productPrices, "Laptop", 1200.00);
        AddItem(cartByPrice, productPrices, "Headphones", 50.00);

        foreach (var item in cartByPrice)
        {
            Console.WriteLine($"{item.Value}: ${item.Key}");
        }
    }

    private static void AddItem(SortedDictionary<double, string> cart, Dictionary<string, double> prices, string name, double price)
    {
        cart[price] = name;
        prices[name] = price;
    }
}