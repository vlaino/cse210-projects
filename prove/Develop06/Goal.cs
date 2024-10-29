using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected int _currentPoint = 0;
    protected string _checkBox = "[ ]";

    public Goal (string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual void IsCompleteToTrue()
    {

    }

    public virtual string GetDetailsString()
    {
        return $"{GetCheckMark()} {_name} - {_description}";
    }

    public abstract string GetStringRepresentation();

    public int GetCurrentPoint()
    {
        return _currentPoint;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void AddPointToCurrentPoint()
    {
        _currentPoint += _points;
    }

    public void CheckMark()
    {
        string newCheckBox = _checkBox.Replace(_checkBox, "[X]");
        _checkBox = newCheckBox;
    }

    public string GetCheckMark()
    {
        return _checkBox;
    }



}