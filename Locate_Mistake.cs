// Exercise 23.1: Locate the Mistake
// The following program, given an arbitrary value for the variable points – is supposed to tell
// you whether you have passed a course:
// However, a bug has crept in!
// Locate and fix the bug.

class Score
{
    public static void Main (string[] args)
    {
        int points = 0; // imagine an arbitrary number of points between 0 and 100
        Console.Write("You ");
        if (points >= 50)
        {
            Console.Write("PASSED");
        }
        if (points <= 50)
        {
            Console.Write("FAILED");
        }
        Console.WriteLine("!");
    }
}