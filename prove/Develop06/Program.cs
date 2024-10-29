using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Eternal Quest Program!");
        GoalManager goalManager = new();
        goalManager.Start();
    }
}