using System;
using System.IO;
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
        e.Display();


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
        string fileName = "myFile.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))

    // You can add text to the file with the WriteLine method
        outputFile.WriteLine("This will be the first line in the file.");
    
    // You can use the $ and include variables just like with Console.WriteLine
        string color = "Blue";
        outputFile.WriteLine($"My favorite color is {color}");

    }
}