// Exercise 13.1: Inventory
// Subtask 1
// The UML class diagram in figure 13.1 shows parts of an inventory system that makes use of
// inheritane. Implement the classes depicted in this figure.
// The ToString methods in FoodItem and NonFoodItem must be annotated with the override
// keyword as they override the method from the Object class (not shown on the diagram).
// The ToString method in FoodItem must return the name, price, and expiration date as a string.
// The ToString method in NonFoodItem must return the name, price, and list of materials as astring.

// Subtask 2
// Make in your own Main method an array that can hold 10 FoodItem objects. Use a loop to add
// a FoodItem object to each element in this array.
// Then add a loop in which you call the ToString method on each of the FoodItem objects in your
// array and print out the resulting string with Console.WriteLine.

// Subtask 3
// Repeat the exercise from the previous subtask, only this time for NonFoodItem objects.


// Exercise 13.1: Inventory
// Subtask 1
// The UML class diagram in figure 13.1 shows parts of an inventory system that makes use of
// inheritane. Implement the classes depicted in this figure.
// The ToString methods in FoodItem and NonFoodItem must be annotated with the override
// keyword as they override the method from the Object class (not shown on the diagram).
// The ToString method in FoodItem must return the name, price, and expiration date as a string.
// The ToString method in NonFoodItem must return the name, price, and list of materials as astring.

// Subtask 2
// Make in your own Main method an array that can hold 10 FoodItem objects. Use a loop to add
// a FoodItem object to each element in this array.
// Then add a loop in which you call the ToString method on each of the FoodItem objects in your
// array and print out the resulting string with Console.WriteLine.

// Subtask 3
// Repeat the exercise from the previous subtask, only this time for NonFoodItem objects.


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