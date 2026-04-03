using System;

public class Product<T> where T : ICategory, new()
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public T Category { get; set; } = new T();

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString() => $"{Name} ({Category.CategoryName}) - ${Price}";
    }