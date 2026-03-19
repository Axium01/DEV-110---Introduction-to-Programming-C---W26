# Week 10: Habit Tracker (File I/O) — Study Notes

**Name: Milo Wearn**

## File I/O — Reading

**What does `File.ReadAllLines` return, and how did you use it?**
[Think about the return type and what you did with each element]

Answer: ReadAllLines returns an array of strings. I used it to create a list of habits with individual attributes for each element in the list.

**Why is it important to skip blank lines when reading a CSV file?**
[What would happen if you tried to split an empty string on `','`?]

Answer: If you didn't skip blank lines, an exception would be thrown because you would be trying to read something that doesn't exist.

## File I/O — Writing

**What does `File.WriteAllLines` do, and what arguments does it take?**
[Describe the path argument and what goes in the string array]

Answer: File.WriteAllLines overwrites a file and writes new lines to that file, with each line being an element in the array that is provided to it.

**What is `Select(...).ToArray()` doing in `SaveHabits`?**
[Break down the two steps: what does `Select` produce, and why call `ToArray()`?]

Answer: Select(...) grabs elements from a list that meet the specifications found in (...). .ToArray() makes the selected elements (the ones that Select grabbed) into an array.

## Exception Handling

**What is a `FileNotFoundException` and when does it occur?**
[Describe the scenario where C# throws this specific exception]

Answer: FileNotFoundException occurs when the program cannot find a file from a specified path.

**Why do we catch `FileNotFoundException` specifically instead of using `catch (Exception)`?**
[Think about what catching all exceptions can hide from you]

Answer: Catching all exceptions will assume that *any* exception causes the file to not be found, even when that isn't the case. If you intended to catch all exceptions, then you would likely want some way to figure out which kind of exception is thrown.

## What I Learned

**Key takeaways from this week:**
[List 3 main things you learned]

1. When you want to catch exceptions using try-catch, it's better to only catch specific exceptions for certain cases (like catching an exception for a file that couldn't be found). You should have your program setup in a way that would only catch those specific exceptions that your looking for.
2. When writing to files, you need to rewrite the full file to save data. Though there may be a more efficient way to do this?
3. CSV files are a *much* easier way of storing data, compared to what I used to use in the past.

**What was the trickiest part of this assignment and how did you work through it?**

Answer: Figuring out reading and writing for files was a bit tricky, since I had thought that attempting to use the array would push every line/element to just one element/line at first.

## Time Spent

**Total time:** 3 hours

**Breakdown:**

- Understanding the starter code and CSV formats: 25 minutes
- Implementing LoadHabits: 20 minutes
- Implementing PrintHabits / PrintSummary: 15 minutes
- Implementing AddHabit / UpdateHabit / SaveHabits: 30 minutes
- Testing and debugging: 1 hour
- Writing study notes: 30 minutes

**Most time-consuming part:**

Answer: Debugging took the longest because I had to rewrite portions of the code to make it compatible with the provided tests.
