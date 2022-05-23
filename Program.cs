using System;
using System.Linq;



Random rand = new Random();
void GameLoop()
{
    int secretNum = rand.Next(1, 101);
    int userGuesses = 0;
    double allowedGuesses = 0;
    bool difficultySelected = false;

    Console.WriteLine("How difficult do you want the game to be?");
    Console.WriteLine("Easy(E), Medium(M), Hard(H), Cheater(C)");
    string difficulty = Console.ReadLine();

    switch (difficulty.ToLower())
    {
        case "e":
            allowedGuesses = 8;
            difficultySelected = true;
            break;
        case "m":
            allowedGuesses = 6;
            difficultySelected = true;
            break;
        case "h":
            allowedGuesses = 4;
            difficultySelected = true;
            break;
        case "c":
            allowedGuesses = double.PositiveInfinity;
            difficultySelected = true;
            break;
        default:
            Console.WriteLine("Please enter a valid difficulty (E,M,H,C)!");
            break;

    }

    while (difficultySelected && userGuesses <= allowedGuesses)
    {
        Console.WriteLine($"You have {allowedGuesses - userGuesses} guesses left!");
        Console.WriteLine("Guess the secret number!");
        string userGuess = Console.ReadLine();


        if (!userGuess.All(char.IsDigit))
        {
            Console.WriteLine("Please enter a number!");
            userGuess = Console.ReadLine();
        }
        else if (userGuess.All(char.IsDigit) && int.Parse(userGuess) == secretNum)
        {
            Console.WriteLine("You guessed the secret number!");
            break;
        }
        else
        {
            if (userGuess.All(char.IsDigit) && int.Parse(userGuess) > secretNum)
            {
                Console.WriteLine("You guessed too big!");
            }
            else
            {
                Console.WriteLine("You guessed too small!");
            }
            userGuesses++;
        }
        if (userGuesses == allowedGuesses)
        {
            Console.WriteLine("Game Over!");
            Console.WriteLine($"The number was {secretNum}!");
            break;
        }
    }
};

GameLoop();



