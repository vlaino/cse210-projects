using System;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        if (newEntry != null)
        {
            _entries.Add(newEntry);
        }

    }

    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            
            Console.WriteLine("Date: " + e._dateText);
            Console.Write($"- Prompt: " + e._promptText);
            Console.Write($"- Entry: " + e._entryText);
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