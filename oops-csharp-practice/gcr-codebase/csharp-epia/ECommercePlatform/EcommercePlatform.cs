using System;

namespace ECommercePlatform.ECommercePlatform
{
    public class EcommercePlatform
    {
        public static void Main(string[] args)
        {
            Product[] Products = new Product[3];

            for (int i = 0; i < Products.Length; i++)
            {
                Console.WriteLine("\nSelect Product Category:");
                Console.WriteLine("1. Electronics");
                Console.WriteLine("2. Clothing");
                Console.WriteLine("3. Groceries");
                Console.Write("Enter choice: ");

                int Choice = Convert.ToInt32(Console.ReadLine());

                Product Product;

                switch (Choice)
                {
                    case 1:
                        Product = new Electronics();
                        break;

                    case 2:
                        Product = new Clothing();
                        break;

                    case 3:
                        Product = new Groceries();
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        i--;
                        continue;
                }

                Console.Write("Enter Product ID: ");
                Product.ProductId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Product Name: ");
                Product.Name = Console.ReadLine();

                Console.Write("Enter Product Price: ");
                Product.Price = Convert.ToDouble(Console.ReadLine());

                Products[i] = Product;
            }

            ProductProcessor Processor = new ProductProcessor();
            Processor.ShowFinalPrices(Products);
        }
    }
}
