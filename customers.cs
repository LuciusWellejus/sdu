// 1. Create a new project with a class that contains a Main-method.
// 2. Create, in this project, a new class called Customer.
// 3. In the Customer class, add the following
//     An attribute called name of type string.
//     An attribute called id of type int.
//     An attribute called balance of type double.
// 4. Add constructors to the Customer class:
// One constructor takes a name and an id as parameters, and uses these values to
// initialize their corresponding attributes. The balance attribute is initialized to zero.

// One constructor takes a name, an id and a balance as parameters, and uses these
// values to initialize their corresponding attributes.

// 5. Add methods to the Customer class:
// A method named Deposit with void return type that takes a parameter named
// amount of type double. This method must increment the value of balance with the
// value of amount.

// A method named Withdraw with void return type that takes a parameter named
// amount of type double. This method must decrement the value of balance with the
// value of amount if and only if balance is greater than or equal to amount. In other
// words, the balance is not allowed to go negative.

// A method named GetBalance that returns a double. When called, this method
// should return the value of balance.

// 6. In the Main method, declare a variable called aCustomer of type Customer.

// 7. Then, assign to aCustomer a (reference to a new) Customer object. This is done using an
// assignment statement where the right-hand side creates a new Customer object by calling
// a constructor for Customer. You decide which arguments to give it.

//     Hint: “new” is used to call the constructor of a class.
    
// 8. Deposit money to the Customer object by calling the Deposit method using an amount of your choice.

// 9. Withdraw money from the Customer object by calling the Withdraw method with an
// amount of your choice (that is less than the amount that you deposited).

// 10. Print out the value of the balance attribute of the Customer object by calling the GetBalance
// instance method and then calling Console.WriteLine with the return value of GetBalance

// 11. Verify – by observing the printout – that the code works as you would expect.

// / / / / / / / / / / / / /

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