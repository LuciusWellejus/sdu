namespace Interface
{
    public interface IDomain
    {
        public void Load ();
        public void Store ();
        public void AddNonFoodItem (string name, double price, string[] materials);
    }
}