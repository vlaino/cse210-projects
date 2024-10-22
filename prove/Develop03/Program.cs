using System;

class Program
{
    static void Main(string[] args)
    {
        Word word1 = new Word();
        Scripture scripture1 = new Scripture();
        Reference reference1 = new Reference();

        reference1 = "Juan 3:16";
        scripture1 = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life";

        Console.WriteLine(reference1 scripture1);

        Console.WriteLine("Press enter to continue or type 'quit' to finish: " )
    }
}