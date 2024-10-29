using System;

public class BreathingActivity : Activity

{
    public BreathingActivity(string name, string description)
        : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        int seconds = GetDuration();
        Console.WriteLine("Get ready...");
        ShowSpinner();

        bool breatheIn = true;
        while (seconds > 0)
        {
            if (breatheIn)
            {
                Console.WriteLine("\nBreathe in...");
                ShowCountDown();
            }
            else{
                Console.WriteLine("Now breathe out...");
                ShowCountDown();
            }

            
            breatheIn = !breatheIn;
            seconds = seconds - 3;
        }
        DisplayEndingMessage();

    }

}