using System;

public class Furniture : WarehouseItem
    {
        public Furniture(string name, double weight) : base(name, weight) { }
        public override void GetDetails() => Console.WriteLine($"[Furniture] {Name} ({Weight}kg) - Heavy item.");
    }