int[] array = [1,5,2,10,44,17,7];

int largestNumber = 0;
int index = 0;

for(int i = 0; i < array.Length; i++){
    if(array[i] > largestNumber){
        largestNumber = array[i];
        index = i;
    }
}

Console.WriteLine($"Largest number is in the array is {largestNumber}$");
Console.WriteLine($"Index is {index}$");