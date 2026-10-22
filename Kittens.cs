// Exercise 14.1: Kittens**
// Write a program in which:
// - There is a `Kitten` class.
// - Objects of this type have a `cuteness` attribute of type `double` that is initialized through a constructor.
// - A class variable (aka a static variable) named `count` of type `int` that is initialized to 0, and incremented every time a kitten is constructed.
// - Add a `Main` method that – via a for-loop – constructs a number of `Kitten` objects with varying `cuteness`, and then finally prints out the value of `count`
// - Execute the program and verify that `count` has the expected value.


// class Method
// {
//     public static void Main(String[] args)
//     {
//         Kitten kittens = new Kitten("high");
//         Console.WriteLine($"The amount of kittens are {KittenAmount}");

//         foreach(Kitten)
//     }    
// }


// public class Kitten
// {
//     public double Cuteness;

//     public Kitten(double cuteness)
//     {
//         Cuteness = cuteness;
//     }
// }

// public class KittenAmount
// {
//     public static int Count;

//     public KittenAmount(int count)
//    {
//        Count = count;
//    } 
// }

class Kitten 
{
    double cuteness;
    static int count = 0;

    public Kitten(double cuteness) 
    {
        this.cuteness = cuteness;
        if (cuteness > 9000) 
        {
            Console.WriteLine("The cuteness of this kitten is over 9000!");
        }
        count++;
    }

    public static void Main(string[] args) 
    {
        for (int i = 0; i < 9002; i++) 
        {
            new Kitten(i);
        }
        Console.WriteLine($"There are {count} kittens.");
    }
}