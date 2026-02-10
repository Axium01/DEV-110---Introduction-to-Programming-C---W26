namespace GuessTheNumber;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Guess the Number: Loop Trio ===\n");
        // ReadIntInRange Why: It avoids repeating the same input-validation code for max value and rounds.
        int maxValue = ReadIntInRange("Enter a max value (10 - 100): ", 10, 100);
        int roundCount = ReadIntInRange("How many rounds? (1-3): ",1,3);

        // TODO 4: Use a for loop to repeat the game for each round
        // Example: for (int round = 1; round <= rounds; round++)
        // NOTE: The round header, secret number, and guessing loop are inside this for loop.
        for (int rounds = 1; rounds <= roundCount; rounds++) {
            Console.WriteLine($"\nRound {rounds} of {roundCount}"); // round header

            // rng
            Random rngGen = new Random(maxValue + rounds);
            int secretNumber = rngGen.Next(1, maxValue + 1);

            // tracking variables
            int userGuess = 0;
            int guessCount = 0;

            while (userGuess != secretNumber) {
                userGuess = ReadIntInRange($"Guess a number (1-{maxValue}): ", 1, maxValue);
                guessCount++; // +1 count

                // feedback (incorrect)
                if (userGuess > secretNumber) {
                    Console.WriteLine("Too high");
                } else if (userGuess < secretNumber) {
                    Console.WriteLine("Too low.");
                }
            }

            // feedback (correct)
            Console.WriteLine($"Correct! You got it in {guessCount} guesses.");
        }

        Console.WriteLine("Thanks for playing!");
    }

    private static int ReadIntInRange(string prompt, int min, int max) {

        // variables
        int outputValue; // what were returning
        bool flagValid;

        // do-while loop
        // asks user for prompt until a valid input is given
        do {
            Console.Write(prompt);
            flagValid = int.TryParse(Console.ReadLine(), out outputValue);
        } while (!flagValid || outputValue < min || outputValue > max);
        return outputValue;
    }
}
