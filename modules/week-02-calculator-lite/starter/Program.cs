using System.ComponentModel;
using System.Numerics;

namespace CalculatorLite;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Calculator Lite ===\n");
        // TODO: Declare variables for storing user input (use descriptive names)
        // Hint: You'll need variables for two numbers, user name, and calculation choice
        string userInput; // used for general input if necessary
        string userName;
        double num1 = 0; // 0 is used as a placeholder for both
        double num2 = 0;
        bool decimFormat = false; // used for decimal precision
        int totalCalcs = 7;
        int successfulCalcs = 0;

        // name input
        Console.Write("What is your name? ");
        userName = Console.ReadLine();
        Console.WriteLine("Hello " + userName + "!");

        // decimal precision input
        Console.Write("Do you want to use decimal precision? (yes/no): ");
        userInput = Console.ReadLine().ToLower(); // converts to lowercase
        if (userInput.Equals("yes") || userInput.Equals("y")) {
            Console.WriteLine("Decimal precision enabled.");
            decimFormat = true;
        } else if (userInput.Equals("no") || userInput.Equals("n")) {
            Console.WriteLine("Decimal precision disabled.");
            decimFormat = false;
        } else { // for now...
            Console.WriteLine("Input invalid. Defaulting to precision disabled.");
            decimFormat = false;
        }

        // first number prompt
        Console.Write("Please enter a number: ");
        userInput = Console.ReadLine();
        if (decimFormat) { // decimal precision is active
            num1 = double.Parse(userInput);
        } else { // decimal precision isn't active
            num1 = int.Parse(userInput);
        }

        // second number prompt
        Console.Write("Please enter a second number: ");
        userInput = Console.ReadLine();
        if (decimFormat) {
            num2 = double.Parse(userInput);
        } else {
            num2 = int.Parse(userInput);
        }

        // CALCULATIONS //
        // variables for output
        double addOutput = 0;
        double subOutput = 0;
        double multOutput = 0;
        double divOutput = 0;
        double modOutput = 0;
        double avgOutput = 0;
        double percentOutput = 0;

        // these are for displaying error messages
        bool divError = false;
        bool modError = false;
        bool percentError = false;

        // addition
        addOutput = num1 + num2;

        // subtraction
        subOutput = num1 - num2;

        // multiplication
        multOutput = num1 * num2;

        // adding previous calculations to total (they will ALWAYS succeed)
        successfulCalcs += 3;

        // division
        if (num2 != 0) {
            divOutput = num1 / num2;
            successfulCalcs++;
        } else {
            divError = true;
            Console.WriteLine("Div: Cannot divide by zero");
        }

        // modulus
        if (num2 != 0) {
            modOutput = num1 % num2;
            successfulCalcs++;
        } else {
            modError = true;
            Console.WriteLine("Mod: Cannot divide by zero");
        }

        // average
        avgOutput = (num1 + num2) / 2;
        successfulCalcs++; // this one should always succeed

        // percentage difference
        if (num2 != 0) {
            percentOutput = ((num1 - num2) / num1) * 100;
            successfulCalcs++;
        } else {
            percentError = true;
            Console.WriteLine("Percent Diff.: Cannot divide by zero");
        }

        // printing output
        // these follow the same order as the calculations
        if (decimFormat) { // 2 decimal places
            Console.WriteLine($"Sum: {addOutput:F2}");
            Console.WriteLine($"Difference: {subOutput:F2}");
            Console.WriteLine($"Product: {multOutput:F2}");
            if (divError) {
                Console.WriteLine("Quotient: Cannot divide by 0!");
            } else {
                Console.WriteLine($"Quotient: {divOutput:F2}");
            }
            if (modError) {
                Console.WriteLine("Remainder (Modulus): Cannot divide by 0!");
            } else {
                Console.WriteLine($"Remainder (Modulus): {modOutput:F2}");
            }
            Console.WriteLine($"Average: {avgOutput:F2}");
            if (percentError) {
                Console.WriteLine("Percentage Difference: Cannot divide by 0!");
            } else {
                Console.WriteLine($"Percentage Difference: {percentOutput:F2}%");
            }
        } else { // no decimal places
            Console.WriteLine($"Sum: {addOutput:F0}");
            Console.WriteLine($"Difference: {subOutput:F0}");
            Console.WriteLine($"Product: {multOutput:F0}");
            if (divError) {
                Console.WriteLine("Quotient: Cannot divide by 0!");
            } else {
                Console.WriteLine($"Quotient: {divOutput:F0}");
            }
            if (modError) {
                Console.WriteLine("Remainder (Modulus): Cannot divide by 0!");
            } else {
                Console.WriteLine($"Remainder (Modulus): {modOutput:F0}");
            }
            Console.WriteLine($"Average: {avgOutput:F0}");
            if (percentError) {
                Console.WriteLine("Percentage Difference: Cannot divide by 0!");
            } else {
                Console.WriteLine($"Percentage Difference: {percentOutput:F0}%");
            }
        }

        // the total number of calculations is a fixed number that is made at the beginning of the program
        // the "counted" calculations are calculations that actually succeed.
        Console.WriteLine("Performed " + totalCalcs + " calculations for " + userName + "!");
        Console.WriteLine("Total successful calculations: " + successfulCalcs + "/" + totalCalcs);

        // end message
        Console.WriteLine("\nThank you for using Calculator Lite!");
    }
}
