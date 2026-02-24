/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Milo Wearn
- Assignment: Week 7: Class Roster Builder (Arrays)
-
- What does this program do?:
- Builds a class roster using parallel arrays and a simple menu.
- */

namespace ClassRoster;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Class Roster ===");
        Console.WriteLine();

        string[] rosterNames = new string[3];
        int[] rosterCredits = new int[3];
        int count = 0; // slots in use

        int choice = 0;

        while (choice != 4) {
            // Print the menu options (every loop)
            Console.WriteLine("1) Add multiple students");
            Console.WriteLine("2) Print class roster");
            Console.WriteLine("3) Print roster (sorted)");
            Console.WriteLine("4) Exit\n");

            // get menu choice
            choice = ReadIntInRange("Choose an option: ", 1, 4);

            Console.WriteLine(""); // blank line

            switch (choice) {
                case 1:
                    // rosterCapacity is effectively 3
                    if (count == 3) {
                        Console.WriteLine("Roster is full. Cannot add more students.");
                    } else {
                        int numStudents = ReadIntInRange($"Enter the number of students to add (1-{(3-count)}): ", 1, (3-count));
                        string[] newNames = new string[numStudents];
                        int[] newCredits = new int[numStudents];

                        for (int i = 0; i < numStudents; i++) { // note: "i" will start at 0 the first time this is used
                            Console.Write($"Enter name for student {i + 1}: ");
                            newNames[i] = Console.ReadLine();
                            newCredits[i] = ReadIntInRange($"Enter credits for {newNames[i]} (0-200): ", 0, 200);
                        }

                        // copying over
                        for (int i = count; i < count + numStudents; i++) {
                            rosterNames[i] = newNames[i - count];
                            rosterCredits[i] = newCredits[i - count];
                        }

                        count += numStudents; // fill used slots
                        Console.WriteLine("Students added.");
                    }
                    break;
                case 2:
                    // quick check to make sure the roster isn't empty
                    if (count == 0) {
                        Console.WriteLine("Roster is empty.");
                    } else {
                        Console.WriteLine("- Class Roster -");
                        foreach (string student in BuildRosterLines(rosterNames, rosterCredits, count)) {
                            Console.WriteLine(student);
                        }
                    }
                    break;
                case 3:
                    if (count == 0) {
                        Console.WriteLine("Roster is empty.");
                    } else {
                        // option print
                        Console.WriteLine("- Choose sort method -");
                        Console.WriteLine("1) Name");
                        Console.WriteLine("2) Print class roster\n");

                        // get menu choice
                        int sortChoice = ReadIntInRange("Choose an option: ", 1, 2);
                        Console.WriteLine(""); // blank line

                        // copy over to new arrays
                        CopyUsedRoster(rosterNames, rosterCredits, count, out string[] sortedNames, out int[] sortedCredits);

                        if (sortChoice == 1) {
                            Array.Sort(sortedNames, sortedCredits, StringComparer.OrdinalIgnoreCase);
                        } else { // assume they used option 2
                            Array.Sort(sortedCredits, sortedNames);
                        }

                        // print sorted output
                        Console.WriteLine("Class Roster (Sorted): ");
                        foreach (string student in BuildRosterLines(sortedNames, sortedCredits, count)) {
                            Console.WriteLine(student);
                        }

                    }
                    break;
                case 4:
                    Console.WriteLine("Goodbye.");
                    break;
                default:
                    Console.WriteLine("You shouldn't see this!");
                    break;
            }

            // empty line between choices
            if (choice != 4) {
                Console.WriteLine("");
            }
        }
    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value;
        bool isValid;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? string.Empty;
            isValid = int.TryParse(input, out value);
        }
        while (!isValid || value < min || value > max);

        return value;
    }

    private static string[] BuildRosterLines(string[] names, int[] credits, int count)
    {
        string[] rosterLines = new string[count];

        // line creation
        for (int i = 0; i < rosterLines.Length; i++) {
            rosterLines[i] = names[i] + $" - {credits[i]} credits";
        }

        return rosterLines;
    }

    private static void CopyUsedRoster(
        string[] sourceNames,
        int[] sourceCredits,
        int count,
        out string[] names,
        out int[] credits)
    {
        string[] copiedNames = new string[count];
        int[] copiedCredits = new int[count];

        for (int i = 0; i < count; i++) {
            copiedNames[i] = sourceNames[i];
            copiedCredits[i] = sourceCredits[i];
        }

        names = copiedNames;
        credits = copiedCredits;
    }
}
