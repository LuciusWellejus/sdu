// Consider the output (i.e., what is printed to the screen), and explain what is going on. Specifically:
    
// 1. Which operators are evaluated on the individual lines? Or, in other words,
//    what does (?1?), (?2?), (?3?), (?4?) and (?5?) represent?

// 2. How do these relate to the 3rd argument to the Operator calls?
// 3. What is the important part of that 3rd parameter? Which rule is being exploited?
// 4. Is this a reasonable interface for Operator?

class OperatorTest {
    public static int Operator (int a, int b, bool c)
    {
        return a + b;
    }
    public static int Operator (int a, int b, char c)
    {
        return a - b;
    }

    
    public static void Main (string[] args)
    {
        for (int a = 0, b = 0 ; a<5 && b <5 ; a++, b++)
        { 
            Console.WriteLine(a+" (?1?) "+b+" = "+Operator(a, b, true));
            Console.WriteLine(a+" (?2?) "+b+" = "+Operator(a, b, true));
            Console.WriteLine(a+" (?3?) "+b+" = "+Operator(a, b, 'a'));
            Console.WriteLine(a+" (?4?) "+b+" = "+Operator(a, b, 'b'));
            Console.WriteLine(a+" (?5?) "+b+" = "+Operator(a, b, '.'));
        }
    }   
}