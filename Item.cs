namespace inventory_management_assignment
{
    public class Item
    {
        public Item(string name, int quantity)
        {
            _name = name;
            _quantity = quantity;
            _createdAt = DateTime.Now;
        }
        public string GetName()
        {
            return _name;
        }
        public DateTime GetCreatedAt()
        {
            return _createdAt;
        }
          public int GetQuantity()
        {
            return _quantity;
        }
        private readonly string _name;
        private int _quantity;
        private DateTime _createdAt;

    }


}
