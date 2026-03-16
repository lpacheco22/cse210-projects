using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Did you had a good day?",
        "What's the best thing that happened to you today?",
        "Who did you helped today?",
        "What made you smile today?",
        "What did you learned today?"
    };

    Random random = new Random();
    public string GetRandomPrompt()
    {
        
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

}