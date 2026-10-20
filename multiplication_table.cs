// Exercise 7.6: Multiplication Table
// Write a program in which
// 1. An integer variable named size is declared and initialized to some value under 30.
//  You pick the concrete value.

// 2. An array is created with a length that matches the value of size.
// 3. This array is filled up with the 3 table. That is, an element at index n must have the value 3 · n.
// 4. Print out one or more elements to verify the correctness of what you have done.

// How do you pick which elements to observe in such a way that you gain a lot of value from
//  these observations while limiting the number of observations?

int size = 30;
int[] array = new int[size];
int testnumber = 9;

for (int i = 0; i < array.Length; i++) {

    array[i] = 3 * (i+1);
}
Console.WriteLine($"Lowest to highest. The middle index is number spot: [{array[0]}] [{array[testnumber]}]  [{array[array.Length-1]}] ");


// int n = 3 * n;
// int index = n;

// for(int i = 0; i < array.Length; i++){
//     if(array[i] > size){
//         size = array[i];
//         index = i;
//     }
// }
// Console.WriteLine(size);

// int n = 3;


// while(i<array.Length){
//     size = array[i]*n;
//     Console.WriteLine($"The 3 table caculatio is {size} $");
// }