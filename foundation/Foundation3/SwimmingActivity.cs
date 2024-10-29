using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int laps, int time)
        : base(date, "Swimming", time)
    {
        _laps = laps;
    }

    protected override double GetDistance()
    {
        return (_laps * 50) / 1000;
    }
    protected override double GetSpeed()
    {
        return (GetDistance() / GetTimeInMinutes()) * 60;
    }
    protected override double GetPace()
    {
        return GetTimeInMinutes() / GetDistance();
    }
}