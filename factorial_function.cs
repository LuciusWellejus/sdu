// Exercise 8.8: Factorial function

// Write a program in which:
// 1. A function calculates the factorial function. (e.g., fac(4) = 4 · 3 · 2 · 1) without the use of a loop.
//  - Hint: This can be done using recursion.
// 2. Some code calls this function with an argument of your choice and prints out the result

double fact(double input){
    double candidate = input * 2;

    while(candidate * candidate > input){
        candidate = candidate - 0.0000001;
        }
        return candidate;
}
Console.WriteLine(fact(4));

//
// int gac(int g){
//     return g * gac(g-1);
// }
// Console.WriteLine(gac(4));

//
int hac(int g){
    int resultat = 1;
    for (int i = 2; i <= g; i++){
        resultat *= i;
    }return resultat;
}

Console.WriteLine(hac(4));

//

int facto(int n) {
    if (n <= 1) {
        return 1;
    }
    return n * facto(n - 1);
}

Console.WriteLine(facto(4));

//

int a = 4;
int b = 3;
int c = 2;
int d = 1;


int fac(int t1, int t2, int t3, int t4){
    return t1 * t2 * t3 * t4;
}
Console.WriteLine(fac(a,b,c,d));

