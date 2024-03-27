
namespace inventory_management_assignment
{
    public enum SortOrder
    {
        ACS,
        DESC
    }
    public class Store
    {
        private readonly string _name;
        private List<Item> _items;
        private int _capacity;
        public Store(string name, int capacity)
        {
            _name = name;
            _items = [];
            _capacity = capacity;
        }
        public int GetCapacity()
        {
            return _capacity;
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
        public List<Item> SortByDate(SortOrder order)
        {
            if (order == SortOrder.DESC)
            {
                var sorted = _items.OrderByDescending(item => item.GetCreatedAt());
                return sorted.ToList();
            }
            else
            {
                return _items.OrderByDescending(item => item.GetCreatedAt()).ToList();
            }
        }
        public void GroupByDate()
        {
            var groupByDate = _items.GroupBy(item => item.GetCreatedAt() >= DateTime.Now.AddMonths(-3) ? "New Arrival" : "Old");
            foreach (var group in groupByDate)
            {
                Console.WriteLine($"{group.Key} Items:");
                foreach (var item in group)
                {
                    Console.WriteLine($" - {item.GetName()}, Created: {item.GetCreatedAt().ToShortDateString()}");
                }
            }
        }
        public int AmountOfItem()
        {
            return _items.Sum(item => item.GetQuantity());
        }
        public bool AddItem(Item newItem)
        {
            if (!_items.Any(item => item.GetName() == newItem.GetName()))
            {
                if (AmountOfItem() + newItem.GetQuantity() >= _capacity)
                {
                    Console.WriteLine($"There no capacity");

                    return false;
                }
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
    }
}
