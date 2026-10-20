// 1. What happens if you give the program “3” as input?
// 2. Make a variant of the program that uses exception handling in the while loop to make the program more robust to this input.
// Place try-catch in while-loop (inf.)
// 
// 3. What happens if you give the program “to” as input?
// 4. Make a variant of the program that uses exception handling to make the program more robust to this input.
//  Where is the right place to add this exception handling?

int[] accounts = {903, 716, 67, 3, Int32.Parse("3") };
int GetAccountNumber ()
{
	Console.WriteLine("Enter an account number: ");
	return Convert.ToInt32(Console.ReadLine());
}

void PrintAccountState (int accountId)
{
	Console.WriteLine("Account " + accountId + " contains " + accounts[accountId]);
}

while (true)
{ 
    try {
    	int accountId = GetAccountNumber();
    	PrintAccountState(accountId);
} 
catch(IndexOutOfRangeException)
{
    Console.WriteLine("The number is out of range (account not found)");
}
catch(FormatException)
{
    Console.WriteLine("It's not a number");
}

}