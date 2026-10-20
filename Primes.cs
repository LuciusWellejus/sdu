// Execise 7.11: Primes
// Write a program that calculates all primes below 1,000,000 and prints out the largest.
// Do this by implementing the Sieve of Eratosthenes. link: https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes:

// algorithm Sieve of Eratosthenes is
//     input: an integer n > 1.
//     output: all prime numbers from 2 through n.

//     let A be an array of Boolean values, indexed by integers 2 to n,
//     initially all set to true.
    
//     for i = 2, 3, 4, ..., not exceeding √n do
//         if A[i] is true
//             for j = i2, i2+i, i2+2i, i2+3i, ..., not exceeding n do
//                 set A[j] := false

//     return all i such that A[i] is true.

// The square root of i is calculated as Math.Sqrt(i).

// Note: This is a progression of exercise 6.10. Here, you will find a definition of what a prime number is:
// 6.10:
// int last = 100;
// int max = -1;
// // start at 2, the first prime number
// for (int i=2 ; i<last ; i++)
// {
//     bool isPrime = true;
//     // skip even numbers greater than 2
//     if (i>2 && (i&1) == 0)
//     continue;
//     // only check up to the square root of i
//     for (int j=3 ; j*j<=i ; j+=2)
//     {
//         if (i%j == 0)
//         {
//             isPrime = false;
//             break;
//         }
// }
// if (isPrime)
// {
//     Console.WriteLine(i);
//     max = i;
//     }
// }

int last = 100;
bool[] sieve = new bool[last];

for (int i=1 ; i<sieve.Length ; i++)
sieve[i] = true;

for (int i=2 ; i<Math.Sqrt(sieve.Length) ; i++)
{
    if (sieve[i])
    {
        for (int l=i*2 ; l<last ; l+=i)
        {
            sieve[l] = false;
        }
    }
}

int maxime = -1;
for (int i=last-1 ; i>0 ; i--)
{
    if (sieve[i])
    {
        maxime = i;
        break;
    }
}
Console.WriteLine("The highest prime is "+maxime);