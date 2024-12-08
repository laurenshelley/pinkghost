public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public override void RecordEvent()
    {
        _currentCount++;
        if (_currentCount >= _targetCount)
        {
            _isCompleted = true;
        }
    }

    public override bool IsComplete()
    {
        return _isCompleted;
    }

    public override string GetProgress()
    {
        return $"{base.GetProgress()} Completed {_currentCount}/{_targetCount}";
    }

    public int GetBonusPoints()
    {
        return _isCompleted ? _bonusPoints : 0;
    }
}
