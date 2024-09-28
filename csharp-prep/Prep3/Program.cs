using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int gnumber = -1;

        
        while (gnumber != number)
        {
            Console.Write("What is your guess? ");
            gnumber = int.Parse(Console.ReadLine());

            if (number > gnumber)
            {
                Console.WriteLine("Higher");
            }
            else if (number == gnumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else
            {
                Console.WriteLine("Lower");
            }
        }
    }
}