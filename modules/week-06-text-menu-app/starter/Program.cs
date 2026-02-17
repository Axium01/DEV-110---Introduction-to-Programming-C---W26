/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Milo Wearn
- Assignment: Week 6: Text Menu App
-
- What does this program do?:
- Runs a text-heavy menu app that demonstrates string formatting and output patterns.
- */

namespace TextMenuApp;

public class Program
{
    public static void Main(string[] args)
    {
        // title stuff
        string title = "Text Menu Studio";
        string subtitle = "Strings + Console Output Patterns";
        string divider = "================================================";

        // title output
        // to get text to pad correctly, do (divider length / 2) + (string length / 2)
        // for padding with a decimal such as 40.5, just truncate the decimal
        Console.WriteLine(divider + "\n" + title.PadLeft(32) + "\n" + subtitle.PadLeft(40) + "\n" + divider);

        int choice = 0;

        // TODO 2: Create a menu loop that repeats until user chooses 6 (Exit)
        // Hint: Use a while loop
        while (choice != 6){
            // menu display
            Console.WriteLine("- Options -\n".PadLeft(17) +
                              "1) Greeting Card\n" +
                              "2) Name Tag Formatter\n" +
                              "3) Phrase Analyzer\n" +
                              "4) Fancy Receipt Line\n" +
                              "5) Menu Banner Builder\n" +
                              "6) Exit");

            choice = ReadIntInRange("Choose an option (1-6): ", 1, 6);

            Console.WriteLine(""); // blank line

            switch (choice) {
                case 1:
                    Console.WriteLine("hii");
                    // ===== OPTION 1: Greeting Card =====
                    // Prompts: "Enter your name: " and "Enter a short message: "
                    // Required string operations:
                    // - Use Trim() to clean up the name
                    // - Use ToUpper() for an uppercase version
                    // - Use concatenation OR interpolation for greeting text
                    // - Use string.Format() for at least one output line
                    // - Display a boxed card with the name, uppercase name, and message
                    // Include the word "Message:" in your output
                    string greetingName;
                    string greetingMessage;
                    break;
                case 2:
                    // ===== OPTION 2: Name Tag Formatter =====
                    // Prompts: "Enter first name: " and "Enter last name: "
                    // Required string operations:
                    // - Use Trim() on both inputs
                    // - Use concatenation to build full name
                    // - Use string indexing to get first characters for initials
                    // - Use ToUpper() for initials
                    // - Use ToLower() for lowercase version
                    // Display three things:
                    // - Name tag with the full name (include a bracket [)
                    // - Initials (use word "Initials:" in label)
                    // - Lowercase version (use word "Lowercase:" in label)
                    string tagFirst;
                    string tagLast;

                    break;
                case 3:
                    string phraseInput;
                    break;
                case 4:
                // ===== OPTION 4: Fancy Receipt Line =====
                // Prompts: "Enter item name: ", "Enter price: ", "Enter quantity (1-9): "
                // Use ReadDouble for price and ReadIntInRange for quantity
                // Required:
                // - Calculate total (price * quantity)
                // - Create a receipt table with header row (ITEM, QTY, TOTAL)
                // - Use string.Format() with composite formatting for the data row
                // - Use alignment specifiers (left/right alignment)
                // - Use currency format specifier (:C2) for the total
                    string itemName;
                    double itemPrice;
                    int itemQuantity;

                    // inputs
                    Console.Write("Enter item name: ");
                    itemName = Console.ReadLine();
                    itemPrice = ReadDouble("Enter price: ");
                    itemQuantity = ReadIntInRange("Enter quantity (1-9): ");

                    // total price
                    double itemTotal = itemPrice * itemQuantity;

                    // output

                    break;
                case 5:
                    // ===== OPTION 5: Menu Banner Builder =====
                    // Prompts: "Enter a title: ", "Enter a subtitle: ", "Enter width (30-60): "
                    // Use ReadIntInRange for width (min=30, max=60)
                    // Required string operations:
                    // - Create border line with equals signs (use new string constructor)
                    // - Use PadLeft() to center text (formula: (width + text.Length) / 2)
                    // - Use ToUpper() on title
                    // - Display banner with borders and centered text
                    // - Show three alignment examples (centered, left, right)
                    string bannerTitle;
                    string bannerSubtitle;
                    int bannerWidth = ReadIntInRange("Enter width (30-60): ");
                    break;
                case 6:
                    // input
                    Console.Write("Enter a closing word: ");

                    // output
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("This shouldn't appear!!!")
                    break;
            }

            // ===== OPTION 2: Name Tag Formatter =====
            // Prompts: "Enter first name: " and "Enter last name: "
            // Required string operations:
            // - Use Trim() on both inputs
            // - Use concatenation to build full name
            // - Use string indexing to get first characters for initials
            // - Use ToUpper() for initials
            // - Use ToLower() for lowercase version
            // Display three things:
            // - Name tag with the full name (include a bracket [)
            // - Initials (use word "Initials:" in label)
            // - Lowercase version (use word "Lowercase:" in label)

            // ===== OPTION 3: Phrase Analyzer =====
            // Prompt: "Enter a phrase: "
            // Required string operations:
            // - Use Trim() on input
            // - Use Length property
            // - Use Contains() to check for letter 'a' (convert to lowercase first)
            // - Use Replace() to change spaces to dashes
            // - Use Split() to break into words
            // - Use string.Join() to create comma-separated list
            // Display: length, contains check, dashed version, and words list





            // ===== OPTION 6: Exit with String Analysis =====
            // Prompt: "Enter a closing word: "
            // Required string operations (demonstrate these 4 methods):
            // - Use Equals() with StringComparison.OrdinalIgnoreCase to compare with "goodbye"
            // - Use Substring() to extract first 3 characters (check length first!)
            // - Use EndsWith() to check if ends with "!"
            // - Use IndexOf() to find position of space character
            // Display the results of all four operations
            // Then print: "Goodbye!"

            // TODO 6: Add a blank line between menu actions (but not after Exit)
            if (choice != 6) {
                Console.WriteLine("");
            }
        }
    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        // basically the same method from last week
        int value;
        bool isValid;

        do {
            Console.Write(prompt);
            isValid = int.TryParse(Console.ReadLine(), out value);
        } while (!isValid || value < min || value > max);

        return value;
    }

    private static double ReadDouble(string prompt)
    {
        double value;
        bool isValid;

        do {
            Console.Write(prompt);
            isValid = double.TryParse(Console.ReadLine(), out value);
        } while (!isValid);
        // TODO 8: Implement input validation
        // Use a do-while loop with double.TryParse()
        // Keep prompting until input is a valid number
        // Return the valid number

        return value;
    }
}
