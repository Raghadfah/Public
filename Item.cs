namespace inventory_management_assignment
{
    public class Item
    {
        public Item(string name, int quantity, DateTime? dateTime = null)
        {
            _name = name;
            Quantity = quantity;
            _createdAt = dateTime is null ? DateTime.Now : (DateTime)dateTime;
        }
        private readonly string _name;
        private int _quantity;
        private DateTime _createdAt;
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Quantity can not be negative");
                }
                else
                {
                    _quantity = value;
                }
            }
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
    }
}
