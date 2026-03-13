using System;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "You had a good day?",
        "Who did you helped today?",
        "What made you smile today?",
        "What did you learned today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

}