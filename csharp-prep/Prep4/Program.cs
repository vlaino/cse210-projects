using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int gnumber = -1;

        while (gnumber != 0)
        {
            Console.Write("Enter number: ");
            string userNumber = Console.ReadLine();
            gnumber = int.Parse(userNumber);
        
            if (gnumber != 0)
            {
                numbers.Add(gnumber);
            }
        }

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) /  numbers.Count;
        Console.WriteLine($"The average is {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }

}