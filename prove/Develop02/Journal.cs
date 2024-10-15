using System;
public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {
        if (newEntry != null)
        {
            _entries.Add(newEntry);
        }

    }

    public void DisplayAll()
    {
        foreach (newEntry in Entry)
        {
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            Console.WriteLine("Date: " + dateText);
            Console.Write($"- Prompt: ")
        }


    }

    public void SaveToFile(string file)
    {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string firstName = parts[0];
            string lastName = parts[1];
        }

    }

    public void LoadFromFile (string file)
    {

    }
}