# Week 2: Calculator Lite - Study Notes

**Name: Milo Wearn**

## Understanding Data Types

**What are the four data types you used in this assignment?**
[List each data type (string, bool, int, double) and explain what kind of data each one stores]

Answer: "string" is used to store non-numeric values, such as "Hi!", although you *can* store numbers like "123" (You'll need to parse it if you want to do this).
"bool" is used for storing true/false values. It only accepts the inputs [true] or [false].
"int" stores integers, like [123]. It cannot store values with decimals, such as [123.4].
"double" stores numeric values including decimals, such as [123.4].

**Why did we use `double` instead of `int` for the calculations?**
[Explain the difference between int and double, and why double is better for this calculator]

Answer: double lets us retain decimal places, which lets us take more precise calculations.


**How do you convert a string to a boolean?**
[Explain how you converted the user's "yes/no" input into a true/false value]

Answer: Pretty simple, you just check the string from the input and if it says "yes" or "no" then you
set the value of the boolean accordingly. If the input wouldn't be applicable, then it just defaults to false.

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Understanding data types, getting user input, performing calculations, formatting output, or handling division by zero?]

Answer: I wouldn't say there was any hard part.

**How you solved it:**
[Explain what you did to overcome the challenge - reviewed documentation, asked for help, tested different approaches, etc.]

Answer: ^ See above ^

**Most confusing concept:**
[What was hardest to understand? Parsing input, modulus operator, percentage formula, conditional formatting, or something else?]

Answer: None of this was really that confusing, although I did get a little confused when I forgot that C# outputs remainder rather than modulo, because I was testing out negative number cases.

## Understanding Arithmetic Operations

**What is the difference between the modulus operator (%) and division (/)?**
[Explain what each operator does and give an example]

Answer: Division gives the quotient of a formula while modulus gives the remainder.
Division will give the number of times a number can fit into another one, while modulus will give the remainder of that.
For example, 10 / 2 = 5 (five 2's can fit into 10), while 10 % 2 = 0 (no remainder)

**How do you calculate the average of two numbers?**
[Write the formula in your own words]

Answer: Add your two numbers together and then divide by the total amount of numbers (in this case, two).

**What is the formula for percentage difference?**
[Explain the formula you used: ((num1 - num2) / num1) * 100]

Answer: Take the difference of num1 and num2, divide that by num1, and then multiply it by 100 to make it into a percentage.
For example, num1 = 8, num2 = 3
(8 - 3) = 5, 5 / 8 = 0.625, 0.625 * 100 = 62.5
62.5% is the percentage difference.

## Input and Output

**How do you read user input in C#?**
[Explain what Console.ReadLine() does and what type of data it returns]

Answer: Console.ReadLine reads the current line of text input and returns it as a string.

**How do you convert string input to a number?**
[Explain the Parse methods you used, like double.Parse()]

Answer: To convert a string input into a number, use [variable] = [datatype].Parse([input]).
Parse itself converts a data type into another datatype.
[datatype] must match the data type of [variable].
[input] must be a string, although you can use a variable with a string data type. 


**What is string interpolation and how did you use it?**
[Explain the $ symbol and curly braces {} in Console.WriteLine()]

Answer: $ enables string interpolation, allowing you substitute values of variables into placeholders in a string.
Curly braces are what contain the placeholder.

## Conditional Logic

**How do you format numbers with 2 decimal places vs whole numbers?**
[Explain the :F2 and :F0 format specifiers]

Answer: With string format specifiers, you can format a string in different ways.
As an example, you can use {[variable]:F2} to format the variable as a string with 2 decimal places.
You can use {[variable]:F0} to format the variable as a string with no decimal places.

**Why is it important to check for division by zero?**
[Explain what happens if you try to divide by zero and how you handled it]

Answer: You can get an error if you don't check for division by zero.

**How did you use the boolean variable to control formatting?**
[Explain how you used if/else to format output differently based on user preference]

Answer: There has to be a better way of doing this, but I just had 2 copies of the output in an if statement.
If the user enables decimal precision, then the program will display all calculations with :F2 format specifiers.
If the user didn't do that, then it displays all calulations with the :F0 format specifier.


## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned?]

1.
2.
3.
4.
5.

**Which data type concept was most useful?**
[Explain which data type (string, bool, int, or double) you found most interesting and why]

Answer:

**How does conditional formatting improve user experience?**
[Why is it helpful to let users choose decimal precision?]

Answer: Some user's may not use decimals in their calculations, so there's no need to show decimal places.

## Testing and Debugging

**What test cases did you use to verify your program works?**
[List the different inputs you tested - positive numbers, negative numbers, decimals, zero, etc.]

Answer: I used test cases with positive numbers, decimals, 0 as the first and second number, a mix of positive and negative numbers, a mix of positive and negative numbers with decimals

**What bugs or errors did you encounter and fix?**
[Describe any errors you got and how you fixed them]

Answer: Nothing really.

## Time Spent

**Total time:** 1 hour

**Breakdown:**

-   Understanding data types: 2 minutes 
-   Reading and parsing user input: 4 minutes
-   Implementing arithmetic operations: 5 minutes
-   Adding conditional formatting: 5 minutes
-   Handling division by zero: 8 minutes
-   Testing and debugging: 12 minutes
-   Writing documentation: 36 minutes (including this document)

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Writing the documentation. Again, this is probably going to be the longest part for a bit. 

## Reflection

**What would you do differently next time?**
[What would you change in your approach or code?]

Answer: I *think* this program isn't flawed in any way other than missing a few things that will come in a later build. I do need to reserve more time to actually code though.

**How does this assignment prepare you for more complex programs?**
[Why are these skills important for future programming tasks?]

Answer: This is a nice refresher since I haven't taken a C# class in 2 years. I took something similar to this in high school, but that course didn't go over stuff like formatting strings.
