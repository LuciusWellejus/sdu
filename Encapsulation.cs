// Exercise 14.5: Encapsulation
// Follow these instructions:
// 1. Describe in english what the programs Main method does. Focus on the details. Verify by evaluation.
// 2. Make a copy of this program. You will not continue the work on the old version, but you need it for step 11.
// 3. Update the new copy so that the attribute r (that represents a radius) is replaced by a d attribute (that represents a diameter).
// 4. Write down the changes you have made to achieve this.
// 5. Make a copy of this program. You will not continue the work on the old version, but you need it for step 11.
// 6. Encapsulate all attributes. To encapsulate an attribute, you need to: • Declare the attribute private. • Add relevant getters and setters.
// 7. Make a copy of this program. You will not continue the work on the old version.
// 8. Create a new class by the name Coordinate that represent an (x, y) coordinate.
// 9. Update the new program to make use of the Coordinate class.
// 10. Write down the changes you have made to achieve this.
// 11. Steps 4 and 10 represents similar changes with different starting points. The difference is whether the attributes are encapsulated. Compare not you notes from these steps. What does encapsulation for for you when you modify the representation of Circle?

class Circle
{
    public double x, y;
    public double r;
    public Circle (double x, double y, double radius)
    {
        this.x = x;
        this.y = y;
        this.r = radius;
    }
}

class TestCircle
{
    static void Main (string[] args)
    {
        Circle c = new Circle(1.24, 2.83, 12.7);
        Console.WriteLine("x=" + c.x + " y=" + c.y + " r=" + c.r);
        c.r *= 1.37; c.x += 0.65;
        Console.WriteLine("x=" + c.x + " y=" + c.y + " r=" + c.r);
    }
}