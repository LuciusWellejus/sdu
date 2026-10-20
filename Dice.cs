// Write a program in which:
// 1. the result of a roll of a dice is stored in a variable named dice.
// • Which type should the variable be declared as?
// • Chose a value and initialize the variable to it.
// 2. Declare a boolean variable and assign it a value that represent whether the value in dice
// is even and greater than 3.
// 3. Print out the value of this boolean variable.

float dice;
float roll;
dice = 5;
roll = 3;


bool boolean_variable = dice >=roll;
Console.WriteLine(boolean_variable);
Console.WriteLine("The value of the dice roll" + "is" + boolean_variable);

//

int diceRoll =5;
bool diceEvenAndTrue = (diceRoll > 3 && diceRoll % 2 == 0);
string diceMsg = diceEvenAndTrue ? "The diice roll is even and greater than 3.":"The dice"