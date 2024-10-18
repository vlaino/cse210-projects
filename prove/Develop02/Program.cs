using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        
        anEntry._promptText = "What was the best part of my day?";
        anEntry._entryText = 1;

        theJournal.AddEntry(anEntry);

        theJournal.DisplayAll();
        theJournal.SavetoFile();
        theJournal.LoadFromFile();

        int option = 0;
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.WriteLine("What would you like to do? ");
            option = Convert.ToInt32(Console.ReadLine());
        } while (option != 5);
        
    }
}