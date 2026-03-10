# Week 7: Class Roster Builder (Arrays) - Study Notes

**Name: Milo Wearn**

## Arrays and `count`

**What are “parallel arrays” and how did you use them in this assignment?**
[Explain how rosterNames and rosterCredits stay lined up by index]

Answer: "Parallel arrays" refer to two or more arrays that have the same length, but may not have the same data type. In the assignment, they are used to hold the names (strings) and credits (int) in the roster. 

**What is the purpose of the `count` variable?**
[Explain how it tracks how many roster slots are “in use”]

Answer: "count" tracks how many roster slots are currently filled in. The variable is only updated *after* the slots are filled in so that subsequent uses of option 1 are able to properly fill in new slots.

**Where did you use `count` in loops and why?**
[Explain why you loop 0..count-1 instead of using the full array length]

Answer: Because "count" tracks the number of filled in roster slots, it is used instead of the full length of the array. If we were to just use the full array length, the loops that print an output would start to print lines that have no name or credits in them.

## Printing and Sorting

**How did you print the class roster using a `foreach` loop?**
[Describe building an array of roster lines and then printing each line]

Answer: In the foreach loop, the roster lines are first built using the method "BuildRosterLines", which creates an array that houses all of the needed strings for the list. Then, each element in that array is individually printed to the console on a separate line.

**How did you sort the roster while keeping names and credits aligned?**
[Describe copying the used roster into new arrays and using Array.Sort on parallel arrays]

Answer: A copy of both roster arrays are made to a new set of arrays (sortedNames and sortedCredits) using "CopyUsedRoster". Depending on the user's choice of how to sort, Array.Sort is used to either sort the array copies based on name or credits *without* affecting the original roster arrays.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. When creating a method, you can use the "out" parameter to update multiple variables at once without having to use separate methods.
2. For methods that output arrays, you can use them in place of actual arrays for things like foreach loops.
3. Parallel arrays can be used to "group" arrays of different datatypes together.
4.
5.

**Which loop felt most natural to use and why?**

Answer: As I've said before, all of them feel pretty natural to use since I've had experience with all of them, but I do think I have a better understanding of how foreach works now.

## Time Spent

**Total time:** 1 hour

**Breakdown:**

- Planning the arrays/menu: 10~ minutes
- Input validation: 15~ minutes
- Add + print roster features: 30~ minutes
- Sorting feature: 15~ minutes
- Testing and debugging: 10 minutes~
- Writing documentation: 7 minutes

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Roster features took the longest because I got stuck on trying to figure out why subsequent uses of adding students to the roster would throw errors. I figured out that trying to update count alongside creating the elements caused the index to exceed the length of the array, so I had to rework the whole system.

## Reflection

**What would you do differently next time?**

Answer: I think taking some time to read more into the documentation of certain things (like the out parameter) that I only sort of understand would help a bit.

**How did using `for` and `foreach` improve your understanding of arrays?**

Answer: I already mostly understand arrays and how they work with for and foreach, but I do think I have a better understanding of how foreach works now.
