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
        Console.WriteLine($"Welcome...ALGO: {_name} VA SEPARADO?{description}");
        //ShowCountDown();
        Console.WriteLine($"The {_name} activity will start for {_duration} seconds...");
        //CountDown;

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Great job! You complete {_name} for {_duration} seconds...");
        Thread.Sleep(2500);
        Console.WriteLine();

    }

    public void ShowSpinner (int seconds)
    {

    }

    public void ShowCountDown(int seconds)
    {

    }
}