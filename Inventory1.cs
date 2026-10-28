//Exercise 15.1: Inventory
// This exercise builds on the exercise from section 13.1. You can find a reference solution in section
// 81. It is your choice whether to build on this, or your own solution.
// Subtask 1
// Extend the implementation to reflext this UML class diagram:
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
        FoodItem[] foodArray = new FoodItem[10];
        for (int i = 0; i < 10; i++)
        {
            foodArray[i] = new FoodItem("bread", 15.00, new DateTime(2026, 10, 10));
        }
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(foodArray[i].ToString());
        }

        NonFoodItem[] nonFoodArray = new NonFoodItem[10];
        for (int i = 0; i < 10; i++)
        {
            nonFoodArray[i] = new NonFoodItem("screw", 5.00, ["jern"]);
        }
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(nonFoodArray[i].ToString());
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
          return GetName()+ " " + GetPrice(); //NonFoodItem must return the name, price, and list of materials as a string.
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