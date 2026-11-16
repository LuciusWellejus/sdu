namespace Presentation
{
    class Test
    {
        public static void Add()
        {
        Interface.IDomain domain = new Domain.Domain("FIle.txt");
        domain.Load();
        domain.AddNonFoodItem("USB_Charger", 17.45, new string[] {"plastic", "stuff"});
        domain.Store();
    
        
        // Item i1 = new NonFoodItem("USB_Charger", 17.45, new string[] { "plastic", "stuff" });
        // Inventory inventory = new Inventory();
        // inventory.Load("inventory.txt");
        // inventory.AddItem(i1);
        // inventory.Store("inventory.txt");
        }
        public static void Main (string[] args)
        {
            Add();
            Console.WriteLine("the USB (nonfood item) has been added");
        }
    }
}
    
    // public static void List ()
    // {
    //     Inventory inventory = new Inventory();
    //     inventory.Load("inventory.txt");
    //     inventory.PrintInventory();
    //     }
    //     public static void Main (string[] args)
    //     {
    //         Add();
    //         List();
    //     }