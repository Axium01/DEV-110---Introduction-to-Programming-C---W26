/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Milo Wearn
- Assignment: Week 8: Mad Libs (Structure + Debugging)
-
- What does this program do?:
- Represents a Mad Libs story template with prompts and story text.
- */

namespace MadLibs;

public class StoryTemplate
{
    public StoryTemplate(string title, string[] prompts, string templateText)
    {
        Title = title;
        Prompts = prompts;
        TemplateText = templateText;
    }

    public string Title { get; }

    public string[] Prompts { get; }

    public string TemplateText { get; }

    public string GenerateStory(string[] words)
    {
        string generatedStory;
        if (words.Length != Prompts.Length) { // not equal lengths
            return "Cannot generate story!";
        } else { // equal lengths
            generatedStory = FormatStory(words);
        }
        return generatedStory;
    }

    private string FormatStory(string[] words)
    {
        object[] wordsObj = new object[words.Length];
        // converting array
        for (int i = 0; i < words.Length; i++) {
            wordsObj[i] = words[i];
        }
        string formattedStory = string.Format(TemplateText, wordsObj);
        return formattedStory;
    }
}
