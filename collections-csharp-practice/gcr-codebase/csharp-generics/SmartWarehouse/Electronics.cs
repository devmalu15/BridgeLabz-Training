using System;

public class Electronics : WarehouseItem
    {
        public Electronics(string name, double weight) : base(name, weight) { }
        public override void GetDetails() => Console.WriteLine($"[Electronics] {Name} ({Weight}kg) - Handle with care.");
    }