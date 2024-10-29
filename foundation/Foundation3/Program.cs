using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities =  new List<Activity>();
        activities.Add(new RunningActivity("03 Nov 2022",4.8,30));
        activities.Add(new CyclingActivity("18 Jul 2018",9.4,30));
        activities.Add(new Swimming("07 Jan 2021",91,30));

        int index = 1;
        foreach(Activity activity in activities)
        {
            Console.WriteLine($"\nActivity {index}°:\n{activity.GetSummary()}");
            index++;
        }
        Console.WriteLine();
    }
}