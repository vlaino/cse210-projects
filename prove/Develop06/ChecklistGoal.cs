using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;
    private string _type;
    private bool _isComplete = false;

    public ChecklistGoal(string name, string description, int points, string goal, int target, int bonus)
        : base(name, description, points)
    {
        _type = goal;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (IsComplete() && GetAmountCompleted() == _target)
        {
            AddPointToCurrentPoint();
            CheckMark();
        }
        else
        {
            AddPointToCurrentPoint();
            AmountCompleted();
            _isComplete = false;

        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"{GetCheckMark()} {_name} ({_description}) -- Currently completed: {GetAmountCompleted()}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_type}: {_name}, {_description}, {_points}, {_bonus}, {_target}, {GetAmountCompleted()}";
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public void AmountCompleted()
    {
        _amountCompleted++;
    }

    public override void IsCompleteToTrue()
    {
        _isComplete = true;
    }

    public void AddAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }

}