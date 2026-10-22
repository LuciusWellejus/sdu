// Exercise 22.1: Timing
// Subtask 1:
// Write a program in which
// 1. There is a single class called Timing.
// 2. This class contains a single static method called Fun. This method takes two double parameters (x and y), and returns a double. This method is recursively defined so that:
// 	- If y ≤ 1 then it returns the value of x.
// 	- Otherwise (y > 1), it turns the value of the following expression: Fun(x,y-1) * Fun(x,y-1).
// 3. The same class contains a Main method which for x = 1.0000001 iterates through all y values from 1 to 32 (both included). For every combination of x and y, it evaluates Fun(x,y), prints out the resulting value, and times how long time the evaluation takes.
// 	- The static method DateTimeOffset.Now.ToUnixTimeMilliseconds returns a timestamp measured in milliseconds in the form of a long.
// 	- By subtracting one such timestamp from another, you get the time in between.

// Subtask 2:
// Does this implementation calculate Fun(x,-1) correctly, and why is this the case?

// Subtask 3:
// Is this otherwise a good implementation of Fun(x,y)?


class Timing
{
        public static double Fun(double x, double y)
        {
            if (y <=1)
                {
                    return x;
                }
                else
                {
                    return Fun(x,y-1) * Fun(x,y-1);
                }
        }
        
        public static void Main(string[] args)
        {
            double x = 1.0000001;
            
            for(int i = 1; i<=32 ;i++)
            {
                long start = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                double fun = Fun(x,i);
                long end = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                Console.WriteLine(fun + $"the time between is {end-start}");
            }
        }
}