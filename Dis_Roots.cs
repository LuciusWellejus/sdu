// Exercise 8.7: Discriminants and Roots
// Write a program in which:
// 1. There is a function called discriminant that calculates a discriminant basend on the parameters a, b and c.
// 2. There is a function called roots that takes the paramters a, b and c from a quadratic polynomia, and returns an array of roots.
// • Hint: You can use Math.Sqrt(9.0) to calculate √ 9.
// 3. There is code that demonstrates how to call roots and prints out the result


int a = 1;
int b = 1;
int c = -10;


double discriminant(double a, double b, double c){
    return b*b-4*a*c;
}

double[]? roots(double a, double b, double c){
    double dis = discriminant(a,b,c);
    double[]? array = null;
    
    if (dis<0){
        return new double[0];
    }if (dis == 0){
        array = new double[1];

        double x = -b/(2*a);
        array[0] = x;
        
    }else if(dis>0){
        array = new double[2];

        double x1 = -b+Math.Sqrt(dis)/(2*a);
        double x2 = -b-Math.Sqrt(dis)/(2*a);

        array[0] = x1;
        array[1] = x2;
        }    
        return array;
}
Console.WriteLine(String.Join(",", roots(a,b,c)));