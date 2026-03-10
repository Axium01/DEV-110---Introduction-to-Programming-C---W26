# Week 9: Score Stats (Methods + LINQ) - Study Notes

**Name:** Milo Wearn

## Methods and Decomposition

**Why is it helpful to break a program into small methods?**
[Think about readability, testing, and debugging]

Answer: If one part breaks, you won't have to sift through hundreds of lines of code to figure out which part broke. Instead, you'd only need to check a single method.

## LINQ (Stats + Method Chaining)

**Which LINQ methods did you use for basic statistics?**
[Examples: Min, Max, Average, Count with predicates]

Answer: I used the following...
Min(): To determine the smallest value in the array.
Max(): To determine the largest value in the array.
Average(): To determine the mean of all values in the array.
Count(predicate): To count elements that meet a specific condition (the predicate).

**Which LINQ methods did you chain together for reports?**
[Examples: Where + OrderByDescending, OrderByDescending + Take]

Answer: For this assignment, I used...
Where + OrderByDescending: To first filter the array based on the conditions given, and then sort the results from highest to lowest.
OrderByDescending + Take: To sort the array, then take the first 3 values (in this case, the top 3 values).

**Why is it helpful to put score logic in a class (ScoreReport) instead of keeping everything in Program?**
[Think about organization, reuse, and readability]

Answer: Program.cs already houses it's own methods, which might make it a bit hard to understand which ones are used directly for the user input and data gathering, and which ones are used for printing everything if the methods from ScoreReport were put into it.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. LINQ methods can be chained together to make code more readable, and makes it easier to keep track of how things sequentially run.
2. Splitting methods between classes can help keep everything organized.
3. Predicates can be used as a way to run what is essentially a method in a smaller format.

**Which concept felt easiest (methods or LINQ) and why?**

Answer: Methods were definitely easier. I am used to using LINQ methods, but I'm much more used to the concept of methods.

## Time Spent

**Total time:** 1 hour and 30~ minutes

**Breakdown:**

- Understanding the starter code: 13 minutes
- Implementing the print methods: 45~ minutes
- LINQ method chaining: 5 minutes
- Testing and debugging: 15 minutes
- Writing documentation: 30 minutes 

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Implementing the print methods took the longest since I needed to rewrite most of the code after I found out that the array that's used for the input can't be properly converted.

## Reflection

**What would you improve next time?**

Answer: I don't think theres much to improve with the program, but I do think some of the variables could be renamed.

**How did methods make this program easier to work on?**

Answer: It helped me pinpoint what was going wrong with my program, and let me split up things based on what needed testing.
