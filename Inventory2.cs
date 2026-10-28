// Exercise 16.1: Inventory
// Subtask 1
// To ensure that items are always instantiated as either FoodItem or NonFoodItem objects, you
// must declare the Item class abstract. What happens if you then try to instantiate the Item class
// directly, and why is this the case?

// Subtask 2
// CHAPTER 16. ABSTRACT METHODS 216
// Create an interface called IExpireable that contains a method with the following prototype:
// bool IsExpired();

// Subtask 3
// Implement this interface in Item.

// Subtask 4
// As FoodItem and NonFoodItem inherits from Item, they also inherit the IsExpired method.
// Override this method in the FoodItem class and make its implementation rely on the expiresAt
// attribute for defining when the item is too old.
// Hint: The DateTime type in the .NET framework can be used to represent dates (and a time
// of day).

// ----------------------------------------------------------------------------------------------------

// Subtask 2 & 3: Interfacet oprettes og implementeres i Item
interface IExpireable 
{ 
    bool IsExpired(); 
}

// Subtask 1 & 3: Item er abstract og implementerer IExpireable
public abstract class Item : IExpireable
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

    // Subtask 3: Default virtuel metode så alle nedarvede klasser har adgang
    public virtual bool IsExpired()
    {
        return false;
    }
}

class Method
{
    public static void Main(string[] args)
    {
        Inventory myInventory = new Inventory();

        FoodItem bread = new FoodItem("bread", 15.00, new System.DateTime(2026, 10, 10));
        FoodItem milk = new FoodItem("milk", 12.50, new System.DateTime(2026, 11, 05));
        NonFoodItem screw = new NonFoodItem("screw", 5.00, new string[] { "jern" });
        NonFoodItem hammer = new NonFoodItem("hammer", 45.00, new string[] { "wood", "steel" });

        myInventory.AddItem(bread);
        myInventory.AddItem(milk);
        myInventory.AddItem(screw);
        myInventory.AddItem(hammer);

        System.Console.WriteLine("--- Show Inventory ---");
        myInventory.PrintInventory();

        System.Console.WriteLine($"Total Price: {myInventory.GetInventoryValue()}");

        System.Console.WriteLine("\n--- Removing milk ---");
        myInventory.RemoveItem(milk);

        System.Console.WriteLine("\n--- Updated Inventory ---");
        myInventory.PrintInventory();

        System.Console.WriteLine($"Total Price: {myInventory.GetInventoryValue()}");
    }    
}

public class Inventory
{
    private Item[] items = new Item[0];

    public void AddItem(Item item)
    {
        System.Array.Resize(ref items, items.Length + 1);
        items[items.Length - 1] = item;
    }

    public void RemoveItem(Item item)
    {
        int index = System.Array.IndexOf(items, item);
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
            System.Console.WriteLine(items[i].ToString());
        }
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
        return GetName() + " " + GetPrice() + " " + string.Join(", ", Materials);
    }
}

public class FoodItem : Item
{
    public System.DateTime ExpiresAt;

    public FoodItem(string name, double price, System.DateTime expiresAt): base(name, price)
    {
        ExpiresAt = expiresAt;
    }

    public System.DateTime GetExpiresAt()
    {
        return ExpiresAt.Date;
    }

    // Subtask 4: Metoden overskrives til at bruge expiresAt-attributten
    public override bool IsExpired()
    {
        return System.DateTime.Now > ExpiresAt;
    }

    public override string ToString()
    {
        return GetName()+" "+ GetPrice()+" "+GetExpiresAt();
    }
}