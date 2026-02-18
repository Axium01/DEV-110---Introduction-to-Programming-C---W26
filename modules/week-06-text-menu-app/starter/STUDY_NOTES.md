# Week 6: Text Menu App - Study Notes

**Name: Milo Wearn**

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: "do-while" will first "do" whatever is inside the loop and then loop if the requirements to move on are not met (for example, if a user inputs a number less than the required number, it will loop). "while" will first check the requirements before looping, basically doing the inverse of what do-while does.

**Where did you use a `do-while` loop in this assignment and why?**
[Describe how you validated the menu choice and numeric inputs]

Answer: The do-while loop is used for validating the user's menu and numeric inputs when necessary. It first prompts the user and then checks if the input is valid. If it's not, then the user is looped back to the prompt. This happens until the user enters a valid input. 

**Where did you use a `while` loop and why?**
[Describe the menu loop and why it repeats]

Answer: The while loop is used to repeatedly allow the user to go through the menu options until they decide to exit.

**Where did you use a `for` loop and why?**
[If you didn’t use a for loop, explain why it wasn’t needed]

Answer: You technically don't need a for loop for anything here, since you don't really need to iterate through anything like an array.

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for multiple prompts]

Answer: You don't need to rewrite the same piece of code multiple times if you use a method, making the program much more readable.

**How did you validate the menu choice (1–6)?**
[Explain your range check logic and do-while loop]

Answer: You can validate the menu choice by using what is essentially a copy of the method from the previous assignment "ReadIntFromRange", which uses a do-while loop to prompt a user and then check if that input is a number and is within range of the specified prompt, in this case from 1 to 6.

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse and double.TryParse work]

Answer: TryParse can be used to check if a string can be converted into an integer or double, depending on which is needed.

## String Operations

**Which string methods did you use across the different menu options?**
[List key methods like Trim, ToUpper, ToLower, Replace, Split, Join, Contains, PadLeft, PadRight, and formatting techniques]

Answer: I used the following string methods
- Trim: To remove leading and trailing whitespace.
- ToUpper: To convert a string to all uppercase.
- ToLower: To convert a string to all lowercase.
- Replace: To replace a character with a different character.
- Split: To split up a string into an array, with each word being a different array entry.
- Contains: To find if a string contains a certain character or string.
- PadLeft: To add padding to the left side of a string.
- PadRight: To add padding to the right side of a string.

**Which four string methods did you demonstrate in Option 6 (String Analysis)?**
[Explain Equals with StringComparison, Substring, EndsWith, and IndexOf]

Answer: The string methods used for Option 6 are
- Equals (with StringComparison): Checks if a string is equal to another string. StringComparison essentially sets the logic for it.
- Substring: Extracts a substring from a given string, starting and ending at a certain position.
- EndsWith: Checks if a string ends with a certain string or character.
- IndexOf: Gives the position of the first instance of a certain character/substring.

**What's the difference between string concatenation and interpolation?**
[Explain when you used each approach and which you prefer]

Answer: Concatenation joins strings together while interpolation embeds variables directly into strings.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. Methods can be used to greatly cut down on code length.
2. String formatting is a lot easier than I thought once I got it down.
3. Strings actually have much more ways to interact with them by using other in-built methods like Replace and Split.
4.
5.

**Which loop felt most natural to use and why?**

Answer: I'd say all of the loops felt pretty natural to me since I've already had experience with most of them.

## Time Spent

**Total time:** 5 hours (including the "remake")

**Breakdown:**

- Planning the loops: 12 minutes
- Input validation: 17 minutes
- String formatting: 1.5 hours
- Testing and debugging: 24 minutes
- Writing documentation: 9 minutes

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer:

## Reflection

**What would you do differently next time?**

Answer: 

**How did using three different loop types improve your understanding of repetition?**

Answer: 
