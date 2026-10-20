// Write a program in which
// 1. A variable is initialized to be an array containing the number of days in each of the 12
// months in a normal year. The first element will then contain the number of days in January.
// • What should the type of this array be?
// 2. Another variable is initialized to be an array containing the number of days in each of the
// 12 months in a leap year.
// • What should the type of this array be?
// 3. Iterate through the years 2000 through 2020:
// a) Use a new variable called pointer to refer to the array that matches the year from
// the iteration.

// • What should the type of this variable be?
// • How much data is copied here?
// • Hint: You can simplify the leap year rules so that any year divisible by four is a
// leap year.
// b) For every year, the contents of the array referenced by pointer is printed to the
// screen.

int[] monthsNormal = [31,28,31,30,31,30,31,31,30,31,30,31];
int[] monthsLeap = [31,29,31,30,31,30,31,31,30,31,30,31];

for (int i=0 ; i<2020 ; i++) {
int[] months = (i%4==0 ? monthsLeap : monthsNormal);
Console.WriteLine("In year "+i+" February is "+months[1]+" days long");
}