// data

string secret = "adam";
int remaining_lives = 10;
bool[] guesses = new bool['z' - 'a' + 1]; // false -> not guessed


// helpers

string? receive_guess()
{
    Console.WriteLine("Place your guess: ");
    return Console.ReadLine();
}

int c2int(char c)
{
    return Char.ToLower(c) - 'a';
}

char int2c(int i)
{
    return (char)(i + 'a');
}


void print_out_status()
{
    // secret
    Console.Write("Secret: ");

    foreach (char c in secret)
    {
        if (!guesses[c2int(c)])
        {
            Console.Write("_");
        }
        else
        {
            Console.Write(c);
        }
    }

    Console.WriteLine("");

    // guesses
    Console.WriteLine("Guesses:");

    for (int i = 0; i < guesses.Length; i++)
    {
        char c = int2c(i);

        if (guesses[i])
        {
            Console.Write(c + " ");
        }
    }

    Console.WriteLine("");

    // remaining lives
    Console.WriteLine("Lives: " + remaining_lives);
    Console.WriteLine("");
}


bool contains(char input)
{
    foreach (char c in secret)
    {
        if (input == c)
        {
            return true;
        }
    }

    return false;
}


bool finished()
{
    foreach (char c in secret)
    {
        if (!guesses[c2int(c)])
        {
            return false;
        }
    }

    return true;
}


// main

bool done = false;

while (!done)
{
    // get input
    string? guess = receive_guess();

    // check input
    if (guess == null) continue;
    if (guess.Length != 1) continue;

    char c = Char.ToLower(guess[0]);

    if (!(c >= 'a' && c <= 'z')) continue;

    // check if letter was already guessed
    if (guesses[c2int(c)])
    {
        Console.WriteLine("You already guessed that letter!");
        continue;
    }

    // check guess
    if (!contains(c))
    {
        remaining_lives--;

        if (remaining_lives == 0)
        {
            Console.WriteLine("Oops! You lost!");
            break;
        }
    }

    guesses[c2int(c)] = true;

    // check outcome
    if (finished())
    {
        print_out_status();
        Console.WriteLine("Yay! You won!");
        done = true;
        continue;
    }

    // print out status
    print_out_status();
}