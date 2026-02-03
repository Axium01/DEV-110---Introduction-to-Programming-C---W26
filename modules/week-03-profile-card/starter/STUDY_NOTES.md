# Week 3: Personal Profile Card - Study Notes

**Name: Milo Wearn**

## Understanding Variables and Data Types

**What are the four main data types you used in this assignment?**
[List string, int, double, and bool - explain what each stores and give examples from your profile card]

Answer: string stores things like words, like a students name
int stores integers (whole numbers) like 1, but cannot store numbers like 1.02.
When using numbers with integers, int will truncate the decimal places (ex. 1.99 -> 1)
double will store numbers like 1.02, along with anything int can store.
doubles are good for storing precise numbers like GPA values.
bool stores a value of true or false. It's good for storing values that might only have 2 states, such as a student being full-time or not full-time.

**Why did you use `double` for GPA instead of `int`?**
[Explain the difference and why decimal precision matters for GPA]
Answer: Normally, GPA uses decimal places. double can store the decimal while int cannot store the decimal.

**How did you convert the yes/no input into a boolean?**
[Explain the comparison operation you used]
Answer: First get the user's input, then use .Equals() to check if that input is equal to a given string.
If it is, then set the boolean "isFullTime" to true or false accordingly.
NOTE: .Equals() is a way to compare 2 values just like ==, but unlike ==, it won't completely crash the program if the data types don't match or are not compatible.
As an example...
int test1 = 12;
object test2 = 12;
If we use == to compare both values using [if (test1 == test2)]... it'll crash since the types don't match!
However, if we use .Equals instead [if test1.Equals(test2)]... it will be treated as if it was a "true" output, and will properly run whatever is in the if statement!
There is a small downside to .Equals though. Because .Equals is a method, it will always be slower than just using operator ==, so if you *know* you won't be using 2 data types when comparing, use ==.



## Data Modeling Decisions

**How did you organize the information into logical groups?**
[Explain why you grouped certain pieces of information together (personal, academic, etc.)]

Answer: The more organized your information is, the easier it is to read. Putting it into groups can help make it less confusing when you come back to it.


**Which pieces of information did you calculate rather than ask for?**
[List the derived data: birth year, years to graduation, height conversion, honor status, age in months]

Answer: You can easily calculate some things without the user's input since you already have the necessary information. For example, instead of asking the user if they are an honor student, we can just check if the GPA they inputted is above a certain threshold, and from that we can determine whether or not the user is an honor student.

**Why is it better to calculate birth year from age rather than ask for both?**
[Explain data consistency and reducing redundant input]

Answer: You'd want to calculate it the birth year so that the user can't input a birth year that is different to what they would have gotten.

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Type conversion, calculations, formatting, choosing data types?]

Answer: I'd say the formatting was the hardest part since I haven't worked with it much.

**How you solved it:**
[Explain your approach to overcoming the challenge]

Answer: I did some online research for some of the formatting methods that I had known about from other coding languages, like Java.

**Most confusing concept:**
[What was hardest to understand? Type casting, modulus for height, boolean logic, or formatting?]

Answer: Formatting.

## Type Conversion and Calculations

**How do you convert string input to a number?**
[Explain Parse methods: int.Parse(), double.Parse()]

Answer: You can use int.Parse() and double.Parse() to convert a string input into a number. 

**What calculation did you use to convert height from inches to feet and inches?**
[Explain: feet = inches / 12, remaining = inches % 12]

Answer: Inches can be converted to feet by dividing the amount of inches by 12, then you can find the remaining inches by using modulo.

**How did you determine if someone is an honor student?**
[Explain the boolean comparison: gpa >= 3.5]

Answer: Check if the GPA variable is at/above 3.5, and if it is, then set the honor boolean to true, otherwise, set it to false.

## Output Formatting

**How did you format the GPA to show exactly 2 decimal places?**
[Explain the :F2 format specifier]

Answer: You can use the format specifier :F2 to truncate the displayed value's decimal places to 2 places.

**How did you display different text based on whether someone is full-time or part-time?**
[Explain the conditional/ternary operator you used]

Answer: The text that would be displayed is determined before the output is actually created. An If-ElseIf-Else statement is used to check whether or not the
user typed yes. If they did, then a boolean for tracking full-time status is set to true, and the string variable that's used for the output is given the string "Full-Time". If that check fails (either from the user typing "no" or the user typing something other than the accepted inputs), then the string variable is set to "Part-Time". 

**What techniques did you use to make the output look organized?**
[Discuss alignment, spacing, section headers, borders]

Answer: I tried getting all of the information as centered as possible, which sort of worked with .PadLeft(). Section headers are easy since it's just one line with the section name with some padding above and below the header to give it some space.

## Real-World Data Modeling

**What other calculated fields could you add to a profile?**
[Think of other derived data: BMI from height/weight, time to birthday, etc.]

Answer: 

**Why is choosing the right data type important in real applications?**
[Explain memory, precision, and type safety]

Answer: In a real application, choosing the right data types can help with storage efficiency, optimizing performance, data integrity (preventing data loss), and can help keep your code easy to read. 

**How does this profile card relate to real-world applications?**
[Think about social media profiles, job applications, student records systems]

Answer: 

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned about variables and data modeling?]

1.
2.
3.
4.
5.

**Which data type was most challenging to work with and why?**
[Reflect on your experience with string, int, double, or bool]

Answer: None of them were really challenging to work with. 

**How does understanding data types help you write better programs?**
[Explain the benefits of type safety and appropriate data representation]

Answer: Understanding data types helps with a multitude of things. It can help with optimizing your code, prevent errors, make it easier to understand what specific data is used for, etc.

## Testing and Debugging

**What test cases did you use to verify your calculations?**
[List different inputs you tested - edge cases, typical values, etc.]

Answer: There aren't many unique test cases that need to be made, but some things, such as the honor status, do need extra testing. For those, I'd usually go through a list of possible non-working values (for example, a GPA of 3.49) and check if each one would turn up false.

**What bugs or errors did you encounter and fix?**
[Describe any type conversion errors, calculation mistakes, or formatting issues]

Answer: I didn't really find any issues while making the program, but I did learn that attempting to use a string with a newline escape character (\n) at the start in tandem with .PadLeft() just won't work. 

**How did you validate that your data types were correct?**
[Explain how you checked that GPA, heights, ages worked correctly]

Answer: It's pretty easy to check if a variable's data type wouldn't be correct, since you can input incompatible data to see if your data type is right.
For example, GPA shouldn't accept data that would be for a string, so if I typed "Hi!" when it asked for my GPA, it should throw an error.
If it didn't do that, then something is wrong with the used data type.

## Time Spent

**Total time:** 2 hours

**Breakdown:**

-   Understanding data types and planning variables: Around 10 minutes
-   Collecting user input with correct types: 9 minutes
-   Implementing calculations: 12 minutes
-   Formatting output: 20 minutes
-   Testing and debugging: 10 minutes
-   Writing documentation: 1 hour

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Other than documentation taking a while, formatting was the longest.

## Reflection

**What would you do differently if you started over?**
[Consider variable names, calculation order, organization, etc.]

Answer: Probably some of the questions could be shifted around. Age could definitely go in personal information while favorite color and dream job could go in additional details.

**How does proper data modeling make programs easier to maintain?**
[Think about readability, consistency, and reducing errors]

Answer: Having data properly organized can help reduce confusion with what data is linked to what part of code. Plus, if you end up coming back to an old program, having it all organized can help with figuring out what does what from a quick glance.

**What real-world system would you like to model next?**
[Shopping cart, game character, recipe calculator, etc.]

Answer: Not sure really, I've already made a ton of systems. I would probably wanna redo some of the ones I did in the past.
