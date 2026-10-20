// Exercise 6.6: Celcius to Fahrenheit
// Write a program in which:

// 1. When executed, the program should write out a table of matching Celcius and Fahrenheit
// values.
// - Formula: TF = 32 + 9/5 T_C
// 2. There should be one matching pair per line
// 3. The list should start at -5◦C and end at 40◦C.
// 4. The list should have one line for ach 0.5◦C.

// Flow control

for (double c=-5 ; c<=40 ; c+=0.5)
{
    double f = c*9/5 + 32;
    Console.WriteLine("{0,5:F1}°C {1,5:F1}°F", c, f);
}