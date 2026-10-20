// Exercise 8.5: Own Square Root
// Write a program in which:
// 1. A function called sqrt is defined that calculates the square root of its input (of type
// double) to a precision of a specific (e.g., 7) number of decimals.

// • Hint: Solve this experimentall by starting with the most significant digit of he solution
// and iterate towards the least significant digit. For this, you pick a start and an end,
// and then iterate through these digits. These could be 1000000000 and 0.000000001.
// What should the value of this digit be? When you have found the right value for
// this digit, continue with the next. The right value is that which (when added to the
// previously determined digits and then squared) is ≤ the input. As you iterate through
// the digits, you will get closer and closer to the perfect answer.
// 
// 2. Some code demonstrate how to call this function.



// double Sqrt(double input){
//     double candidate = input/2;

//     while(candidate <=input){
//         if(candidate*candidate == input){
//             return candidate;
            
//         }else{
//             candidate = candidate - 0.0000001;
//         }
//     }
//     return -1;
    
// }

// Console.WriteLine("square root of 11.5 is:" + Sqrt(9));


double Sqrt(double input){
    double candidate = input/2;

    while(candidate * candidate > input){
        candidate = candidate - 0.0000001;
        }
        return candidate;
}

Console.WriteLine("square root of 11 is:" + Sqrt(11));