using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn about yourself?",
        "What made this time different?",
        "How can you apply this in the future?"
    };

    public ReflectionActivity()
        : base("Reflection Activity",
        "This activity helps you reflect on your strengths and resilience.") { }

    public void Run()
    {
        StartMessage();

        Random rand = new Random();

        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);
        Console.WriteLine("\nReflect on the following questions:");

        int time = 0;

        while (time < _duration)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine($"\n{question}");

            ShowSpinner(5);
            time += 5;
        }

        EndMessage();
    }
}