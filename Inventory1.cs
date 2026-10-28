// Exercise 15.1: Inventory
// Subtask 1
// Extend the implementation to reflect this UML class diagram:
// The GetInventoryValue must iterate through all Item objects in items, call GetPrice on each
// of the objects, sum up the resulting values and return this value.
// The PrintInventory method must print out a textual representation of all the objects in the
// items array using Console.WriteLine. Use a loop of your choice to accomplish this.
// AddItem and RemoveItem must add and remove objects to and from the items array.

// Subtask 2
// Move the Main method out into a Test class and update it in such a way that you add items of
// both FoodItem and NonFoodItem to an Items array in an instance of Inventory.
// Call the PrintInventory and GetInventoryValue methods to validate their functionality.


class Method
{
    public static void Main(String[] args)
    {
        Inventory myInventory = new Inventory();

        FoodItem bread = new FoodItem("bread", 15.00, new DateTime(2026, 10, 10));
        FoodItem milk = new FoodItem("milk", 12.50, new DateTime(2026, 11, 05));
        NonFoodItem screw = new NonFoodItem("screw", 5.00, ["jern"]);
        NonFoodItem hammer = new NonFoodItem("hammer", 45.00, ["wood", "steel"]);

        myInventory.AddItem(bread);
        myInventory.AddItem(milk);
        myInventory.AddItem(screw);
        myInventory.AddItem(hammer);

        Console.WriteLine("--- Show Inventory ---");
        myInventory.PrintInventory();

        Console.WriteLine($"Total Price: {myInventory.GetInventoryValue()}");

        Console.WriteLine("\n--- Removing milk ---");
        myInventory.RemoveItem(milk);

        Console.WriteLine("\n--- Updated Inventory ---");
        myInventory.PrintInventory();

        Console.WriteLine($"Total Price: {myInventory.GetInventoryValue()}");
    }    
}

public class Inventory
{
    private Item[] items = new Item[0];

    public void AddItem(Item item)
    {
        Array.Resize(ref items, items.Length + 1);
        items[items.Length - 1] = item;
    }

    public void RemoveItem(Item item)
    {
        int index = Array.IndexOf(items, item);
        if (index >= 0)
        {
            Item[] newItems = new Item[items.Length - 1];
            for (int i = 0, j = 0; i < items.Length; i++)
            {
                if (i != index)
                {
                    newItems[j++] = items[i];
                }
            }
            items = newItems;
        }
    }

    public double GetInventoryValue()
    {
        double sum = 0;
        for (int i = 0; i < items.Length; i++)
        {
            sum = sum + items[i].GetPrice();
        }
        return sum;
    }

    public void PrintInventory()
    {
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(items[i].ToString());
        }
    }
}

public class Item
{
    public string Name;
    public double Price;

    public Item(string name, double price)
    {
        Name = name;
        Price = price;
    }
    
    public string GetName()
    {
        return Name;
    }
    public double GetPrice()
    {
        return Price;
    }
}


public class NonFoodItem : Item
{
    public string[] Materials;

    public NonFoodItem(string name, double price, string[] materials): base(name, price)
    {
        Materials = materials; 
    }
    public string[] GetMaterials()
    {
        return Materials;
    }

    public override string ToString()
    {
        return GetName() + " " + GetPrice() + " " + string.Join(", ", Materials); //NonFoodItem must return the name, price, and list of materials as a string.
    }
}

public class FoodItem : Item
{
    public DateTime ExpiresAt;

    public FoodItem(string name, double price, DateTime expiresAt): base(name, price)
    {
        ExpiresAt = expiresAt;
    }

    public DateTime GetExpiresAt()
    {
        return ExpiresAt.Date;
    }

    public override string ToString()
    {
        return GetName()+" "+ GetPrice()+" "+GetExpiresAt(); // FoodItem must return the name, price, and expiration date as a string.
    }
}