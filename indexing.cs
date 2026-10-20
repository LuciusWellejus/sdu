// 1. Compile an execute the above code. 
// 2. Which exception is thrown?
// 3. What causes this exception to be thrown?
// 4. Use a try-catch construct to skip the iteration that throw this exception.
// 5. Is this the correct solution to the problem, and why?

int iterationer = 10;
int[] array = {1, 2, 3, 4, 5};

// increment
for (int i = 0; i < iterationer; i++){
    try{
        array[i]++;
    }
    catch (IndexOutOfRangeException e){
        Console.WriteLine("Index is outside the array."); // piece of cake example
    }
}

// print
for (int i=0 ; i<array.Length; i++) {
	Console.WriteLine(array[i]);
}

//1. 
// Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.
//  at Program.<Main>$(String[] args) in /Users/kat/sdu/Primative/indexing.cs:line 12
// 
// 2. IndexOutOfRangeException
// 
// 3. The iterationer is deffined as 10 but the is only 5 elements so it goes to 0-4.

