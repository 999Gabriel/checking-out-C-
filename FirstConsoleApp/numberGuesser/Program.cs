using System;

namespace NumberGuesser
{
    /// <summary>
    /// A simple number guessing game where the player tries to guess a randomly generated number between 1 and 100.
    /// </summary>
    public class GuessingGame
    {
        private static readonly Random random = new Random();
        private static int randomNumber;
        private static int userTries;

        /// <summary>
        /// Main entry point of the application.
        /// </summary>
        /// <param name="args">Command line arguments</param>
        public static void Main(string[] args)
        {
            // Initialize the game
            randomNumber = random.Next(1, 101); // Generate random number between 1 and 100
            userTries = 0;

            Console.WriteLine("=== Welcome to the Number Guessing Game! ===");
            Console.WriteLine("I'm thinking of a number between 1 and 100.");
            Console.WriteLine("Can you guess what it is?");
            Console.WriteLine();

            // Main game loop
            while (true)
            {
                Console.Write("Enter your guess: ");
                
                // Get user input with error handling
                if (!int.TryParse(Console.ReadLine(), out int userGuess))
                {
                    Console.WriteLine("Please enter a valid number!");
                    continue;
                }

                // Validate input range
                if (userGuess < 1 || userGuess > 100)
                {
                    Console.WriteLine("Please enter a number between 1 and 100!");
                    continue;
                }

                userTries++;

                // Check the guess
                if (userGuess < randomNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (userGuess > randomNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    // Correct guess - end the game
                    Console.WriteLine();
                    Console.WriteLine("🎉 Congratulations! You guessed it! 🎉");
                    Console.WriteLine($"The number was {randomNumber}");
                    Console.WriteLine($"It took you {userTries} {(userTries == 1 ? "try" : "tries")}!");
                    
                    // Provide feedback based on performance
                    if (userTries <= 3)
                    {
                        Console.WriteLine("Excellent! You're a natural at this!");
                    }
                    else if (userTries <= 7)
                    {
                        Console.WriteLine("Great job! That's pretty good!");
                    }
                    else
                    {
                        Console.WriteLine("Good job! Better luck next time!");
                    }

                    break; // Exit the game loop
                }

                Console.WriteLine();
            }

            // Ask if they want to play again
            Console.WriteLine();
            Console.Write("Would you like to play again? (y/n): ");
            string playAgain = Console.ReadLine()?.ToLower();
            
            if (playAgain == "y" || playAgain == "yes")
            {
                Console.Clear();
                Main(args); // Restart the game
            }
            else
            {
                Console.WriteLine("Thanks for playing! Goodbye!");
            }
        }
    }
}