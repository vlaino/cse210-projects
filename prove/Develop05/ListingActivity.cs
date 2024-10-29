using System;

public class ListingActivity : Activity

{
    private List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"};
    
    private List<string> _list = new List<string>();

    public ListingActivity(string name, string description)
        : base (name, description)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get ready...");
        ShowSpinner();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        int seconds = GetDuration();
        Console.Write("\nList as many responses you can to the following prompt:");
        Console.WriteLine($"\n---- {GetRandomPrompt()} ----");
        Console.WriteLine("\nYou may begin in: ");
        ShowCountDown();
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string user = Console.ReadLine();
            if(!string.IsNullOrEmpty(user))
            {
                _list.Add(user);
            }   

        }
        DisplayQuantityList();
        DisplayEndingMessage();

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    private void DisplayQuantityList()
    {
        Console.WriteLine($"You listed {_list.Count} items!");
        Thread.Sleep(3000);
    }



    

}