// Exercise 7.13: Calendar Prettyprinting
// Write a program in which
// 1. A data structure is created to hold the calendar of a single year.
// One needs to be able to index it using a date (month and day) in order to extract which weekday it is (e.g., Monday).
//
// 	- What is the type of this data structure?
// 	- How do you initialize a variable of this type?
// 	- How can you make sure that the contents is correct?
// 2. Print out the contents of this data structure in a “nice” way.

string[] days = { "Mon", "Tue", "Wed", "Thurs", "Fri", "Sat", "Sun" };
string[] months = { "Jan", "Feb", "March", "April", "May", "June", "July", "Aug", "Sep", "Oct", "Nov", "Dec" };

Console.WriteLine("The day is " + days[2] + " and the month is " + months[5]);

// string[] days = { "Mon", "Tue", "Wed", "Thurs", "Fri", "Sat", "Sun" };
// string[] months = { "Jan", "Feb", "March", "April", "May", "June", "July", "Aug", "Sep", "Oct", "Nov", "Dec" };

// int[,] calendar = new int[7,12];

// int iterations = 1;

// for (int i = 0; i < iterations; i++){
//     try{
//         Console.WriteLine(days[i]);
//     }catch (IndexOutOfRangeException){
//         Console.WriteLine("Index is outside the array.");
//     }
// }

// for(int i = 0; i < days.Length; i++){
//     Console.WriteLine(days[i]);
// }
        
// Console.WriteLine(days[0]);
// Console.WriteLine(months[0]);



// string[] days = { "Mon", "Tue", "Wed", "Thurs", "Fri", "Sat", "Sun" };
// string[] months = { "Jan", "Feb", "March", "April", "May", "June", "July", "Aug", "Sep", "Oct", "Nov", "Dec" };

// int[,] calendar = new int[7, 12];

// for (int i = 0; i < days.Length; i++)
// {
//     Console.WriteLine(days[i]);
// }