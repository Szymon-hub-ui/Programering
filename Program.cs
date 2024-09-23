Random random = new Random();
int randomNumber = random.Next(1, 101);
int userGuess = 0;
int guessCount = 0;
while (userGuess != randomNumber)
{
    Console.WriteLine("Guess a number between 1 and 100");
    string input = Console.ReadLine();
    bool isValidNumber = int.TryParse(input, out userGuess);
    if (!isValidNumber)
    {
        Console.WriteLine("Please enter a valid number");
        continue;
    }
    guessCount++;
    if (userGuess < randomNumber)
    {
        Console.WriteLine("Too low, guess higher");
    }
    else if (userGuess > randomNumber)
    {
        Console.WriteLine("Too high, guess lowe");
    }
}
Console.WriteLine($"Congratulations! You guessed the number {randomNumber} in {guessCount} guesses");
