/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Milo Wearn
- Assignment: Week 8: Mad Libs (Structure + Debugging)
-
- What does this program do?:
- Runs a two-template Mad Libs app that practices structure and debugging.
- */

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace MadLibs;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Mad Libs: Structure + Debugging ===");
        Console.WriteLine();

        bool playAgain;
        do
        {
            StoryTemplate template = ChooseTemplate();
            Console.WriteLine();

            string[] words = CollectWords(template);

            string story = template.GenerateStory(words);
            Console.WriteLine(story);
            Console.WriteLine();

            playAgain = ReadYesNo("Play again? (y/n): ");
            Console.WriteLine();
        }
        while (playAgain);
    }

    private static StoryTemplate ChooseTemplate()
    {
        int input;
        StoryTemplate template;
        // note: these next two strings are used when generating the story.
        string storyOne = "Today I visited a {0} zoo. I saw {1} {2} while writing {3}. I used a {4} {5} times until the bug disappeared. I felt {6} and yelled, \"{7}\"";
        string storyTwo = "{0} showed up looking {1} and holding a {2}. They {3} for {4} hours battling {5}. The culprit? A {6} bug. We fixed it and celebrated with {7}.";

        input = ReadIntInRange("1) Debugging at the Zoo\n2) The Standup Meeting\nChoose a template: ", 1, 2);

        if (input == 1) {
            template = new StoryTemplate("Debugging at the Zoo", ["Enter an adjective: ",
                                                                  "Enter an animal (plural): ",
                                                                  "Enter a verb ending with -ing: ",
                                                                  "Enter a programming language: ",
                                                                  "Enter a debugging tool (example: breakpoint): ",
                                                                  "Enter a number: ",
                                                                  "Enter an emotion: ",
                                                                  "Enter an exclamation: "], storyOne);
        } else { // assume 2, since theres no other possible options... maybe.
            template = new StoryTemplate("The Standup Meetup", ["Enter a name: ",
                                                                "Enter an adjective: ",
                                                                "Enter a noun: ",
                                                                "Enter a verb (past tense): ",
                                                                "Enter a number: ",
                                                                "Enter a plural noun: ",
                                                                "Enter a type of bug (example: null reference): ",
                                                                "Enter a snack: "], storyTwo);
        }

        return template;
    }

    private static string[] CollectWords(StoryTemplate template)
    {
        Logger.Info("Word collection has started.");
        string[] words = new string[template.Prompts.Length];
        for (int i = 0; i < words.Length; i++) {
            words[i] = ReadNonEmptyString(template.Prompts[i]);
        }
        return words;
    }

    private static bool ReadYesNo(string prompt) {
        string input;
        bool value; // this is the value to output
        bool isValid; // this is for checking validity of string

        do {
            Console.Write(prompt);
            input = Console.ReadLine() ?? string.Empty;
            input = input.Trim().ToLower();
            isValid = input.Equals("y") || input.Equals("n"); // check if input = y or n
        } while (!isValid);

        if (input.Equals("y")) {
            value = true;
        } else {
            value = false;
        }

        return value;
    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value;
        bool isValid;

        do {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? string.Empty;
            isValid = int.TryParse(input, out value);
        } while (!isValid || value < min || value > max);

        return value;
    }

    private static string ReadNonEmptyString(string prompt) {
        string input;
        bool isValid;

        do {
            Console.Write(prompt);
            input = Console.ReadLine() ?? string.Empty;
            input = input.Trim();
            isValid = !string.IsNullOrWhiteSpace(input); // check if input isn't empty or just whitespace.
        } while (!isValid);

        return input;
    }
}
