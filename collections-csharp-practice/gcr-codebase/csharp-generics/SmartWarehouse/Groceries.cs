using System;

public class Groceries : WarehouseItem
    {
        public Groceries(string name, double weight) : base(name, weight) { }
        public override void GetDetails() => Console.WriteLine($"[Groceries] {Name} ({Weight}kg) - Perishable.");
    }