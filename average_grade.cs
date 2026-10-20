// Exercise 9.3: Average Grade
// On some educations, the average grade is calculated solely from the passing grades a student has achieved. Lets assume that any grade below 2 (or 02) is a failing grade. In this exercise we explore how that could be implemented.
// 1. Create a new project.

// 2. Declare an int[] variable called grades and initialize this to hold the grades 4, 7, 02, 00, 10, 4, og 12.

// 3. Then declare a GetGrade function that takes an int as parameter and returns an int. Give the parameter the name courseid.

// 4. In the body of this function, extract using indexing first a value from the courseid position of grades.
// This value is stored in a local int variable called grade. If this is a passing grade, then return the grade. Otherwise, throw an exception.

// 5. Finally, write the main program code. It is split into three parts:
// 	a. **Initialization** Two variables of the type int are declared and named count and sum.
	
// 	b. **Process** Iterate through all indices (call them courseid) from grades using a for loop.
// 
//  Make sure it does not hardcode the number of courses1 . For every courseid, you call GetGrade.
//  Make sure that the the calls that doesn’t result in an exception results in (i) count being incremented,
// and (ii) sum being incremented with the return value.
	
// 	c. **Printout** The average $\frac{sum}{count}$ (sum/count) is calculated and printed to the screen. 
	
// 6. Verify that the code work as intended.

int[] grades = {4, 7, 02, 00, 10, 4, 12};
double count = 0;
double sum = 0;

int GetGrade(int courseid)
{
    int grade = grades[courseid];
    if (grade>=2)
    { 
        return grade;
    }
    else
    {
        throw new Exception("Not a passing grade");
    }
}

for (int i = 0; i < grades.Length; i++)
{
    try {
    
    sum += GetGrade(i);
   
    }
    catch(Exception)
    {

    }
    count++;
}
double average = sum/count;
Console.WriteLine($"The average score is {average}");