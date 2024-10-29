using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to the {_name}. \n{_description}.");
        Duration();
        Console.WriteLine($"\nThe {_name} activity will start for {_duration} seconds...");

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        Thread.Sleep(1000);
        ShowSpinner();
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        ShowSpinner();
        Console.WriteLine();

    }

    public void ShowSpinner ()
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        foreach (string s in animationString)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }

    public void ShowCountDown()
    {
        for (int i= 3; i > 0; i--)
        {
            Console.Write($"\r{i}");
            Thread.Sleep(1100);
        }
        Console.WriteLine();
    }

    public void Duration()
    {
        Console.Write("\nHow long, in seconds, would you like for you session? ");
        int duration = int.Parse(Console.ReadLine());
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

}