using System;

public class EternalGoal : Goal
{
    private string _type;

    public EternalGoal(string name, string description, int points, string goal)
        : base(name, description, points)
    {
        _type = goal;
    }

    public override void RecordEvent()
    {
        if(IsComplete())
        {
            AddPointToCurrentPoint();
        }
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{_type}: {_name}, {_description}, {_points}";
    }
}