namespace inventory_management_assignment
{
    public class Store
    {
        private readonly string _name;
        private List<Item> _items;

        public Store(string name)
        {
            _name = name;
            _items = [];
        }
        public List<Item> GetItems()
        {
            return _items;

        }
        public bool FindByName(string itemName)
        {
            var findItem = _items.Find(item => item.GetName() == itemName);
            if (findItem is not null)
            {
                Console.WriteLine($"{itemName} Item founded: Quantity = {findItem.GetQuantity()},CreatedDate = {findItem.GetCreatedAt()}");
                return true;
            }
            Console.WriteLine($"{itemName} Item not found");
            return false;
        }
        public int AmountOfItem(Item item)
        {
            return _items.Count;
        }
        public bool AddItems(Item newItem)
        {
            if (!_items.Any(item => item.GetName() == newItem.GetName()))
            {
                _items.Add(newItem);
                return true;
            }
            return false;
        }
        public bool RemoveItems(Item item)
        {
            _items.Remove(item);
            return true;
        }
        public List<Item> SortItem()
        {
            return _items.OrderBy(item => item.GetName()).ToList();
        }
        // public int Capacity()
        // {
            
        // }




    }
}
