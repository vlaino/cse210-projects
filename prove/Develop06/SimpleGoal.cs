using System;

public class SimpleGoal : Goal
{
    private string _type;
    private bool _isComplete = false;

    public SimpleGoal (string name, string description, int points, string goal)
        : base(name, description, points)
    {
        _type = goal;
    }

    public override void RecordEvent()
    {
        if (IsComplete())
        {
            AddPointToCurrentPoint();
            CheckMark();
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void IsCompleteToTrue()
    {
        _isComplete = true;
    }

    public override string GetStringRepresentation()
    {
        return $"{_type}: {_name}, {_description}, {_points}, {IsComplete()}";
    }
}