public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points,
        int target, int bonus, int timesCompleted = 0)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _timesCompleted = timesCompleted;
    }
    public override int RecordEvent()
    {
        if (_timesCompleted < _target)
        {
            _timesCompleted++;

            if (_timesCompleted == _target)
            {
                return GetPoints() + _bonus;
            }

            return GetPoints();
        }

        return 0;
    }
    public override string GetStatus()
    {
        return _timesCompleted >= _target ? "[X]" : "[ ]";
    }
    public override string GetDetails()
    {
        return $"{GetStatus()} {GetName()} ({GetDescription()}) -- Completed {_timesCompleted}/{_target}";
    }
    public override string GetSaveString()
    {
        return $"Checklist|{GetName()}|{GetDescription()}|{GetPoints()}|{_timesCompleted}|{_target}|{_bonus}";
    }
}