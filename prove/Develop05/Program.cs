using System;

class Program
{
    static void Main(string[] args)
    {
        int breath = 0;
        int reflect = 0;
        int list = 0;

        bool runActivity = true;
        while(runActivity)
        {
            string options = "\n Menu options: \n1. Start breathing activity \n2. Start reflecting activity \n3. Start listing activity \n4. Quit \nSelect a choice from the menu: ";
            Console.Write(options);
            int user = int.Parse(Console.ReadLine());

            switch (user) 
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity("Breathing Activity", "\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breathing.Run();
                    breath += 1;
                    break;
                
                case 2:
                    ReflectingActivity reflecting = new ReflectingActivity("Reflection Activity", "\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflecting.Run();
                    reflect += 1;
                    break;
                
                case 3:
                    ListingActivity listing = new ListingActivity("Listing Activity", "\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area");
                    listing.Run();
                    list += 1;
                    break;
                
                case 4:
                    Console.WriteLine("Activity - Number of times performed in this session");
                    Console.WriteLine($"Breathing Activity: {breath} times");
                    Console.WriteLine($"Reflecting Activity: {reflect} times");
                    Console.WriteLine($"Listing Activity: {list} times");
                    break;

                case 5:
                    Console.WriteLine("Thanks for using the app! :)");
                    runActivity = false;
                    break;
                
            }
        }
        
    }
}