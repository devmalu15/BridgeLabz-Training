using System;

public class Storage<T> where T : WarehouseItem
    {
        private List<T> _items = new List<T>();

        public void AddItem(T item)
        {
            _items.Add(item);
            Console.WriteLine($"Added {item.Name} to storage.");
        }

        public void DisplayInventory()
        {
            Console.WriteLine("\n--- Inventory ---");
            foreach (var item in _items)
            {
                item.GetDetails();
            }
        }
        
        public IEnumerable<T> GetAllItems() => _items;
    }