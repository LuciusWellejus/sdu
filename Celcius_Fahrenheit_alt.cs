// Exercise 6.8: Celcius to Fahrenheit Alternatives
// Make two other variants of the program from exercise 6.6; one for each to the remaining loop
// types. Rewrite your solution to use this loop type.

double c = -5;

while (c <= 40)
{
    double f = c*9/5 + 32;
    Console.WriteLine("{0,5:F1}°C {1,5:F1}°F", c, f);
    c += 0.5;
}
    
// Implementation based on do-while:
// double c = -5;
// do
//     {
//     double f = c*9/5 + 32;
//     Console.WriteLine("{0,5:F1}°C {1,5:F1}°F", c, f);
//     c += 0.5;
// }
// while (c <= 40);