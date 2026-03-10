namespace ProfileCard;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║         STUDENT PROFILE CARD               ║");
        Console.WriteLine("╚════════════════════════════════════════════╝\n");

        // PERSONAL INFORMATION //

        // name
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();

        // hometown
        Console.Write("Enter your hometown (formatted as city, state): ");
        string homeTown = Console.ReadLine();

        // fav color
        Console.Write("What is your favorite color? ");
        string favColor = Console.ReadLine();

        // dream job
        Console.Write("Enter your future dream job: ");
        string dreamJob = Console.ReadLine();

        Console.WriteLine("\n-════════════════════════════════════════════-\n"); // line between each "step"

        // ACADEMIC INFORMATION //

        // major
        Console.Write("What is your major? ");
        string userMajor = Console.ReadLine();

        // gpa
        Console.Write("What is your current GPA? Please enter this as a number from 0.0 to 4.0: ");
        double userGPA = double.Parse(Console.ReadLine()); // parses input string to double in the same line
        // fix for numbers lower than 0.0 and greater than 4.0
        if (userGPA > 4.0) {
            userGPA = 4.0;
        } else if (userGPA < 0.0) {
            userGPA = 0.0;
        }

        // grad year
        Console.Write("When will you graduate? ");
        int gradYear = int.Parse(Console.ReadLine());

        // full-time?
        Console.Write("Are you a full-time student? Please enter either \"yes\" or \"no\": ");
        string timeInput = Console.ReadLine().ToLower();
        // allows for shorter version to be used in addition to "yes" or "no", this is mostly just for dev purposes :]
        bool isFullTime = false;
        if (timeInput.Equals("yes") || timeInput.Equals("y")) {
            isFullTime = true;
        } else if (timeInput.Equals("no") || timeInput.Equals("n")) {
            isFullTime = false;
        } else { // fallback
            isFullTime = false;
        }
        string fullTimeOutput;
        if (isFullTime == true) {
            fullTimeOutput = "Full-Time";
        } else {
            fullTimeOutput = "Part-Time";
        }

        Console.WriteLine("\n-════════════════════════════════════════════-\n");

        // ADDITIONAL DETAILS //
        // kinda wish some of these like age were at personal info rather than here...
        // also why is favorite color up there but not down here???

        // age
        Console.Write("What is your age? ");
        int userAge = int.Parse(Console.ReadLine());

        // height
        Console.Write("What is your height (in inches)? ");
        double userHeightIn = double.Parse(Console.ReadLine());


        // fav number
        Console.Write("What is your favorite number? ");
        int favNumber = int.Parse(Console.ReadLine());

        // CALCULATIONS //

        // birth year
        int userBirth = 2026 - userAge;

        // years to grad
        int userToGrad = gradYear - 2026;

        // user height (feet, then inches)
        int userHeightFt = (int)(userHeightIn / 12); // feet
        double userHeightCalcIn = userHeightIn % 12; // calculated inches

        // honor student
        bool userHonors = (userGPA >= 3.5);
        string honorsOutput;
        if (userHonors) {
            honorsOutput = "Yes";
        } else {
            honorsOutput = "No";
        }

        // age in months
        int userAgeMon = userAge * 12;

        Console.WriteLine("\n-════════════════════════════════════════════-\n");

        // DISPLAY //
        // PadLeft(22) is used to push everything to the middle if needed.
        Console.WriteLine("           - PERSONAL INFORMATION -\n" +
                          "Name: ".PadLeft(22) + userName + "\n" +
                          "Age: ".PadLeft(22) + userAge + "\n" +
                          "Height (In.): ".PadLeft(22) + userHeightIn + "\n" +
                          "Hometown: ".PadLeft(22) + homeTown + "\n" +
                          "Dream Job: ".PadLeft(22) + dreamJob + "\n" +
                          "Favorite Color: ".PadLeft(22) + favColor + "\n" +
                          "Favorite Number: ".PadLeft(22) + favNumber + "\n");
        Console.WriteLine("             - ACADEMIC DETAILS -\n"  +
                          "Major: ".PadLeft(22) + userMajor + "\n" +
                          "Current GPA: ".PadLeft(22) + $"{userGPA:F2}" + "\n" +
                          "Full-Time Status: ".PadLeft(22) + fullTimeOutput + "\n" +
                          "Graduation Year: ".PadLeft(22) + gradYear + "\n");


        Console.WriteLine("           - CALCULATED STATISTICS -\n"   +
                          "Birth Year: ".PadLeft(22) + userBirth + "\n" +
                          "Years to graduation: ".PadLeft(22) + userToGrad + "\n" +
                          "Height (In Feet): ".PadLeft(22) + userHeightFt + "'" + userHeightCalcIn + "\n" +
                          "Honor Student Status: ".PadLeft(22) + honorsOutput + "\n" +
                          "Age (in months): ".PadLeft(22) + userAgeMon + "\n");


        Console.WriteLine("\n-═══════════════════════════════════════════-");
        Console.WriteLine("Profile complete! Good luck with your studies!");
    }
}
