float radius;
radius = 20;
double area = 0;
float pi = 3.14f;

int i = 0;
int[] array = [1,3,5,8];
while(i<array.Length){
    area = array[i]*array[i]*pi;
    Console.WriteLine("The area for the circle of radius " + array[i] + " is " + area);

     i=i+1;
}


// area = 3.14 * radius * radius; // area (π · r 2 )

// Console.WriteLine("The area for the circle of radius " + radius + " is " + area);