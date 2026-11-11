// Exercise 24.1: Pin
// When paying wirelessly with a credit card, there are rules for when to provide a PIN. One of
// the rules could be that you must always provide a PIN when the amount exceeds 350 DKK.
// Another could state that you – regardless of the amount – must provide a PIN at least every
// fourth transaction.
// The method Expend in the following class has been developed to decide whether it is necessary
// to ask for a PIN:

// Subtask 1 
// Investigate how the method Expend works.

// Subtask 2
// The code is built to comply with the two rules described at the beginning of this exercise. For
// each of these rules, you must now find the boundary cases. Boundary cases are those situations
// that define the edge of there a condition shifts between true or not. For example, 17 and 18 are
// boundary cases for some logic that determines whether a person has the right to vote (assuming
// that you have to be 18 to vote).

// Subtask 3
// Some rules are expressed in the problem text, and others may have arisen during the implementation. Create a test case that represents each combination of boundary values, and execute
// these test cases. Now verify that the method Expend works correctly by looking at the results
// of executing the program that you build from the test code.

// Subtask 4
// How would the testing strategy change if there was a random number generator in the picture
// such that the probability that you would be asked to provide a PIN code was 20%?

public class Pin
{
    const int CRITICAL_AMOUNT = 350;
    const int MAX_TRANSACTIONS = 4;
    private int time2pin = MAX_TRANSACTIONS;
    
    bool Expend (int amount)
    {
        if (time2pin==0 || amount>CRITICAL_AMOUNT)
        {
            time2pin = MAX_TRANSACTIONS;
        }
        return amount > CRITICAL_AMOUNT || --time2pin == 0;
    }

    public static void Main (string[] args)
    {
        Pin pin = new Pin();
        for (int i=0 ; i<20 ; i++)
        {
            bool give_pin = pin.Expend(42);
            Console.WriteLine(i + ": 42 -> " + give_pin);
            }
        }
}