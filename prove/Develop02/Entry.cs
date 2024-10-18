using System;
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"- Prompt: {_promptText}");
        Console.WriteLine($"- Entry: {_entryText}");
        DateTime theCurrentTime = DateTime.Now;
        string _dateText = theCurrentTime.ToShortDateString();
        e._dateText = _dateText;

    }
}