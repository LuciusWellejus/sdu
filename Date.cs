// Exercise 22.2: Date
// Write a program which
// 1. Constructs a DateType object for each of the timestamps 10^3 , 10^4 , 10^5 and 10^6.
// 	- First, use the System.DateTimeOffset.FromUnixTimeMilliseconds method to create a DateTimeOffset object from the timestamp.
// 	- Then acess the DateTime attribute.
	
// 2. For each of these, print out the time represented by the object by using its implementation of the ToString method.
// 3. Verify that these printouts makes sense by reading the documentation1 .


class Date
{
    public static void Main (string[] args)
    {
    DateTime Day = System.DateTimeOffset.FromUnixTimeMilliseconds(1000).DateTime;
    for (int i = 1000; i <= 1000000 ; i*=10)
    {
        // Console.Write(i);

        DateTime temp = System.DateTimeOffset.FromUnixTimeMilliseconds(i).DateTime;
        Console.WriteLine(temp);
    }

    // Console.WriteLine(Day);
    }
}