// List of tasks below for the C# program:

//1. Declare and initialize an array of integers.
//2. You decide how many elements and what their values are.
//3. Use example values that showcase.
//4. detemines the largest negative value stored in the array.

// Introduction:
// Hi there, I'm Lucius and this my first pointgiving activity.
// In this program, you I've writen in C#, which the program is called "Point.cs"

int[] array = [-26, -13, 12, 1, 30, -27]; // A declared and initialized array with integeres
int largestnegative = 0; // this is the starting value which it find from 0 to -2147483648.

for(int i = 0; i < array.Length; i++){
    if(array[i] < largestnegative){ // array[i] is the array filed with values.
        // the largest negative is large then array[i] so 0, it will print the largest negative
        largestnegative = array[i];
    }
}
Console.WriteLine($"Largest negative number in the array is {largestnegative}$");
// A simple printing line to showcase the largest negativ in the terminal, where the lowest is 0.