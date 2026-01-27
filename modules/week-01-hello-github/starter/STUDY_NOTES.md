# Week 1: Hello, GitHub - Study Notes

**Name: Milo Wearn**

## Development Environment Setup

**Software installed and versions:**
[List each piece of software you installed: .NET SDK, Visual Studio Code, Git, and any VS Code extensions]

Answer: .NET SDK (Version 9.0.103), Visual Studio Code (Latest Version), Git (Latest Version), C# Dev Kit (VS Extension, Latest Version), C# (VS Extension, Latest Version), EditorConfig for VS Code (VS Extension, Latest Version)

**Operating system:**
[What OS are you using? Windows, macOS, or Linux?]

Answer: Windows

## Challenges and Solutions

**Biggest challenge during setup:**
[What was the hardest part? Installing software, configuring VS Code, understanding the terminal, or something else?]

Answer: Step 3 got a little confusing since the repo isn't named "dev-110-setup.git" at all, and I thought it was trying to point to something that may have been created already. Step 4 was also a bit of an issue because I thought that git would recognize the "/tree/main" at the end of the url as not part of the upstream url.

**How you solved it:**
[Explain what you did to overcome the challenge - search online, ask for help, restart your computer, etc.]

Answer: Mainly just a few tweaks and googling how to remove an existing upstream.

**Most confusing concept:**
[What was hardest to understand? Git commands, terminal navigation, C# syntax, or dotnet CLI?]

Answer: None of them were really hard, but I've never used Git before (only ever used the web gui to do everything), so I'd say that was a bit of a hurdle I had to cross.

## Understanding C# Basics

**What does `Console.WriteLine()` do?**
[Explain in your own words what this command does]

Answer: Prints a single line of text. You need to supply text for it to display anything, but it's fine if the argument is empty. Using it without text will just create an empty line, which can act as a line break.

**What is the purpose of `Program.cs`?**
[Why is this file important in a C# project?]

Answer: This *is* the file that the project runs off of. All of the code is inside of this file.

**What does `dotnet run` do?**
[Explain what happens when you run this command]

Answer: It runs the program. In this case, Program.cs, from the source code.

## Git Workflow Understanding

**What is the difference between `git add`, `git commit`, and `git push`?**
[Explain each command and when you would use it]

Answer: 'git add' prepares/stages any made changes, 'git commit' will create a snapshot of the currently staged changes (but only locally!), and 'git push' will upload the commit that you made locally to the remote repository. Basically, it makes any private changes public. 

**Why do we create branches?**
[Explain the purpose of creating a student branch]

Answer: Branches let you work on things such as new features without tampering with the original repository. The best way to think of it is like having a backup of your hard drive. The branch is the current hard drive your using and the backup is the original repository.

## What I Learned

**Key takeaways from this week:**
[What are the 3 most important things you learned?]

1. Git is actually better than using the Github web GUI and I should start using it in more of my projects :D
2. Using the Git workflow can help prevent accidental destructive changes from occuring on the remote repository.
3. Yeah that's all I've got. I've already learned most of the stuff here but I've really never messed with Git before. I'd say it's easier to use compared to the web GUI.

**How this connects to professional development:**
[Why are these skills important for programmers?]

Answer: You can't really program without the basics, I guess.

## Time Spent

**Total time:** 1 hour

**Breakdown:**

-   Installing and configuring software: 15 minutes
-   Learning terminal/command line basics: 8 minutes
-   Writing the "Hello, GitHub!" program: 2 minutes
-   Understanding Git workflow: 12 minutes
-   Testing and fixing issues: 4 minutes
-   Writing documentation: 20~ minutes (including this document)

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: The documentation if you also include this file. It's probably going to be like that for a bit since I've already learned a lot of programming languages that are similar to this.
