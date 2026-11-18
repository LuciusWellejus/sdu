// Exercise 23.3: Sum
// In the following program, there is a Sum method that is written to sum up the values of a series
// of numbers.

// The program also has a Main method that defines two test cases and prints the
// result of calling Sum on each of them.

// However, it seems that Sum is not written correctly. Can
// you figure out what is wrong and fix the code?

public class Adder
{
    public static int Sum (int[] numbers)
    {
        int result = 0;
        for (int i=1 ; i<=numbers.Length ; i++)
        {
            result += i;
        }
        return result;
    }
    public static void Main (string[] args)
    {
        int[] testcase1 = {1, 3, 5, 2, 3, 7};
        int[] testcase2 = {5, 6, 2, 3};
        Console.WriteLine(Sum(testcase1));
        Console.WriteLine(Sum(testcase2));
    }
}