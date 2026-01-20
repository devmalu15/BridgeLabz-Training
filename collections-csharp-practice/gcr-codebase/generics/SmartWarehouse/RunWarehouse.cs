using System;

public class RunWarehouse
    {
        public static void Main(string[] args)
        {
            Storage<Electronics> eStorage = new Storage<Electronics>();
            eStorage.AddItem(new Electronics("Laptop", 2.5));
            eStorage.AddItem(new Electronics("Smart TV", 15.0));
            eStorage.DisplayInventory();

            Storage<Groceries> gStorage = new Storage<Groceries>();
            gStorage.AddItem(new Groceries("Apples", 1.0));
            gStorage.DisplayInventory();

            IEnumerable<WarehouseItem> allElectronics = eStorage.GetAllItems();
        }
    }