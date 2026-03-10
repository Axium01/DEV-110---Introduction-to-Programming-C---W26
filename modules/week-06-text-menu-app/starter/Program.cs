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

using System.Reflection;
using System.Security.Cryptography;

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

        while (choice != 6){
            Console.WriteLine(" ");
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
                    // input
                    Console.Write("Enter your name: ");
                    string greetingName = Console.ReadLine().Trim();
                    Console.Write("Enter a short message: ");
                    string greetingMessage = Console.ReadLine();

                    // string operations
                    string greetingNameUpper = greetingName.ToUpper();

                    // output
                    Console.WriteLine("=============================================");
                    Console.WriteLine(string.Format("{0}          {1}", greetingName, greetingNameUpper));
                    Console.WriteLine("Message: " + greetingMessage);
                    Console.WriteLine("=============================================");
                    break;
                case 2:
                    Console.Write("Enter first name: ");
                    string tagFirst = Console.ReadLine().Trim();
                    Console.Write("Enter last name: ");
                    string tagLast = Console.ReadLine().Trim();

                    // string operations
                    string tagFull = (tagFirst + " " + tagLast);
                    string tagInitialFirst = tagFirst.Substring(0, 1).ToUpper(); // grab first letter
                    string tagInitialLast = tagLast.Substring(0, 1).ToUpper();
                    string tagFullLower = tagFull.ToLower();

                    // output
                    Console.WriteLine("[" + tagFull + " | Initials: " + tagInitialFirst + tagInitialLast + " | Lowercase: " + tagFullLower + "]");


                    break;
                case 3:
                    // input
                    Console.Write("Enter a phrase: ");
                    string phraseInput = Console.ReadLine().Trim();

                    // string operations
                    int phraseLength = phraseInput.Length;
                    bool phraseContains = phraseInput.ToLower().Contains("a");
                    string phraseDashes = phraseInput.Replace(" ", "-");
                    string[] phraseSplit = phraseInput.Split(" ");
                    string phraseList = String.Join(", ", phraseSplit);

                    // output
                    Console.WriteLine("Phrase Length: " + phraseLength +
                                      "\nPhrase contains \'a\'? " + phraseContains +
                                      "\nDashed version: " + phraseDashes +
                                      "\nWord List: " + phraseList);

                    break;
                case 4:
                    // inputs
                    Console.Write("Enter item name: ");
                    string itemName = Console.ReadLine();
                    double itemPrice = ReadDouble("Enter price: ");
                    int itemQuantity = ReadIntInRange("Enter quantity (1-9): ", 1, 9);

                    // total price
                    double itemTotal = itemPrice * itemQuantity;
                    string receiptTable = String.Format("| {0,-5} | {1} | {2,5:C2} |", itemName, itemQuantity, itemTotal);
                    string receiptBorder = new string('=', receiptTable.Length);

                    // output
                    Console.WriteLine(receiptBorder + "\n" + receiptTable + "\n" + receiptBorder);


                    break;
                case 5:
                    Console.Write("Enter a title: ");
                    string bannerTitle = Console.ReadLine();
                    Console.Write("Enter a subtitle: ");
                    string bannerSubtitle = Console.ReadLine();
                    int bannerWidth = ReadIntInRange("Enter width (30-60): ", 30, 60);
                    string bannerBorder = new string('=', bannerWidth);

                    // output
                    // centered
                    Console.WriteLine("Centered\n");
                    Console.WriteLine(bannerBorder + "\n" +
                                      bannerTitle.PadLeft((bannerWidth + bannerTitle.Length) / 2).ToUpper() + "\n" +
                                      bannerSubtitle.PadLeft((bannerWidth + bannerSubtitle.Length) / 2) + "\n" +
                                      bannerBorder);
                    // left
                    Console.WriteLine("Left\n");
                    Console.WriteLine(bannerBorder + "\n" +
                                      bannerTitle.ToUpper() + "\n" +
                                      bannerSubtitle + "\n" +
                                      bannerBorder);
                    // right
                    Console.WriteLine("Right\n");
                    Console.WriteLine(bannerBorder + "\n" +
                                      bannerTitle.PadLeft(bannerWidth).ToUpper() + "\n" +
                                      bannerSubtitle.PadLeft(bannerWidth) + "\n" +
                                      bannerBorder);

                    break;
                case 6:
                    // input
                    Console.Write("Enter a closing word: ");
                    String closingInput = Console.ReadLine();

                    // string operations
                    bool closingEquals = string.Equals(closingInput, "goodbye",StringComparison.OrdinalIgnoreCase);
                    string closingFirstThree;
                    if (closingInput.Length >= 3) {
                        closingFirstThree = closingInput.Substring(0,3);
                    } else {
                        closingFirstThree = closingInput;
                    }
                    bool closingExclamation = closingInput.EndsWith("!");
                    int closingIndex = closingInput.IndexOf(" ");

                    // output
                    Console.WriteLine("Equals \"goodbye\"? " + closingEquals +
                                      "\nFirst three letters: " + closingFirstThree +
                                      "\nEnds with exclamation? " + closingExclamation);
                    if (closingIndex >= 0) {
                        Console.WriteLine("Space position: " + closingIndex+1);
                    } else { // if no space
                        Console.WriteLine("Space position: N/A");
                    }

                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("This shouldn't appear!");
                    break;
            }

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

        return value;
    }
}
