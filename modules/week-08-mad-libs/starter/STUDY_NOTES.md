# Week 8: Mad Libs (Structure + Debugging) - Study Notes

**Name:** Milo Wearn

## Program Structure

**What helper methods did you create (and what does each one do)?**
[List your methods and briefly describe each]

Answer: (List below)
ChooseTemplate - Creates a StoryTemplate based on the user's input. Uses ReadIntInRange to choose the story. The StoryTemplate contains the title, prompts, and story text for the chosen story.
CollectWords - Using the prompts from the StoryTemplate, prompts the user with ReadNonEmptyString for each prompt in StoryTemplate. Outputs a list of words that the user inputted. 
ReadYesNo - Shows a prompt, reads the input given, checks if the input is "y" or "n", and outputs true or false depending on said input. If the input isn't "y" or "n", then the prompt is reprinted and the user is forced to make another input. This repeats until a valid input is given. 
ReadIntInRange - Same as ReadYesNo, but checks if the input is within a certain integer range, and outputs the inputted integer once a valid input is given.
ReadNonEmptyString - Same as ReadYesNo, but checks if the input is not empty, and outputs the inputted string once a valid input is given.

**Why is it helpful to move code out of `Main` and into helper methods?**
[Explain how this improves readability and reduces bugs]

Answer: Helper methods are used to perform a certain task in the program. This can be used repetatively, which can greatly cut down on the total lines of code.

## Data Modeling

**What is the purpose of the `StoryTemplate` class in this assignment?**
[Explain what data it stores and why]

Answer: StoryTemplate is used to store the data for the title of the story, the words from the inputs given, and the text for the specific story. 

**How did using a template make it easier to support two different stories?**
[Explain how the same logic can work with different prompts/text]

Answer: Using templates makes it easier to support the two stories because they both have the same structure. Both have a title, an array of prompts, and a string that contains the text for that story. Since this is the case, we don't need to make a separate "container" for each story.

## Testing and Debugging

**Where did you set a breakpoint while debugging this program (what line or method)?**
[Be specific - example: inside GenerateStory, at the beginning of CollectWords, etc.]

Answer: I had set a breakpoint at the for loop inside of FormatStory to figure out if it was correctly converting strings into objects.

**What did you learn from stepping through your code line by line?**
[Describe how watching execution helped you understand flow or find bugs]

Answer: I already mostly understand how the flow of the code I wrote works, but stepping mainly helped me with finding out why some of the bugs I came across occurred.

**What bug or logic mistake did you encounter (and how did you fix it)?**
[Describe a real issue you ran into and how breakpoints/stepping helped]

Answer: I kept running into an issue where the formatted string wouldn't include the input I used stepping to confirm that the input words were trying to be put into the formatted string, but would be overwritten afterwards. I found out that I had tried to previously format the string using $"", which caused the program to overwrite the input words with whatever was within the curly braces.  

## What I Learned

**Key takeaways from this week:**
[3 main things you learned]

1. You can create variables off of classes that have fields, also wanted to add something about how you can also access functions through those variables but the test won't let me :|.
2. Breakpoints and Stepping can be used to help you find bugs that you may not fully know the location or cause of.
3. Breaking up your program into smaller parts can make debugging much faster.

**What part of this assignment helped you understand program structure the most?**
[Breaking into methods, using public/private methods, separating concerns, etc.]

Answer: I think using public and private methods helped me understand program structure the most.

## Time Spent

**Total time:** 1 hour and 15 minutes

**Breakdown:**

- Planning structure (methods/classes): 10~ minutes
- Input validation: 15~ minutes
- Story templates + formatting: 25~ minutes
- Testing and debugging: 25~ minutes
- Writing documentation: 10~ minutes

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Although templates + formatting and testing took around the same amount of time, debugging is actually what took the longest to complete. I had issues with figuring out how to get the outputted story to format correctly.

## Reflection

**What would you improve if you had more time?**
[Ideas: more templates, better formatting, more validation, etc.]

Answer: Other than some improvements to how the data for the templates is stored, I think the program is mostly fine.  

**How did breaking your program into smaller parts help you debug?**
[Explain the connection between structure and debugging]

Answer: Breaking the program into smaller parts makes it easier to debug each part individually if necessary, rather than having to find one bug in a large part.
