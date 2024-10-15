using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        
        anEntry._promptText = "What was the best part of my day?";
        anEntry._entryText = 1;

        theJournal.AddEntry(anEntry);
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
        } while (option != 5);
        
    }
}