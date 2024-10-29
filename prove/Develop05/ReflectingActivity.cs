using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _reflections = new List<string> {
        "> Why was this experience meaningful to you?",
        "> Have you ever done anything like this before?",
        "> How did you get started?",
        "> How did you feel when it was complete?",
        "> What made this time different than other times when you were not as successful?",
        "> What is your favorite thing about this experience?",
        "> What could you learn from this experience that applies to other situations?",
        "> What did you learn about yourself through this experience?",
        "> How can you keep this experience in mind in the future?",
    };

    public ReflectingActivity(string name, string description)
        : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get ready...");
        ShowSpinner();
        Console.WriteLine("\nConsider de following prompt:");
        Console.WriteLine($"\n---- {Prompt()} ----");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may begin in: ");
        ShowCountDown();
        DisplayReflection();
        DisplayEndingMessage();

    }

    private string Prompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string Reflection()
    {
        Random random = new Random();
        int index = random.Next(_reflections.Count);
        return _reflections[index];
    }

    private void DisplayReflection()
    {
        int seconds = GetDuration();
        while (seconds > 0)
        {
            string reflection = Reflection();
            Console.WriteLine(reflection);
            ShowSpinner();
            ShowSpinner();
            seconds -= 3;
            break;
        }
    }
}