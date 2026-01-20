using System;

public abstract class WarehouseItem
    {
        public string Name { get; set; }
        public double Weight { get; set; }

        protected WarehouseItem(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public abstract void GetDetails();
    }