using System;

public class Activity
{
    protected string _date;
    protected int _time;
    protected string _type;

    public Activity(string date, string type, int time)
    {
        _date = date;
        _type = type;
        _time = time;
    }
    public string GetSummary()
    {
        return $"{_date} {_type} ({_time} min)- Distance {GetDistance()} km - Speed: {Math.Round(GetSpeed(), 1)} kph - Pace: {Math.Round(GetPace(), 2)} min per km";
    }
    protected virtual double GetDistance()
    {
       return 0;
    }
    protected virtual double GetSpeed()
    {
        return 0;
    }
    protected virtual double GetPace()
    {
        return 0;
    }
    protected int GetTimeInMinutes()
    {
        return _time;
    }
}