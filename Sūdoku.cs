// How would you represent a Sūdoku puzzle in C#?
// How is this data structure laid out in memory?
// Multidimensional Arrays??

// Sudoku sudoku = new sudoku{numbers = true};


// int array[,] = {
//     4,1,3,
//     8,2,2,
//     9,2,3
// };

// class Sudoku{
//     public bool numbers;
// };

// int largestnumber = 9;
// int lowestnumber = 0;


// for(int i = 1; lowestnumber> i < array.Length; i++){
//     if(lowestnumber > array[i] > largestNumber){
//         sudoku.numbers = array[i];
//     }
// }
// Console.WriteLine($"Sūduko is correct {sudoku.numbers}$");

// int i = 1;
// while(i<array.Length){
//     Console.WriteLine($"The sūduko game is {sudoku.numbers}$" + array[i]);
//     index = i;
// }

//
// 
// 

int[,] array ={
    {4, 1, 3},
    {8, 2, 2},
    {9, 2, 3}
};

bool correct = true;

for(int r = 0; r < 3; r++){
    for(int c = 0; c < 3; c++){
        if(array[r, c] < 1 || array[r, c] > 9)
        correct = false;
    }
}

Console.WriteLine($"Sūdoku is correct: {correct}");