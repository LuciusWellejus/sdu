// Exercise 6.5: Holidays
// A common educational calendar will have the following holidays:
// • Autumn Holiday October
// • Christmas Holiday December
// • Spring Holiday April
// • Summer Holiday July + August
// Write a program in which:
// 1. A month is given in the form of an integer via a variable.
// 2. Depending on the value of this variable, either print out the name of the holiday (if there
// is a holiday in the month), or simply “Hard work” (if there isn’t).

string common_educational = [Autumn, Christmas, Spring, Summer]

int Summer = {July, August};
int Spring = {April};
int Autumn = {October};
int Christmas = {December};

int i = 0;

byte January = 1;
byte February = 2;
byte March = 3;
byte April = 4;
byte May = 5;
byte June = 6;
byte July = 7;
byte August = 8;
byte September = 9;
byte October = 10;
byte November = 11;
byte December = 12;

if (i == Summer ) {
    if (i == Spring) {
Console.WriteLine("It's summer");
    }

if (i == Spring ) {
    if (i == Autumn) {
 Console.WriteLine("It's Spring");
      }

if (i == Autumn ) {
    if (i == Christmas) {
Console.WriteLine("It's Autumn");
    }
} else {
    Console.WriteLine("It's Christmas");
}


//Write a calender that prin't the four sessions,
int month = 8;
string work = "good work";

if (month = 6 || month == 7){
    work = ("It's summer");
}
if (month = 4){
    work = ("It's Spring");

if (month = 10){
    work + Console.WriteLine("It's Autumn");
}
if (month = 12){
    work + Console.WriteLine("It's Christmas");
}