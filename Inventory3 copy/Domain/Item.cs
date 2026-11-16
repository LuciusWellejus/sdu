namespace Domain
{
    public abstract class Item : IExpirable, IComparable<Item>
    {
        public string Name { get; set; }
        public double Price { get; set; }

        protected Item(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public abstract bool IsExpired();

        public int CompareTo(Item? other)
        {
            if (other == null) return 1;
            return Price.CompareTo(other.Price);
        }

        public abstract string GetItemType();

        public abstract string[] GetState();

        public string Marshal()
        {
            string type = GetItemType();
            string[] parameters = GetState();
            return $"{type} {string.Join(" ", parameters)}";
        }

        public static Item? Unmarshal(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return null;

            string[] args = input.Split(' ');
            string type = args[0];

            return type switch
            {
                "FoodItem" => FoodItem.Unmarshal(args),
                "NonFoodItem" => NonFoodItem.Unmarshal(args),
                _ => null
            };
        }
    }
}