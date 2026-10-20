Exercise 12.2: Customer Database (Topic Creativity feedback)
Extend the result from 12.1 with the following:

1.  Create a new class called CustomerDatabase.
2. Add an attribute named customers of type Customer[] to CustomerDatabase.
    3. Add a constructor to CustomerDatabase that doesn’t take any parameters. It should
    initialize the customers attribute with an empty Customer-array with a length of 10.
4. Add the following methods to CustomerDatabase:

        A method that takes a Customer-object as parameter, and adds it to the customers
        array at an empty position. What would be suitable names for the method, and its
        parameter?

        A method that takes an int parameter, and searches through the customers array to
        check if the id attribute of any element matches this parameter. If that is the case,
        the matching object is removed from the array. Otherwise, nothing is changed. What
        would be suitable names for this method, and its parameter.

            Hint: The customers array holds references to Customer objects. The value
            null is used to indicate that a reference is invalid (aka, that the space is unused).

        A method that returns (all the contents of) the customers array. What would be a good name for this method?

        A method that prints out all the Customer objects in customers. What would be a good name for this method?

5.  Add a main method to test the new functionality. How would you do this?


class MM
{
    // Main Method
    public static void Main(String[] args)
    {
        Customer customer = new Customer("lukas", 123);

        customer.Deposit(250);         // Deposit(customer)
        customer.Withdraw(200);

        customer.GetBalance();
            
        Console.WriteLine($"Main Method and balance is {customer.GetBalance()}");

        
    }    
}

public class CustomerDatabase
{

}


public class Customer
{
    string Name;
    int Id;
    double Balance;

    
    public Customer (string name, int id)
    {
    Name = name;
    Id = id;
    Balance = 0;
    }

    public Customer (string name, int id, double balance_zero)
    {
    Name = name;
        Id = id;
    Balance = balance_zero;
    }

    
    // Deposit Method
    public void Deposit(double amount)
    {
        Balance += amount;
    }

    // Withdraw Method
    public void Withdraw(double amount)
    {
        if (Balance + amount >= 0)
        {
            Balance -= amount;
        }
    }
    
    public double GetBalance()
    {
        return Balance;
    }
}