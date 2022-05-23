using System;

Random rand = new Random();


void GameLoop()
{
    int secretNum = rand.Next(0, 101);
    int userGuesses = 0;
    double allowedGuesses = 0;
    bool difficultySelected = false;

    Console.WriteLine("How difficult do you want the game to be?");
    Console.WriteLine("Easy(E), Medium(M), Hard(H), Cheater(C)");
    string difficulty = Console.ReadLine();

    switch (difficulty)
    {
        case "E":
            allowedGuesses = 8;
            difficultySelected = true;
            break;
        case "M":
            allowedGuesses = 6;
            difficultySelected = true;
            break;
        case "H":
            allowedGuesses = 4;
            difficultySelected = true;
            break;
        case "C":
            allowedGuesses = double.PositiveInfinity;
            difficultySelected = true;
            break;

    }

    while (difficultySelected && userGuesses < allowedGuesses)
    {
        Console.WriteLine($"You have {allowedGuesses - userGuesses} guesses left!");
        Console.WriteLine("Guess the secret number!");
        string userGuess = Console.ReadLine();

        if (int.Parse(userGuess) == secretNum)
        {
            Console.WriteLine("You guessed the secret number!");
            break;
        }
        else
        {
            if (int.Parse(userGuess) > secretNum)
            {
                Console.WriteLine("You guessed too big!");
            }
            else
            {
                Console.WriteLine("You guessed too small!");
            }
            userGuesses++;
        }
    }
}

GameLoop();



