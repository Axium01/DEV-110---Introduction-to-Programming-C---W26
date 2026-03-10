# Week 5: Guess the Number - Study Notes

**Name: Milo Wearn**

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: Do-while does the code inside of it once before checking the condition and looping if applicable, whereas while checks the condition first before running the code.

**Where did you use a `do-while` loop in this assignment and why?**
[Describe the input validation use]

Answer: It was put into the helper method "ReadIntInRange" to ask the user for a prompt (given from the helper method), and then attempts to parse that input to an int.

**Where did you use a `while` loop and why?**
[Describe the guessing loop]

Answer: The while loop was put in the for loop (seen below) so that the user can keep guessing the secret number until they guess correctly.

**Where did you use a `for` loop and why?**
[Describe the rounds loop]

Answer: The for loop is used to "start" a new round, and loops for as many rounds as the user inputted.

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for max value and rounds]

Answer: If we make a method rather than just repeating the same code over and over again, we can cut down on the number of lines that are used, making it easier to read the code.

**How did you make sure the max value was between 10 and 100?**
[Explain your range check logic]

Answer: Using the code "(outputValue < min || outputValue > max);", we can check if the inputted max value is above or below our minimum and maximum allowed values (or in this case, our range), and either allow the user to continue if it would be true, or not allow the user to continue if it would be false.

**How did you make sure the number of rounds was between 1 and 3?**
[Explain your range check logic]

Answer: Same as above, but we just check for a range of 1 to 3.

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse works]

Answer: Using int.TryParse lets us figure out if a string can be turned into an input, and throws out a false or true input depending on if it can or cannot be converted.

## Guessing Logic

**How did you compare the guess to the secret number?**
[Explain the if/else logic for too low, too high, and correct]

Answer: You can just compare if the secret number is too low or high to the secret number. Using an if/else statement just allows us to display a message if the user didn't get the number right, so that the message doesn't show when it isn't needed (like if the user got the number on their first try).

**How did you count the number of guesses?**
[Explain where you incremented the counter]

Answer: Just use variable++; after a valid input is given. It works the same as variable = variable + 1, just shorter.

## Random Numbers

**How did you generate the secret number?**
[Explain Random and Next(min, max)]

Answer: Random.Next generates a random number from the minimum inputted value to 1 below the maximum inputted value, so if you had Random.Next(1, 10), you'd be able to get any number between or at 1 and less than 10

**Why does `Random.Next(1, max + 1)` include the max value?**
[Explain why +1 is needed]

Answer: Without the +1 being added to the max value, Random.Next(1, max) would only be able to generate a number from 1 to max-1, whereas including +1 allows the max number to be generated.

## Testing and Debugging

**What inputs did you test to confirm your loops worked correctly?**
[List several test cases]

Answer: Everything, from numbers above the maximum to numbers below the minimum, and even non-number inputs.

**What bugs or errors did you encounter and fix?**
[Describe any logic or loop errors]

Answer: I didn't really encounter any errors.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. Different loops can be used to achieve different things.
2. Methods can be used to make code shorter by preventing repeated instances of the same exact code from needing to be written.
3. Do-while loops specially allow code to be ran before needing a condition.

**Which loop felt most natural to use and why?**

Answer: I'd say the for loop since I already have experience with it.

## Time Spent

**Total time:** >1 Hour

**Breakdown:**

- Planning the loops: 10 minutes
- Input validation: 9 minutes
- Guessing logic: 12 minutes
- Testing and debugging: 15 minutes
- Writing documentation: 6 minutes

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Testing took the longest just because I wanted to test out some other methods to get a valid output. 

## Reflection

**What would you do differently next time?**

Answer: I think everything was mostly fine this time, though I might do a bit more research before diving head in for the next project.

**How did using three different loop types improve your understanding of repetition?**

Answer: I already mostly understood how repitition works when writing code, but learning how do-while works helped me think of ways to get around some of the previous limitations I had in other projects.
