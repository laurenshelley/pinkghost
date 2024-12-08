using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isCompleted;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = false;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetProgress() => _isCompleted ? "[X]" : "[ ]";

    public override string ToString()
    {
        return $"{GetProgress()} {_name} ({_description})";
    }

    public int GetPoints()
    {
        return _points;
    }
}
